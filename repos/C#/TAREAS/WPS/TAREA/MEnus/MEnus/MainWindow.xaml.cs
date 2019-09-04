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

namespace MEnus
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInic_Click(object sender, RoutedEventArgs e)
        {
            Window1 Miventana = new Window1();
            Miventana.Owner = this;
            Miventana.ShowDialog();
            Miventana.Close();
            
        }

        private void btnSalr_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
