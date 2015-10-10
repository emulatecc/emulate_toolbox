using System;
using System.IO;

namespace Toolbox.Framework.Projects.Wizard
{
    static class InitializationWizard
    {
        static string ProjectConfFolder = "Projects";        

        static bool IsFirstrun()
        {
            return Directory.Exists(ProjectConfFolder);
        }

        static bool InitFirstrun()
        {
            try
            {
                DirectoryInfo projectConfDirectory = Directory.CreateDirectory(ProjectConfFolder);

                if (projectConfDirectory != null)
                {

                }
                else
                {
                    return false;
                }
                return false;
            }
            catch(Exception ex)
            {
                // TODO: Throw error message?
                return false;
            }
        }
    }
}
