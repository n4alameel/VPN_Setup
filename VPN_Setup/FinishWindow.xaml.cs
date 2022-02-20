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

namespace VPN_Setup
{
    /// <summary>
    /// Логика взаимодействия для FinishWindow.xaml
    /// </summary>
    public partial class FinishWindow : Window
    {
        public FinishWindow()
        {
            InitializeComponent();
        }

        

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
