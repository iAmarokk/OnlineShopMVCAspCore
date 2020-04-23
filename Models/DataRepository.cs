using Microsoft.EntityFrameworkCore;
using OnlineShopMVCAspCore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopMVCAspCore.Models
{
    public class DataRepository : IDataRepository
    {
        private OnlineShopMVCAspCoreContext context;

        public DataRepository(OnlineShopMVCAspCoreContext ctx)
        {
            context = ctx;
        }

        public Product GetProduct(long id)
        {
            return context.Products.Find(id);
        }

        public IEnumerable<Product> Products => context.Products
                .Include(c => c.Rating)
                .Include(c => c.Category).ToList();

        public IEnumerable<Product> GetFilteredProducts(string category = null, int? rating = null,
                decimal? price = null)
        {

            IQueryable<Product> data = context.Products;
            if (category != null)
            {
                data = data.Where(p => p.Category.Name == category);
            }
            if (rating != null)
            {
                data = data.Where(p => p.Rating.Value == rating);
            }
            if (price != null)
            {
                data = data.Where(p => p.Price >= price);
            }
            return data;
        }

        public void CreateProduct(Product newProduct)
        {
            newProduct.ProductID = 0;
            context.Products.Add(newProduct);
            context.SaveChanges();
            Console.WriteLine($"New Key: {newProduct.ProductID}");
        }

        public void UpdateProduct(Product changedProduct, Product originalProduct = null)
        {
            if (originalProduct == null)
            {
                originalProduct = context.Products.Find(changedProduct.ProductID);
            }
            else
            {
                context.Products.Attach(originalProduct);
            }
            originalProduct.Name = changedProduct.Name;
            originalProduct.Category = changedProduct.Category;
            originalProduct.Price = changedProduct.Price;
            context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            context.Products.Remove(new Product { ProductID = id });
            context.SaveChanges();
        }
    }
}
