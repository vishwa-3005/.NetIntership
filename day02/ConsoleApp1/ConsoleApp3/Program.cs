using System.Collections;
using System.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }

            //public Employee() { }
            public string Address { get; set; }
            public Employee(int id, string name, string address)
            {
                Id = id;
                Name = name;
                Address = address;
            }

            public void Display()
            {
                Console.WriteLine($"Name : {Name}, ID: {Id}, Address: {Address}");
                
            }
            //public void Accept()
            //{
            //    Console.WriteLine("Enter ID: ");
            //    Id = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter Name: ");
            //    Name = Console.ReadLine();
            //}
        }
        static void Main(string[] args)
        {

            #region non-generic collection
            //Console.WriteLine("Hello, World!");
            //ArrayList arr = new ArrayList();
            //arr.Add(1);
            //arr.Add("Vishwadeep");
            //arr.Add(2);
            //arr.Add("Sankpal");
            //arr.Add('!');
            //int num = (int)arr[0];
            //string s = (string)arr[3]; //you have typcase it since arr[i] is of type object -> issue

            //foreach(var item in arr)
            //{

            //    Console.WriteLine(item);
            //}

            //Hashtable mp = new Hashtable()
            //{
            //    {1,"ram" }, {2,"sita" }, {3,"laxman"}
            //};

            ////same issue is for hashtable -> typecasting issue
            //string a = (string)mp[3];
            #endregion

            #region generic collection
            //List<int> l1 = new List<int>();
            //List<string> l2 = new List<string>();
            //List<object> l3 = new List<object>(); //legacy type
            //l1.Add(1);
            //l1.Add(2);
            //l1.Add(3);

            //l2.Add("arjun");
            //l2.Add("krishna");
            //l2.Add("karn");

            ////dictionary - alternative to hashtable
            //Dictionary<int, string> d1 = new Dictionary<int, string>();
            //d1.Add(0, "he");
            //d1.Add(1, "she");
            //d1.Add(2, "they");

            //foreach(var item in d1)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            List<Employee> list = new List<Employee>() {
                new Employee(1, "ram", "kolhapur"),
                new Employee(1, "sham", "pune"),
                new Employee(1, "radhey", "pune"),
                new Employee(1, "parth", "banglore"),
                new Employee(1, "sam", "london")

            };
            //Console.Write("Enter number od Employees: ");
            //int n = Convert.ToInt32( Console.ReadLine() );

            //for(int i = 0; i < n; i++)
            //{
            //    Employee e = new Employee();
            //    Console.WriteLine($"Enter Name of Employee({i+1})");
            //    e.Name = Console.ReadLine();
            //    Console.WriteLine($"Enter ID of Employee({i + 1})");
            //    e.Id = Convert.ToInt32(Console.ReadLine());
            //    list.Add(e);
            //}

            //foreach (var e in list) { 
            //    e.Display();
            //}

             new Employee(1, "ram", "kolhapur");
             new Employee(1, "sham", "Pune");
             new Employee(1, "radhey", "Pune");
             new Employee(1, "parth", "banglore");
            new Employee(1, "sam", "london");

            //list.Add(e1);
            //list.Add(e2);
            //list.Add(e3);
            //list.Add(e4);
            //list.Add(e5);

            foreach (Employee e in list) { 
                string s = e.Address;
                if (s.Contains('p', StringComparison.OrdinalIgnoreCase))
                {
                    e.Display();
                }
            }

            
            
        }
    }
}
