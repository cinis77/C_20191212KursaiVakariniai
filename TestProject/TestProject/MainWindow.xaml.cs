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

namespace TestProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            System.Windows.Forms.MessageBox.Show("Labas");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void PopupBox_OnOpened(object sender, RoutedEventArgs e)
        {
        }

        private void PopupBox_OnClosed(object sender, RoutedEventArgs e)
        {
        }
    }
}