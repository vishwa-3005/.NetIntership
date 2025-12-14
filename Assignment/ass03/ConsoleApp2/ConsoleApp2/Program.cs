using Microsoft.EntityFrameworkCore;
namespace ConsoleApp2
{
    internal  class Program
    {
        public static EmployeeContext em = new EmployeeContext();
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------Employee Management System----------------");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Manager\n2. Add Staff (assign to Manager)\n3. Add Task(assign to Staff)\n4. View all Managers, Staff & Tasks\n5. Update Task (mark as completed)\n6.Delete Task\n7. Exit");
            int ch;

            do
            {
                Console.Write("Enterc choice: ");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        int res = AddManager();
                        if(res == 1) Console.WriteLine("Manager Added!");
                        else Console.WriteLine("Operation Failed!");
                        break;
                    case 2:
                        int res2 = AddStaff();
                        if(res2 == 1) Console.WriteLine("New Staff Member Added");
                        else Console.WriteLine("Operation Failed!");
                        break;
                    case 3:
                        int res3 = AddTask();
                        if (res3 == 1) Console.WriteLine("Task Added!");
                        else Console.WriteLine("Operation Failed!");
                        break;
                    case 4:
                        ViewAllDetails();
                        break;
                    case 5:
                        int res5 = UpdateTask();
                        if (res5 == 1) Console.WriteLine("Task Updated!");
                        else Console.WriteLine("Operation Failed!");
                        break;
                    case 6:
                        break;
                    case 7:
                        Console.WriteLine("Thank you! Have a nice day...");
                        break;
                }
            } while (ch != 7);
        }

        static int AddManager()
        {
            string name, email;
            Console.Write("Enter Manager name: ");
            name = Console.ReadLine();
            Console.Write("Enter Manager Email (xyz@abc.com): ");
            email = Console.ReadLine();
            Manager m = new Manager { Name = name, Email = email };
            em.Managers.Add(m);
            return em.SaveChanges();
        }

        static int AddStaff() //assign to manager
        {
            int mid;
            string name, mail;
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Email: ");
            mail = Console.ReadLine();
            Console.Write("Enter Manager ID: ");
            mid = Convert.ToInt32(Console.ReadLine());

            Staff s = new Staff { Email = mail, ManagerId = mid , Name = name};
            em.Staffs.Add(s);
            return em.SaveChanges();
        }

        static int AddTask() //asign to staff
        {
            
            string title, desc;
            bool isCompleted;
            int staffId;
            Console.Write("Enter Title of Task: ");
            title = Console.ReadLine();
            Console.Write("Enter Description of Task: ");
            desc = Console.ReadLine();
            Console.Write("Is Task Completed ?(True/False): ");
            isCompleted = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Enter Staff Id for task to be assigned: ");
            staffId = Convert.ToInt32(Console.ReadLine());

            TaskItem t = new TaskItem
            {
                Title = title,
                Description = desc,
                IsCompleted = isCompleted,
                StaffId = staffId
            };

            em.TaskItems.Add(t);
            return em.SaveChanges();
        }

        static void ViewAllDetails() //manager->staff->task
        {
            //Console.WriteLine();
            List<Manager> managers = em.Managers.Include(s => s.staflist).ThenInclude(t => t.taskItems).ToList();
            foreach (var m in managers)
            {
                Console.WriteLine($"Manager Name: {m.Name}, Email: {m.Email}");
                Console.WriteLine("Staff Members Working under: ");
                int i = 1;
                foreach(var s in m.staflist)
                {
                    Console.WriteLine(i + ". " + s.Name + " Working on: ");
                    foreach(var t in s.taskItems)
                    {
                        Console.WriteLine($"Title:{t.Title}\nDescription: {t.Description}\nIsCompleted: {t.IsCompleted}");
                    }
                    i++;
                }
                Console.WriteLine("\n---------------------------");
            }
            
        }

        static int UpdateTask()
        {
            Console.Write("Enter Task Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            TaskItem t = em.TaskItems.Find(id);
            if (t == null)
            {
                Console.WriteLine("Invalid Task ID! Enter Valid TaskID..");
                UpdateTask();
            }
            else
            {
                Console.Write("Update Task to Completed(True)/Not Completed(False): ");
                bool flag = Convert.ToBoolean(Console.ReadLine());
                t.IsCompleted = flag;
            }
            return em.SaveChanges();
        }

        static int DeleteTask()
        {
            Console.Write("Enter Task Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            TaskItem t = em.TaskItems.Find(id);
            if (t == null)
            {
                Console.WriteLine("Invalid Task ID! Enter Valid TaskID..");
                DeleteTask();
            }
            em.TaskItems.Remove(t);
            return em.SaveChanges();
        }

    }
} 
