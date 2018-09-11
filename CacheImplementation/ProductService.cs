using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheImplementation
{
    class ProductService : IProductService
    {
        public List<Product> GetAllProducts()
        {
            IRepository productRepo = new Database();
            return productRepo.GetAllProducts();
        }
        public Product GetById(int id)
        {
            IRepository productRepo = new Database();
            Console.WriteLine("It is coming from database");
            return productRepo.GetById(id);
        }
    }
}
