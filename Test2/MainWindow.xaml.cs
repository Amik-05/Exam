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
using Test2.Models;

namespace Test2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext app = new ApplicationContext();
        List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            Output();
        }

        public void Output()
        {
            products = app.Product.ToList();
            evList.ItemsSource = products;
        }


        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите удалить товар?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                Button b = sender as Button;
                string t = b.Tag.ToString();
                var ee = app.Product.FirstOrDefault(x => x.ProductArticle == t);
                app.Product.Remove(ee);
                app.SaveChanges();
                MessageBox.Show("Товар удален");
                evList.ItemsSource = null;
                Output();
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Add a = new Add();
            a.ShowDialog();
            evList.ItemsSource = null;
            Output();
        }
    }
}
