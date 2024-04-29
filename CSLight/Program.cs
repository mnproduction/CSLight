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
            // Math operations
            int timeInMinutes = 130;
            int hour;
            int minute;

            hour = timeInMinutes / 60;
            minute = timeInMinutes % 60;

            int age = 10;
            age++;
            Console.WriteLine("Age is {0}", age);

            age += 1;
            Console.WriteLine("Age is {0}", age);

            age--;
            Console.WriteLine("Age is {0}", age);

            age -= 1;
            Console.WriteLine("Age is {0}", age);

            Console.WriteLine("{0} minutes is {1} hours and {2} minutes", timeInMinutes, hour, minute);
            Console.ReadKey();




        }
    }
}
