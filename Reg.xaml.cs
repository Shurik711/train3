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
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Regmenu win = new Regmenu();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            Class1.db.USERS.Add(new USERS
            {
                LOGIN = Login.Text,
                PASSWORD = Password.Text,
                FIO = FIO.Text,
                EMAIL = EMAIL.Text,
                PHONE_NUMBER = Phone_number.Text
            });
            Class1.db.SaveChanges();

            this.Hide();
            Regmenu win = new Regmenu();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }
    }
}
