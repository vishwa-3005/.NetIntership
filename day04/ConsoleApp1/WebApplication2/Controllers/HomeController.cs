using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        StudentContext sb = new StudentContext();
        public IActionResult Index()
        {
            List<Student> slist = sb.students.ToList();
            return View(slist);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult AfterCreate(Student s)
        {
            sb.students.Add(s);
            sb.SaveChanges();

            return Redirect("/Home/Index");
        }

        public IActionResult Edit(int id)
        {
            var s = sb.students.Find(id);
            return View(s);
        }

        public IActionResult Delete(int id)
        {
            var s = sb.students.Find(id);
            sb.students.Remove(s);
            sb.SaveChanges();
            return Redirect("/Home/Index");
        }
        public IActionResult AfterEdit(Student s)
        {
            Student st = sb.students.Find(s.StudentId);
            st.StudentName = s.StudentName;
            st.CourseName = s.CourseName;
            st.StudentId = s.StudentId;
            sb.SaveChanges();

            return Redirect("/Home/Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
