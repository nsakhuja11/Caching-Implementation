﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheImplementation
{
    interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetById(int id);
    }
}
