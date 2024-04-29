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
            //Switch

            string dayOfWeak;

            Console.Write("Enter the day of the week: ");
            dayOfWeak = Console.ReadLine();


            switch (dayOfWeak.ToLower())
            {
                case "monday":
                    Console.WriteLine("It's Monday"); break;
                case "tuesday":
                    Console.WriteLine("It's Tuesday"); break;
                case "wednesday":
                    Console.WriteLine("It's Wednesday"); break;
                case "thursday":
                    Console.WriteLine("It's Thursday"); break;
                case "friday":
                    Console.WriteLine("It's Friday"); break;
                case "saturday":
                case "sunday":
                    Console.WriteLine("It's Weekend!!!"); break;
                default:
                    Console.WriteLine("Invalid day of the week"); break;
            }












            Console.ReadKey();




        }
    }
}
