// Project Name: Project Traker
// Purpose: To create a project tracker to be used to track progress and minutes of all future projects
// File Name: MainForm.cs
// Description: This file contains the main form of the application where users can interact with the project tracker and manage their projects.
// Programmer: Cody Eckard
// Creation Date: May 12, 2026
// GitHub Repository: https://github.com/Nubbie16/ProjectTracker

using ProjectTracker.UserInterfaces;
using ProjectTracker.Models;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ProjectTracker
{
    public partial class MainForm : Form
    {
        private List<Project> projects = new List<Project>();   // This will hold the list of projects in memory for testing before SQLite is used
        private int nextProjectID = 1;                          // This will be used to assign unique IDs to projects for testing before SQLite is used

        public MainForm()
        {
            InitializeComponent();

            projects.Add(new Project
            {
                Id = nextProjectID++,
                Name = "Project Alpha",
                Description = "This is the first project.",
                Language = "C#",
                StartDate = DateTime.Today,
                EndDate = null,
                Minutes = 0,
                Status = "Not Started"
            });

            RefreshProjectGrid();
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
                    "View/Edit");
            }
        }

        private void newProjectBtn_Click(object sender, EventArgs e)
        {
            new EditProjectForm().Show();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

        }

        private void projectsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            { return; }

            if (e.ColumnIndex == projectsGV.Columns["editBtnCol"].Index)
            {
                Project selectedProject = projects[e.RowIndex];
                EditProjectForm editForm = new EditProjectForm(selectedProject);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    projects[e.RowIndex] = editForm.newProject;
                    RefreshProjectGrid();
                }

            }
        }
    }
}
