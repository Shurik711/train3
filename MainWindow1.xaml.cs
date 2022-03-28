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

namespace train3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow1.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {
        public MainWindow1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zakaz win = new Zakaz();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Sklad win = new Sklad();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
