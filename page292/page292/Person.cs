using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page292
{
    class Person
    {
        public List<string> SayName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void ListFullName()
        {
            foreach(string fullname in SayName)
            {
                Console.WriteLine(fullname);
            }
        }
    }
}
