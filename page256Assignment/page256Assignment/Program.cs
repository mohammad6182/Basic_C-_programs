using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page256Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part One Assignment 
            string[] colors = { "Pink", "Blue", "Red", "White" };
            Console.WriteLine("what color are we missing ?");
            string color = Console.ReadLine();
            for(int i = 0; i < colors.Length; i++)
            {
                colors[i] += color;
                
            }
            for (int i = 0; i < colors.Length; i++)
            {
                
                Console.WriteLine(colors[i]);
            }
            //Part Two
            //old one( Infinite)
            //for (int i = 0; i >= 0; i++)
            //{
            //    Console.WriteLine("Looping");
            //}
            ///Fixed one , Condition had been changed 
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Looping");
            }



            // Part Three
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine("Part Three");
            }
            for (int a = 0; a <= 9; a++)
            {
                Console.WriteLine("Part three, second one");
            }

            // part four 
            List<string> names = new List<string>() { "John", "David", "Mike", "Tom" };
            Console.WriteLine("What name are you looking for");
            string name= Console.ReadLine();
            for (int n = 0; n < names.Count; n++)
            {
                if(names[n] == name)
                {
                    Console.WriteLine("match found at index number " + n);
                    break;
                }
             
            }
            if (!names.Contains(name))
            {
                Console.WriteLine("Name doesnt exist");
            }


            // Part Five
            List<string> phones = new List<string>() { "Apple", "Nokia", "Samsung", "HTC", "Apple" };
            Console.WriteLine("what is your favorite?");
            string phone = Console.ReadLine();
            for (int p = 0; p < phones.Count; p++)
            {
                if(phones[p] == phone)
                {
                    Console.WriteLine("We have that in our list, thst is phone number " + p);
                }
                
            }
            if (!phones.Contains(phone))
            {
                Console.WriteLine("We dont have that brand");
            }

            //part six
            List<string> alphabets = new List<string>() { "a", "b", "d", "x", "x" };
            List<string> duplicate = new List<string>();
            foreach (string a in alphabets)
            {
                if (duplicate.Contains(a))
                {
                    Console.WriteLine("alphabet is a duplicate" + a);
                }
                else
                {
                    Console.WriteLine("It is a unique item" + a);
                    duplicate.Add(a);
                }
            }




            Console.ReadLine();
        }
    }
}
