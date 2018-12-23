using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQPuzzleProVer2
{
    public class MapSprite : System.Windows.Forms.Control
    {
       
        Graphics gObject;
        MapBuilder lMap;
        public int[,] arr;
        public int locX;
        public int locY;
        GraphicsPath gp;
        public int[] locXa;
        public int[] locYa;
        List<PuzzlePiece> pieces;
        Rectangle circle;
        Pen red = new Pen(Color.Red);
        Pen pink = new Pen(Color.Pink);
        Pen yellow = new Pen(Color.Yellow);
        Pen blue = new Pen(Color.Blue);
        Pen orange = new Pen(Color.Orange);
        Pen turquoise = new Pen(Color.Turquoise);
        Pen skyblue = new Pen(Color.SkyBlue);
        Pen green = new Pen(Color.Green);
        Pen lightgreen = new Pen(Color.LightGreen);
        Pen darkred = new Pen(Color.DarkRed);
        Pen darkblue = new Pen(Color.DarkSlateBlue);
        Pen violet = new Pen(Color.Violet);
        System.Drawing.SolidBrush fillred = new System.Drawing.SolidBrush(Color.Red);
        System.Drawing.SolidBrush fillpink = new System.Drawing.SolidBrush(Color.Pink);
        System.Drawing.SolidBrush fillyellow = new System.Drawing.SolidBrush(Color.Yellow);
        System.Drawing.SolidBrush fillblue = new System.Drawing.SolidBrush(Color.Blue);
        System.Drawing.SolidBrush fillorange = new System.Drawing.SolidBrush(Color.Orange);
        System.Drawing.SolidBrush fillturquoise = new System.Drawing.SolidBrush(Color.Turquoise);
        System.Drawing.SolidBrush fillskyblue = new System.Drawing.SolidBrush(Color.SkyBlue);
        System.Drawing.SolidBrush fillgreen = new System.Drawing.SolidBrush(Color.Green);
        System.Drawing.SolidBrush filllightgreen = new System.Drawing.SolidBrush(Color.LightGreen);
        System.Drawing.SolidBrush filldarkred = new System.Drawing.SolidBrush(Color.DarkRed);
        System.Drawing.SolidBrush filldarkblue = new System.Drawing.SolidBrush(Color.DarkSlateBlue);
        System.Drawing.SolidBrush fillviolet = new System.Drawing.SolidBrush(Color.Violet);

        public MapSprite(int level, Graphics g)
        {
            arr = new int[5, 11];
            gp = new GraphicsPath();
            gObject = g;
            lMap = new MapBuilder(level);
            circle = new Rectangle(locX, locY, 60, 60);
            pieces = new List<PuzzlePiece>();
            locXa = new int[5];
            locYa = new int[5];
            
            setUpCanvas();
            fillCanvas();
        }

  

        public void setMapArray(int[,] arr)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    this.arr[i, j] = arr[i, j];
                }
            }
        }
        public void fillCanvas()
        {
            circle.X = 0;
            circle.Y = 0;
          
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[j, i] = 0;
                }
            }
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[j, i] = lMap.getMapArray()[j, i];
                }
            }
            
            pieces = lMap.getMapPuzzlePieces();
            foreach (PuzzlePiece item in pieces)
            {
                Sprite2 sprite = new Sprite2(item.getLocX(),item.getLocY(),60,item);
                sprite.draw(gObject);
            }
          /*  foreach (PuzzlePiece item in pieces)
            {
                Console.WriteLine(item.getLocX());
                circle.X = item.getLocX();
                circle.Y = item.getLocY();
                bool[,] pieceArray = item.getPieceArray();
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
                    }
                    circle.X -= 240;
                    circle.Y += 60;
                }
                

                gObject.DrawPath(item.getColor(), gp);

                gObject.FillPath(item.getBrush(), gp);
            }*/


            /* int count11 = 0;
             int count9 = 0;
             PuzzlePiece piece = null;
             for (int i = 0; i < 11; i++)
             {
                 circle.Y = 0;
                 circle.X = (i) * 60;
                 for (int j = 0; j < 5; j++)
                 {

                     if (arr[j, i] == 11 && count11 == 0)
                     {
                         circle.Y = (j) * 60;
                         piece = new PuzzlePiece(11, 11, false);
                          Sprite2 sprite = new Sprite2(circle.X, circle.Y,60,piece);
                         sprite.drawing(gp);
                         count11++;

                         /*PuzzlePiece piece = new PuzzlePiece(11,11,false);
                         gObject.DrawPath(piece.getColor(),gp);
                         gObject.FillPath(piece.getBrush(), gp);*/
            // pieces.Add(piece);



            /* gObject.DrawEllipse(pink, circle);
              gObject.FillEllipse(fillpink, circle);


        }
        else if (arr[j, i] == 9 &&count9 == 0)
        {
            circle.Y = (j) * 60;
            piece = new PuzzlePiece(9, 9, false);
            Sprite2 sprite = new Sprite2(circle.X, circle.Y, 60, piece);
            sprite.drawing(gp);
            count9++;
            /*circle.Y = (j) * 60;
            PuzzlePiece piece = new PuzzlePiece(9, 9, false);
            Sprite2 sprite = new Sprite2(circle.X, circle.Y, 60, piece);
            sprite.draw(gObject);*/
            /* circle.Y = (j) * 60;
             gObject.DrawEllipse(blue, circle);
             gObject.FillEllipse(fillblue, circle);

        }
        else if (arr[j, i] == 7)
        {
            circle.Y = (j) * 60;
            gObject.DrawEllipse(yellow, circle);
            gObject.FillEllipse(fillyellow, circle);

        }
        else if (arr[j, i] == 8)
        {
            circle.Y = (j) * 60;
            gObject.DrawEllipse(orange, circle);
            gObject.FillEllipse(fillorange, circle);

        }
        else if (arr[j, i] == 4)
        {
            circle.Y = (j) * 60;
            gObject.DrawEllipse(green, circle);
            gObject.FillEllipse(fillgreen, circle);

        }
        else if (arr[j, i] == 1)
        {
            circle.Y = (j) * 60;
            gObject.DrawEllipse(skyblue, circle);
            gObject.FillEllipse(fillskyblue, circle);

        }
        else if (arr[j, i] == 10)
        {
            circle.Y = (j) * 60;
            gObject.DrawEllipse(violet, circle);
            gObject.FillEllipse(fillviolet, circle);

        }
        else if (arr[j, i] == 3)
        {
            circle.Y = (j) * 60;
            gObject.DrawEllipse(darkblue, circle);
            gObject.FillEllipse(filldarkblue, circle);

        }
        else if (arr[j, i] == 2)
        {
            circle.Y = (j) * 60;
            gObject.DrawEllipse(darkred, circle);
            gObject.FillEllipse(filldarkred, circle);

        }
        else if (arr[j, i] == 5)
        {
            circle.Y = (j) * 60;
            gObject.DrawEllipse(red, circle);
            gObject.FillEllipse(fillred, circle);

        }
        else if (arr[j, i] == 6)
        {
            circle.Y = (j) * 60;
            gObject.DrawEllipse(lightgreen, circle);
            gObject.FillEllipse(filllightgreen, circle);

        }
        else if (arr[j, i] == 12)
        {
            circle.Y = (j) * 60;
            gObject.DrawEllipse(turquoise, circle);
            gObject.FillEllipse(fillturquoise, circle);

        }
        else
        {

        }

    }


}
circle.X = 0;
circle.Y = 0;
gObject.DrawPath(piece.getColor(),gp);
gObject.FillPath(piece.getBrush(),gp);*/
SendToBack();
        }
        public void setUpCanvas()
        {
            GraphicsPath path = new GraphicsPath(FillMode.Alternate);
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
   new Point(0, 10),
   new Point(200, 10),
   Color.FromArgb(255, 139,125,107),   // Opaque red
   Color.FromArgb(255, 238,203,173));  // Opaque blue

            //Brush bg = new SolidBrush(linGrBrush);
            //Pen lines = new Pen(lin);

          //  path.AddRectangle(new Rectangle(0, 0, 660, 300));
            path.AddLine(new Point(60, 300),new Point(60, 0));
            path.AddLine(new Point(120, 0), new Point(120, 300));
            path.AddLine(new Point(180, 300),new Point(180, 0));
            path.AddLine(new Point(240, 0), new Point(240, 300));
            path.AddLine( new Point(300, 300),new Point(300, 0));
            path.AddLine(new Point(360, 0), new Point(360, 300));
            path.AddLine(new Point(420, 300),new Point(420, 0));
            path.AddLine(new Point(480, 0), new Point(480, 300));
            path.AddLine(new Point(540, 300),new Point(540, 0));
            path.AddLine(new Point(600, 0), new Point(600, 300));
            path.AddLine(new Point(660, 300),new Point(660, 0));

            path.AddLine(new Point(660, 60),new Point(0, 60));
            path.AddLine(new Point(0, 120), new Point(660, 120));
            path.AddLine(new Point(660, 180),new Point(0, 180));
            path.AddLine(new Point(0, 240), new Point(660, 240));
            path.AddLine(new Point(660, 300),new Point(0, 300));


            path.AddLine(new Point(0, 300), new Point(660, 300));
            path.AddLine(new Point(660, 240), new Point(0, 240));
            path.AddLine(new Point(0, 180), new Point(660, 180));
            path.AddLine(new Point(660, 120), new Point(0, 120));
            path.AddLine(new Point(0, 60), new Point(660, 60));


            path.AddLine(new Point(660, 0), new Point(660, 300));
            path.AddLine(new Point(600, 300), new Point(600, 0));
            path.AddLine(new Point(540, 0), new Point(540, 300));
            path.AddLine(new Point(480, 300), new Point(480, 0));
            path.AddLine(new Point(420, 0), new Point(420, 300));
            path.AddLine(new Point(360, 300), new Point(360, 0));
            path.AddLine(new Point(300, 0), new Point(300, 300));
            path.AddLine(new Point(240, 300), new Point(240, 0));
            path.AddLine(new Point(180, 0), new Point(180, 300));
            path.AddLine(new Point(120, 300), new Point(120, 0));
            path.AddLine(new Point(60, 0),new Point(60, 300));




             gObject.FillPath(linGrBrush,path);
            gObject.DrawPath(new Pen(Color.Black), path);
            Region rgn = new Region(path);
             this.Region = rgn;

            /* gObject.DrawLine(lines, new Point(60, 0), new Point(60, 300));
              gObject.DrawLine(lines, new Point(120, 0), new Point(120, 300));
              gObject.DrawLine(lines, new Point(180, 0), new Point(180, 300));
              gObject.DrawLine(lines, new Point(240, 0), new Point(240, 300));
              gObject.DrawLine(lines, new Point(300, 0), new Point(300, 300));
              gObject.DrawLine(lines, new Point(360, 0), new Point(360, 300));
              gObject.DrawLine(lines, new Point(420, 0), new Point(420, 300));
              gObject.DrawLine(lines, new Point(480, 0), new Point(480, 300));
              gObject.DrawLine(lines, new Point(540, 0), new Point(540, 300));
              gObject.DrawLine(lines, new Point(600, 0), new Point(600, 300));
              gObject.DrawLine(lines, new Point(660, 0), new Point(660, 300));

              gObject.DrawLine(lines, new Point(0, 60), new Point(660, 60));
              gObject.DrawLine(lines, new Point(0, 120), new Point(660, 120));
              gObject.DrawLine(lines, new Point(0, 180), new Point(660, 180));
              gObject.DrawLine(lines, new Point(0, 240), new Point(660, 240));
              gObject.DrawLine(lines, new Point(0, 300), new Point(660, 300));
              */
            


            SendToBack();



        }


    }
}
