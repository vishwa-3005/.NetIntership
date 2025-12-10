using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01
{
    internal class Program
    {
        class Student
        {
            private int _rollNo;
            private string _name;
            private String _course;
            private int _age;

            public int RollNum {
                get { return _rollNo; }
                set { _rollNo = value; }
             }
            public int Age {  
                get { return _age; }
                set { _age = value; }
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public String Course
            {
                get { return _course; }
                set { _course = value; }
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Student : {_name}, Student Age : {_age}, Student Roll Number : {_rollNo}, Student Course : {_course}");
            }
        }
        static void Main(string[] args)
        {
            
            int roll = -1;
            string name;
            string course;
            int age = -1;

            List<Student> students = new List<Student>();
            Console.WriteLine("Enter number of student :");
            int n = Convert.ToInt32( Console.ReadLine() );
            for (int i = 0; i < n; i++) {
                Console.Write("Enter Student name :");
                name = Console.ReadLine();

                Console.Write("Enter Student Roll Number :");

                try
                {
                    int r = Convert.ToInt32(Console.ReadLine());
                    roll = r;
                    if (roll < 0)
                    {
                        throw new Exception("Invalid roll number");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.Write("Enter Student age :");
                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    age = a;
                    if (age < 0 && age > 150)
                    {
                        throw new Exception("Invalid roll number");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.Write("Enter Student Course :");
                course = Console.ReadLine();

                Student s = new Student();
                s.Course = course;
                s.Age = age;
                s.RollNum = roll;
                s.Name = name;

                students.Add(s);
            }

            Console.WriteLine("Student Information : ");
            for(int i = 0; i < n; i++)
            {
                students[i].DisplayInfo();
            }
        }
    }
}
