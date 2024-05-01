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
            Knight knight1 = new Knight("Sedric", 100, 10, 10);
            Barbarian barbarian1 = new Barbarian("Durak", 100, 10, 10, 2);

            knight1.TakeDamage(50);
            barbarian1.TakeDamage(50);

            knight1.ShowStatus();
            barbarian1.ShowStatus();

            Console.ReadKey();
        }
    }

    class Warrior
    {
        protected string Name;
        protected int Health;
        protected int Armor;
        protected int Damage;

        public Warrior(string name, int health, int armor, int damage)
        {
            Name = name; 
            Health = health;
            Armor = armor;
            Damage = damage;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage - Armor;
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Name: {Name}, Health: {Health}, Armor: {Armor}, Damage: {Damage}");
        }

    }

    class Knight : Warrior
    {
        public Knight(string name, int health, int armor, int damage) : base(name, health, armor, damage) { }

        public void Pray()
        {
            Armor += 3;
            Health += 1;
        }

    }

    class Barbarian : Warrior
    {
        public Barbarian(string name, int health, int armor, int damage, int attackSpeed) : base(name, health, armor, damage * attackSpeed) { }

        public void Shout()
        {
            Armor -= 2;
            Damage += 1;
        }
    }


}
