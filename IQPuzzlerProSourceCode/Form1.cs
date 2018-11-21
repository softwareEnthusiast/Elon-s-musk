using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class IqPuzzlerPro : Form
    {
        List<Panel> listPanel = new List<Panel>();
        public IqPuzzlerPro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
			soloGamePanel.Visible = true;
			mainMenuPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String exitMessage = "Thank you for using this program!";
            String exitHeader = "See you again";
            MessageBox.Show(exitMessage,exitHeader);
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
		
        }

        private void label1_Click(object sender, EventArgs e)
        {	
			
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            gameplayPanel.Visible=true;
            loginPanel.Visible = false;

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void rotateRight_Click(object sender, EventArgs e)
        {

        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Visible = true;
            gameplayPanel.Visible = false;  
        }
    }
}
