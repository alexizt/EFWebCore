using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFWeb.Models;

namespace EFWeb.Controllers
{
    public class HomeController : Controller
    {
        readonly CourseRepository CourseRepository;

        public HomeController(CourseRepository courseRepository) {
            CourseRepository = courseRepository;
            
        }


        public async Task<IActionResult> Index()
        {
            //CourseRepository.Add(new Course() { CourseID = 1, Credits = 1, Enrollments = new List<Enrollment>(), Title = "EF 5" });
            var allCourses = await CourseRepository.GetAllAsync();
            ViewBag.allCourses = allCourses;
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
