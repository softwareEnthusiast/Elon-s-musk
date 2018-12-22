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
            int currentHint;
            int boardHeight;
            int boardWidth;
            int numberOfMoves;
            Stopwatch stopwatch;
            MapBuilder mapBuilder;
            MapSprite mapSprite;

            // TODO: store scores in a local file
            // TODO: puzzlepiecesprite here
            List<PuzzlePiece> pieces;
            List<Hint> hints;
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
        public bool useHint()
            {
                if (currentHint > hints.Count)
                {
                    return false;
                }
                currentHint += 1;
                int pieceID = hints.ElementAt(currentHint).getPieceID();
                int index = findIndexOfPiece(pieceID);
                resetAllPieces();
                pieces.ElementAt(index).setLocX(hints.ElementAt(currentHint).getLocX());
                pieces.ElementAt(index).setLocY(hints.ElementAt(currentHint).getLocY());
                pieces.ElementAt(index).setPieceArray(hints.ElementAt(currentHint).getArr());
                pieces.ElementAt(index).setSelectable(false);
                pieces.ElementAt(index).setIsInInventory(false);
                return true;
                // TODO: update pieceSprite here???
            }
            // returns true if the game is complete
            public bool movePiece(int pieceID, int newLocX, int newLocY)
            {
                int index = findIndexOfPiece(pieceID);
                int oldLocX = pieces.ElementAt(index).getLocX();
                int oldLocY = pieces.ElementAt(index).getLocY();
                pieces.ElementAt(index).setLocX(newLocX);
                pieces.ElementAt(index).setLocY(newLocY);
                if (collisionFound())
                {
                    pieces.ElementAt(index).setLocX(oldLocX);
                    pieces.ElementAt(index).setLocY(oldLocY);
                return false;
                }
                else
                {
                    // TODO: update pieceSprite here???
                    numberOfMoves += 1;
                    return isPuzzleComplete();
                }
            }
            public bool[,] rotatePieceRight(int pieceID)
            {
                int index = findIndexOfPiece(pieceID);
                pieces.ElementAt(index).rotateRight();
                if (collisionFound())
                {
                    pieces.ElementAt(index).rotateLeft();
                }
                else
                {
                    // TODO: update sprite here???
                }
                return pieces.ElementAt(index).getPieceArray();
            }
            public bool[,] rotatePieceLeft(int pieceID)
            {
                int index = findIndexOfPiece(pieceID);
                pieces.ElementAt(index).rotateLeft();
                if (collisionFound())
                {
                    pieces.ElementAt(index).rotateRight();
                }
                else
                {
                    // TODO: update sprite here???
                }
                return pieces.ElementAt(index).getPieceArray();
            }
            public bool[,] flipPiece(int pieceID)
            {
                int index = findIndexOfPiece(pieceID);
                pieces.ElementAt(index).flip();
                if (collisionFound())
                {
                    pieces.ElementAt(index).flip();
                }
                else
                {
                    // TODO: update sprite here???
                }
                return pieces.ElementAt(index).getPieceArray();
            }

           /* public bool[,] flipPieceVertical(int pieceID)
            {
                int index = findIndexOfPiece(pieceID);
                pieces.ElementAt(index).flipVertical();
                if (collisionFound())
                {
                    pieces.ElementAt(index).flipVertical();
                }
                else
                {
                    // TODO: update sprite here???
                }
                return pieces.ElementAt(index).getPieceArray();
            }*/
            // resets all selectable pieces to inventory
            public void resetAllPieces()
            {
                for (int i = 0; i < pieces.Count; i++)
                {
                    if (pieces.ElementAt(i).isSelectable())
                    {
                        pieces.ElementAt(i).setIsInInventory(true);
                        pieces.ElementAt(i).setLocX(-1);
                        pieces.ElementAt(i).setLocY(-1);
                    }
                }
            }
           /* public List<Score> getScores()
            {
                // TODO: need local storage first
            }*/
            // checks all puzzle pieces, if any of them is in inventory then returns false
            private bool isPuzzleComplete()
            {
                for (int i = 0; i < pieces.Count; i++)
                {
                    if (pieces.ElementAt(i).isInInventory())
                    {
                        return false;
                    }
                }
                return true;
            }
            // returns the index of given pieceID in the piece list of GameManager. 
            // returns -1 if the ID is invalid
            private int findIndexOfPiece(int pieceID)
            {
                int index = -1;
                for (int i = 0; i < pieces.Count; i++)
                {
                    if (pieceID == pieces.ElementAt(i).getID())
                    {
                        index = i;
                        break;
                    }
                }
                return index;
            }
            public bool collisionFound()
            {
                // create a new boolean array of false values which has same size with the puzzle board
                bool[,] tempPiecesArray = new bool[boardHeight, boardWidth];
                for (int i = 0; i < boardHeight; i++)
                {
                    for (int j = 0; j < boardWidth; j++)
                    {
                        tempPiecesArray[i, j] = false;
                    }
                }
                // flip values in this array where pieces fit to
                // if the flipped value is false then we have found a collision
                for (int p = 0; p < pieces.Count; p++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (pieces.ElementAt(p).isInInventory())
                            {
                                p += 1;
                                if (p == pieces.Count)
                                {
                                    return false;
                                }
                            }
                            // we are sure the piece is not in inventory now
                            bool[,] tempArr = pieces.ElementAt(p).getPieceArray();
                            int currentY = pieces.ElementAt(p).getLocY() - 1 + i;
                            int currentX = pieces.ElementAt(p).getLocX() - 1 + j;
                            if (tempArr[i, j])
                            {
                                tempPiecesArray[currentY, currentX] = !tempPiecesArray[currentY, currentX];
                                if (!tempPiecesArray[currentY, currentX])
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
                return false;
            }
        }
    }

