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

            Vehicle[] vehicles =
            {
                new Car(),
                new Train()
            };

            foreach (var veh in vehicles)
            {
                veh.Move();
            }

            Console.ReadKey();
        
        
        }
    }

    abstract class Vehicle
    {
        protected float Speed;

        public abstract void Move();

        public float GetSpeed()
        { return Speed; }

    }

    class Car : Vehicle
    {
        public override void Move() { Console.WriteLine("Car is moving at highway"); }
    }

    class Train : Vehicle
    {
        public override void Move() { Console.WriteLine("Train is moving at railway"); } 
    }
}
