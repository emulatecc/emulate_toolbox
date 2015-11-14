using System;
using System.IO;

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
        private readonly static FileStream LogStream = new FileStream("error.log", FileMode.Create, FileAccess.Write);
        private readonly static StreamWriter LogWriter = new StreamWriter(LogStream);

        /// <summary>
        /// Writes a message to the logfile
        /// </summary>
        /// <param name="logMessage">Message that should be written to the file.</param>
        /// <param name="logLevel">Which type of message is it?</param>
        public static void Write(string logMessage, LogLevel logLevel = LogLevel.Normal)
        {
            try
            {
                LogWriter.WriteLine($"{DateTime.Now.ToLongTimeString()} - {logLevel}: {logMessage}");
                LogWriter.Flush();
            }
            catch (Exception)
            {
                throw new ApplicationException();
            }
        }
    }
}
