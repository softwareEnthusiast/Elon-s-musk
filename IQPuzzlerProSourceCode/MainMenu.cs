using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginPanel log = new loginPanel();
            log.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IQPuzzleProVer2.LevelDifficulty level = new IQPuzzleProVer2.LevelDifficulty();
            level.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String exitMessage = "Thank you for using this program!";
            String exitHeader = "See you again";
            MessageBox.Show(exitMessage, exitHeader);
            Application.Exit();
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
