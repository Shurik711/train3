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
    /// Логика взаимодействия для Regmenu.xaml
    /// </summary>
    public partial class Regmenu : Window
    {
        public Regmenu()
        {
            InitializeComponent();
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            W1 win = new W1();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Reg win = new Reg();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Avt win = new Avt();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }
    }
}
