using System;

namespace HelloWorldOnPremDeploy
{
    class Program
    {
        static void some_func()
        {
            Console.WriteLine("Some func has been called...");
        }

        static void some_func2()
        {
            Console.WriteLine("Some func2 has been called...");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Damir and World!");

            some_func();
            some_func2();

            Console.ReadLine();
        }
    }
}
