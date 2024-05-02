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
            Console.WriteLine("Hello World!");
            MyClass instance = new MyClass();
            Console.WriteLine(MyClass.StaticField);



            Console.ReadKey();
        }
    }

    class MyClass
    {
        public static float StaticField;

        static MyClass()
        {
            StaticField = 100;
            Console.WriteLine("Static Constructor");
        }

        public MyClass()
        {
            Console.WriteLine("Simple Constructor");
        }

    }
    
}
