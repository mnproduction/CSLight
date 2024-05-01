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
            
        
            Console.ReadKey();
        
        
        }
    }

    interface Movable
    {
        void Move();
        void ShowMovementSpeed();
    }

    interface Burnable
    {
        void Burn();
    }

    class Vehicle
    {


    }



    class Car : Vehicle, Movable, Burnable
    {
        public void Move()
        {

        }

        public void ShowMovementSpeed() { }

        public void Burn() { }
    }

    class Human: Movable
    {
        public void Move()
        {

        }
        public void ShowMovementSpeed() { }
    }

}
