using System.Collections.Generic;
using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET
        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }

        //Create GET Action
        public IActionResult Create()
        {
            return View();
        }
        
        //Create Post Action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj)
        {
            _db.Items.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}