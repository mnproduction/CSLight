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
            // Functions


            Console.WriteLine($"Hi!");
            Console.WriteLine("How are you?");
            Console.WriteLine("I'm fine, thank you!");
            WriteError(message: "Now I'm going to write an error!");
            Console.WriteLine("Goodbye!");
            WriteError();


            Console.ReadKey();


        }

        static void WriteError(string message = "Error!")
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = defaultColor;


        }
    }
}
