using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Toolbox.Framework.Projects;
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Windows.Input;

namespace Toolbox.Resources.UserControls
{
    /// <summary>
    /// Interaktionslogik für ProjectStackPanel.xaml
    /// </summary>
    public partial class ProjectStackPanel : UserControl
    {

        public ProjectStackPanel()
        {
            InitializeComponent();
        }

        public void AddProject(Project project)
        {
            try
            {
                var logo = new BitmapImage();

                if (File.Exists(project.Logo))
                {
                    logo.BeginInit();
                    logo.UriSource = new Uri(project.Logo);
                    logo.EndInit();
                }
                    

                var projectTab = new ProjectTab();
                projectTab.ProjectName.Content = project.Name;
                projectTab.ProjectDir.Content = project.Path;
                projectTab.ProjectImage.Source = logo;


                // Registering Tab Behaviour Events
                projectTab.MouseEnter += (sender, args) =>
                {
                    Cursor = Cursors.Hand;
                    projectTab.ActiveBorder.Visibility = Visibility.Visible;
                };

                projectTab.MouseLeave += (sender, args) =>
                {
                    Cursor = Cursors.Arrow;

                    if(!projectTab.IsFocused)
                        projectTab.ActiveBorder.Visibility = Visibility.Hidden;
                };

                projectTab.MouseUp += (sender, args) => projectTab.Focus();
                projectTab.GotFocus += (sender, args) => projectTab.ActiveBorder.Visibility = Visibility.Visible;
                projectTab.LostFocus += (sender, args) => projectTab.ActiveBorder.Visibility = Visibility.Hidden;

                ProjectStackpanel.Children.Add(projectTab);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed on loading the Project into an ProjectTab!" + ex.Message, "Error!", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

    }
}
