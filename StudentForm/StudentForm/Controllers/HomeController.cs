using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentForm.Models;

namespace StudentForm.Controllers
{
    public class HomeController : Controller
    {
        StudentDbContext _db = null;
        public HomeController(StudentDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Students.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student v)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(v);
                _db.SaveChanges();
                return RedirectToAction("Create");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
