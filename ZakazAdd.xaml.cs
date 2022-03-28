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
    /// Логика взаимодействия для ZakazAdd.xaml
    /// </summary>
    public partial class ZakazAdd : Window
    {
        public ZakazAdd()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            Class1.db.ZAKAZY.Add(new ZAKAZY { NAME = naz.Text, ZAKAZSHICK = zak.Text, PRICE = pr.Text, SROK = srok.Text });
            Class1.db.SaveChanges();
            MessageBox.Show("Заказ добавлен");
            this.Hide();
            Zakaz win = new Zakaz();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zakaz win = new Zakaz();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }
    }
}
