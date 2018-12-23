using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace IQPuzzleProVer2
{
    public class PuzzlePiece 
    {
        int ID;     // All pieces in a puzzle has different ID
        int pieceType;  // one of the unique pieces (12 types in solo)
        bool inInventory;
        bool[,] pieceArray; // stores the orientation of the piece
        int locX;   // x loc of piece array's leftmost cell in map
        int locY;   // y loc of piece array's topmost cell in map
        public bool isMovable;  // if false it is immovable
        Pen currentColor;
        System.Drawing.SolidBrush currentBrush;

        public PuzzlePiece(int ID, int pieceType, bool isSelectable)
        {
            this.ID = ID;
            this.pieceType = pieceType;
            this.isMovable = isSelectable;
            inInventory = true;
            pieceArray = new bool[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    pieceArray[i, j] = false;
                }
            }

            // below are the initial states of pieces

            if (pieceType == 1)
            {
                pieceArray[0, 0] = true;
                pieceArray[0, 1] = true;
                pieceArray[1, 1] = true;
                currentColor = new Pen(Color.SkyBlue);
                currentBrush = new System.Drawing.SolidBrush(Color.SkyBlue);

            }
            else if (pieceType == 2)
            {
                pieceArray[0, 0] = true;
                pieceArray[0, 1] = true;
                pieceArray[1, 1] = true;
                pieceArray[1, 2] = true;
                currentColor = new Pen(Color.DarkRed);
                currentBrush = new System.Drawing.SolidBrush(Color.DarkRed);
            }
            else if (pieceType == 3)
            {
                pieceArray[0, 0] = true;
                pieceArray[1, 0] = true;
                pieceArray[0, 1] = true;
                pieceArray[0, 2] = true;
                currentColor = new Pen(Color.DarkSlateBlue);
                currentBrush = new System.Drawing.SolidBrush(Color.DarkSlateBlue);

            }
            else if (pieceType == 4)
            {
                pieceArray[0, 1] = true;
                pieceArray[1, 1] = true;
                pieceArray[1, 2] = true;
                pieceArray[1, 0] = true;
                currentColor = new Pen(Color.Green);
                currentBrush = new System.Drawing.SolidBrush(Color.Green);
            }
            else if (pieceType == 5)
            {
                pieceArray[1, 0] = true;
                pieceArray[1, 1] = true;
                pieceArray[1, 2] = true;
                pieceArray[1, 3] = true;
                pieceArray[0, 3] = true;
                currentColor = new Pen(Color.Red);
                currentBrush = new System.Drawing.SolidBrush(Color.Red);
            }
            else if (pieceType == 6)
            {
                pieceArray[0, 0] = true;
                pieceArray[1, 0] = true;
                pieceArray[1, 2] = true;
                pieceArray[0, 1] = true;
                pieceArray[0, 2] = true;
                currentColor = new Pen(Color.LightGreen);
                currentBrush = new System.Drawing.SolidBrush(Color.LightGreen);
            }
            else if (pieceType == 7)
            {
                pieceArray[0, 2] = true;
                pieceArray[1, 0] = true;
                pieceArray[1, 1] = true;
                pieceArray[1, 2] = true;
                pieceArray[1, 3] = true;
                currentColor = new Pen(Color.Yellow);
                currentBrush = new System.Drawing.SolidBrush(Color.Yellow);
            }
            else if (pieceType == 8)
            {
                pieceArray[0, 2] = true;
                pieceArray[1, 0] = true;
                pieceArray[1, 1] = true;
                pieceArray[1, 2] = true;
                pieceArray[2, 1] = true;
                currentColor = new Pen(Color.Orange);
                currentBrush = new System.Drawing.SolidBrush(Color.Orange);
            }
            else if (pieceType == 9)
            {
                pieceArray[2, 0] = true;
                pieceArray[2, 1] = true;
                pieceArray[2, 2] = true;
                pieceArray[1, 2] = true;
                pieceArray[0, 2] = true;
                currentColor = new Pen(Color.Blue);
                currentBrush = new System.Drawing.SolidBrush(Color.Blue);
            }
            else if (pieceType == 10)
            {
                pieceArray[0, 0] = true;
                pieceArray[0, 1] = true;
                pieceArray[1, 1] = true;
                pieceArray[1, 2] = true;
                pieceArray[2, 2] = true;
                currentColor = new Pen(Color.Violet);
                currentBrush = new System.Drawing.SolidBrush(Color.Violet);
            }
            else if (pieceType == 11)
            {
                pieceArray[0, 0] = true;
                pieceArray[0, 1] = true;
                pieceArray[1, 1] = true;
                pieceArray[1, 2] = true;
                pieceArray[1, 3] = true;
                currentColor = new Pen(Color.Pink);
                currentBrush = new System.Drawing.SolidBrush(Color.Pink);
            }
            else if (pieceType == 12)
            {
                pieceArray[0, 1] = true;
                pieceArray[0, 2] = true;
                pieceArray[1, 0] = true;
                pieceArray[1, 1] = true;
                pieceArray[1, 2] = true;
                currentColor = new Pen(Color.Turquoise);
                currentBrush = new System.Drawing.SolidBrush(Color.Turquoise);
            }
        }

        public void rotateRight()
        {
            bool[,] tempPieceArray = new bool[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    tempPieceArray[j, 3 - i] = pieceArray[i, j];
                }
            }

            pieceArray = tempPieceArray;
        }

        public void rotate180()
        {
            rotateRight();
            rotateRight();
        }

        public void rotateLeft()
        {
            bool[,] tempPieceArray = new bool[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    tempPieceArray[3 - j, i] = pieceArray[i, j];
                }
            }

            pieceArray = tempPieceArray;
        }

        public void flip()
        {
            bool[,] tempPieceArray = new bool[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    tempPieceArray[i, 3 - j] = pieceArray[i, j];
                }
            }

            pieceArray = tempPieceArray;
        }


        public bool isSelectable()
        {
            return isMovable;
        }

        public void setSelectable(bool s)
        {
            isMovable = s;
        }

        public bool isInInventory()
        {
            return inInventory;
        }

        public void setIsInInventory(bool s)
        {
            inInventory = s;
        }

        public int getLocX()
        {
            return locX;
        }

        public void setLocX(int x)
        {
            locX = x;
        }

        public int getLocY()
        {
            return locY;
        }

        public void setLocY(int y)
        {
            locY = y;
        }

        public bool[,] getPieceArray()
        {
            return pieceArray;
        }

        public void setPieceArray(bool[,] arr)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = pieceArray[i, j];
                }
            }
        }
        public int getPieceType()
        {
            return pieceType;
        }
        public Pen getColor()
        {
            return currentColor;
        }
        public System.Drawing.SolidBrush getBrush()
        {
            return currentBrush;
        }
        public int getID()
        {
            return ID;
        }
    }
}
