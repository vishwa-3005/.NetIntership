namespace methodDemo
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int result = Maths.Add(10, 20);
            Console.WriteLine("Result: " + result);
        }
    }

    class Maths
    {
        /* public void Add(int x, int y)  //non static
         {
             int result = x + y;

             Console.WriteLine("Addition"+result);
         }*/
        /*public static void Add(int x, int y)  // static
        {
            int result = x + y;

            //Console.WriteLine("Addition" + result);
        }*/
        public static int Add(int x, int y)  // static
        {
            int result = x + y;
            return result;

            //Console.WriteLine("Addition" + result);
        }
    }
}
