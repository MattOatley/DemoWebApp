using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoWebProject.Models;

namespace DemoWebProject
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
