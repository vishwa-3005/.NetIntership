using ConsoleApp1;
using Microsoft.EntityFrameworkCore;
namespace ConsoleApp1
{
    internal partial class Program
    {
        static SchoolContext sb = new SchoolContext();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("---------------Student Management System---------------");
            Console.WriteLine("1.Add Student\n2. Add Course (assign to Student)\n3. View all Students with Courses\n4. Update Course Name\n5. Delete Course\n6. Delete Student\n7. Exit");
            int ch;
            do
            {
                Console.Write("Enter Choice: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out ch))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return; // or loop again
                }
                switch (ch)
                {
                    case 1:
                        int res = AddStudent();
                        if (res == 1) Console.WriteLine("Student Added!");
                        else Console.WriteLine("Operation failed!");
                        break;
                    case 2:
                        int res2 = AddCourse();
                        if (res2 == 1) Console.WriteLine("Course Added!");
                        else Console.WriteLine("Operation failed!");
                        break;
                    case 3:
                        ViewAllStudentXCourse();
                        break;
                    case 4:
                        int res3 = UpdateCourseName();
                        if (res3 == 1) Console.WriteLine("Course Name Updated!");
                        else Console.WriteLine("Operation failed!");
                        break;
                    case 5:
                        int res4 = DeleteCourse();
                        if (res4 == 1) Console.WriteLine("Course Deleted!");
                        else Console.WriteLine("Operation failed!");
                        break;
                    case 6:
                        int res5 = DeleteStudent();
                        if (res5 == 1) Console.WriteLine("Student Deleted!");
                        else Console.WriteLine("Operation failed!");
                        break;
                    case 7:
                        Console.WriteLine("Thank you ! Have a nice day!");
                        break;
                    default:
                        Console.WriteLine("Enter valid choice!!");
                        break;
                }
            } while (ch != 7);
        }

        public static int AddStudent()
        {
            Console.Write("Enter First name: ");
            string sname = Console.ReadLine();
            Console.Write("Enter Last name: ");
            string lname = Console.ReadLine();
            Student s = new Student { FirstName = sname , LastName = lname};
            sb.Students.Add(s);
            return sb.SaveChanges();
        }

        public static int AddCourse()
        {
            Console.Write("Enter Course name: ");
            string cname = Console.ReadLine();
            Console.Write("Enter Student ID: ");
            int sid = Convert.ToInt32(Console.ReadLine());
            Course c = new Course { StudentId = sid, CourseName =  cname};
            sb.Courses.Add(c);
            return sb.SaveChanges();
        }

        public static void ViewAllStudentXCourse()
        {
            var students = sb.Students.Include(s => s.Courses).ToList();
            foreach(var s in students)
            {
                
                Console.Write($"studentId:{s.StudentId}, StudentName:{s.FirstName} Enrolled in:  ");
                if(s.Courses.Count() == 0)
                {
                    Console.Write("No courses");
                    Console.WriteLine("\n-------------------------------------------");
                    continue;
                }
                foreach(var c in s.Courses)
                {
                    Console.Write($"{c.CourseName} || ");
                }
                Console.WriteLine("\n-------------------------------------------");
            }
            
        }
        public static int UpdateCourseName() {
            Console.Write("Enter Course Id: ");
            int cid = Convert.ToInt32(Console.ReadLine());
            Course c = sb.Courses.Find(cid);

            if(c != null)
            {
                Console.Write("Enter Course Name: ");
                string newName = Console.ReadLine();
                c.CourseName = newName;
               
            }
            return sb.SaveChanges();
            
        }
        public static int DeleteCourse()
        {
            Console.Write("Enter Course Id for the Course to be DELETED: ");
            int cid = Convert.ToInt32(Console.ReadLine());
            Course c = sb.Courses.Find(cid);
            if(c != null)
            {
                sb.Courses.Remove(c);
            }
            return sb.SaveChanges();
        }
        public static int DeleteStudent() {
            Console.Write("Enter Student Id for the Student to be DELETED: ");
            int sid = Convert.ToInt32(Console.ReadLine());
            Student s = sb.Students.Find(sid);
            if (s != null)
            {
                sb.Students.Remove(s);
            }
            return sb.SaveChanges();
        }
    }
}


//1.Add Student 2. Add Course (assign to Student) 3. View all
//Students with Courses 4. Update Course Name 5. Delete Course 6. Exitq [
