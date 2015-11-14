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

namespace Toolbox.Resources.UserControls
{
    /// <summary>
    /// Interaction logic for PrimaryButton.xaml
    /// </summary>
    public partial class PrimaryButton : UserControl
    {
        /// <summary>
        /// DependencyProperty to expose the Content-Property of the Primary Button
        /// </summary>
        public new static DependencyProperty ContentProperty = DependencyProperty.Register("Content", typeof(object), typeof(PrimaryButton));

        /// <summary>
        /// Exposing a click event handler from the button.
        /// </summary>
        public event EventHandler Click;

        /// <summary>
        /// Constructor of the PrimaryButton
        /// </summary>
        public PrimaryButton()
        {
            InitializeComponent();
            this.DataContext = this;

            button.Click += ButtonClick;
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var eventHandler = this.Click;

            eventHandler?.Invoke(this, e);
        }

        /// <summary>
        /// Property for the exposed button content
        /// </summary>
        public new object Content
        {
            get { return GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }

        }
    }
}
