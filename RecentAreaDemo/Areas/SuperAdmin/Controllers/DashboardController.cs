using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecentAreaDemo.Areas.SuperAdmin.Data;
using RecentAreaDemo.Areas.SuperAdmin.Models;

namespace RecentAreaDemo.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class DashboardController : Controller
    {
        private readonly ApplicationDBContext dbContext;

        public DashboardController(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            dbContext.Books.Add(book);
            dbContext.SaveChanges();

            return RedirectToAction("Create","Dashboard", new { area = "SuperAdmin" });
        }
    }

}
