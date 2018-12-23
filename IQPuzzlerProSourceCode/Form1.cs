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
        int minute;
        int second;
        int splitSecond;
        int level;
        int length;
        EventArgs formE;
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
        public int selectedPiece;
        MapBuilder builder;
        int[] locXArray;
        int[] locYArray;
        Sprite2[] sprite1;
        Graphics g;
        int currentHint;
        int firstPieceI;
        int firstPieceJ;
        Point cursor = Point.Empty;
        PaintEventArgs e;

        public Form2(int level)
        {
            initial = true;
            timer1 = new Timer();
            timer2 = new Timer();
            timer3 = new Timer();
            
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            currentHint = 0;
            gameManager = new GameManager();
            this.level = gameManager.getLevel(level);
            g = this.CreateGraphics();
            gameManager.initializePuzzle(level, g);
            spriteMap2 = new MapSprite(level, g);
            length = gameManager.numberOfPuzzlePiece();
            pieceArray = gameManager.getInventoryPuzzlePieces();
            locXarray = new int[length];
            locYarray = new int[length];
            builder = new MapBuilder(level);

  
            timer1.Start(); timer2.Start(); timer3.Start();

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

            this.e = e;
            spriteMap = new MapSprite(level, toPass);
            g = this.CreateGraphics();
            if (selectedPiece < length && sprite1[selectedPiece].isMovable)
            {
                sprite1[selectedPiece].chooseSelected(true);
            }
            if (selectedPiece < length && !sprite1[selectedPiece].isMovable)
            {
                sprite1[selectedPiece].chooseSelected(false);
            }
            for (int i = 0; i < length; i++)
            {
                sprite1[i].draw(toPass);
            }


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            g = this.CreateGraphics();
            if (selectedPiece < length)
            {
                sprite1[selectedPiece].chooseSelected(true);
            }
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

                if (sprite1[i].isSelected(e.X, e.Y))
                {
                    sprite1[selectedPiece].chooseSelected(false);
                    selectedPiece = i;
                    sprite1[selectedPiece].chooseSelected(true);
                    Invalidate();
                    x = 30;
                }
                x++;
            }
            if (selectedPiece < length)
            {
                Region rgn = new Region(sprite1[selectedPiece].gp);
                rgn.Union(sprite1[selectedPiece].gp);
                Invalidate(rgn, false);
                panel1.Invalidate();
                sprite1[selectedPiece].draw(g);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
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

        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            bool allAvailable = false;
            bool done = false;
            int[,] arrr = spriteMap.arr;
            if (selectedPiece < length)
            {
                int inventoryX = sprite1[selectedPiece].getLocX();
                int inventoryY = sprite1[selectedPiece].getLocY();
                int d = (sprite1[selectedPiece].getLocX() )/ 60;
                int f = (sprite1[selectedPiece].getLocY()) / 60;
                int x1 = (int)d;
                int y1 = (int)f;
                for (int i = 0; i < 4; i++) 
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine("array" + sprite1[selectedPiece].pieceArray[i, j]);
                        if (sprite1[selectedPiece].pieceArray[i, j] && f < 5 && d < 11 && f >= 0 && d >= 0)
                        {
                            Console.WriteLine("fssghaj" + arrr[f, d]);
                           
                            if (arrr[f, d] == -1)
                            {
                                spriteMap.arr[f, d] = selectedPiece;
                                allAvailable = true;
                            }
                            else
                            {
                                allAvailable = false;
                                break;
                            }
                        }
                        if (!allAvailable)
                        {
                            break;
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
                    Console.WriteLine(sprite1[selectedPiece].getLocX());
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
                                int newX = e.X;
                                int newY = e.Y;
                                Console.Write(sprite1[selectedPiece].getLocX() + " " + sprite1[selectedPiece].getLocY());
                                if (newX > 300 && newY > 660)
                                    spriteMap2.arr[(y1 + j), (x1 + i)] = -1;
                                else
                                    spriteMap2.arr[(y1 + j), (x1 + i)] = selectedPiece;





                            }

                        }

                    }
                }


            }
           
            dragging = false;
            if (selectedPiece < length)
            {
                Region rgn = new Region(sprite1[selectedPiece].gp);
                rgn.Union(sprite1[selectedPiece].gp);
                Invalidate(rgn, false);
                panel1.Invalidate();
                sprite1[selectedPiece].draw(g);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formE = e;
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            timer1.Interval = 60000;
            timer1.Enabled = true;
            timer2.Interval = 1000;
            timer2.Enabled = true;
            timer3.Interval = 10;
            timer3.Enabled = true;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = 0;
            for (int i = 0; x < length; i++)
            {

                if (sprite1[i].isSelected(e.X, e.Y) )
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
            for (int i = 0; x < length; i++)
            {

                if (sprite1[i].isSelected(e.X, e.Y) )
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

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            bool allAvailable = true ;
            bool done = false;
            MapBuilder mapa = new MapBuilder(level);
            int[,] arrr = mapa.getMapArray();

            if (selectedPiece < length)
            {
 
                int d = (sprite1[selectedPiece].getLocX() )/ 60;
                int f = (sprite1[selectedPiece].getLocY()) / 60;
               
                int x1 = (int)d;
                int y1 = (int)f ;

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

                    d=  d - 4;
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

                    sprite1[selectedPiece].setLocX(x1*60);
                    sprite1[selectedPiece].setLocY(y1*60);
                   
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {

                           
                            if (sprite1[selectedPiece].pieceArray[j,i]  && (x1 + i) < 11 && (y1 + j) < 5 )
                            {

                                 spriteMap2.arr[(y1 + j),(x1 + i)] = sprite1[selectedPiece].ID;
 
                            }
  
                        }
                        
                    }
                    if (e.X > 660 || e.Y > 300)
                    {

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 11; j++)
                            {

                                if (spriteMap2.arr[i, j] == sprite1[selectedPiece].ID)
                                {
                                    spriteMap2.arr[i, j] = -1;
                                }

                            }
                        }
                    }
                }
            

            }

            for(int i = 0;  i < 5; i++)
            {
                for(int j =0; j < 11; j++)
                {
                    Console.Write(" | " + spriteMap2.arr[i, j]);
                }
                Console.WriteLine();
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
            if (isGameOver(spriteMap2.arr))
            {
                int nLevel = level++;
                string s = label1.Text + " : " + label2.Text + " : " + label3.Text;
                GameOver gOver = new GameOver(nLevel,s );
                gOver.Show();
                this.Hide();
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            cursor.X = (MousePosition.X - this.Location.X);
            cursor.Y = (MousePosition.Y - this.Location.Y);

            if (dragging && sprite1[selectedPiece].isMovable)
            {/*
                cursor.X = MousePosition.X - this.Location.X;
                cursor.Y = MousePosition.Y - this.Location.Y;
                int a = (sprite1[selectedPiece].getLocX() / 60) - (cursor.X / 60);
                int b = (sprite1[selectedPiece].getLocY() / 60) - (cursor.Y / 60);
                
                sprite1[selectedPiece].setLocX( (( sprite1[selectedPiece].getLocX() / 60 ) + cursor.X ) * 60);
                sprite1[selectedPiece].setLocY( (( sprite1[selectedPiece].getLocY() / 60) + cursor.Y) * 60);
                */
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (sprite1[selectedPiece].pieceArray[i,j])
                        {
                            firstPieceI = i;
                            firstPieceJ = j;
                        }
                    }
                }

                sprite1[selectedPiece].setLocX((cursor.X) - 45 - (firstPieceJ * 60));
                sprite1[selectedPiece].setLocY((cursor.Y) - 45 - (firstPieceI * 60 ));

                Region rgn = new Region(sprite1[selectedPiece].gp);
                rgn.Union(sprite1[selectedPiece].gp);
                Invalidate(rgn, false);
                panel1.Invalidate();
                sprite1[selectedPiece].draw(g);

                /*Invalidate();
                sprite1[selectedPiece].draw(g);*/

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LevelDifficulty form = new LevelDifficulty();
            form.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Form2_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            // Ensure the Form remains square (Height = Width).
            if (control.Size.Height != control.Size.Width)
            {
                control.Size = new Size(control.Size.Width, control.Size.Width);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(builder.getHint() == null)
            {
                MessageBox.Show("There is no hint");
            }
            else
            {
                if (currentHint < builder.getHint().Count)
                {
                    Graphics g = this.CreateGraphics();
                    Sprite2 sprite2 = new Sprite2(builder.getIndexedHint(currentHint).getLocX(), builder.getIndexedHint(currentHint).getLocY(), 60, builder.hintPuzzleList[currentHint]);

                    int x = 0;
                  
                    for (int i = 0; x < length; i++)
                    {
                       
                        if (sprite1[i].getLocX() == builder.getIndexedHint(currentHint).oldX && sprite1[i].getLocY() == builder.getIndexedHint(currentHint).oldY )
                        {
                            
                            selectedPiece = i;
                           sprite1[selectedPiece].chooseSelected(true);
                            Invalidate();
                          
                            sprite1[selectedPiece].setLocX(builder.getIndexedHint(currentHint).getLocX());
                            sprite1[selectedPiece].setLocY(builder.getIndexedHint(currentHint).getLocY());
                            sprite1[selectedPiece].isMovable = false;
                            Region rgn = new Region(sprite1[selectedPiece].gp);
                            rgn.Union(sprite1[selectedPiece].gp);
                            Invalidate(rgn, false);
                            panel1.Invalidate();

                            sprite1[selectedPiece].draw(g);
                            

                            x = 30;
                        }
                        x++;
                
                    }
                    currentHint++;
         
                }

                else
                {
                    MessageBox.Show("You have no more hint");
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            minute++;
            label1.Text = Convert.ToString(minute);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (second == 60)
                second = 0;
            second++;
            label2.Text = Convert.ToString(second);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (splitSecond == 100)
                splitSecond = 0;
            splitSecond++;
            label3.Text = Convert.ToString(splitSecond);
        }

        private void button6_Click(object sender, EventArgs e)
        {
  


         
            currentHint = 0;
            spriteMap2 = new MapSprite(level, g);
            length = gameManager.numberOfPuzzlePiece();
            pieceArray = gameManager.getInventoryPuzzlePieces();
            locXarray = new int[length];
            locYarray = new int[length];
            builder = new MapBuilder(level);
            timer1 = new Timer();
            timer2 = new Timer();
            timer3 = new Timer();

            Form1_Load(sender,formE);

            timer1.Start(); timer2.Start(); timer3.Start();
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



            for (int i = 0; i < sprite1.Length; i++)
            {
                sprite1[i].setLocX(locXarray[i]);
                sprite1[i].setLocY(locYarray[i]);
            }

            Invalidate();


            sprite1 = new Sprite2[length];
            selectedPiece = 30;
            for (int i = 0; i < length; i++)
            {

                sprite1[i] = new Sprite2(locXarray[i], locYarray[i], 60, pieceArray[i]);

            }
        }
    }
}
