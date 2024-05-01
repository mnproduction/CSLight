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
            Performer worker1 = new Performer("John");
            Performer worker2 = new Performer("Jane");

            Task[] tasks = { new Task(worker1, "Dig a hole"), new Task(worker2, "Throw ground away") };

            Board schedule = new Board(tasks); 

            schedule.ShowTasks();


            Console.ReadKey();
        }
    }

    class Performer
    {
        public string Name;
        
        public Performer(string name) { Name = name; }
    }

    class Board
    {
        public Task[] Tasks;

        public Board(Task[] tasks) 
        { 
            Tasks = tasks; 
        }

        public void ShowTasks()
        {
            foreach (var task in Tasks)
            {
                task.ShowInfo();
            }
        }
    }

    class Task
    {
        public Performer Worker;
        public string Description;

        public Task(Performer worker, string description)
        {
            Worker = worker;
            Description = description;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Description: {Description}\nResponsable:{Worker.Name}");
        }
    }


}
