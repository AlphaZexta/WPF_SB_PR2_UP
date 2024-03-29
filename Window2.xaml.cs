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

namespace WPF_SB_PR2_UP
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        InkCanvas Prosto = new InkCanvas();
        public Window2()
        {
            InitializeComponent();
            Prosto = Holst;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Prosto.DefaultDrawingAttributes.Height = Polzuok.Value;
            Prosto.DefaultDrawingAttributes.Width = Polzuok.Value;
        }

        private void Krasniy_Click(object sender, RoutedEventArgs e)
        {
            Holst.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void Siniy_Click(object sender, RoutedEventArgs e)
        {
            Holst.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void Chorniy_Click(object sender, RoutedEventArgs e)
        {
            Holst.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void Beliy_Click(object sender, RoutedEventArgs e)
        {
            Holst.DefaultDrawingAttributes.Color = Colors.White;
        }
    }
}
