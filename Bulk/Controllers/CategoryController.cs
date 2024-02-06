using Bulk.Data;
using Bulk.Models;
using Microsoft.AspNetCore.Mvc;


namespace Bulk.Controllers
{
    public class CategoryController : Controller


    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db=db;
 
        }
        public IActionResult Index()
        {
            List<Category> objmodel = _db.Models.ToList();
            return View(objmodel);
        }
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            _db.Models.Add(obj);
            _db.SaveChanges(); 

            return RedirectToAction("Index");
        }
    }
}
