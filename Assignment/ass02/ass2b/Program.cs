using System.Collections;
using System.Globalization;

namespace ass2b
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Department { get; set; }

        public Decimal Salary { get; set; }

        public Employee(int id, string name, string department, decimal salary)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
        }

        public void Display()
        {
            Console.WriteLine($"{Id}, {Name}, {Department}, {Salary}");
        }
    }

    class Student
    {
        
        public int SId { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            SId = id;
            Name = name;
        }
    }

    class Marks
    {
        //StudentId, Subject, Score
        public int StudentId { get; set; }
        public string Subject { get; set; }

        public double Score { get; set; }

        public Marks(int sid, string subject, double score)
        {
            StudentId = sid;
            Subject = subject;
            Score = score;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            #region 1
            List<int> nums = new List<int> { 10, 2, 30, 4, 55, 60, 7, 8 };

            var res1 = from n in nums
                       where n % 2 == 0
                       select n;
            var res2 = from n in nums
                       where n > 20
                       orderby n descending
                       select n ;
            int minAns = nums.Min();
            int maxAns = nums.Max();
            var avgAns = nums.Average();

            Console.WriteLine($"Minumum value from given numbers: {minAns}");
            Console.WriteLine($"Maximum value from given numbers: {maxAns}");
            Console.WriteLine($"Average value from given numbers: {avgAns}");

            Console.Write("Even numbers from given numbers: ");
            foreach(var v in res1)
            {
                Console.Write(v+" ");
            }
            Console.WriteLine();

            Console.Write("Numbers greater than 20 (descending order): ");
            foreach (var v in res2)
            {
                Console.Write(v + " ");
            }
            Console.WriteLine();
            #endregion

            #region 2
            List<Employee> employees = new List<Employee>
            {
                new Employee(1, "Joey", "Computer Science", 50000),
                new Employee(2, "Rachel", "Information Technology", 52000),
                new Employee(3, "Ross", "Mechanical Engineering", 48000),
                new Employee(4, "Monica", "Electrical Engineering", 55000),
                new Employee(5, "Chandler", "Information Technology", 47000),
                new Employee(6, "Phoebe", "Computer Science", 51000),
                new Employee(7, "Mike", "Electronics", 53000),
                new Employee(8, "Janice", "Information Technology", 49500),
                new Employee(9, "Gunther", "Mechanical Engineering", 46000),
                new Employee(10, "Emily", "Computer Science", 60000),
            };


            var res5 = from e in employees
                       where e.Department == "Information Technology"
                       select e;

            Console.WriteLine("Employess in IT department: ");
            foreach(var r in res5)
            {
                r.Display();
            }

            var highestSal = employees.Max(e => e.Salary);

            var res6 = from e in employees
                       where e.Salary == highestSal
                       select e;
            Console.WriteLine();
            Console.WriteLine("Employess with higest salary: ");
            foreach (var r in res5)
            {
                r.Display();
            }

            var res7 = from emp in employees
                       group emp by emp.Department into g
                       orderby g.Key
                       select new { Department = g.Key, NumberOfEmployees = g.Count() };
            Console.WriteLine();
            Console.WriteLine("Group by Department: ");
            foreach(var r in res7)
            {
                Console.WriteLine($"{r.Department} : {r.NumberOfEmployees}");
            }

            #endregion

            #region 3
            List<Student> studentList = new List<Student> {
                new Student(1, "Vishwadeep"),
                new Student(2, "manish"),
                new Student(3, "durvankur"),
                new Student(4, "pruthviraj"),
                new Student(5, "sunny"),
                new Student(6, "sudha"),
                new Student(7, "atharv"),
                new Student(8, "satyajit"),
                new Student(9, "prafull"),
                new Student(10, "varad")

            };
            List<Marks> markList = new List<Marks> {
                new Marks(1,"maths",95),
                new Marks(2,"science",95),
                new Marks(3,"history",95),
                new Marks(4,"geography",95),
                new Marks(5,"operating system",95),
                new Marks(6,"computer networks",95),
                new Marks(1,"marathi",95),
                new Marks(2,"english",95),
                new Marks(4,"computer network",95),
                new Marks(10,"operating sytem",95),
            };

            //Display: Student Name – Subject – Score.

            var res8 = from stud in studentList
                       join mark in markList on stud.SId equals mark.StudentId
                       select new { Name = stud.Name, Subject = mark.Subject, Score = mark.Score };
            #endregion

            #region 4
            List<String> cities = new List<string>
            {
                "Pune", "Pandharpur", "Paris", "Kolhapur", "Mumbai", "Pavas", "Satara", "Ichalkarani", "Karad", "Delhi"
            };
            var res9 = from city in cities
                       where (city.StartsWith('P') && city.Length == 5)
                       select city;
            Console.WriteLine();
            Console.WriteLine("Cities starting with P having length 5:");
            foreach(var r in res9)
            {
                Console.WriteLine(r);
            }
            #endregion
            
        }
    }
}
