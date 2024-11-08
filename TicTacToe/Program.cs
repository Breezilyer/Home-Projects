using static System.Console;

namespace TicTacToe
{
    internal class Program
    {
        private static char[,] board;
        static int x;
        static int y;
        static bool draw = false;
        static int moveCount = 0;

        static bool playerXTurn = true;
        static void Main()
        {
            Clear();
            WriteLine("Welcome to TicTacToe!");
            WriteLine("Press 'Enter' to continue");
            ReadLine();
            Clear();

            // initialize the game
            InitBoard();

            runGameLoop();
            Draw();
            WriteLine();
            if (draw == false && playerXTurn == true)
            {
                WriteLine("Game Over! X won!");
            } 
            else if (draw == false && playerXTurn == false)
            {
                WriteLine("Game Over! O won!");
            }
            else
            {
                WriteLine("Draw!");
            }

            ReadLine();
            moveCount = 0;
            Main();
        }
        static void InitBoard()
        {
            board = new char[,]
            {
                { 'Y', ' ', ' ', ' ', ' ' },
                { '1', ' ', ' ', ' ', ' ' },
                { '2', ' ', ' ', ' ', ' ' },
                { '3', ' ', ' ', ' ', ' ' },
                { ' ', '1', '2', '3', 'X' }
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
        static bool playerTurn(char player)
        {
            Write("X: ");
            string X = ReadLine()!;
            x = Convert.ToInt32(X);
            Write("Y: ");
            string Y = ReadLine()!;
            y = Convert.ToInt32(Y);

            return isPlaceable(player);
        }
        static bool isPlaceable(char player)
        {
            if (board[y, x] == ' ')
            {
                board[y, x] = player;
                Clear();
                return true;
            }
            else
            {
                Clear();
                WriteLine("Already placed here!");
                ReadLine();
                Clear();
                return false;
            }
        }
        static void runGameLoop()
        {
            while (true)
            {
                Draw();
                char player = playerXTurn ? 'X' : 'O';

                WriteLine($"\nPlayer {player}'s turn: ");
                bool moveSucces = playerTurn(player);

                if (moveSucces == false)
                {
                    continue;
                }

                moveCount++;

                if (isGameOver() == true)
                {
                    break;
                }

                if (moveCount == 9)
                {
                    draw = true;
                    break;
                }

                playerXTurn = !playerXTurn;
            }
        }
        // Make a method where the player can win
        static bool isGameOver()
        {
            for (int i = 1; i <= 3; i++)
            {
                if (board[i, 1] != ' ' && board[i,1] == board[i,2] && board[i,2] == board[i,3])
                {
                    return true;
                }
                if (board[1, i] != ' ' && board[1, i] == board[2,i] && board[2,i] == board[3,i])
                {
                    return true;
                }
            }

            if (board[1,1] != ' ' && board[1,1] == board[2,2] && board[2,2] == board[3,3])
            {
                return true;
            }
            if (board[3, 1] != ' ' && board[3, 1] == board[2, 2] && board[2, 2] == board[1, 3])
            {
                return true;
            }
            return false;
        }
    }
}
