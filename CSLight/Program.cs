﻿using System;
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
            User.Identifications = 10;
            User user1 = new User();
            User user2 = new User();
            user1.ShowInfo();
            user2.ShowInfo();




            Console.ReadKey();
        }
    }

    class User
    {
        public static int Identifications;
        public int Identification;

        public User() 
        { 
            Identification = ++Identifications;
        }


        public void ShowInfo()
        { 
            Console.WriteLine("Identification: " + Identification);
        }
    }
    
}
