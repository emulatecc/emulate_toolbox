using Toolbox.Framework.Enumerations;

namespace Toolbox.Framework.Projects
{
    /// <summary>
    /// Represents a Database
    /// </summary>
    public struct Database
    {
        /// <summary>
        /// Name of the Database
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// What type is the database of
        /// </summary>
        public DbType DatabaseType { get; set; } 
    }
}
