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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

            // Assumes the Id column is the first column in your grid.
            // Hide it from the user but keep it available for edit/update logic.
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
                    project.EndDate?.ToShortDateString() ?? "",
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
                return;
            }

            projectNameCBO.DisplayMember = "Name";
            projectNameCBO.ValueMember = "Id";
            projectNameCBO.DataSource = projects.ToList();
        }

        private void newProjectBtn_Click(object sender, EventArgs e)
        {
            using EditProjectForm editForm = new EditProjectForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                databaseCmds.AddProject(editForm.newProject);

                LoadProjects();
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (projectNameCBO.SelectedValue == null)
            {
                MessageBox.Show("Please select a project.");
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

            if (e.ColumnIndex != projectsGV.Columns["editBtnCol"].Index)
            {
                return;
            }

            int projectId = Convert.ToInt32(projectsGV.Rows[e.RowIndex].Cells[0].Value);

            Project? selectedProject = projects.FirstOrDefault(project => project.Id == projectId);

            if (selectedProject == null)
            {
                MessageBox.Show("Could not find the selected project.");
                return;
            }

            using EditProjectForm editForm = new EditProjectForm(selectedProject);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                Project updatedProject = editForm.newProject;

                updatedProject.Id = selectedProject.Id;

                databaseCmds.UpdateProject(updatedProject);

                LoadProjects();
            }
        }
    }
}