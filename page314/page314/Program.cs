using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page314
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e2 = new Employee()
            {
                iD = 2
            };
            Employee e1 = new Employee()
            {
                iD = 3
            };
            Console.WriteLine(e1 == e2);
            Console.WriteLine(e1 != e2);
            Console.ReadLine();

        }
    }
}
