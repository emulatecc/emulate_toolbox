using System;
using System.Windows;
using Toolbox.Framework.Projects;

namespace Toolbox.ProjectManagement
{
    /// <summary>
    /// Interaktionslogik für ProjectOverview.xaml
    /// </summary>
    public partial class ProjectOverview : Window
    {
        /// <summary>
        /// Constructor of ProjectOverview
        /// </summary>
        public ProjectOverview()
        {
            InitializeComponent();
            ProjectManager.LoadProjects();

            AddProjects();
        }

        private void AddProjects()
        {
            foreach (var project in ProjectManager.Projects)
            {
                ProjectPanel.AddProject(project);
            }
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
            var project = new Project();

            project.Logo = "C:/Users/Mathias/Desktop/ron.png";
            project.Name = "TestName";
            project.Path = "TestPath";
            ProjectPanel.AddProject(project);
        }
    }
}
