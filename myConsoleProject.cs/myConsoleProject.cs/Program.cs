using System;


namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("hello, " + name + "!");
            Console.Read();
        }
    }
}
