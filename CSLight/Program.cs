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
            Fighter[] fighters =
                {
                    new Fighter("Gladiator", 500, 20, 20),
                    new Fighter("Barbarian", 520, 25, 15),
                    new Fighter("Archer", 300, 50, 5),
                    new Fighter("Wizard", 250, 80, 0)
                };

            int fighterIndex;

            foreach (Fighter f in fighters)
            {
                f.ShowInfo();
            }

            Console.WriteLine("\n||" + new string('-', 35) + "||");
            Console.WriteLine("\tChoose fighter 1: ");
            fighterIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            Fighter firstFighter = fighters[fighterIndex];

            Console.WriteLine("\tChoose fighter 2: ");
            fighterIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            Fighter secondFighter = fighters[fighterIndex];
            Console.WriteLine("\n||" + new string('-', 35) + "||");

            while (firstFighter.Health > 0 && secondFighter.Health > 0)
            {
                firstFighter.TakeDamage(secondFighter.Damage);
                secondFighter.TakeDamage(firstFighter.Damage);
                firstFighter.ShowCurHealth();
                secondFighter.ShowCurHealth();
            }



            Console.ReadKey();
        }
    }

    class Fighter
    {
        private string _name;
        private int _health;
        private int _damage;
        private int _armor;
    
        public Fighter(string name, int health, int damage, int armor)
        {
            _name = name;
            _health = health;
            _damage = damage;
            _armor = armor;
        }

        public int Health { get { return _health; } }

        public int Damage { get { return _damage; } }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {_name}, Health: {_health}, Damage: {_damage}, Armor: {_armor}");
        }

        public void ShowCurHealth()
        { Console.WriteLine($"{_name} has {_health} health left."); }

        public void TakeDamage(int damage)
        { _health -= (damage - _armor); }
    }


}
