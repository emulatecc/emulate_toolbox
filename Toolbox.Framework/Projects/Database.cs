using Toolbox.Framework.Enumerations;

namespace Toolbox.Framework.Projects
{
    public struct Database
    {
        /// <summary>
        /// Name of the Database
        /// </summary>
        public string DatabaseName { get; set; } = "";

        /// <summary>
        /// What type is the database of
        /// </summary>
        public DBType DatabaseType { get; set; } 
    }
}
