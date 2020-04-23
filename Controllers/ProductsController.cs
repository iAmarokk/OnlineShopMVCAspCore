using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineShopMVCAspCore.Data;
using OnlineShopMVCAspCore.Models;

namespace OnlineShopMVCAspCore.Controllers
{
    public class ProductsController : Controller
    {
        //private readonly OnlineShopMVCAspCoreContext _context;
        private IDataRepository dataRepository;

        public ProductsController(IDataRepository dataRep)
        {
            dataRepository = dataRep;
        }

        // GET: Products
        public IActionResult Index(string category = null, int? rating = null,
           int? price = null, string sort = null)
        {
            //ViewData["Rating"] = new SelectList(_context.Set<Rating>(), "Rating", "Name");
            //ViewData["Category"] = new SelectList(_context.Set<Category>(), "Category", "Name");
            var products = dataRepository.GetFilteredProducts(category, rating, price, sort);
            ViewBag.category = category;
            ViewBag.rating = rating;
            ViewBag.price = price;
            ViewBag.sort = sort;
            return View(products);
        }

        //// GET: Products/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var product = await _context.Products
        //        .Include(p => p.Category)
        //        .Include(p => p.Rating)
        //        .FirstOrDefaultAsync(m => m.ProductID == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(product);
        //}

        // GET: Products/Create
        public IActionResult Create()
        {

            return View();
        }



    }
}
