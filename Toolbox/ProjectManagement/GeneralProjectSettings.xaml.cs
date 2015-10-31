using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Toolbox.General;
using Toolbox.Framework.Projects;

namespace Toolbox
{
    /// <summary>
    /// Interaction logic for GeneralProjectSettings.xaml
    /// </summary>
    public partial class GeneralProjectSettings : Window
    {
        /// <summary>
        /// Represents if an edit is made or a new Project is added
        /// </summary>
        public bool EditMode { get; set; }

        /// <summary>
        /// Prepares the GeneralProjectSettings Window
        /// </summary>
        public GeneralProjectSettings( Project project = null)
        {
            InitializeComponent();

            if (project != null)
            {
                EditMode = true;
                assignProjectToMask(project);
                submit.Content = "Save";
            }
            else
            {
                submit.Content = "Next";
                EditMode = false;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void assignProjectToMask(Project project)
        {

        }

        private void Submit_OnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
