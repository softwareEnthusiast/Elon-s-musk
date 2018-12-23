using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQPuzzleProVer2
{
    public partial class GameOver : Form
    {
        int level;
        public GameOver(int nLevel, string s)
        {
            InitializeComponent();
            level = nLevel;
            textBox1.Text = "You completed the puzzle in " + s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(level < 15)
            {
                Form2 form = new Form2(level);
                form.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LevelDifficulty form = new LevelDifficulty();
            form.Show();
            this.Hide();
        }

        private void GameOver_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
