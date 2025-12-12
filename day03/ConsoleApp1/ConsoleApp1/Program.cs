namespace ConsoleApp1
{
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }

        //public int courseID { get; set; }
    }

    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
