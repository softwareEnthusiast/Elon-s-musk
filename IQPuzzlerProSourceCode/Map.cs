using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQPuzzleProVer2
{
    public class Map
    {

        bool isCustom;
        bool isActive;      // activated when puzzle is started
        bool completeMap;    // is true when mapArray is filled
                             // UserDTO creator;    // TODO: required for online
        int boardHeight;
        int boardWidth;
        int currentHint;
        int numberOfMoves;
        //Stopwatch stopwatch;



        public int[,] mapArray;
        // List<ScoreDTO> scores;      // This variable holds 
        List<PuzzlePiece> pieces;   // Both moveable and immovable pieces related to the puzzle rests here
        List<Hint> hints;           // Some of the right places of pieces are stored here


        public Map(List<Hint> hints, List<PuzzlePiece> pieces)
        {
            isCustom = false;
            isActive = false;
            completeMap = false;
            boardHeight = 5;
            boardWidth = 11;
            currentHint = 1;
            numberOfMoves = 0;
            this.hints = hints;
            this.pieces = pieces;

            mapArray = new int[boardHeight, boardWidth];
            for (int i = 0; i < boardHeight; i++)
            {
                for (int j = 0; j < boardWidth; j++)
                {
                    mapArray[i, j] = -1;    // -1 means empty
                }
            }
            // mapArray maps the placed pieces' ID numbers on cells they are placed on
        }

        public Map(List<PuzzlePiece> pieces)
        {
            isCustom = true;
            isActive = false;
            completeMap = false;
            boardHeight = 5;
            boardWidth = 11;
            this.pieces = pieces;


            mapArray = new int[boardHeight, boardWidth];
            for (int i = 0; i < boardHeight; i++)
            {
                for (int j = 0; j < boardWidth; j++)
                {
                    mapArray[i, j] = -1;    // -1 means empty
                }
            }
            // mapArray maps the placed pieces' ID numbers on cells they are placed on
        }

       

        public bool isComplete()
        {
            for (int i = 0; i < boardHeight; i++)
            {
                for (int j = 0; j < boardWidth; j++)
                {
                    if (mapArray[i, j] == -1)
                    {
                        return false;
                    }
                }
            }
            completeMap = true;
            return completeMap;
        }

        public Map getMap()
        {

            return this;

        }


    }
}
