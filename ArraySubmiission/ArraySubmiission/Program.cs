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

            int[] mineNumbers = { 1,3,9,16,444 };
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

            List<string> names = new List<string>() { "John", "Alex", "Mike", "Tom" };
            Console.WriteLine("Choose index to show name");
            int index2 = Convert.ToInt32(Console.ReadLine());
            if (index2 < names.Count)
            {
                Console.WriteLine(names[index2]);
                Console.ReadLine();
            }


        }
    }
}
