using Markets.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markets.Concrete
{
    class ProductManager : IProductService
    {
 
        public void Add(Product product)
        {
            Console.WriteLine("Ürün eklendi." + " " + product.Name);
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Ürün silindi." + " " + product.Name);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Ürün güncellendi." + " " + product.Name);
        }
    }
}
