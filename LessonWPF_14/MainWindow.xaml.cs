using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace LessonWPF_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection <Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                Name = "Колбаса",
                Price = 500,
                Image = "Data/Sausage.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                Name = "Картофель",
                Price = 69,
                Image = "Data/Potato.jpg",
                ProductCategory = ProductCategories.Food
            }); products.Add(new Product()
            {
                Name = "Мультиварка",
                Price = 6000,
                Image = "Data/Multicooker.jpg",
                ProductCategory = ProductCategories.Appliances
            }); products.Add(new Product()
            {
                Name = "Блендер",
                Price = 3500,
                Image = "Data/Blender.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            lstBox.ItemsSource = products;

        }
    }
}
