using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScalFoldDemo1.Models;

namespace ScalFoldDemo1.Controllers
{
    
    public class StudentController : Controller
    {
        public static SbContext sb = new SbContext();
        public IActionResult Index() 
        {
            var slist = sb.Students.Include(s => s.course).ToList();
            return View(slist);
        }
        public IActionResult Create()
        {
            var result = sb.Courses.ToList();

            ViewBag.Courses = new SelectList(result,"CourseId","CourseName");
            return View();
        }
        public IActionResult AfterCreate(Student s)
        {
            sb.Students.Add(s);
            sb.SaveChanges();

            return Redirect("/Student/Index");
        }
        public IActionResult Edit(int id)
        {
            var s = sb.Students.Find(id);

            var result = sb.Courses.Where(c=>c.CourseId==s.CourseId);

            ViewBag.Courses = new SelectList(result, "CourseId", "CourseName");
            return View(s);
        }
        public IActionResult AfterEdit(Student st)
        {

            sb.Students.Update(st);
            sb.SaveChanges();

            return Redirect("/Student/Index");
        }
    }
}
