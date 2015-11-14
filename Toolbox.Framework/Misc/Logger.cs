using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Toolbox.Framework.Misc
{
    /// <summary>
    /// Represents the importance of a log entry
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Information about something that happened like loading something.
        /// </summary>
        Normal,

        /// <summary>
        /// If something fails but it was not certainly a problem in this case, so that the toolbox would not have been stopped by the error.
        /// </summary>
        Warning,

        /// <summary>
        /// Something that has a termination of the toolbox as a result.
        /// </summary>
        Error
    }

    /// <summary>
    /// Takes care of the logging.
    /// </summary>
    public static class Logger
    {
        private readonly static FileStream LogStream = new FileStream("error.log", FileMode.CreateNew, FileAccess.Write);
        private static StreamWriter _logWriter = new StreamWriter(LogStream);

        
    }
}
