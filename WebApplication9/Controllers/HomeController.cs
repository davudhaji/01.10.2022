using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        

        public HomeController(AppDbContext context)
        {
            _context = context;             
        }

        public IActionResult Index()
        {
            CartModel newCart = new CartModel();
            newCart.Title = "Davud Haji";
            newCart.Price = 55;
            newCart.Count = 4;
            newCart.Discount = 40;
            newCart.date = DateTime.UtcNow;

            _context.cartModels.Add(newCart);

            _context.SaveChanges();


            

            //ViewBag.carts = _context.cartModels.ToList();


            return View();
        }

    }
}
