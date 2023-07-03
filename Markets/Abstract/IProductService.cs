using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markets.Abstract
{
    interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }
}
