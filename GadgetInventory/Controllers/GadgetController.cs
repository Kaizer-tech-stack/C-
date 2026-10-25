using Microsoft.AspNetCore.Mvc;
using GadgetInventory.Models;
using System.Collections.Generic;

namespace GadgetInventory.Controllers
{
    public class GadgetController : Controller
    {
        //Data Storage = In memory storage
        private static List<Gadget> _gadgets = new List<Gadget>
        {
            new Gadget { Id = 1, Brand = "Apple", ModelName = "iPhone 15", Price = 799.00m },
            new Gadget { Id = 2, Brand = "Samsung", ModelName = "Galaxy S24", Price = 849.00m }
        };

        //GET: /Gadget/Index
        public IActionResult Index()
        {
            return View(_gadgets);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Gadget newGadget)
        {
            if (!ModelState.IsValid)
            {
                return View(newGadget); // Return form with error validation
            }

            newGadget.Id = _gadgets.Count + 1;
            _gadgets.Add(newGadget);

            return RedirectToAction("Index"); // PRG pattern
        }
    }
}