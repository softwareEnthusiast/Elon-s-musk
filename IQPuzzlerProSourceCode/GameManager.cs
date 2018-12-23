using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace IQPuzzleProVer2
{

        public class GameManager : System.Windows.Forms.Control
        {
            int level;
            public int currentHint;
            int boardHeight;
            int boardWidth;
            int numberOfMoves;
            Stopwatch stopwatch;
            MapBuilder mapBuilder;
            MapSprite mapSprite;

            // TODO: store scores in a local file
            // TODO: puzzlepiecesprite here
            List<PuzzlePiece> pieces;
            public List<Hint> hints;
            public GameManager()
            {
                stopwatch = new Stopwatch();
            }
            public int getLevel(int level)
            {
                this.level = level;
                return this.level;
            }
            public void initializePuzzle(int level, Graphics g)
            {
                this.level = level;
                mapBuilder = new MapBuilder(level);
                int[,] map = mapBuilder.getMapArray();
                mapSprite = new MapSprite(level, g);  // init MapSprite
                pieces = mapBuilder.getInventoryPuzzlePieces();    // init pieces
                hints = mapBuilder.getHint();  // init hints
                stopwatch.Start();
                numberOfMoves = 0;
                boardHeight = 5;
                boardWidth = 11;
                currentHint = 1;
            }

       public List<PuzzlePiece> getInventoryPuzzlePieces()
        {
           return mapBuilder.getInventoryPuzzlePieces();
            
        }

        public int numberOfPuzzlePiece()
        {
            return mapBuilder.numberOfPuzzlePiece();
        }



        }
    }

