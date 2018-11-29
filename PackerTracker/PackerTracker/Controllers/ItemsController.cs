using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PackerTracker.Controllers
{
    public class ItemsController : Controller
    {
        [HttpGet("/items")]
        public ActionResult Index()
        {
            List<PackObject> allItems = PackObject.GetAll();
            return View(allItems);
        }

        [HttpGet("/items/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/items")]
        public ActionResult Create(string item, int price, int weight, bool purchase)
        {
            PackObject myPackObject = new PackObject(item, price, weight, purchase);
            return RedirectToAction("Index");
        }

        [HttpGet("/items/{id}")]
        public ActionResult Show(int id)
        {
            PackObject item = PackObject.Find(id);
            return View(item);
        }
    }
}
