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
using System.Windows.Shapes;

namespace FloatingMemo
{
    /// <summary>
    /// version.xaml の相互作用ロジック
    /// </summary>
    public partial class version : Window
    {
        public version()
        {
            InitializeComponent();
            
        }

        private void close_button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OK_button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MITlink_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://opensource.org/licenses/mit-license.php");
        }
    }
}
