using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQPuzzleProVer2
{
    public class Hint
    {

        int hintNo; // hints are not activated randomly they have a specified sequence
        int pieceToPlaceID; // 1-12
        int boardLocX;  // correct location of the piece is stored here
        int boardLocY;  // correct location of the piece is stored here
        bool[,] correctPieceArray;  // correct orientation of the piece is stored here
        public int oldX;
        public int oldY;


        public Hint(int pieceID, int hintNo, bool[,] array, int locX, int locY)
        {
            pieceToPlaceID = pieceID;
            this.hintNo = hintNo;
            boardLocX = locX;
            boardLocY = locY;
            //location of the pieces in the inventory
            oldX = 0;
            oldY = 0;
            correctPieceArray = array;
        }

        // There are no set methods because hints are constructed in the solo level generating
        // static method and there is no need to change after being constructed

       public int getPieceID()
        {
            return pieceToPlaceID;
        }
        
        public int getHintNo()
        {
            return hintNo;
        }

        public int getLocX()
        {
            return boardLocX;
        }

        public int getLocY()
        {
            return boardLocY;
        }

        public bool[,] getArr()
        {
            return correctPieceArray;
        }


    }
}
