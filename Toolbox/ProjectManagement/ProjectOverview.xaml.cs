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

namespace Toolbox
{
    /// <summary>
    /// Interaktionslogik für ProjectOverview.xaml
    /// </summary>
    public partial class ProjectOverview : Window
    {
        public ProjectOverview()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startProject_Click(object sender, EventArgs e)
        {
            var projectSettingsWnd = new GeneralProjectSettings();
            projectSettingsWnd.Show();
        }

        private void deleteProject_Click(object sender, EventArgs e)
        {

        }
    }
}
