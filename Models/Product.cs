using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopMVCAspCore.Models
{
    public class Product
    {
        [Display(Name = "Номер")]
        public int ProductID { get; set; }
        [Display(Name = "Товар")]
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int RatingID { get; set; }
        public Rating Rating { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
