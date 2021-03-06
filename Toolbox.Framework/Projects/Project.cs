﻿using Newtonsoft.Json;

namespace Toolbox.Framework.Projects
{
    /// <summary>
    /// Represents a Project
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Project Name
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Path to the logo of the Project
        /// </summary>
        public string Logo { get; set; } = "";

        /// <summary>
        /// Path to the Project´s WoW Folder
        /// </summary>
        public string Path { get; set; } = "";

        /// <summary>
        /// MySQL Informations of the project
        /// </summary>
        public MySqlSettings MySqlInfo { get; set; } = new MySqlSettings();

        /// <summary>
        /// Serializes Object into a JSON String
        /// </summary>
        /// <returns></returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
