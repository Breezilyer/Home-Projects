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
                    Console.SetCursorPosition(y, x);
                    Console.Write(Grid[x, y]);
                }
        }
        public int getElement(int x, int y)
        {
            return Grid[x,y];
        }
        public bool isPositionWalkable(int x, int y)
        {
            if(x < 0 || y < 0 || x >= cols || y >= rows) return false;
            return Grid[y,x] == ' ' || Grid[y,x] == 'A';
        }
    }
}
