using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Product(int id, string name, string descr)
        {
            this.Id = id;
            this.Name = name;
            this.Description = descr;
        }
        //destructor
        ~Product()
        {
            this.Id = 0;
            this.Name = null;
            this.Description = null;
            // Cleanup code if needed
        }

    }

    public class StoreInformation : IDisposable
    {
        public List<Product> Products { get; set; }

        public void Dispose()
        {
            Products = null;
        }
    }

    public class StartProgram
    {
        static void Main(string[] args)
        {
            Product product = new Product(1, "Laptop", "A high-performance laptop.");
            Console.WriteLine($"Product ID: {product.Id}");
            Console.WriteLine($"Product Name: {product.Name}");
            Console.WriteLine($"Product Description: {product.Description}");

            StoreInformation storeInfo = new StoreInformation();
            storeInfo.Products = new List<Product>
            {
                new Product(2, "Smartphone", "A latest model smartphone."),
                new Product(3, "Tablet", "A lightweight tablet device.")
            };
            storeInfo.Dispose(); // Dispose of the store information when done

        }
    }
}
