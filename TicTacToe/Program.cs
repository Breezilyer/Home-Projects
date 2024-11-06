﻿using static System.Console;

namespace TicTacToe
{
    internal class Program
    {
        private static char[,] board;
        static int x;
        static int y;
        static bool playerXTurn = true;
        static void Main()
        {
            WriteLine("Welcome to TicTacToe!");
            WriteLine("Press enter to continue");
            ReadLine();
            Clear();

            // initialize the game
            InitBoard();

            runGameLoop();

            ReadLine();
        }
        static void InitBoard()
        {
            board = new char[,]
            {
                { '1', ' ', ' ', ' ' },
                { '2', ' ', ' ', ' ' },
                { '3', ' ', ' ', ' ' },
                { ' ', '1', '2', '3' }
            };
            Draw();
        }

        static void Draw()
        {
            for (int col = 0; col < board.GetLength(0); col++)
            {
                for (int row = 0; row < board.GetLength(1); row++)
                {
                    SetCursorPosition(col, row);
                    Write(board[row, col]);
                }
            }
        }

        static void playerTurnX()
        {
            Write("X: ");
            string X = ReadLine()!;
            x = Convert.ToInt32(X);
            Write("Y: ");
            string Y = ReadLine()!;
            y = Convert.ToInt32(Y);

            isPlaceable('X');
            Draw();
        }

        static void playerTurnY()
        {
            Write("X: ");
            string X = ReadLine()!;
            x = Convert.ToInt32(X);
            Write("Y: ");
            string Y = ReadLine()!;
            y = Convert.ToInt32(Y);

            isPlaceable('O');
            Draw();
        }

        static void isPlaceable(char player)
        {
            if (board[x - 1, y] == ' ')
            {
                playerXTurn = !playerXTurn;
                board[x - 1, y] = player;
                Clear();
            }
            else
            {
                Clear();
                WriteLine("Already placed!");
                ReadLine();
                Clear();
            }
        }

        static void runGameLoop()
        {
            while (true)
            {
                if (playerXTurn == true)
                {
                    WriteLine("\nPlayer X's turn: ");
                    playerTurnX();
                }

                if (playerXTurn == false)
                {
                    WriteLine("\nPlayer O's turn: ");
                    playerTurnY();
                }
            }
        }
    }
}