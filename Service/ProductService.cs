using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskLINQ.Models;

namespace TaskLINQ.Productservice
{
    public class ProductService
    {
        private static List<Product> products;

        static ProductService()
        {
            products = new List<Product>();
        }
        public static void FilterProductsAbove50(List<Product> products)
        {
            var filtered = products
                .Where(p => p.Price > 50)
                .Select(p => new { p.Name, p.Price });

            Console.WriteLine("Qiyməti 50 manatdan yuxarı olan məhsullar:");
            foreach (var p in filtered)
            {
                Console.WriteLine($"{p.Name} - {p.Price} AZN");
            }
        }
        public static void GroupByCategory(List<Product> products)
        {
            var groups = products
                .GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key, Count = g.Count() });

            Console.WriteLine("Kateqoriyaya görə məhsul sayı:");
            foreach (var g in groups)
            {
                Console.WriteLine($"{g.Category}: {g.Count} məhsul");
            }
        }

        public static void SortByPriceDescending(List<Product> products)
        {
            var sorted = products.OrderByDescending(p => p.Price);

            Console.WriteLine("Qiymətə görə azalan sırada məhsullar:");
            foreach (var p in sorted)
            {
                Console.WriteLine($"{p.Name} - {p.Price} AZN");
            }
        }
        public static void FindMostExpensiveProduct(List<Product> products)
        {
            var mostExpensiveProduct = products.OrderByDescending(p => p.Price).FirstOrDefault();

            if (mostExpensiveProduct != null)
            {
                Console.WriteLine($"Ən bahalı məhsul: {mostExpensiveProduct.Name} - {mostExpensiveProduct.Price} AZN");
            }
            else
            {
                Console.WriteLine("Məhsullar siyahısı boşdur.");
            }
        }
        public static void CalculateTotalPrice(List<Product> products)
        {
            double total = products.Sum(p => p.Price);
            Console.WriteLine($"Bütün məhsulların ümumi qiyməti: {total} AZN");
        }
        public static void CheckStockGreaterThanZero(List<Product> products)
        {
            bool allInStock = products.All(p => p.Stock > 0);
            Console.WriteLine(allInStock
                ? "Bütün məhsulların stoku 0-dan yuxarıdır."
                : "Bəzi məhsulların stoku 0-dır.");
        }
        
    }


}
