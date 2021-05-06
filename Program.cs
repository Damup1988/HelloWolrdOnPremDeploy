using System;

namespace HelloWorldOnPremDeploy
{
    class Program
    {
        static void some_func()
        {
            Console.WriteLine("Some func has been called...");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Damir and World!");

            some_func();

            Console.ReadLine();
        }
    }
}
