using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Lab7_CosmeticApp_UWP.Data;
using Lab7_CosmeticApp_UWP.Models;
using System.Linq;

namespace Lab7_CosmeticApp_UWP
{
    public sealed partial class MainPage : Page
    {
        private AppDbContext dbContext;

        public MainPage()
        {
            this.InitializeComponent();
            dbContext = new AppDbContext();
            dbContext.Database.EnsureCreated();
            LoadProducts();
        }

        private void LoadProducts()
        {
            ProductListView.ItemsSource = dbContext.CosmeticProducts.OrderBy(p => p.Name).ToList();
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            dbContext.CosmeticProducts.Add(new CosmeticProduct
            {
                Name = "Шампунь",
                Brand = "Head&Shoulders",
                Type = "Догляд за волоссям",
                ExpiryDate = System.DateTime.Now.AddYears(1),
                IsAvailable = true
            });
            dbContext.SaveChanges();
            LoadProducts();
        }

        private void EditProduct_Click(object sender, RoutedEventArgs e)
        {
            if (ProductListView.SelectedItem is CosmeticProduct selected)
            {
                selected.Name = "Оновлено: " + selected.Name;
                dbContext.SaveChanges();
                LoadProducts();
            }
        }

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            if (ProductListView.SelectedItem is CosmeticProduct selected)
            {
                dbContext.CosmeticProducts.Remove(selected);
                dbContext.SaveChanges();
                LoadProducts();
            }
        }
    }
}