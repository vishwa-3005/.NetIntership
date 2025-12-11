using System.Collections;
using System.Numerics;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] arr = { 1, 2, 3, 4 };
            char[] brr = { 'a', 'b', 'c' };
            int[] nums = new int[10];
            int[] crr = new int[10];

            for (int i = 0; i < 10; i++) {
                nums[i] = i;
            }

            for (int i = 0; i < nums.Length; i++) {
                Console.WriteLine(nums[i]);
            }

            Console.WriteLine("Enter size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[n];
            for (int i = 0; i < words.Length; i++) {
                Console.Write($"Enter {i}th word : ");
                words[i] = Console.ReadLine();
            }
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }

            ArrayList a1 = new ArrayList();
            a1.Add(10);
            a1.Add("vishwadeep");

            foreach(var t in a1) Console.WriteLine(t);
        }
    }
}
