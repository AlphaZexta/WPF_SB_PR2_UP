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
using System.Windows.Shapes;

namespace WPF_SB_PR2_UP
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            Imy.Background = Brushes.Blue;
        }

        private void ORazrabotchike_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разраб: Шовкун Б.Н.");
        }

        private void Zakrit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Beliy_Click(object sender, RoutedEventArgs e)
        {
            Meny.Background = Brushes.White;
        }

        private void Siniy_Click(object sender, RoutedEventArgs e)
        {
            Meny.Background = Brushes.Blue;
        }

        private void Krasniy_Click(object sender, RoutedEventArgs e)
        {
            Meny.Background = Brushes.Red;
        }

        private void TipoSiniy_Click(object sender, RoutedEventArgs e)
        {
            Meny.Background = Brushes.Blue;
        }

        private void TipoKrasniy_Click(object sender, RoutedEventArgs e)
        {
            Meny.Background = Brushes.Red;
        }

        private void TipoBeliy_Click(object sender, RoutedEventArgs e)
        {
            Meny.Background = Brushes.White;
        }

        private void TipoZakrit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ZadanieDva_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            this.Close();
        }
    }
}

