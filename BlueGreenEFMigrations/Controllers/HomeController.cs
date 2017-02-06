using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlueGreenEFMigrations.Models;
using BlueGreenEFMigrations.ViewModels;

namespace BlueGreenEFMigrations.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var context = new SchoolDbContext();

            var subjects = context
                .Subjects
                .Select(s =>
                    new SubjectViewModel
                    {
                        Id = s.Id,
                        Name = s.Name
                    })
                .ToList();

            return View(subjects);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}