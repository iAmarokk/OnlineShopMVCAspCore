using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopMVCAspCore.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public SelectList Rating { get; set; }
        public SelectList Category { get; set; }
        public int SearchPrice { get; set; }
    }
}
