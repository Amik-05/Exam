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
using Test2.Models;

namespace Test2
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        ApplicationContext app = new ApplicationContext();
        List<Product> products;
        public Add()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Byte b = Convert.ToByte(p1.Text);
            Decimal pc = 10;
            Product newItem = new Product
            {
                ProductCost = pc,
                ProductDescription = p3.Text,
                ProductDiscount = p4.Text,
                ProductEd = "шт",
                ProductPhoto = p5.Text,
                ProductManufacturer = p6.Text,
            };
            app.Product.Add(newItem);
            app.SaveChanges();
            MessageBox.Show("Товар добавлен");
            this.Close();
        }
    }
}
