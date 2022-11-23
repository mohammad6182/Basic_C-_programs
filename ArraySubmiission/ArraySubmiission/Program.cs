using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySubmiission
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating my array list
            string[] mineWords = { "Blue", "Pink", "Red" };
            Console.WriteLine("Please choose a index");
            int index = Convert.ToInt32(Console.ReadLine());
            //whith using if statemnet, telling the array how to react to the different orders
            if (index < mineWords.Length)
            {
                Console.WriteLine(mineWords[index]);
                Console.ReadLine();

            }

            string[] mineNumbers = { "1", "3", "9" };
            Console.WriteLine("Please choose a index number");
            int index1 = Convert.ToInt32(Console.ReadLine());
            if (index1 < mineNumbers.Length)
            {
                Console.WriteLine(mineNumbers[index1]);
                Console.ReadLine();
            }
            if (index1 > mineNumbers.Length)
            {
                Console.WriteLine("No, That is ot a valid choice, try again");
                Console.ReadLine();
            }


        }
    }
}
