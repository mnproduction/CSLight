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
            // Collections

            // List

            

            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(22);
            numbers.Add(13);
            numbers.Add(8);
            numbers.Add(10);

            numbers.AddRange(new int[] { 11, 12, 14, 15, 22, 15, 122, 453 });

            numbers.Insert(2, 2300);

            numbers.Remove(10);
            numbers.RemoveAt(6);
            numbers.Insert(1, 100);

            //numbers.RemoveAll(x => x > 12);
            numbers.RemoveRange(3, 2);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine($"Count: {numbers.Count}. Value \"2300\" is {numbers.IndexOf(2300)}\n\n\n");

            numbers.Clear();

            // Queue - first in first out

            Queue<string> patiens = new Queue<string>();

            patiens.Enqueue("Amber");
            patiens.Enqueue("Bob");
            patiens.Enqueue("Chloe");
            patiens.Enqueue("David");
            patiens.Enqueue("Eve");
            patiens.Enqueue("Frank");
            patiens.Enqueue("Gary");

            Console.WriteLine($"Now its turn of {patiens.Dequeue()}");

            foreach (var patient in patiens)
            {
                Console.WriteLine(patient);
            
            }
            Console.WriteLine($"Next is {patiens.Peek()}\n\n\n");

            // Stack - last in first out

            Stack<int> nums = new Stack<int>();

            nums.Push(1);
            nums.Push(2);
            nums.Push(3);
            nums.Push(4);
            nums.Push(5);


            //nums.Pop();

            while (nums.Count > 0)
            {
                Console.WriteLine($"First out is {nums.Pop()}");
            }

            Console.WriteLine("\n\n");


            // Dictionary

            Dictionary<string, string> countriesCapitals = new Dictionary<string, string>();

            countriesCapitals.Add("Poland", "Warsaw");
            countriesCapitals.Add("Germany", "Berlin");
            countriesCapitals.Add("France", "Paris");
            countriesCapitals.Add("Spain", "Madrid");
            countriesCapitals.Add("Italy", "Rome");

            countriesCapitals.Remove("France");

            if (countriesCapitals.ContainsKey("Poland"))
            
                Console.WriteLine(countriesCapitals["Poland"]);


            foreach (var item in countriesCapitals)
            {
                Console.WriteLine($"Country: {item.Key}, Capital: {item.Value}"); 

                
            }
            
            Console.ReadKey();


        }

        


    }
}
