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
