using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCraze.Web.Mvc.Models;

namespace ShoppingCraze.Web.Mvc.Controllers
{
    public class ShoppingController : Controller
    {
        // GET: Shopping
        public ActionResult Index()
        {
            var cart = (List<OrderVM>)Session["cart"];
            return View(cart);
        }

        [HttpGet]
        public ActionResult Create(OrderVM order)
        {
            List<OrderVM> cart = (List<OrderVM>)Session["cart"];
            cart.Add(order);

            return RedirectToAction("Index");
        }
    }
}