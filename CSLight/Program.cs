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
            //While

            int age;
            
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            int forAge = age;
            while (age-- > 0)
            {
                if (age == 5) { continue; }
                Console.WriteLine($"Age is {age}");

            }

            // For

            for (int i = 0; i <= forAge; ++i)
            {
                Console.WriteLine($"Age is {i}");
            }

          




            Console.ReadKey();




        }
    }
}
