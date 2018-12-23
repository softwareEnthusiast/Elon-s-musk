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
    public partial class CustomMap : Form
    {
        int level;

        MapSprite spriteMap;
        MapSprite spriteMap2;
        public int locX;
        public int locY;
        private bool initial;
        bool dragging;
        public int transparency;
        public int layer;
        List<PuzzlePiece> pieceArray;
        int[] locXarray;
        int[] locYarray;
        bool[,] pieceArrayB = new bool[4, 4];
        GameManager gameManager;

        MapBuilder builder;
        int[] locXArray;
        int[] locYArray;

        Graphics g;
        Point cursor = Point.Empty;
        Graphics gObject;
        customMapBuilder cMap;
        CustomMapSprite sprite;
        Sprite2[] sprite1;
        int length;
        public int selectedPiece;
        GraphicsPath gp;
        public List<PuzzlePiece> customArr;
        public List<PuzzlePiece> invArr;




        public CustomMap()
        {
            initial = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            g = this.CreateGraphics();
           
            cMap = new customMapBuilder(1, 1);
            gp = new GraphicsPath();
            gObject = this.CreateGraphics();
            pieceArray = cMap.inventoryPuzzlePieces;
            locXarray = new int[length];
            locYarray = new int[length];

            invArr = pieceArray;

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
                for (int i = 0; i < length - 3; i++)
                {
                    locXarray[i] += i * 300;
                }
                for (int i = length - 3; i < length; i++)
                {
                    locXarray[i] += (i - (length - 3)) * 300;
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
                for (int i = 0; i < length - 3; i++)
                {
                    locXarray[i] += i * 300;
                }
                for (int i = length - 3; i < length; i++)
                {
                    locXarray[i] += (i - (length - 3)) * 300;
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


            selectedPiece = 30;
            length = pieceArray.Count;
            sprite1 = new Sprite2[length];
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
 

          
        public bool isGameOver(int[,] arr)
        {

            foreach (int item in arr)
            {
                if (item == -1)
                    return false;

            }
            return true;
        }





        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void panel1_MouseClick_1(object sender, MouseEventArgs e)
        {
            int x = 0;
            for (int i = 0; x < length; i++)
            {

                if (sprite1[i].isSelected(e.X, e.Y))
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

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            int x = 0;
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

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            bool allAvailable = true;
            bool done = false;
            customMapBuilder mapa = new customMapBuilder(1,1);
            int[,] arrr = mapa.levelMap.mapArray;

            if (selectedPiece < length)
            {

                int d = (sprite1[selectedPiece].getLocX()) / 60;
                int f = (sprite1[selectedPiece].getLocY()) / 60;

                int x1 = (int)d;
                int y1 = (int)f;
                Console.WriteLine(sprite1[selectedPiece].getLocX());
                Console.WriteLine(sprite1[selectedPiece].getLocY());
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
                                break;
                            }
                            if (!allAvailable)
                            {
                                break;
                            }

                        }

                        d++;
                    }

                    d = d - 4;
                    if (!allAvailable)
                    {
                        break;
                    }

                    f++;


                }

                if (!allAvailable && selectedPiece < length)
                {
                    sprite1[selectedPiece].setLocX(locXarray[selectedPiece]);
                    sprite1[selectedPiece].setLocY(locYarray[selectedPiece]);

                }
                else
                {

                    sprite1[selectedPiece].setLocX(x1 * 60);
                    sprite1[selectedPiece].setLocY(y1 * 60);
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {



                            if (sprite1[selectedPiece].pieceArray[j, i] && (x1 + i) < 11 && (y1 + j) < 5)
                            {

                                spriteMap2.arr[(y1 + j), (x1 + i)] = selectedPiece;
                              

                            }
                           
                        }

                    }


                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 11; j++)
                        {
                            Console.Write(" | " + spriteMap2.arr[i, j]);
                        }
                        Console.WriteLine("");
                    }


                }


                if (isGameOver(spriteMap2.arr))
                {
                    MessageBox.Show("Game Over");
                }
            }

            if (selectedPiece < length)
            {
                Region rgn = new Region(sprite1[selectedPiece].gp);
                rgn.Union(sprite1[selectedPiece].gp);
                Invalidate(rgn, false);
                panel1.Invalidate();
                sprite1[selectedPiece].draw(g);
            }

            dragging = false;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            cursor.X = (MousePosition.X - this.Location.X);
            cursor.Y = (MousePosition.Y - this.Location.Y);

            if (dragging)
            {
                sprite1[selectedPiece].setLocX((cursor.X) - 100);
                sprite1[selectedPiece].setLocY((cursor.Y) - 100);

                Region rgn = new Region(sprite1[selectedPiece].gp);
                rgn.Union(sprite1[selectedPiece].gp);
                Invalidate(rgn, false);
                panel1.Invalidate();
                sprite1[selectedPiece].draw(g);

            }
        }

        private void CustomMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure want to exit?",
                               "My First Application",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                    Environment.Exit(1);
                else
                    e.Cancel = true; // to don't close form is user change his mind
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics toPass = panel1.CreateGraphics();


            sprite = new CustomMapSprite(1, 1, toPass);
            g = this.CreateGraphics();
            if (selectedPiece < length)
            {
                sprite1[selectedPiece].chooseSelected(true);
            }
            for (int i = 0; i < length; i++)
            {
                sprite1[i].draw(toPass);
            }
        }
    }
}

