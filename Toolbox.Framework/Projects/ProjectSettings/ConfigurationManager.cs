using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Framework.Projects.ProjectSettings
{
    class ConfigurationManager
    {
        DatabaseConnection MySQLConnections { get; set; }
        List<Project> Projects = new List<Project>();

        public bool LoadSettings()
        {
            foreach(Project project in Projects)
            {

            }
            return true;
        }

        public bool LoadMySQLSettings()
        {
            return true;
        }
    }
}
