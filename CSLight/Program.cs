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
            
            Car ferrary = new Car("F40", 30, 471, 317.0f);

            Car mazda = new Car();

            ferrary.ShowPassport();
            ferrary.BecomeOlder(1, 10);
            ferrary.ShowPassport();


            mazda.ShowPassport();
            Console.ReadKey();


        }

        


    }

    class Car
    {
        public string Name;
        public int Age;
        public int Hp;
        public float MaxSpeed;

        public Car(string name, int age, int hp, float maxSpeed) //constructorCar()
        {
            if (hp <= 0)
            {
                Hp = 1;
            }
            else
            {
                Hp = hp;
            }

            Name = name;
            Age = age;
            MaxSpeed = maxSpeed;
        }

        public Car() 
        {
            Name = "";
            Age = 1990;
            Hp = 500;
            MaxSpeed = 250.0f;
        }
        public void ShowPassport() //method
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nHP: {Hp}\nMaxSpeed: {MaxSpeed} km/h");
        }

        public void BecomeOlder(int years, int decreaseHp) //method
        {
            Age += years;
            Hp -= decreaseHp;
        }

    }


}
