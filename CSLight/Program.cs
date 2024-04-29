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
            // Increment and Decrement

            int a = 0;

            // postfix
            Console.WriteLine(a++);
            // prefix
            Console.WriteLine(a);
            Console.WriteLine(++a);

            double health;
            int damage;
            int armor;


            // reading data from the user
            Console.Write("Enter your health: ");
            health = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your armor: ");
            armor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter damage: ");
            damage = Convert.ToInt32(Console.ReadLine());

            // calculating the damage received
            double recievedDamage = damage * (1 - armor * 0.01);


            // updating the player's health
            health -= recievedDamage;

            Console.WriteLine($"Your recieved {damage} damage and your health is {health}");

            int money;
            int food;
            int foodUnitPrice = 10;
            

            Console.WriteLine($"Grettings wonderer! Welcome to our backery store! Today we have food for {foodUnitPrice} gold coins!");
            Console.Write("How much gold coins do you have?: ");

            money = Convert.ToInt32(Console.ReadLine());

            Console.Write("How much food units do you want?: ");

            food = Convert.ToInt32(Console.ReadLine());

            bool isEnoughMoney = money >= foodUnitPrice * food;

            food *= Convert.ToInt32(isEnoughMoney);

            money -= food * foodUnitPrice;

            Console.WriteLine($"You bought {food} food units for {food * foodUnitPrice} gold coins! You have now {money} gold coins left!");


            Console.ReadKey();




        }
    }
}
