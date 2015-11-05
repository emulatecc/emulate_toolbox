using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Framework.Projects
{
    /// <summary>
    /// Stores MySQLSettings
    /// </summary>
    public class MySQLSettings
    {
        /// <summary>
        /// IP of the MySQL Server
        /// </summary>
        public string IP { get; set; } = "";

        /// <summary>
        /// Port of the MySQL Server
        /// </summary>
        public int Port { get; set; } = 0;

        /// <summary>
        /// User that should be used for database operations
        /// </summary>
        public string User { get; set; } = "";

        /// <summary>
        /// Password for the User that should be used for database operations
        /// </summary>
        public string Password { get; set; } = "";

        /// <summary>
        /// Databases
        /// </summary>
        public List<Database> Databases { get; set; } = new List<Database>();

    }
}
