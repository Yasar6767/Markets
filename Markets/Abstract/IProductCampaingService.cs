using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markets.Abstract
{
    interface IProductCampaingService
    {
        void Add(ProductCampaing productCampaing);
        void Delete(ProductCampaing productCampaing);
        void Update(ProductCampaing productCampaing);
    }
}
