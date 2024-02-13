using Bulkyweb.Data;
using Bulkyweb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Bulkyweb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db )
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create1() 
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Create1(Category obj)
        {
            _db.Categories.Add(obj); //it is use dto add the enetr value that the user has entered 
            _db.SaveChanges(); //whenever we addd we ahve to give save change in oder to get updated to that 
            return RedirectToAction("Index");
        }

    }
}
