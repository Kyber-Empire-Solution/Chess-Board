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
            ///*
            ChessBoard ch = new ChessBoard(8); // Creating ChessBoard object (in this example board will be 8x8)
            ch.WriteBoard(); // Writing out chess board named "ch".
            ChessBoard.WriteBoard(8); // Second method for writing out Chess Board.
            //*/

            ///*
            ChessBoard ch1 = new ChessBoard(8, 20); // Also you can specify the width and height of the board. 8 is width and 20 is height. 
            ch1.WriteBoard(true); // For writing out the board we created above you need to set argument here to "true".
            ChessBoard.WriteBoard(8, 3); // Or you can write out the same chess board above without creating new object.
            //*/
        }
    }
}
