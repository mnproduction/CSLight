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
            //Guess a number from 1 to 100

            Random random = new Random();
            int value;
            int triesCount = 5;
            int userInput;
            
            value = random.Next(1, 101);
            Console.Write("Guess the number from 1 to 100: ");

            while (triesCount-- > 0)
            {
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == value && triesCount > 0)
                {
                    Console.WriteLine("You guessed the right number!");
                    break;
                }
                else if (userInput > value)
                {
                    Console.WriteLine("Your guess is too high!");
                }
                else if (userInput < value)
                {
                    Console.WriteLine("Your guess is too low!");
                }
                else { Console.WriteLine("Invalid input!"); }

                if (triesCount == 0) { Console.WriteLine($"You've run out of tries! The number was {value}"); break; }
            }


            Console.ReadKey();




        }
    }
}
