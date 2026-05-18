// Project Name: Project Tracker
// Purpose: To create a project tracker to be used to track progress and minutes of all future projects
// File Name: EditProjectForm.cs
// Description: This file contains the code for the EditProjectForm, which allows users to add or edit projects in the project tracker.
// Programmer: Cody Eckard
// Creation Date: May 12, 2026
// GitHub Repository: https://github.com/Nubbie16/ProjectTracker

using ProjectTracker.Models;

namespace ProjectTracker.UserInterfaces
{
    public partial class EditProjectForm : Form
    {
        private Project? projectBeingEdited;

        public Project? newProject { get; private set; }

        public EditProjectForm()
        {
            InitializeComponent();

            InitializeFormForNewProject();
        }

        public EditProjectForm(Project project)
        {
            InitializeComponent();

            InitializeFormForExistingProject(project);
        }

        private void InitializeFormForNewProject()
        {
            projectBeingEdited = null;

            Text = "Add New Project";

            nameTXT.Clear();
            descripTXT.Clear();

            if (langCBO.Items.Count > 0)
            {
                langCBO.SelectedIndex = -1;
            }

            startDateDTP.Value = DateTime.Today;

            minsLoggedLbl.Text = "0";
            minsLogLbl.Visible = false;
            minsLoggedLbl.Visible = false;

            if (statusCBO.Items.Count > 0)
            {
                statusCBO.SelectedIndex = 0;
            }

            UpdateEndDateVisibility();
        }

        private void InitializeFormForExistingProject(Project project)
        {
            projectBeingEdited = project;

            Text = "Edit Project - " + project.Name;

            nameTXT.Text = project.Name;
            descripTXT.Text = project.Description;
            langCBO.SelectedItem = project.Language;
            startDateDTP.Value = project.StartDate;

            minsLoggedLbl.Text = project.Minutes.ToString();
            minsLogLbl.Visible = true;
            minsLoggedLbl.Visible = true;

            statusCBO.SelectedItem = project.Status;

            if (project.EndDate.HasValue)
            {
                endDateDTP.Value = project.EndDate.Value;
            }
            else
            {
                endDateDTP.Value = DateTime.Today;
            }

            UpdateEndDateVisibility();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateProjectInput())
            {
                return;
            }

            DateTime? endDate = null;

            if (IsProjectCompleted())
            {
                endDate = endDateDTP.Value;
            }

            newProject = new Project
            {
                Id = projectBeingEdited?.Id ?? 0,
                Name = nameTXT.Text.Trim(),
                Description = descripTXT.Text.Trim(),
                Language = langCBO.SelectedItem?.ToString() ?? string.Empty,
                StartDate = startDateDTP.Value,
                EndDate = endDate,
                Minutes = projectBeingEdited?.Minutes ?? 0,
                Status = statusCBO.SelectedItem?.ToString() ?? string.Empty
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool ValidateProjectInput()
        {
            if (string.IsNullOrWhiteSpace(nameTXT.Text))
            {
                MessageBox.Show("Please enter a project name.");
                nameTXT.Focus();
                return false;
            }

            if (langCBO.SelectedItem == null)
            {
                MessageBox.Show("Please select a programming language.");
                langCBO.Focus();
                return false;
            }

            if (statusCBO.SelectedItem == null)
            {
                MessageBox.Show("Please select a project status.");
                statusCBO.Focus();
                return false;
            }

            if (IsProjectCompleted() && endDateDTP.Value.Date < startDateDTP.Value.Date)
            {
                MessageBox.Show("End date cannot be before the start date.");
                endDateDTP.Focus();
                return false;
            }

            return true;
        }

        private bool IsProjectCompleted()
        {
            return statusCBO.SelectedItem?.ToString() == "Completed";
        }

        private void UpdateEndDateVisibility()
        {
            bool isCompleted = IsProjectCompleted();

            endDateLbl.Visible = isCompleted;
            endDateDTP.Visible = isCompleted;

            if (isCompleted && (projectBeingEdited == null || !projectBeingEdited.EndDate.HasValue))
            {
                endDateDTP.Value = DateTime.Today;
            }
        }

        private void EditProjectForm_Load(object sender, EventArgs e)
        {
            UpdateEndDateVisibility();
        }

        private void nameTXT_TextChanged(object sender, EventArgs e)
        {
            string projectName = nameTXT.Text.Trim();

            if (string.IsNullOrWhiteSpace(projectName))
            {
                Text = projectBeingEdited == null ? "Add New Project" : "Edit Project";
            }
            else
            {
                Text = projectBeingEdited == null
                    ? "Add Project - " + projectName
                    : "Edit Project - " + projectName;
            }
        }

        private void statusCBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEndDateVisibility();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}