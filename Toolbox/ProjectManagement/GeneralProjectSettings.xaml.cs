using System;
using System.Windows;
using Toolbox.Framework.Projects;

namespace Toolbox.ProjectManagement
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

        public Project project { get; set; }
        /// <summary>
        /// Prepares the GeneralProjectSettings Window
        /// </summary>
        public GeneralProjectSettings( Project project = null)
        {
            InitializeComponent();

            if (project != null)
            {
                EditMode = true;
                this.project = project;
                AssignProjectToMask();
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


        private void AssignProjectToMask()
        {
            projectName.Text = project.Name;
            projectDirectory.Text = project.Path;
            logoPath.Text = project.Logo;
        }

        private void Submit_OnClick(object sender, EventArgs e)
        {
            if (!EditMode)
                ProjectManager.Projects.Add(new Project
                {
                    Name = projectName.Text,
                    Path = projectDirectory.Text,
                    Logo = logoPath.Text
                });
            else
            {
                ProjectManager.Projects.Find(x => x.Name == projectName.Text).Logo = logoPath.Text;
                ProjectManager.Projects.Find(x => x.Name == projectName.Text).Path = projectDirectory.Text;
                ProjectManager.Projects.Find(x => x.Name == projectName.Text).Name = projectName.Text;
            }

            ProjectManager.SaveProjects();
        }
    }
}
