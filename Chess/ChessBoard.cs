using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class ChessBoard
    {
        public static int Size;
        public static int Size_2;

        public ChessBoard(int size) // Constructor
        {
            Size = size;
        }

        public ChessBoard(int size, int size_2) // Second constructor 
        {
            Size = size;
            Size_2 = size_2;
        }

        public void WriteBoard() // First OverLoad
        {
            string board1 = ""; // empty string for first variant of line
            string board2 = ""; // for second variant

            for (int f = 1; f < Size + 1; f++) // Loop for creating first variant of line for board(example: #.#.#.#)
            {
                if (f % 2 != 0)
                {
                    board1 += "#";
                }
                else
                {
                    board1 += ".";
                }
            }

            for (int d = 1; d < Size + 1; d++) // Loop for creating second variant of line for board(example: .#.#.#.)
            {
                if (d % 2 != 0)
                {
                    board2 += ".";
                }
                else
                {
                    board2 += "#";
                }
            }

            for (int i = 0; i < Size; i++) // Loop for writing out chess board.
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(board1); 
                }
                else
                {
                    Console.WriteLine(board2);
                }
            }
        }

        public static void WriteBoard(int size_of_board) // Second overload
        {
            string board1 = "";
            string board2 = "";

            for (int f = 1; f < size_of_board + 1; f++)
            {
                if (f % 2 != 0)
                {
                    board1 += "#";
                }
                else
                {
                    board1 += ".";
                }
            }

            for (int d = 1; d < size_of_board + 1; d++)
            {
                if (d % 2 != 0)
                {
                    board2 += ".";
                }
                else
                {
                    board2 += "#";
                }
            }

            for (int i = 0; i < size_of_board; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(board1);
                }
                else
                {
                    Console.WriteLine(board2);
                }
            }
        }

        public void WriteBoard(bool СonstUse) // Third overload
        {
            if (СonstUse == true)
            {
                string board1 = "";
                string board2 = "";

                for (int f = 1; f < Size + 1; f++)
                {
                    if (f % 2 != 0)
                    {
                        board1 += "#";
                    }
                    else
                    {
                        board1 += ".";
                    }
                }

                for (int d = 1; d < Size + 1; d++)
                {
                    if (d % 2 != 0)
                    {
                        board2 += ".";
                    }
                    else
                    {
                        board2 += "#";
                    }
                }

                for (int i = 0; i < Size_2; i++)
                {

                    if (i % 2 == 0)
                    {
                        Console.WriteLine(board1);
                    }
                    else
                    {
                        Console.WriteLine(board2);
                    }
                }
            }
            else
            {
                Console.WriteLine("You have disabled the Constructor Usage, use other methods or enable it!");
            }
        }



        public static void WriteBoard(int size_of_board, int size_2_of_board) // Fourth overload
        {
            string board1 = "";
            string board2 = "";

            for (int f = 1; f < size_of_board + 1; f++)
            {
                if (f % 2 != 0)
                {
                    board1 += "#";
                }
                else
                {
                    board1 += ".";
                }
            }

            for (int d = 1; d < size_of_board + 1; d++)
            {
                if (d % 2 != 0)
                {
                    board2 += ".";
                }
                else
                {
                    board2 += "#";
                }
            }

            for (int i = 0; i < size_2_of_board; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(board1);
                }
                else
                {
                    Console.WriteLine(board2);
                }
            }
        }


    }
}
