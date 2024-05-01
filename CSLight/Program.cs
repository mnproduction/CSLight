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

            NPC[] characters = { new NPC(), new Farmer(), new Knight(), new Child() };

            foreach (var character in characters)
            {
                character.ShowInfo();
                Console.WriteLine("--------------------");
            }
            Console.ReadKey();
        }
    }

    class NPC
    {
        public virtual void ShowInfo()
        { Console.WriteLine("Just NPC"); }
    }

    class Farmer : NPC
    {
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("And I am a farmer");
        }
    }

    class Knight : NPC
    {
        public override void ShowInfo()
        {
            Console.WriteLine("I am a knight");
        }
    }

    class Child : NPC
    {

    }
}
