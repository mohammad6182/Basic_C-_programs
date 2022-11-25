using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page275
{
   public class Math
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 3, 5, 7, 8 };
            Console.WriteLine("Add a number: ");
            int numbers2 = Convert.ToInt32(Console.ReadLine());
            foreach (int num in numbers2)
            {
                if (num >= 0)
                {
                    Console.WriteLine(num + numbers);
                    
                }
                Console.ReadLine();
            }
        }
    }
}
