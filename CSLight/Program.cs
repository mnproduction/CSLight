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
            // Strings

            // Concat

            Console.WriteLine("Hello" + " " + "World");

            // Interpolation

            Console.WriteLine($"Hello {1 + 1} World");

            // Conversions

            int age;
            
            string ageAsString = "25";

            age = Convert.ToInt32(ageAsString);
            Console.WriteLine(Convert.ToChar(age));

            
            Console.WriteLine(Convert.ToDouble(ageAsString));
            

            Console.WriteLine(Convert.ToByte(age));


            Console.WriteLine(Convert.ToDecimal(age));


            Console.WriteLine(Convert.ToBoolean(age));


            Console.WriteLine();



            Console.WriteLine();
            Console.ReadKey();




        }
    }
}
