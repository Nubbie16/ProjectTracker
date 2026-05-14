// Project Name: Project Tracker
// Purpose: To create a project tracker to be used to track progress and minutes of all future projects
// File Name: Program.cs
// Description: This file contains the main entry point of the application and initializes the project tracker.
// Programmer: Cody Eckard
// Creation Date: May 12, 2026
// GitHub Repository: https://github.com/Nubbie16/ProjectTracker

namespace ProjectTracker
{
class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Initialize the project tracker application
            Application.Run(new MainForm());
        }
    }
}