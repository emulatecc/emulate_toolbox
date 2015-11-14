using System.Windows.Controls;
using Toolbox.Framework.Projects;

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
            var projectTab = new ProjectTab();

            projectTab.ProjectName.Content = project.Name;
            projectTab.ProjectDir.Content = project.Path;

            ProjectStackpanel.Children.Add(projectTab);
        }

    }
}
