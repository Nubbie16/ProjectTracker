// Project Name: Project Tracker
// Purpose: To create a project tracker to be used to track progress and minutes of all future projects
// File Name: DatabaseCmds.cs
// Description: This file contains the DatabaseCmds class which will handle all database commands and interactions for the project tracker application.
// Programmer: Cody Eckard
// Creation Date: May 12, 2026
// GitHub Repository: https://github.com/Nubbie16/ProjectTracker

using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Data.Sqlite;
using ProjectTracker.Models;

namespace ProjectTracker.Data
{
    public class DatabaseCmds
    {
        private readonly string connectionString;

        public DatabaseCmds()
        {
            string folderPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "ProjectTracker"
            );

            Directory.CreateDirectory(folderPath);

            string databasePath = Path.Combine(folderPath, "projects.db");

            SqliteConnectionStringBuilder builder = new SqliteConnectionStringBuilder
            {
                DataSource = databasePath
            };

            connectionString = builder.ConnectionString;
        }

        public void InitializeDatabase()
        {
            using SqliteConnection connection = new SqliteConnection(connectionString);
            connection.Open();

            string sql = @"
                CREATE TABLE IF NOT EXISTS Projects (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Description TEXT,
                    StartDate TEXT NOT NULL,
                    EndDate TEXT,
                    Language TEXT,
                    Minutes INTEGER NOT NULL DEFAULT 0,
                    Status TEXT
                );
            ";

            using SqliteCommand command = new SqliteCommand(sql, connection);
            command.ExecuteNonQuery();
        }

        public void AddProject(Project project)
        {
            using SqliteConnection connection = new SqliteConnection(connectionString);
            connection.Open();

            string sql = @"
                INSERT INTO Projects 
                (
                    Name,
                    Description,
                    StartDate,
                    EndDate,
                    Language,
                    Minutes,
                    Status
                )
                VALUES 
                (
                    @Name,
                    @Description,
                    @StartDate,
                    @EndDate,
                    @Language,
                    @Minutes,
                    @Status
                );
            ";

            using SqliteCommand command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@Name", project.Name);
            command.Parameters.AddWithValue("@Description", project.Description);
            command.Parameters.AddWithValue("@StartDate", project.StartDate.ToString("yyyy-MM-dd"));

            if (project.EndDate.HasValue)
            {
                command.Parameters.AddWithValue("@EndDate", project.EndDate.Value.ToString("yyyy-MM-dd"));
            }
            else
            {
                command.Parameters.AddWithValue("@EndDate", DBNull.Value);
            }

            command.Parameters.AddWithValue("@Language", project.Language);
            command.Parameters.AddWithValue("@Minutes", project.Minutes);
            command.Parameters.AddWithValue("@Status", project.Status);

            command.ExecuteNonQuery();
        }

        public List<Project> GetAllProjects()
        {
            List<Project> projects = new List<Project>();

            using SqliteConnection connection = new SqliteConnection(connectionString);
            connection.Open();

            string sql = @"
                SELECT 
                    Id,
                    Name,
                    Description,
                    StartDate,
                    EndDate,
                    Language,
                    Minutes,
                    Status
                FROM Projects
                ORDER BY Id DESC;
            ";

            using SqliteCommand command = new SqliteCommand(sql, connection);
            using SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Project project = new Project
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    StartDate = DateTime.Parse(reader.GetString(3)),
                    EndDate = reader.IsDBNull(4) ? null : DateTime.Parse(reader.GetString(4)),
                    Language = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                    Minutes = reader.GetInt32(6),
                    Status = reader.IsDBNull(7) ? string.Empty : reader.GetString(7)
                };

                projects.Add(project);
            }

            return projects;
        }

        public void UpdateProject(Project project)
        {
            using SqliteConnection connection = new SqliteConnection(connectionString);
            connection.Open();

            string sql = @"
                UPDATE Projects
                SET
                    Name = @Name,
                    Description = @Description,
                    StartDate = @StartDate,
                    EndDate = @EndDate,
                    Language = @Language,
                    Minutes = @Minutes,
                    Status = @Status
                WHERE Id = @Id;
            ";

            using SqliteCommand command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@Id", project.Id);
            command.Parameters.AddWithValue("@Name", project.Name);
            command.Parameters.AddWithValue("@Description", project.Description);
            command.Parameters.AddWithValue("@StartDate", project.StartDate.ToString("yyyy-MM-dd"));

            if (project.EndDate.HasValue)
            {
                command.Parameters.AddWithValue("@EndDate", project.EndDate.Value.ToString("yyyy-MM-dd"));
            }
            else
            {
                command.Parameters.AddWithValue("@EndDate", DBNull.Value);
            }

            command.Parameters.AddWithValue("@Language", project.Language);
            command.Parameters.AddWithValue("@Minutes", project.Minutes);
            command.Parameters.AddWithValue("@Status", project.Status);

            command.ExecuteNonQuery();
        }

        public void AddMinutesToProject(int projectId, int minutesToAdd)
        {
            using SqliteConnection connection = new SqliteConnection(connectionString);
            connection.Open();

            string sql = @"
                UPDATE Projects
                SET Minutes = Minutes + @MinutesToAdd
                WHERE Id = @Id;
            ";

            using SqliteCommand command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@Id", projectId);
            command.Parameters.AddWithValue("@MinutesToAdd", minutesToAdd);

            command.ExecuteNonQuery();
        }
    }
}