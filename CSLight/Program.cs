using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If Else

            int age;

            Console.Write("Enter your age: ");

            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are an adult");
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("You are not an adult");
                Console.WriteLine($"Come again in {18 - age} years");
            }

            string dayOfWeak;

            Console.Write("Enter the day of the week: ");
            dayOfWeak = Console.ReadLine();

            if (dayOfWeak == "Monday".ToLower())
            {
                Console.WriteLine("It's Monday");
            }
            else if (dayOfWeak == "Tuesday".ToLower())
            {
                Console.WriteLine("It's Tuesday");
            }









            Console.ReadKey();




        }
    }
}
