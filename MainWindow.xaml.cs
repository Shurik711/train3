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

namespace train3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            W1 win = new W1();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }
    }
}
