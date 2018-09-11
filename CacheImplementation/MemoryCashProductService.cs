using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheImplementation
{
    class MemoryCashProductService : ICacheProductService
    {
        private IProductService _productService;
        private MemoryCacheProvider _memoryCachProvider;
        public MemoryCashProductService()
        {
            _productService = new ProductService();
            _memoryCachProvider = new MemoryCacheProvider();
        }
        public Product GetById(int id)
        {
            Product product = (Product)_memoryCachProvider.GetItem(Convert.ToString(id));
            if (product != null)
            {
                Console.WriteLine("It is coming from Cache");
                return product;
            }
            product = _productService.GetById(id);
            _memoryCachProvider.AddItem(Convert.ToString(product.id), product);
            return product;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = _productService.GetAllProducts();
            //foreach(Product product in products)
            //{
            //    if(_memoryCachProvider.GetItem(Convert.ToString(product.Id))==null)
            //    {
            //        Console.WriteLine("Adding Cache");
            //        _memoryCachProvider.AddItem(Convert.ToString(product.Id), product);
            //    }
            //}
            return products;
        }
    }
}
