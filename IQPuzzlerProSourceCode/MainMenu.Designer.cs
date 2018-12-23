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
            this.soloGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.onlineGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // soloGameButton
            // 
            this.soloGameButton.BackColor = System.Drawing.Color.Transparent;
            this.soloGameButton.BackgroundImage = global::IQPuzzleProVer2.Properties.Resources.soloButton;
            this.soloGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soloGameButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.soloGameButton.FlatAppearance.BorderSize = 0;
            this.soloGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soloGameButton.ForeColor = System.Drawing.Color.Transparent;
            this.soloGameButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.soloGameButton.Location = new System.Drawing.Point(360, 170);
            this.soloGameButton.Name = "soloGameButton";
            this.soloGameButton.Size = new System.Drawing.Size(145, 53);
            this.soloGameButton.TabIndex = 0;
            this.soloGameButton.UseVisualStyleBackColor = true;
            this.soloGameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = global::IQPuzzleProVer2.Properties.Resources.exitButton;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.Transparent;
            this.exitButton.Location = new System.Drawing.Point(360, 340);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(145, 53);
            this.exitButton.TabIndex = 3;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // onlineGameButton
            // 
            this.onlineGameButton.BackColor = System.Drawing.Color.Transparent;
            this.onlineGameButton.BackgroundImage = global::IQPuzzleProVer2.Properties.Resources.onlineButton;
            this.onlineGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onlineGameButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.onlineGameButton.FlatAppearance.BorderSize = 0;
            this.onlineGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onlineGameButton.ForeColor = System.Drawing.Color.Transparent;
            this.onlineGameButton.Location = new System.Drawing.Point(360, 252);
            this.onlineGameButton.Name = "onlineGameButton";
            this.onlineGameButton.Size = new System.Drawing.Size(145, 53);
            this.onlineGameButton.TabIndex = 1;
            this.onlineGameButton.UseVisualStyleBackColor = false;
            this.onlineGameButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IQPuzzleProVer2.Properties.Resources.backgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(966, 554);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.onlineGameButton);
            this.Controls.Add(this.soloGameButton);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button onlineGameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button soloGameButton;
    }
}

