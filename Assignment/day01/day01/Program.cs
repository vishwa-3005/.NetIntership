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
                Console.WriteLine($"Student Name : {_name}");
                Console.WriteLine($"Student Age : {_age}");
                Console.WriteLine($"Student Roll Number : {_rollNo}");
                Console.WriteLine($"Student Course : {_course}");
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            int roll = -1;
            string name;
            string course;
            int age = -1;
            Console.WriteLine("Enter Student name :");
            name = Console.ReadLine();

            Console.WriteLine("Enter Student Roll Number :");
            
            try
            {
                int r = Convert.ToInt32( Console.ReadLine() );
                roll = r;
                if(roll < 0)
                {
                    throw new Exception("Invalid roll number");
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Enter Student age :");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                age = a;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Enter Student Course :");
            course = Console.ReadLine();

            s.Course = course;
            s.Age = age;
            s.RollNum = roll;
            s.Name = name;

            s.DisplayInfo();;
        }
    }
}
