using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoard ch = new ChessBoard(8); // Creating ChessBoard object
            ch.WriteBoard(); // Writing out chess board named "ch".

            ChessBoard.WriteBoard(5); // Second method for writing out Chess Board.
        }
    }
}
