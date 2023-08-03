using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Helpers;
using WebApplication3.Model;

namespace WebApplication3.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Quantity * item.Product.Price);
            ViewBag.total = Math.Round(ViewBag.total,2);
            return View("Checkout");
        }
    }
}
