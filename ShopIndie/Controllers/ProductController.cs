using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopIndie.Data;
using ShopIndie.Models;

namespace ShopIndie.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Product Product { get; set; }

        public IActionResult SubmitProduct()
        {
           
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}