using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using prodCat.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace prodCat.Controllers
{
    public class HomeController : Controller
    {
        private Context dbContext;
        public HomeController(Context context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("products")]
        [HttpGet]
        public IActionResult Products()
        {
            ProdNewView info = new ProdNewView()
            {
                prodList = dbContext.Products.ToList()
            };
            return View(info);
        }
        [Route("products")]
        [HttpPost]
        public IActionResult newProd(Product newProduct)
        {
            System.Console.WriteLine("Got to make new product");
            if(ModelState.IsValid)
            {
                System.Console.WriteLine("Is valid");
                dbContext.Add(newProduct);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Products");
        }
        [Route("products/{prodId}")]
        [HttpGet]
        public IActionResult ProductInfo(int prodId)
        {
            ProdInfoView info = new ProdInfoView()
            {
                thisProduct = dbContext.Products
                    .Include(item => item.prodCategories)
                    .ThenInclude(assoc => assoc.category)
                    .SingleOrDefault(prod => prod.productId == prodId),
                catList = dbContext.Categories
                    .Include(cat => cat.catProducts)
                    .ThenInclude(assoc => assoc.category)
                    .Where(cate => cate.catProducts.Any(asoc => asoc.productId == prodId) == false)
                    .ToList()
            };
            return View(info);
        }

        [Route("products/{prodId}")]
        [HttpPost]
        public IActionResult AddCat(int prodId, Association newPair)
        {
            dbContext.Add(newPair);
            dbContext.SaveChanges();
            return RedirectToAction("ProductInfo");
        }

        [Route("categories")]
        [HttpGet]
        public IActionResult Categories()
        {
            CatNewView info = new CatNewView()
            {
                catList = dbContext.Categories.ToList()
            };
            return View(info);
        }
        [Route("categories")]
        [HttpPost]
        public IActionResult newCat(Category newCategory)
        {
            System.Console.WriteLine("Got to make new category");
            if(ModelState.IsValid)
            {
                System.Console.WriteLine("Is valid");
                dbContext.Add(newCategory);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Categories");
        }
        [Route("categories/{catId}")]
        [HttpGet]
        public IActionResult CategoryInfo(int catId)
        {
            CatInfoView info = new CatInfoView
            {
                thisCategory = dbContext.Categories
                    .Include(cat => cat.catProducts)
                    .ThenInclude(assoc => assoc.product)
                    .SingleOrDefault(cat => cat.categoryId == catId),
                prodList = dbContext.Products
                    .Include(prod => prod.prodCategories)
                    .ThenInclude(assoc => assoc.product)
                    .Where(produ => produ.prodCategories.Any(asoc => asoc.categoryId == catId) ==false)
                    .ToList(),
            };
            
            return View(info);
        }
        [Route("categories/{catId}")]
        [HttpPost]
        public IActionResult AddProd(int catId, Association newPair)
        {
            dbContext.Add(newPair);
            dbContext.SaveChanges();
            return RedirectToAction("CategoryInfo");
        }
    }
}
