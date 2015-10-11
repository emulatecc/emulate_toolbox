using System.IO;
using System;
using System.Collections.Generic;

using Toolbox.Framework.Projects;

namespace Toolbox.Framework.Configuration
{
    public static class ConfigurationManager
    {
        public static string ProjectSettingsFolder { get; } = "Projects";
        public static List<Project> Projects { get; set; } = new List<Project>();
                    
        /// <summary>
        /// Checks if the Local Toolbox settings folder exists
        /// </summary>
        /// <returns></returns>
        public static bool SettingsDirectoryExists()
        {
            return Directory.Exists(ProjectSettingsFolder);
        }

        /// <summary>
        /// Creates the Config directory
        /// </summary>
        /// <returns></returns>
        public static DirectoryInfo CreateSettingsDirectory()
        {
            return Directory.CreateDirectory(ProjectSettingsFolder);
        }

        /// <summary>
        /// Serializes all Projects into JSONs and saves them into the Projects folder
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
                    string configPath = ProjectSettingsFolder + "/" + project.Name + ".json";

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
    }
}
