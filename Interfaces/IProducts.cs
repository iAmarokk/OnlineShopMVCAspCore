using OnlineShopMVCAspCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopMVCAspCore.Interfaces
{
    interface IProducts
    {
        IEnumerable<Product> Products { get; set; }
        Product getObjectProduct(int ProductID);
    }
}
