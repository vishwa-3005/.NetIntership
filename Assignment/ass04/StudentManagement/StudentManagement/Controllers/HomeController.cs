using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using Microsoft.EntityFrameworkCore;
namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        public static StudentContext sb = new StudentContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CreateStudent() { 
            return View();
        }
        public IActionResult CreateCourse() { 
            return View();
        }
        public IActionResult ViewStudents()
        {
            var slist = sb.Students.Include(s => s.Courses).ToList();
            return View(slist);
        }
        public IActionResult ViewCourses()
        {
            var clist = sb.Courses.ToList();
            return View(clist);
        }
        public IActionResult AfterCreateStudent(Student s) {
            sb.Students.Add(s);
            sb.SaveChanges();
            return Redirect("/Home/ViewStudents");
        }
        public IActionResult AfterCreateCourse(Course c) {
            sb.Courses.Add(c);
            sb.SaveChanges();
            return Redirect("/Home/ViewCourses");
        }
        public IActionResult DeleteCourse(int id)
        {
            var s = sb.Courses.Find(id);
            sb.Courses.Remove(s);
            sb.SaveChanges();
            return Redirect("/Home/ViewCourses");
        }
        public IActionResult DeleteStudent(int id)
        {
            var s = sb.Students.Find(id);
            sb.Students.Remove(s);
            sb.SaveChanges();
            return Redirect("/Home/ViewStudents");
        }
        public IActionResult EditStudent(int id)
        {
            var s = sb.Students.Find(id);

            return View(s);
        }
        public IActionResult EditCourse(int id)
        {
            var s = sb.Courses.Find(id);

            return View(s);
        }
        public IActionResult AfterEdit(Student s)
        {
            Student st = sb.Students.Find(s.StudentId);
            st.FirstName = s.FirstName;
            st.LastName = s.LastName;
            sb.SaveChanges();
            return Redirect("/Home/ViewStudents");
        }
        public IActionResult AfterCourseEdit(Course s)
        {
            Course c = sb.Courses.Find(s.StudentId);
            c.StudentId = s.StudentId;
            c.CourseName = s.CourseName;
            
            sb.SaveChanges();
            return Redirect("/Home/ViewCourses");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
