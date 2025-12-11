namespace ConsoleApp1
{
    class Employee
    {
        //auto implemented properties
        //public property + private field
        public string Name {  get; set; }
        public double Salary { get; set; }
        public int Id { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var e = new Employee(); //implicit datatype -> compile time
        }

        
    }
}
