using Microsoft.AspNetCore.Mvc;
using MVCDemo1.Models;
using System.Diagnostics;

namespace MVCDemo1.Controllers
{
    public class HomeController : Controller
    {
        StudentContext sb = new StudentContext();
        
        public IActionResult Index()
        {
            var students = sb.students.ToList();

            return View(students);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
