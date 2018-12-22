using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQPuzzleProVer2
{
    public partial class Form2 : Form
    {
        int level;
        int length;
        MapSprite spriteMap;
        public int locX;
        public int locY;
        private bool initial;
        bool dragging;
        public int transparency;
        public int layer;
        bool done;
        List<PuzzlePiece> pieceArray;
        int[] locXarray;
        int[] locYarray;
        bool[,] pieceArrayB = new bool[4, 4];
        GameManager gameManager;
        public int selectedPiece;
        int[] locXArray;
        int[] locYArray;
        Sprite2[] sprite1;
        Graphics g;
        GraphicsPathIterator gpi;

        Point cursor = Point.Empty;

        public Form2()
        {
            initial = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer,true);
            gameManager = new GameManager();
            level = gameManager.getLevel(1);
            g = this.CreateGraphics();
            gameManager.initializePuzzle(level, g);
            length = gameManager.numberOfPuzzlePiece();
            pieceArray = gameManager.getInventoryPuzzlePieces();
            locXarray = new int[length];
            locYarray = new int[length];
 

            if (length > 3)
            {
                for (int i = 0; i < length - 3; i++)
                {
                    locYarray[i] = 400;
                }
                for (int i = length - 3; i < length; i++)
                {
                    locYarray[i] = 500;
                }
                for (int i = 0; i < length-3; i++)
                {
                    locXarray[i] += i* 300;
                }
                for (int i = length - 3; i < length; i++)
                {
                    locXarray[i] += (i-(length-3)) * 300;
                }

            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    locYarray[i] = 400;
                }
                for (int i = 0; i < length; i++)
                {
                    locXarray[i] += i * 300;
                }
            }


            sprite1 = new Sprite2[length];
            selectedPiece = 30;
             for (int i = 0; i < length; i++)
             {
                 sprite1[i] = new Sprite2(locXarray[i], locYarray[i], 60, pieceArray[i]);

             }

             
            InitializeComponent();
            

        }


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics toPass = panel1.CreateGraphics();
            
            spriteMap = new MapSprite(level, toPass);

            g = this.CreateGraphics();
            for (int i = 0; i < length; i++)
            {
                sprite1[i].draw(toPass);                
            }

           
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            g = this.CreateGraphics();
            for (int i = 0; i < length; i++)
            {
                sprite1[i].draw(g);
            }
            
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (selectedPiece < length)
            {
                Graphics g = this.CreateGraphics();
                sprite1[selectedPiece].setPieceArray(sprite1[selectedPiece].flip());

                Region rgn = new Region(sprite1[selectedPiece].gp);
                rgn.Union(sprite1[selectedPiece].gp);
                Invalidate(rgn, false);
                panel1.Invalidate();
                sprite1[selectedPiece].draw(g);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (selectedPiece < length)
            {
                Graphics g = this.CreateGraphics();
                sprite1[selectedPiece].setPieceArray(sprite1[selectedPiece].rightRot());

                Region rgn = new Region(sprite1[selectedPiece].gp);
                rgn.Union(sprite1[selectedPiece].gp);
                Invalidate(rgn, false);
                panel1.Invalidate();
                sprite1[selectedPiece].draw(g);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (selectedPiece < length)
            {
                Graphics g = this.CreateGraphics();
                sprite1[selectedPiece].setPieceArray(sprite1[selectedPiece].leftRot());
                Region rgn = new Region(sprite1[selectedPiece].gp);
                rgn.Union(sprite1[selectedPiece].gp);
                Invalidate(rgn, false);
                panel1.Invalidate();
                sprite1[selectedPiece].draw(g);

            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = 0;
            for (int i = 0; x < length; i++)
            {

                if (sprite1[i].isSelected(e.X, e.Y) && selectedPiece < length)
                {
                    sprite1[selectedPiece].chooseSelected(false);
                    selectedPiece = i;
                    sprite1[selectedPiece].chooseSelected(true);

                    Region rgn = new Region(sprite1[selectedPiece].gp);
                    rgn.Union(sprite1[selectedPiece].gp);
                    Invalidate(rgn, false);
                    panel1.Invalidate();
                    sprite1[selectedPiece].draw(g);
                    x = 30;
                }
                x++;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = 0;
            for (int i = 0; x < length; i++)
            {

                if (sprite1[i].isSelected(e.X, e.Y) && selectedPiece < length)
                {
                    sprite1[selectedPiece].chooseSelected(false);
                    
                    selectedPiece = i;
                    sprite1[selectedPiece].chooseSelected(true);
                    dragging = true;

                    Region rgn = new Region(sprite1[selectedPiece].gp);
                    rgn.Union(sprite1[selectedPiece].gp);
                    Invalidate(rgn, false);
                    panel1.Invalidate();
                    sprite1[selectedPiece].draw(g);
                }
                x++;
            }
        }

        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            /*bool allAvailable = false;
            bool done = false;
            int[,] arrr = spriteMap.arr;
            if (selectedPiece < length)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (sprite1[selectedPiece].pieceArray[i, j] && f < 5 && d < 11 && f >= 0 && d >= 0)
                        {
                            if (arrr[f, d] == -1)
                            {
                                spriteMap.arr[f, d] = 1;
                                allAvailable = true;
                            }
                            else
                            {
                                allAvailable = false;
                            }
                        }
                        d++;
                    }
                    f++;
                }

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        if (spriteMap.arr[i, j] == -1)
                        {
                            done = false;
                        }
                        else
                        {
                            done = true;
                        }
                    }
                }
*/
            
            if (selectedPiece < length)
            {
                int f = sprite1[selectedPiece].getLocX() / 60;
                int d = sprite1[selectedPiece].getLocY() / 60;
                int x1 = (int)f;
                int y1 = (int)d;

                sprite1[selectedPiece].setLocX(x1 * 60);
                sprite1[selectedPiece].setLocY(y1 * 60);
                Region rgn = new Region(sprite1[selectedPiece].gp);
                rgn.Union(sprite1[selectedPiece].gp);
                Invalidate(rgn, false);
                panel1.Invalidate();
                sprite1[selectedPiece].draw(g);
            }

            gpi = new GraphicsPathIterator(sprite1[selectedPiece].gp);
            bool isclosed;
            int ind;
            int end;
            gpi.NextSubpath(out ind, out end, out isclosed);
            textBox1.Text = "" + ind +" |" + end ;
            textBox1.Text = sprite1[0].gp.GetLastPoint().ToString();
            if (sprite1[0].gp.GetLastPoint().X == 660 && sprite1[0].gp.GetLastPoint().Y == 210 && sprite1[1].gp.GetLastPoint().Y == 150 && sprite1[1].gp.GetLastPoint().X == 600 && sprite1[2].gp.GetLastPoint().X == 660 && sprite1[2].gp.GetLastPoint().Y == 270)
            {
                Pen red = new Pen(Color.Red);
                Pen blue = new Pen(Color.Blue);
                System.Drawing.SolidBrush fillBlue = new System.Drawing.SolidBrush(Color.Blue);
                Rectangle circle1 = new Rectangle(350, 350, 100, 100);
                g.DrawEllipse(blue, circle1);
                g.FillEllipse(fillBlue, circle1);
                done = true;
            }
            dragging = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = 0;
            for (int i = 0; x < length; i++)
            {

                if (sprite1[i].isSelected(e.X, e.Y) && selectedPiece < length)
                {
                    sprite1[selectedPiece].chooseSelected(false);
                    selectedPiece = i;
                    sprite1[selectedPiece].chooseSelected(true);

                    Region rgn = new Region(sprite1[selectedPiece].gp);
                    rgn.Union(sprite1[selectedPiece].gp);
                    Invalidate(rgn, false);
                    panel1.Invalidate();
                    sprite1[selectedPiece].draw(g);
                    x = 30;
                }
                x++;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = 0;
            if (!done)
            {
                for (int i = 0; x < length; i++)
                {

                    if (sprite1[i].isSelected(e.X, e.Y))
                    {
                        if (selectedPiece < length)
                        {
                            sprite1[selectedPiece].chooseSelected(false);
                        }
                        selectedPiece = i;
                        sprite1[selectedPiece].chooseSelected(true);
                        dragging = true;
                        Region rgn = new Region(sprite1[selectedPiece].gp);
                        rgn.Union(sprite1[selectedPiece].gp);
                        Invalidate(rgn, false);
                        panel1.Invalidate();
                        sprite1[selectedPiece].draw(g);
                        x = 30;
                    }
                    x++;
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if(selectedPiece < length)
            {
                textBox1.Text = sprite1[selectedPiece].gp.GetLastPoint().ToString();

            }
            /*
            bool allAvailable = false;
            bool done = false;
            int[,] arrr = spriteMap.arr;
            if( selectedPiece < length)
            {
                int f = sprite1[selectedPiece].getLocX() / 60;
                int d = sprite1[selectedPiece].getLocY() / 60;
                int x1 = (int)f;
                int y1 = (int)d;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (sprite1[selectedPiece].pieceArray[i, j] && f < 5 && d < 11)
                        {
                            if (arrr[f, d] == -1)
                            {

                                allAvailable = true;
                            }
                            else
                            {
                                allAvailable = false;
                            }
                        }
                        d++;
                    }
                    f++;
                }

                sprite1[selectedPiece].setLocX(x1 * 60);
                sprite1[selectedPiece].setLocY(y1 * 60);
            }
            Pen red = new Pen(Color.Red);
            Pen blue = new Pen(Color.Blue);
            System.Drawing.SolidBrush fillBlue = new System.Drawing.SolidBrush(Color.Blue);
            Rectangle circle1 = new Rectangle(350, 350, 100, 100);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    if (spriteMap.arr[i, j] == -1)
                    {
                        done = false;
                    }
                    else
                    {
                        done = true;
                    }
                }
            }
            */

            if (selectedPiece < length)
            {
                int f = sprite1[selectedPiece].getLocX() / 60;
                int d = sprite1[selectedPiece].getLocY() / 60;
                int x1 = (int)f;
                int y1 = (int)d;

                
                sprite1[selectedPiece].setLocX(x1 * 60);
                sprite1[selectedPiece].setLocY(y1 * 60);
                Region rgn = new Region(sprite1[selectedPiece].gp);
                rgn.Union(sprite1[selectedPiece].gp);
                Region testregion = new Region(rgn.Intersect(spriteMap.circleArr[i]));
                for (int i = 0; i < 55; i++)
                {
                    testregion = new Region(rgn.Intersect(spriteMap.circleArr[i]));
                    if (testregion.IsEmpty(g))
                    {
                        rgn = new Region(sprite1[selectedPiece].gp);
                        rgn.Union(sprite1[selectedPiece].gp);
                        Invalidate(rgn, false);
                        panel1.Invalidate();
                        sprite1[selectedPiece].draw(g);

                    }
                    else
                    {
                        sprite1[selectedPiece].setLocX(locXarray[selectedPiece]);
                        sprite1[selectedPiece].setLocY(locYArray[selectedPiece]);
                        rgn = new Region(sprite1[selectedPiece].gp);
                        rgn.Union(sprite1[selectedPiece].gp);
                        panel1.Invalidate();
                        sprite1[selectedPiece].draw(g);

                    }
                }
                
            }
            dragging = false;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            cursor.X = (MousePosition.X - this.Location.X); 
            cursor.Y = (MousePosition.Y - this.Location.Y);
            
            if (dragging && !done)
            {
                sprite1[selectedPiece].setLocX( ( cursor.X  ) - 100);
                sprite1[selectedPiece].setLocY( ( cursor.Y ) - 100);

                Region rgn = new Region(sprite1[selectedPiece].gp);
                rgn.Union(sprite1[selectedPiece].gp);
                Invalidate(rgn, false);
                panel1.Invalidate();
                Invalidate();
                sprite1[selectedPiece].draw(g);

                textBox1.Text = sprite1[selectedPiece].gp.GetLastPoint().ToString();

            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            cursor.X = (MousePosition.X - this.Location.X);
            cursor.Y = (MousePosition.Y - this.Location.Y);

            if (dragging && !done)
            {
                sprite1[selectedPiece].setLocX((cursor.X) - 100);
                sprite1[selectedPiece].setLocY((cursor.Y) - 100);

                Region rgn = new Region(sprite1[selectedPiece].gp);
                rgn.Union(sprite1[selectedPiece].gp);
                Invalidate(rgn, false);
                panel1.Invalidate();
                Invalidate();
                sprite1[selectedPiece].draw(g);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
