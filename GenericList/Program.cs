using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool isAvailable { get; set; }
    }

    static class Database
    {
        static List<Product> AllProducts;

        static Database()
        {
            AllProducts = new List<Product>() {
            new Product() { ID = 1, Name = "First", Price = 1.11, isAvailable = true },
            new Product() { ID = 2, Name = "Second", Price = 2.22, isAvailable = false},
            new Product() { ID = 3, Name = "Third", Price = 3.33, isAvailable = true }
        };
        }

        public static List<Product> GetProducts()
        {
            return AllProducts;
        }

        public static void AddProduct(Product newProduct)
        {
            AllProducts.Add(newProduct);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> allProducts = Database.GetProducts();

            Database.AddProduct(new Product() { ID = 4, Name = "fourth", Price = 4.44, isAvailable = false });
            Product product05 = new Product() { ID = 5, Name = "fifth", Price = 5.55, isAvailable = true };
            Database.AddProduct(product05);

            Console.WriteLine(Database.GetProducts().GetType());

            foreach (var item in allProducts)
            {
                Console.WriteLine($"{item.ID}, {item.Name}");
            }

            Console.Read();
        }
    }
}
