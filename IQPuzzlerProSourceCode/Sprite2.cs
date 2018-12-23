﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace IQPuzzleProVer2
{


    public class Sprite2 : System.Windows.Forms.Control
    {
        public int locX;
        public int locY;
        public int[] locXa;
        public int[] locYa;
        public GraphicsPath gp;
    

        public PuzzlePiece piece;
        int width;
        public int ID;
        bool dragging;
        public int transparency;
        public int layer;
        public bool[,] pieceArray;
        bool selected;
        Rectangle circle;
        bool init;
        public bool isMovable;



        public Sprite2(int locx, int locy, int width, PuzzlePiece aPiece)
        {
            locX = locx;
            locY = locy;
            locXa = new int[5];
            locYa = new int[5];
            piece = aPiece;
            selected = false;
            isMovable = true;
            init = true;
            this.ID = aPiece.getPieceType();
            this.width = width;
            pieceArray = piece.getPieceArray();
            circle = new Rectangle(locX, locY, width, width);
            dragging = false;

        }



        Point cursor = Point.Empty;


        public void drawing( )
        {
            gp = new GraphicsPath();

            circle.X = locX;
            circle.Y = locY;

            int s = 0;
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (pieceArray[i, j])
                    {

                        gp.AddEllipse(circle);
                        locXa[s] = circle.X;
                        locYa[s] = circle.Y;

                        s++;
                    }
                    circle.X += 60;
                    //Console.Write(pieceArray[i, j]);
                }
                circle.X -= 240;
                circle.Y += 60;
               // Console.WriteLine();
            }
          
          
        }

        public void draw(Graphics g)
        {
            this.drawing();
            Pen selection = new Pen(Color.Black);
            selection.Width = 8.0F;
            if (selected)
            {
                g.DrawPath(selection, gp);
            }
            else
            {
                g.DrawPath(piece.getColor(), gp);
            }

            g.FillPath(piece.getBrush(), gp);

        }
        public bool[,] rightRot()
        {
            piece.rotateRight();
            pieceArray = piece.getPieceArray();

            return pieceArray;
        }

        public bool[,] leftRot()
        {
            piece.rotateLeft();
            pieceArray = piece.getPieceArray();

            return pieceArray;
        }

        public bool[,] flip()
        {
            piece.flip();
            pieceArray = piece.getPieceArray();

            return pieceArray;
        }

        public bool isSelected(int x, int y)
        {
            /*int locx1 = locX;
            int locy1 = locY;
            if (((locx1 <= x) && (x <= (locx1 + (4 * width)))) && ((locy1 <= y) && (y <= locy1 + (4 * width))))
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (pieceArray[i, j])
                        {
                            if (Math.Sqrt((((locx1 + (circle.Width / 2)) - x) * ((locx1 + (circle.Width / 2)) - x)) + (((locy1 + (circle.Width / 2)) - y) * ((locy1 + (circle.Width / 2)) - y))) <= (circle.Width / 2))
                            {
                                selected = true;
                                return selected;
                            }
                        }
                        locx1 += 60;
                    }
                    locx1 -= 240;
                    locy1 += 60;
                }
            }*/
            if (gp.IsVisible(x, y))
            {
                selected = true;
                return selected;
            }
            else
            {
                selected = false;
                return selected;
            }

            //return selected;
        }

        public bool isSelected1()
        {
            return this.selected;
        }

        public void setPieceArray(bool[,] aPieceArray)
        {
            pieceArray = aPieceArray;
        }

        public void setPiece(PuzzlePiece piecee)
        {
            piece = piecee;
            pieceArray = piece.getPieceArray();
        }
        public void setLocX(int x)
        {
            locX = x;
        }

        public void setLocY(int y)
        {
            locY = y;
        }
        public int getLocX()
        {
            return locX;
        }

        public int getLocY()
        {
            return locY;
        }
        public void chooseSelected(bool s)
        {
            selected = s;
        }
     
    }
}


