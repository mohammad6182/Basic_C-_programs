using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page385
{
    class Program
    {
        static void Main(string[] args)
        {
            const string firstName = "John";
            var lastName = "Smith";
            Console.WriteLine("First construct!");
            NewEmployee a = new NewEmployee();
            Console.WriteLine("Second construct!");
            NewEmployee b = new NewEmployee(firstName);
            Console.WriteLine("Third construct!");
            NewEmployee c = new NewEmployee("Daniel", lastName);
            Console.ReadLine(); ;
        }
    }
}
