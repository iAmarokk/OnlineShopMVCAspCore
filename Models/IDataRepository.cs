using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopMVCAspCore.Models
{
    public interface IDataRepository
    {

        Product GetProduct(long id);

        IEnumerable<Product> Products { get; }

        IEnumerable<Product> GetFilteredProducts(string category = null, int? rating = null,
           decimal? price = null, string sort = "Up");

        void CreateProduct(Product newProduct);

        void UpdateProduct(Product changedProduct, Product originalProduct = null);

        void DeleteProduct(int id);
    }
}
