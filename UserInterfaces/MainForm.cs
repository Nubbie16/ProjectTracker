// Project Name: Project Tracker
// Purpose: To create a project tracker to be used to track progress and minutes of all future projects
// File Name: MainForm.cs
// Description: This file contains the main form of the application where users can interact with the project tracker and manage their projects.
// Programmer: Cody Eckard
// Creation Date: May 12, 2026
// GitHub Repository: https://github.com/Nubbie16/ProjectTracker

using ProjectTracker.Data;
using ProjectTracker.Models;
using ProjectTracker.UserInterfaces;

namespace ProjectTracker
{
    public partial class MainForm : Form
    {
        private readonly DatabaseCmds databaseCmds = new DatabaseCmds();

        private List<Project> projects = new List<Project>();

        public MainForm()
        {
            InitializeComponent();

            databaseCmds.InitializeDatabase();

            ConfigureProjectGrid();

            LoadProjects();
        }

        private void ConfigureProjectGrid()
        {
            projectsGV.AllowUserToAddRows = false;
            projectsGV.AllowUserToDeleteRows = false;
            projectsGV.RowHeadersVisible = false;
            projectsGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            projectsGV.MultiSelect = false;

            // Hide the Id column from the user.
            // This assumes the Id column is the first column in the DataGridView.
            if (projectsGV.Columns.Count > 0)
            {
                projectsGV.Columns[0].Visible = false;
            }
        }

        private void LoadProjects()
        {
            projects = databaseCmds.GetAllProjects();

            RefreshProjectGrid();

            RefreshProjectComboBox();
        }

        private void RefreshProjectGrid()
        {
            projectsGV.Rows.Clear();

            foreach (Project project in projects)
            {
                projectsGV.Rows.Add(
                    project.Id,
                    project.Name,
                    project.Description,
                    project.Language,
                    project.StartDate.ToShortDateString(),
                    project.EndDate?.ToShortDateString() ?? string.Empty,
                    project.Minutes,
                    project.Status,
                    "View/Edit"
                );
            }
        }

        private void RefreshProjectComboBox()
        {
            projectNameCBO.DataSource = null;

            if (projects.Count == 0)
            {
                projectNameCBO.Items.Clear();
                return;
            }

            projectNameCBO.DisplayMember = "Name";
            projectNameCBO.ValueMember = "Id";
            projectNameCBO.DataSource = projects.ToList();
            projectNameCBO.SelectedIndex = -1;
        }

        private void newProjectBtn_Click(object sender, EventArgs e)
        {
            using EditProjectForm editForm = new EditProjectForm();

            if (editForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (editForm.newProject == null)
            {
                MessageBox.Show("No project data was returned from the project form.");
                return;
            }

            databaseCmds.AddProject(editForm.newProject);

            LoadProjects();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (projectNameCBO.SelectedValue == null)
            {
                MessageBox.Show("Please select a project.");
                projectNameCBO.Focus();
                return;
            }

            if (!int.TryParse(minutesToLogTXT.Text.Trim(), out int minutesToAdd) || minutesToAdd <= 0)
            {
                MessageBox.Show("Please enter a valid number of minutes.");
                minutesToLogTXT.Focus();
                return;
            }

            int projectId = Convert.ToInt32(projectNameCBO.SelectedValue);

            databaseCmds.AddMinutesToProject(projectId, minutesToAdd);

            minutesToLogTXT.Clear();

            LoadProjects();
        }

        private void projectsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (projectsGV.Columns["editBtnCol"] == null)
            {
                MessageBox.Show("The Edit/View button column could not be found.");
                return;
            }

            if (e.ColumnIndex != projectsGV.Columns["editBtnCol"].Index)
            {
                return;
            }

            Project? selectedProject = GetProjectFromGridRow(e.RowIndex);

            if (selectedProject == null)
            {
                MessageBox.Show("Could not find the selected project.");
                return;
            }

            using EditProjectForm editForm = new EditProjectForm(selectedProject);

            if (editForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (editForm.newProject == null)
            {
                MessageBox.Show("No project data was returned from the project form.");
                return;
            }

            Project updatedProject = editForm.newProject;

            // Preserve the original database Id.
            updatedProject.Id = selectedProject.Id;

            databaseCmds.UpdateProject(updatedProject);

            LoadProjects();
        }

        private Project? GetProjectFromGridRow(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= projectsGV.Rows.Count)
            {
                return null;
            }

            object? projectIdValue = projectsGV.Rows[rowIndex].Cells[0].Value;

            if (projectIdValue == null)
            {
                return null;
            }

            if (!int.TryParse(projectIdValue.ToString(), out int projectId))
            {
                return null;
            }

            return projects.FirstOrDefault(project => project.Id == projectId);
        }
    }
}