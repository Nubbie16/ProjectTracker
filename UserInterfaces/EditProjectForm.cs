// Project Name: Project Tracker
// Purpose: To create a project tracker to be used to track progress and minutes of all future projects
// File Name: EditProjectForm.cs
// Description: This file contains the code for the EditProjectForm, which allows users to edit existing projects in the project tracker.
// Programmer: Cody Eckard
// Creation Date: May 12, 2026
// GitHub Repository: https://github.com/Nubbie16/ProjectTracker


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTracker.Models;
using ProjectTracker.Data;


namespace ProjectTracker.UserInterfaces
{
    public partial class EditProjectForm : Form
    {
        private Project projectBeingEdited;

        public Project newProject { get; private set; }   // This will hold the new project data entered by the user

        public EditProjectForm()
        {
            InitializeComponent();

            statusCBO.SelectedIndex = 0; // Set default status to "Not Started"
            minsLogLbl.Visible = false;
            minsLoggedLbl.Visible = false;
        }

        public EditProjectForm(Project project)
        {
            InitializeComponent();

            projectBeingEdited = project;

            nameTXT.Text = project.Name;
            descripTXT.Text = project.Description;
            langCBO.SelectedItem = project.Language;
            startDateDTP.Value = project.StartDate;

            if (project.EndDate.HasValue)
            {
                endDateDTP.Value = project.EndDate.Value;
            }

            minsLoggedLbl.Text = project.Minutes.ToString();
            statusCBO.SelectedItem = project.Status;

            this.Text = "Edit Project - " + project.Name;
        }

        private void EditProjectForm_Load(object sender, EventArgs e)
        {
            if (statusCBO.SelectedItem.ToString() == "Completed")
            {
                endDateLbl.Visible = true;
                endDateDTP.Visible = true;
                endDateDTP.Value = DateTime.Now;
            }
            else
            {
                endDateLbl.Visible = false;
                endDateDTP.Visible = false;
            }
        }

        private void nameTXT_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTXT.Text))
            {
                this.Text = "Personal Project Tracker";
            }
            else
            {
                this.Text = nameTXT.Text;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

            newProject = new Project
            {
                Name = nameTXT.Text,
                Description = descripTXT.Text,
                Language = langCBO.SelectedItem?.ToString() ?? string.Empty,
                StartDate = startDateDTP.Value,
                EndDate = endDateDTP.Value,
                Minutes = 0,
                Status = statusCBO.SelectedItem?.ToString() ?? string.Empty
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusCBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusCBO.SelectedItem.ToString() == "Completed")
            {
                endDateLbl.Visible = true;
                endDateDTP.Visible = true;
                endDateDTP.Value = DateTime.Now;
            }
            else
            {
                endDateLbl.Visible = false;
                endDateDTP.Visible = false;
            }
        }
    }
}
