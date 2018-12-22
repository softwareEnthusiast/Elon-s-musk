using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQPuzzleProVer2
{
    public class CustomMapSprite : System.Windows.Forms.Control
    {
        Graphics gObject;
        customMapBuilder cMap;
        public int[,] arr;
        public int locX;
        public int locY;
        GraphicsPath gp;
        public int[] locXa;
        public int[] locYa;
        List<PuzzlePiece> pieces;
        Rectangle circle;

        public CustomMapSprite(int userID,int mapID, Graphics g)
        {

            Console.WriteLine("kxjhscgc");
            arr = new int[5, 11];
            gp = new GraphicsPath();
            gObject = g;
            cMap = new customMapBuilder(userID,mapID);
            circle = new Rectangle(locX, locY, 60, 60);
            pieces = new List<PuzzlePiece>();
            locXa = new int[5];
            locYa = new int[5];
            this.setUpMap();
            this.fillMap();


        }


        public void fillMap()
        {
            
            circle.X = 0;
            circle.Y = 0;


            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[j, i] = cMap.levelMap.mapArray[j, i];
                    
                }

            }

            pieces = cMap.getInitialPieces();
            Console.WriteLine(pieces.Count);

            foreach (PuzzlePiece item in pieces)
            {
                Sprite2 sprite = new Sprite2(item.getLocX(), item.getLocY(), 60, item);
                
                sprite.draw(gObject);
            }

            SendToBack();
        }
        public void setUpMap()
        {
            Console.WriteLine("kxjhscgc");
            GraphicsPath path = new GraphicsPath(FillMode.Alternate);
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
   new Point(0, 10),
   new Point(200, 10),
   Color.FromArgb(255, 139, 125, 107),   // Opaque red
   Color.FromArgb(255, 238, 203, 173));  // Opaque blue

            //Brush bg = new SolidBrush(linGrBrush);
            //Pen lines = new Pen(lin);

            path.AddRectangle(new Rectangle(0, 0, 660, 300));
            path.AddLine(new Point(60, 300), new Point(60, 0));
            path.AddLine(new Point(120, 0), new Point(120, 300));
            path.AddLine(new Point(180, 300), new Point(180, 0));
            path.AddLine(new Point(240, 0), new Point(240, 300));
            path.AddLine(new Point(300, 300), new Point(300, 0));
            path.AddLine(new Point(360, 0), new Point(360, 300));
            path.AddLine(new Point(420, 300), new Point(420, 0));
            path.AddLine(new Point(480, 0), new Point(480, 300));
            path.AddLine(new Point(540, 300), new Point(540, 0));
            path.AddLine(new Point(600, 0), new Point(600, 300));
            path.AddLine(new Point(660, 300), new Point(660, 0));

            path.AddLine(new Point(660, 60), new Point(0, 60));
            path.AddLine(new Point(0, 120), new Point(660, 120));
            path.AddLine(new Point(660, 180), new Point(0, 180));
            path.AddLine(new Point(0, 240), new Point(660, 240));
            path.AddLine(new Point(660, 300), new Point(0, 300));


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
            path.AddLine(new Point(60, 0), new Point(60, 300));




            gObject.FillPath(linGrBrush, path);
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
