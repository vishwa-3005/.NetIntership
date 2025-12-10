namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Student s = new Student(21, "Krish", "History");
            Console.WriteLine(s.Name);
        }
    }

    class Student
    {
        int _rollNo;
        string _name;
        string _course;

        //property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //consturctor

        public Student(int rollNo, string name, string course) { 
            this._course = course;
            this._rollNo= rollNo;
            this._name = name;
    }
        //display method

        //accept method

    }

}
