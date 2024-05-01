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
            Behavior[] behaviors =
            {
                new Walker(),
                new Jumper()
            };
            
            while (true) 
            {
                foreach (Behavior behavior in behaviors)
                {
                    behavior.Update(); 
                    System.Threading.Thread.Sleep(1000); // 1 second
                }
            }
        
            Console.ReadKey();
        
        
        }
    }

    class Behavior
    {
        public virtual void Update()
        { 
        
        }
    }
    class Walker : Behavior
    {
        public override void Update() { Console.WriteLine("Walking"); }
    }

    class Jumper : Behavior 
    { 
        public override void Update() { Console.WriteLine("Jumping"); }
    }



}
