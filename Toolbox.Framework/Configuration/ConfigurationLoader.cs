using System.IO;
using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Toolbox.Framework.Projects;

namespace Toolbox.Framework.Configuration
{
    public static class ConfigurationManager
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
        /// <returns></returns>
        public static bool SettingsDirectoryExists()
        {
            return Directory.Exists(ProjectSettingsDirectory);
        }

        /// <summary>
        /// Creates the Config directory
        /// </summary>
        /// <returns></returns>
        public static DirectoryInfo CreateSettingsDirectory()
        {
            return Directory.CreateDirectory(ProjectSettingsDirectory);
        }

        /// <summary>
        /// Serializes all Projects into JSONs and saves them into the Projects directory
        /// </summary>
        /// <returns></returns>
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
        /// <returns></returns>
        public static bool LoadProjects()
        {
            try
            {
                if (SettingsDirectoryExists())
                {
                    List<string> JSONProjectFilenames = new List<string>();
                    List<string> JSONProjectsRaw = new List<string>();
                    FileStream fs;
                    StreamReader reader;

                    // Getting all ProjectSettings-FileNames from ProjectSettingsDirectory
                    foreach (string file in Directory.GetFiles(ProjectSettingsDirectory))
                        JSONProjectFilenames.Add(file);

                    // Getting contents of each file
                    foreach (string file in JSONProjectFilenames)
                    {
                        fs = new FileStream(file, FileMode.Open, FileAccess.Read);
                        if (fs.CanRead)
                        {
                            reader = new StreamReader(fs);

                            JSONProjectsRaw.Add(reader.ReadToEnd());

                            reader.Close();
                            fs.Close();
                        }
                        else
                            throw new FileLoadException("Cannot read file: " + file);
                    }

                    // Serializing ProjectSettings into Projects-List
                    foreach (string file in JSONProjectsRaw)
                    {
                        Project project = JsonConvert.DeserializeObject<Project>(file);

                        Projects.Add(project);
                    }
                    return true;
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
