namespace WindowsFormsApp1
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button button1;
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.BackgroundImage = global::IQPuzzleProVer2.Properties.Resources.soloButton;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.Color.Transparent;
            button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            button1.Location = new System.Drawing.Point(360, 170);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(145, 53);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::IQPuzzleProVer2.Properties.Resources.exitButton;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(360, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 53);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::IQPuzzleProVer2.Properties.Resources.onlineButton;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(360, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 53);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IQPuzzleProVer2.Properties.Resources.backgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(966, 554);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(button1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}

