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

namespace GraphElementGenerationSYS.Pages
{
    /// <summary>
    /// StraitLine1.xaml 的交互逻辑
    /// </summary>
    public partial class StraitLine1 : Page
    {
        public StraitLine1()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://blog.csdn.net/zl908760230/article/details/53945673");
            }
            catch (Exception)
            {

            }

        }
    }
}