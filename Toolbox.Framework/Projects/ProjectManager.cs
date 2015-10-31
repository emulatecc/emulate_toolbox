using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Toolbox.Framework.Projects
{
    public static class ProjectManager
    {
        /// <summary>
        /// Path to the Project-settings directory
        /// </summary>
        public static string ProjectSettingsDirectory { get; } = "Projects";

        /// <summary>
        /// List of all Projects
        /// </summary>
        public static List<Project> Projects { get; set; } = new List<Project>();

        /// <summary>
        /// Checks if the Local Toolbox settings directory exists
        /// </summary>
        /// <returns>True if successfull</returns>
        public static bool SettingsDirectoryExists()
        {
            return Directory.Exists(ProjectSettingsDirectory);
        }

        /// <summary>
        /// Creates the Config directory
        /// </summary>
        /// <returns>True if successfull</returns>
        public static DirectoryInfo CreateSettingsDirectory()
        {
            return Directory.CreateDirectory(ProjectSettingsDirectory);
        }

        /// <summary>
        /// Serializes all Projects into JSONs and saves them into the Projects directory
        /// </summary>
        /// <returns>True if successfull</returns>
        public static bool SaveProjects()
        {
            try
            {
                if (!SettingsDirectoryExists())
                    CreateSettingsDirectory();

                foreach (var project in Projects)
                {
                    string configPath = ProjectSettingsDirectory + "/" + project.Name + ".json";

                    Stream fs = new FileStream(configPath, FileMode.Create, FileAccess.Write);

                    StreamWriter writer = new StreamWriter(fs);
                    writer.Write(project.ToJson());

                    writer.Close();
                    fs.Close();
                }

                return true;
            }
            catch(Exception ex)
            {
                //TODO: Call custom Error Window
                return false;
            }
        }

        /// <summary>
        /// Loads all Projects from the "Projects"-Directory and Serializes them to the List<Projects>
        /// </summary>
        /// <returns>True if successfull</returns>
        public static bool LoadProjects()
        {
            try
            {
                if (!SettingsDirectoryExists())
                    return true;

                var jsonProjectsRaw = new List<string>();

                // Getting all ProjectSettings-FileNames from ProjectSettingsDirectory
                var jsonProjectFilenames= Directory.GetFiles(ProjectSettingsDirectory).ToList();

                // Getting contents of each file
                foreach (var file in jsonProjectFilenames)
                {
                    var fs = new FileStream(file, FileMode.Open, FileAccess.Read);
                    if (fs.CanRead)
                    {
                        var reader = new StreamReader(fs);

                        jsonProjectsRaw.Add(reader.ReadToEnd());

                        reader.Close();
                        fs.Close();
                    }
                    else
                        throw new FileLoadException("Cannot read file: " + file);
                }

                // Serializing ProjectSettings into Projects-List
                foreach (var project in jsonProjectsRaw.Select(JsonConvert.DeserializeObject<Project>))
                {
                    Projects.Add(project);
                }
                return true;
            }
            catch(Exception ex)
            {
                // TODO: Call error window
                return false;
            }
        }
    }
}
