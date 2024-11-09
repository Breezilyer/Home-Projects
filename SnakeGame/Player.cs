using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor color;
        public char player;

        public Player(int initialX, int initialY)
        {
            this.X = initialX;
            this.Y = initialY;
            color = ConsoleColor.Green;
            player = 'S';
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(X, Y);
            Console.Write(player);
            Console.ResetColor();
        }
    }
}
