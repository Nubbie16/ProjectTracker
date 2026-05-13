// Project Name: Project Tracker
// Purpose: To create a project tracker to be used to track progress and minutes of all future projects
// File Name: Project.cs
// Description: This file defines the Project class, which represents a project being tracked
//      in the application. It will contain properties and methods related to project management, such as tracking progress and time spent on the project.
// Programmer: Cody Eckard
// Creation Date: May 12, 2026
// GitHub Repository: https://github.com/Nubbie16/ProjectTracker

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Models
{
    internal class Project
    {

        // Properties of the Project class
        // Set all fields to default values to prevent null reference exceptions

        public int Id { get; set; } = 0;                            // Unique identifier for the project(used for database purposes)
        public string Name { get; set; } = string.Empty;            // Name of the project
        public string Description { get; set; } = string.Empty;     // Description of the project
        public DateTime StartDate { get; set; } = DateTime.Now;     // Start date of the project
        public DateTime EndDate { get; set; } = DateTime.Now;       // End date of the project
        public string Language { get; set; } = string.Empty;        // Programming language used in the project
        public int Minutes { get; set; } = 0;                       // Total minutes spent on the project
        public string Status { get; set; } = string.Empty;          // Status of the project (e.g., "Not Started", "In Progress", "Completed", "On Hold")
    }
}
