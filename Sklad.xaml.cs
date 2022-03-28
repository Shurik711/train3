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
    /// Логика взаимодействия для Sklad.xaml
    /// </summary>
    public partial class Sklad : Window
    {
        public Sklad()
        {
            InitializeComponent();
            MyDataGridSklad.ItemsSource = Class1.db.SKLAD.ToList();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow1 win = new MainWindow1();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }
    }
}
