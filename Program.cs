using TaskLINQ.Models;
using TaskLINQ.Productservice;

namespace TaskLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Category = "Elektronika", Price = 1500, Stock = 5 },
            new Product { Id = 2, Name = "Qələm", Category = "Kırtasiye", Price = 1.5, Stock = 100 },
            new Product { Id = 3, Name = "Kitab", Category = "Kırtasiye", Price = 20, Stock = 30 },
            new Product { Id = 4, Name = "Telefon", Category = "Elektronika", Price = 999, Stock = 0 },
            new Product { Id = 5, Name = "Ofis kreslosu", Category = "Mebel", Price = 250, Stock = 10 }
        };
            ProductService.FilterProductsAbove50(products);
            Console.WriteLine("-------------");
            ProductService.GroupByCategory(products);
            Console.WriteLine("-------------");
            ProductService.SortByPriceDescending(products);
            Console.WriteLine("-------------");
            ProductService.FindMostExpensiveProduct(products);
            Console.WriteLine("-------------");
            ProductService.CalculateTotalPrice(products);
            Console.WriteLine("-------------");
            ProductService.CheckStockGreaterThanZero(products);
            Console.WriteLine("-------------");

        }
    }

}
