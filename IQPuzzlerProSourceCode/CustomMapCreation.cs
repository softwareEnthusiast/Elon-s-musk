using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQPuzzleProVer2
{
    public partial class CustomMapCreation : Form
    {

        Graphics gObject;
        customMapBuilder cMap;
        CustomMapSprite sprite;
        Sprite2[] sprite1;
        int length;
        public int selectedPiece;
        GraphicsPath gp;
        List<PuzzlePiece> customArr;
        List<PuzzlePiece> invArr;


        List<PuzzlePiece> pieceArray;

        public CustomMapCreation()
        {
           
            cMap = new customMapBuilder(1, 1);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            gp = new GraphicsPath();
            gObject = this.CreateGraphics();
            pieceArray = cMap.getInitialPieces();
            customArr = new List<PuzzlePiece>();
            invArr = pieceArray;
            selectedPiece = 30;
            length = pieceArray.Count;
            sprite1 = new Sprite2[length];
            for (int i = 0; i < length; i++)
            {
                sprite1[i] = new Sprite2(pieceArray[i].getLocX(), pieceArray[i].getLocY(), 60, pieceArray[i]);
               
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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics toPass = panel1.CreateGraphics();


            sprite = new CustomMapSprite(1, 1, toPass);
            if (selectedPiece < length)
            {
                sprite1[selectedPiece].chooseSelected(true);
            }
            for (int i = 0; i < length; i++)
            {
                sprite1[i].draw(toPass);
            }
        }



        private void panel1_MouseClick_1(object sender, MouseEventArgs e)
        {
           
            int x = 0;
            for (int i = 0; x < length; i++)
            {

                if ( sprite1[i].isSelected(e.X, e.Y))
                {
                    if(selectedPiece != 30)
                    {
                        sprite1[selectedPiece].chooseSelected(false);
                    }  
                    selectedPiece = i;
                    sprite1[selectedPiece].chooseSelected(true);

                    Region rgn = new Region(sprite1[selectedPiece].gp);
                    rgn.Union(sprite1[selectedPiece].gp);
                    Invalidate(rgn, false);
                    panel1.Invalidate();
                    sprite1[selectedPiece].draw(gObject);
                    x = 30;
                }
                x++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customArr.Add(sprite1[selectedPiece].piece);
            for (int i = 0; i < invArr.Count; i++)
            {
                if (invArr[i] == sprite1[selectedPiece].piece)
                {
                    invArr[i] = null;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < customArr.Count; i++)
            {
                if(customArr[i] == sprite1[selectedPiece].piece)
                {
                    customArr[i] = null;
                }
            }
            invArr.Add(sprite1[selectedPiece].piece);
        }
    }
       
    
}
