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
    /// Логика взаимодействия для Avt.xaml
    /// </summary>
    public partial class Avt : Window
    {
        public Avt()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            if (Class1.db.USERS.Where(x => (x.LOGIN == Login.Text) && x.PASSWORD == Password.Text).FirstOrDefault() != null)
            {
                Class1.Log = Login.Text;
                Class1.Pass = Password.Text;
                this.Hide();
                MainWindow1 win = new MainWindow1();
                win.Top = this.Top;
                win.Left = this.Left;
                win.Show();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Regmenu win = new Regmenu();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }
    }
}
