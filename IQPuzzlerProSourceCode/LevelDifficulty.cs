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
    public partial class LevelDifficulty : Form
    {
        public LevelDifficulty()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EasyLevels form = new EasyLevels();
            form.Show();
            this.Hide();
        }

        private void LevelDifficulty_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.MainMenu form = new WindowsFormsApp1.MainMenu();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MediumLevels form = new MediumLevels();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HardLevels form = new HardLevels();
            form.Show();
            this.Hide();
        }
    }
}
