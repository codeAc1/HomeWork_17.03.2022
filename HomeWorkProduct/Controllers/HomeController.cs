using HomeWorkProduct.DAL;
using HomeWorkProduct.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWorkProduct.Controllers
{
    public class HomeController : Controller
    {
        private readonly WorkDbContext _context;
        public HomeController(WorkDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            List<Product> products = _context.Products.ToList();

            return View();
        }
    }
}
