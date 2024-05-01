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
            bool isOpen = true;
            
            Table[] tables = {new Table(1, 4), new Table(2, 8), new Table(3, 10)};

            while (isOpen)
            {
                foreach (Table table in tables)
                {
                    table.ShowPlaces();
                }
                Console.WriteLine("\n1. Reserve places\n2. Cancel reservation\n3. Exit");
                int choice = int.TryParse(Console.ReadLine(), out int choiceParse) ? choiceParse : 0;


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Which table do you want to take a place at?");
                        int tableReservation = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("How many places do you want to take?");
                        int numPlacesReserve = Convert.ToInt32(Console.ReadLine());
                        tables[tableReservation].TakePlace(tableReservation, numPlacesReserve);
                        continue;
                    case 2:
                        Console.WriteLine("Which table do you want to cancel a reservation at?");
                        int tableCancel = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("How many places do you want to cancel?");
                        int numPlacesCancel = Convert.ToInt32(Console.ReadLine());
                        tables[tableCancel].TakePlace(tableCancel, numPlacesCancel);
                        continue;
                    case 3:
                        isOpen = false;
                        continue;
                    default:
                        continue;

                Console.ReadKey();
                Console.Clear();
                }


            }





            Console.ReadKey();


        }

        


    }

    class Table
    {
        public int Id;
        public int MaxPlaces;
        public int FreePlaces;

        public Table(int id, int maxPlaces)
        {
            Id = id;
            MaxPlaces = maxPlaces;
            FreePlaces = maxPlaces;
        }

        public void ShowPlaces()
        {
            Console.WriteLine($"Table {Id} has {FreePlaces} of {MaxPlaces} places");
        }

        public void TakePlace(int tableId, int numPlaces)
        {
            if (numPlaces <= this.FreePlaces)
            {
                this.FreePlaces -= numPlaces;
                Console.WriteLine($"You have taken {numPlaces} place/s at table #{tableId}\nIt now has {this.FreePlaces} of {this.MaxPlaces} places");
            }
            else if (numPlaces > this.FreePlaces) 
            { 
                Console.WriteLine($"You can't take {numPlaces} place/s at table #{tableId}, as there are only {this.FreePlaces} places left"); 
            }
            else 
            { 
                Console.WriteLine($"Table {tableId} is full"); 
            }
        }
    }


}
