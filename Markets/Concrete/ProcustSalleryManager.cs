using Markets.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markets.Concrete
{
    class ProductSalleryManager : IProductBuy
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün satışı yapıldı." +" " + product.Name);
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Ürün iade edildi." + " " + product.Name);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Ürün stok güncellendi." + " " + product.Name);
        }
    }
}
