using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Framework.Projects.ProjectSettings
{
    class DatabaseConnection
    {
        /// <summary>
        /// IP of the MySQL Server
        /// </summary>
        public string IP { get; set; }

        /// <summary>
        /// Port of the MySQL Server
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// User of the MySQL Server
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Password of the MySQL
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Database names e.g.
        /// logondb, chardb, worlddb
        /// </summary>
        public List<Database> Databases { get; set; }

        /// <summary>
        /// Builds a connection string based on the active object.
        /// </summary>
        /// <returns>Connection String</returns>
        public string BuildConnectionString()
        {
            return string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};",
                                  IP, Port, User, Password);
        }
    }
}
