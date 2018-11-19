using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace IQPuzzlerPro
{

    public class GameManager : System.Windows.Forms.Control
    {
        int level;
        int currentHint;
        MapSprite mapSprite;
        MapBuilder mapBuilder;
        // TODO: puzzlepiecesprite here
        List<PuzzlePiece> pieces;
        List<Hint> hints;
        TextWriter scoreFileManager;
        Stopwatch stopwatch;
        int boardHeight;
        int boardWidth;
        int numberOfMoves;

        public GameManager()
        {
        }

        public int GetLevel(int level)
        {
            this.level = level;
            return this.level;
        }

        public void InitializePuzzle(int level, Graphics g)
        {
            this.level = level;
            mapBuilder = new MapBuilder(level);
            int[,] map = mapBuilder.getMapArray();
            mapSprite = new MapSprite(map, g);  // init MapSprite
            pieces = mapBuilder.getPieces();    // init pieces
            hints = mapBuilder.getHints();  // init hints
            stopwatch.Start();
            numberOfMoves = 0;
            boardHeight = 5;
            boardWidth = 11;
            currentHint = 1;
        }

        public bool UseHint()
        {
            if (currentHint > hints.Count)
            {
                return false;
            }

            currentHint += 1;
            int index = -1;
            int pieceID = hints.ElementAt(currentHint).getPieceID();
            

            for (int i = 0; i < pieces.Count; i++)
            {
                if ( pieceID == pieces.ElementAt(i).getID())
                {
                    index = i;
                    break;
                }
            }

            pieces.ElementAt(index).setLocX(hints.ElementAt(currentHint).getLocX());
            pieces.ElementAt(index).setLocY(hints.ElementAt(currentHint).getLocY());
            pieces.ElementAt(index).setPieceArray(hints.ElementAt(currentHint).getArr());
            pieces.ElementAt(index).setSelectable(false);
            pieces.ElementAt(index).setIsInInventory(false);
        }
    }
}
