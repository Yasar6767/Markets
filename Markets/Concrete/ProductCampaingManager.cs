using Markets.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markets.Concrete
{
    class ProductCampaingManager : IProductCampaingService
    {
        public void Add(ProductCampaing productCampaing)
        {
            Console.WriteLine("Ürün kampanyası eklendi." + " "+ productCampaing.Name + " %" + productCampaing.DiscountRate);
        }

        public void Delete(ProductCampaing productCampaing)
        {
            Console.WriteLine("Ürün kampanyası kaldırıldı." + " " + productCampaing.Name);
        }

        public void Update(ProductCampaing productCampaing)
        {
            Console.WriteLine("Ürün kampanyası güncellendi." + " "+ productCampaing.Name + " %" + productCampaing.DiscountRate);
        }
    }
}
