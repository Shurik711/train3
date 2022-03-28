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
    /// Логика взаимодействия для Zakaz.xaml
    /// </summary>
    public partial class Zakaz : Window
    {
        public Zakaz()
        {
            InitializeComponent();
            MyDataGridZakaz.ItemsSource = Class1.db.ZAKAZY.ToList();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow1 win = new MainWindow1();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ZakazAdd win = new ZakazAdd();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }
    }
}
