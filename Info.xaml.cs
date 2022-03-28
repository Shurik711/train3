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
    /// Логика взаимодействия для Info.xaml
    /// </summary>
    public partial class Info : Window
    {
        public Info()
        {
            InitializeComponent();
            MyDataGridInfo.ItemsSource = Class1.db.INFO.ToList();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            W1 win = new W1();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }
    }
}
