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

            Random random = new Random();

            int playerHealth = 1000;

            int enemyHealth = 500;


            while (playerHealth > 0 && enemyHealth > 0)
            {
                int playerDamage = random.Next(10, 20);
                int enemyDamage = random.Next(5, 50);
                playerHealth -= enemyDamage;
                enemyHealth -= playerDamage;

                Console.WriteLine($"Player hits {playerDamage} damage to enemy.");
                Console.WriteLine($"Enemy Health: {enemyHealth}");

                Console.WriteLine($"Enemy hits {enemyDamage} damage to player.");
                Console.WriteLine($"Player Health: {playerHealth}");
                

            }
            if (playerHealth <= 0 && enemyHealth <= 0)
            {
                Console.WriteLine("Draw");
            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine("Player Wins");
            }
            else if (playerHealth <= 0)
            {
                Console.WriteLine("Enemy Wins");
            }      

          




            Console.ReadKey();




        }
    }
}
