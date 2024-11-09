using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Board
    {
        private char[,] Grid;
        private int rows;
        private int cols;

        public Board(char[,] grid)
        {
            this.Grid = grid;
            this.rows = grid.GetLength(0);
            this.cols = grid.GetLength(1);
        }

        public void Draw()
        {
            for (int x = 0; x < this.rows; x++)
                for (int y = 0; y < this.cols; y++)
                {
                    char element = Grid[x,y];
                    if (element == '#')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (element == 'S')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }



                    Console.SetCursorPosition(y, x);
                    Console.Write(Grid[x, y]);
                }
        }
    }
}
