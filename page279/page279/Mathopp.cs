using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page279
{
    class Mathopp //this is my new class
    {
        //my 1st method, taking in int and add 5 to it and returns int
        public int MAssighnment(int numbers)
        {
            int results = numbers + 5;
            Console.WriteLine("this is the int method");
            return results;
            
        }
        // 2nd method takes in decimal minus 3 and returns int
        public int MAssighnment(decimal a)
        {
            int results = (Convert.ToInt32(a) - 3);
            Console.WriteLine("this is the int decimal");

            return results;
        }
        public int MAssighnment(string w)
        {
            int results = (Convert.ToInt32(w)+4);
            Console.WriteLine("this is the int string");

            return results;
        }
    }
}
