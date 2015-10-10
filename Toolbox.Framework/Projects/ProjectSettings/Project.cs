using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Toolbox.Framework.Projects.ProjectSettings
{
    class Project
    {
        /// <summary>
        /// Path to the Project
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// Logo of the Project(Could be empty)
        /// </summary>
        public string Logo { get; set; }


        /// <summary>
        /// Path to the ".toolbox"
        /// </summary>
        public string ProjectPath { get; set; }

        DatabaseConnection Database { get; set; }

        /// <summary>
        /// Constructor of Project, loads all Configurations for the given Project
        /// </summary>
        Project()
        {

        }


    }
}
