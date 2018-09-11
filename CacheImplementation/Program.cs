using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new MemoryCashProductService();
            List<Product> products = productService.GetAllProducts();
            Console.WriteLine("Enter id");
            int id = int.Parse(Console.ReadLine());
            Product product = productService.GetById(id);
            Console.WriteLine(product.id);
            Console.WriteLine("Enter id");
            id = int.Parse(Console.ReadLine());
            product = productService.GetById(id);
            Console.WriteLine(product.id);
            Console.ReadKey();
        }
    }
}
