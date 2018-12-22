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
    public partial class HardLevels : Form
    {
        public HardLevels()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(3);
            form.Show();
            this.Hide();
        }

        private void HardLevels_FormClosing(object sender, FormClosingEventArgs e)
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
            LevelDifficulty form = new LevelDifficulty();
            form.Show();
            this.Hide();
        }

        private void HardLevels_Load(object sender, EventArgs e)
        {

        }
    }
}
