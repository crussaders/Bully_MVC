using Bully_MVC.Data;
using Bully_MVC.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace Bully_MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
           
           List<Models.Category> objCategoryList = _db.Categories.ToList();
           // _ = _db.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
