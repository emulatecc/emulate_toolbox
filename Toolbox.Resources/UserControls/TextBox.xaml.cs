﻿using System;
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
    /// Interaction logic for TextBox.xaml
    /// </summary>
    public partial class TextBox : UserControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public TextBox()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Exposing the Text-Property of the Textbox.
        /// </summary>
        public string Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }
    }
}
