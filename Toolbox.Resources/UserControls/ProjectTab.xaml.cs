using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace Toolbox.Resources.UserControls
{
    /// <summary>
    /// Interaktionslogik für ProjectStackPanel.xaml
    /// </summary>
    public partial class ProjectTab : UserControl
    {
        /// <summary>
        /// Constructor of the ProjectTab
        /// </summary>
        public ProjectTab()
        {
            InitializeComponent();
        }

        private void ActiveBorder_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Open.Visibility = ActiveBorder.Visibility;
        }
    }
}
