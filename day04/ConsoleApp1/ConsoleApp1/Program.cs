using MathsLibrary;
namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int ch = 0;
            Console.WriteLine("1.Add\n2.Substraction\n3.Exit");
            ;
            var calc = new MathsLibrary.Maths();
            do
            {
                Console.WriteLine("Enter Choice: ");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter a: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter b: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        int sum = calc.Add(a, b);
                        Console.WriteLine($"Addition of {a} and {b} = {sum}");
                        break;
                    case 2:
                        Console.WriteLine("Enter a: ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter b: ");
                        int d = Convert.ToInt32(Console.ReadLine());
                        int sub = calc.Sub(c, d);
                        Console.WriteLine($"Substraction of {c} and {d} = {sub}");
                        break;
                    default:
                        Console.WriteLine("invalid choice!");
                        break;
                }
            } while (ch != 3);
            
        }
    }
}
