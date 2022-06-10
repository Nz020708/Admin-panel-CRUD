using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _db { get; }
        public HomeController(AppDbContext db)
        {
            _db=db;
        }
        public IActionResult Index()
        {
            HomeVM home = new HomeVM
            {
                Slides = _db.Slides.ToList(),
                Summary = _db.Summary.FirstOrDefault(),
                Categories = _db.Categories.Where(c => !c.IsDeleted).ToList(),
                Products=_db.Products.Where(c=>!c.IsDeleted).Include(p=>p.Images).Include(p=>p.Category).ToList()
            };
            return View(home);
        }
    }
}
