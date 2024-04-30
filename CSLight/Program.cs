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


            //Console.WriteLine($"Hi!");
            //Console.WriteLine("How are you?");
            //Console.WriteLine("I'm fine, thank you!");
            //WriteError(message: "Now I'm going to write an error!", ConsoleColor.Green);
            //WriteError();
            //Console.WriteLine("Goodbye!");
            //WriteError(message:Convert.ToString(Sum(400, 3)) + " is the sum of two numbers.", color: ConsoleColor.Yellow);


            // DrawBar
            int health = 20, maxHealth = 20;
            int mana = 20, maxMana = 20;

            while (true)
            {
                DrawBar(health, maxHealth, ConsoleColor.Red, 0, 0, '|');
                DrawBar(mana, maxMana, ConsoleColor.Blue, 25, 0, '|');
                Console.SetCursorPosition(0, 1);
                Console.WriteLine($"Health: {health}/{maxHealth}");
                Console.SetCursorPosition(25, 1);
                Console.WriteLine($"Mana: {mana}/{maxMana}");

                Console.SetCursorPosition(0, 5);
                Console.Write("Change health by: ");
                health += Convert.ToInt32(Console.ReadLine());
                //Console.SetCursorPosition(0, 6);
                Console.Write("Change mana by: ");
                mana += Convert.ToInt32(Console.ReadLine());
                
                
                Console.ReadKey();
                Console.Clear();
            }



        }

        static void WriteError(string message = "Error!", ConsoleColor color = ConsoleColor.Red)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = defaultColor;


        }

        static int Sum(int a, int b)
        { return a + b; }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int posX, int posY, char symbol = '_')
        {
        
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }
        
            Console.SetCursorPosition(posX, posY);
            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += symbol;
            }

            Console.Write(bar + "]");

        }


    }
}
