using Microsoft.EntityFrameworkCore;

namespace EFDemo01
{
    internal class Program
    {
        static SbContext sb = new SbContext();
        static void Main(string[] args)
        {

            //foreach (var item in studlist)
            //{
            //    Console.WriteLine($"Roll no :{item.Roll_no} Name :{item.Name}");
            //}

            // int count=Add();
            //Console.WriteLine("Row Affected: "+count);


            //Student s = FindStudents();

            //Console.WriteLine($"Found :{s.Roll_no} Name :{s.Name}");
            //Console.WriteLine(Update());
            //Console.WriteLine("Deleted rows : " + Delete());

            Console.WriteLine("\nCollegeDB management system\n");
            Console.WriteLine("\n1.Display students \n2.Add Student \n3.Delete studenet \n4.Update student \n5.Find student \n-1.exit");

            int ch;
            do
            {
                Console.Write("\nEnter choice : ");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:

                        List<Student> studlist = GetAllStudents();
                        foreach (var item in studlist)
                        {
                            Console.WriteLine($"RollNo: {item.Roll_no}, Name: {item.Name}");
                        }
                        break;

                    case 2:
                        Console.Write("Enter student name : ");
                        string sname = Console.ReadLine();
                        Console.Write("Enter Course ID: ");
                        int cid = Convert.ToInt32(Console.ReadLine());

                        int res = Add(sname, cid);
                        if (res == 1) Console.WriteLine("Student Added successFully");
                        else Console.WriteLine("Operation Failed!!");
                        break;

                    case 3:
                        Console.Write("Enter student RollNO : ");
                        int rn = Convert.ToInt32(Console.ReadLine());

                        int res1 = Delete(rn);
                        if (res1 == 1) Console.WriteLine("Student Deleted successFully");
                        else Console.WriteLine("Operation Failed!!");
                        break;

                    case 4:
                        Console.Write("Enter student RollNO : ");
                        int rn2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter new name : ");
                        string newName = Console.ReadLine();

                        int res2 = Update(rn2, newName);
                        if (res2 == 1) Console.WriteLine("Student Updated successFully");
                        else Console.WriteLine("Operation Failed!!");
                        break;

                    case 5:

                        Console.Write("Enter student RollNO : ");
                        int rn3 = Convert.ToInt32(Console.ReadLine());

                        Student st = FindStudents(rn3);
                        if (st != null)
                        {
                            Console.WriteLine($"RollNo: {st.Roll_no}, Name: {st.Name}");
                        }
                        else Console.WriteLine("Operation Failed!!");
                        break;

                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }
            } while (ch != -1);

        }
        // select * from students
        public static List<Student> GetAllStudents()
        {
            return sb.students.ToList();
        }

        // add
        public static int Add(string sname, int cid)
        {

            Student s = new Student
            {
                Name = sname,
                Course_id = cid
            };

            sb.students.Add(s);
            return sb.SaveChanges();
        }
        // delete
        public static int Delete(int rn)
        {
            Student s = sb.students.Find(rn);
            if (s != null) sb.students.Remove(s);
            return sb.SaveChanges();
        }

        // update
        public static int Update(int rn2, string newName)
        {
            Student s = sb.students.Find(rn2);
            s.Name = newName;
            //sb.students.Add(s);
            return sb.SaveChanges();
        }

        // find
        public static Student FindStudents(int rn3)
        {
            return sb.students.Find(rn3);
        }


    }
}
