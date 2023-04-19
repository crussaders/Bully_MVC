﻿using Bully_MVC.Data;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.Category obj)
        {
            if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name. ");
            }

         // if (obj.Name.ToLower() == "test")
         //    {
          //      ModelState.AddModelError("name", "Invalid value ");
         //   }

            if (ModelState.IsValid) {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Models.Category obj)
        {
            return View();
        }

    }
}
