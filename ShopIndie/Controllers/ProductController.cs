using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShopIndie.Controllers
{
    public class ProductController : Controller
    {

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