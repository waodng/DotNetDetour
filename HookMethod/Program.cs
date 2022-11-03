using System;
using DotNetDetour;

namespace HookNetMethod
{
    class Program
    {
        public static string Run(string msg)
        {
            return msg;
        }

        static void Main(string[] args)
        {
            TestMethod testMethod = new TestMethod();
            Console.WriteLine(testMethod.RunA("hello method"));
            MethodHook.Install();
            Console.WriteLine(testMethod.RunA("hello method"));

            Console.WriteLine("按任意键继续！");
            Console.ReadKey();
        }
    }
}
