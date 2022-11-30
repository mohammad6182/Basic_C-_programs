using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page292
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SayName = new List<string>() { "John", "Alex", "Mark", "Tom", "Sam" };
            person.ListFullName();
            Console.ReadLine();






            //Console.WriteLine("What is your first name");
            //string FirstName = Console.ReadLine();
            //Console.WriteLine("whay is your last name ");
            //string LastName = Console.ReadLine();
            //Console.WriteLine("Name: " + FirstName + LastName);
            //Console.ReadLine();
        }
    }
}
