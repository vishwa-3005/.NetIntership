using System.Diagnostics;
using System.Reflection;

namespace Refelction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string path = "D:\\Internship\\.NetIntership\\day04\\ConsoleApp1\\MathsLibrary\\bin\\Debug\\net10.0\\MathsLibrary.dll";
            //string path ="D:\Internship\.NetIntership\day04\ConsoleApp1\MathsLibrary\bin\Debug\net10.0\MathsLibrary.dll;

            Assembly assembly = Assembly.LoadFrom(path);

            Type[] allTypesInAssemble = assembly.GetTypes();
            
            foreach (Type type in allTypesInAssemble)
            {
                Console.WriteLine("  " + type.FullName);
                Object dynamicObject = assembly.CreateInstance(type.FullName);
                Console.WriteLine("Object created for type : " + type.FullName);


                MethodInfo[] allMethods = type.GetMethods();
                foreach (MethodInfo method in allMethods) {
                    Console.WriteLine(" -- " + method.ReturnType.ToString() + " " + "( ");

                    Console.WriteLine("-- calling: " + method.Name);
                    ParameterInfo[] allParameters = method.GetParameters();

                    Object[] arguments = new Object[allParameters.Length];

                    for (int i = 0; i < allParameters.Length; i++) { 
                        ParameterInfo para = allParameters[i];

                        Console.WriteLine("Enter data of type " + para.ParameterType.ToString() + " for " + para.Name + " ");

                        string data = Console.ReadLine();
                        arguments[i] = Convert.ChangeType(data, para.ParameterType);
                    }

                    object output = type.InvokeMember(
                        method.Name,
                        BindingFlags.Public |
                        BindingFlags.Instance |
                        BindingFlags.InvokeMethod,
                        null, dynamicObject, arguments
                        );
                    Console.WriteLine(output);
                    Console.WriteLine("----------------");
                    //foreach (ParameterInfo param in allParameters) { 
                    //    Console.WriteLine(param.ParameterType.ToString() + " " + param.Name + " ");
                    //}
                    Console.WriteLine(" )");
                    Console.WriteLine();
                }
            }

        }
    }
}

