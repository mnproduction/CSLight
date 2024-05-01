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
            Renderer renderer = new Renderer();
            Player player = new Player(55, 10);
            renderer.Draw(player.X, player.Y);

            while (true)
            {
                
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        player.Y--;
                        break;
                    case ConsoleKey.DownArrow:
                        player.Y++;
                        break;
                    case ConsoleKey.LeftArrow:
                        player.X--;
                        break;
                    case ConsoleKey.RightArrow:
                        player.X++;
                        break;
                }
                renderer.Draw(player.X, player.Y);
            }


            Console.ReadKey();
        }
    }

    class Player
    {
        private int _x;
        private int _y;

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }

        public Player(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }

    class Renderer
    {
        public void Draw(int x, int y, char character = '@')
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write(character);

        }

    } 
}
