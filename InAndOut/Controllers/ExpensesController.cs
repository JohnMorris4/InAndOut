using System.Collections.Generic;
using System.Threading.Tasks;
using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ExpensesController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET
        public IActionResult Index()
        {
            IEnumerable<MyExpenses> objList = _db.Expenses;
            
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }
        
        //Post Action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MyExpenses obj)
        {
            if (ModelState.IsValid)
            {
                _db.Expenses.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }
    }
}