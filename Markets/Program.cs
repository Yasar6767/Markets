using Markets.Concrete;
using System;

namespace Markets
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Fasulye";
            product1.price = 70;
            Product product2 = new Product();
            product2.Id = 1;
            product2.Name = "Nohut";
            product2.price = 60;

            ProductCampaing productCampaing = new ProductCampaing();
            productCampaing.Name = "Mega İndirim";
            productCampaing.DiscountRate = 25;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            ProductCampaingManager productCampaingManager = new ProductCampaingManager();
            productCampaingManager.Update(productCampaing);

            ProductSalleryManager procustSalleryManager = new ProductSalleryManager();
            procustSalleryManager.Add(product2);

            
        }
    }
}
