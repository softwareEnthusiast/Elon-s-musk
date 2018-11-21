namespace $safeprojectname$
{
    partial class IqPuzzlerPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IqPuzzlerPro));
            
            this.BoardPanel = new System.Windows.Forms.Panel();
            this.goBackButton = new System.Windows.Forms.Button();
	    this.mainMenuPanel = new System.Windows.Forms.Button()
            this.rotateLeftButton = new System.Windows.Forms.Button();
            this.rotateRightButton = new System.Windows.Forms.Button();
            this.flipButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numberOfMovesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inventoryPanel = new System.Windows.Forms.Panel();
            this.mainMenuPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.gameplayPanel.SuspendLayout();
            this.SuspendLayout();
	    this.soloButton = new System.Windows.Forms.Button();
            this.onlineButton = new System.Windows.Forms.Button();
            this.tutorialButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.gameplayPanel = new System.Windows.Forms.Panel();
            // 
            // soloButton
            // 
            resources.ApplyResources(this.soloButton, "soloButton");
            this.soloButton.BackColor = System.Drawing.Color.Transparent;
            this.soloButton.BackgroundImage = global::$safeprojectname$.Properties.Resources.soloButton;
            this.soloButton.FlatAppearance.BorderSize = 0;
            this.soloButton.Name = "soloButton";
            this.soloButton.UseVisualStyleBackColor = false;
            this.soloButton.UseWaitCursor = true;
            this.soloButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // onlineButton
            // 
            this.onlineButton.BackColor = System.Drawing.Color.Transparent;
            this.onlineButton.BackgroundImage = global::$safeprojectname$.Properties.Resources.onlineButton;
            resources.ApplyResources(this.onlineButton, "onlineButton");
            this.onlineButton.FlatAppearance.BorderSize = 0;
            this.onlineButton.Name = "onlineButton";
            this.onlineButton.UseVisualStyleBackColor = false;
            this.onlineButton.UseWaitCursor = true;
            this.onlineButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // tutorialButton
            // 
            this.tutorialButton.BackColor = System.Drawing.Color.Transparent;
            this.tutorialButton.BackgroundImage = global::$safeprojectname$.Properties.Resources.tutorialButton;
            resources.ApplyResources(this.tutorialButton, "tutorialButton");
            this.tutorialButton.FlatAppearance.BorderSize = 0;
            this.tutorialButton.Name = "tutorialButton";
            this.tutorialButton.UseVisualStyleBackColor = false;
            this.tutorialButton.UseWaitCursor = true;
            this.tutorialButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = global::$safeprojectname$.Properties.Resources.exitButton;
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.UseWaitCursor = true;
            this.exitButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // mainMenuPanel
            // 
            resources.ApplyResources(this.mainMenuPanel, "mainMenuPanel");
            this.mainMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuPanel.Controls.Add(this.loginPanel);
            this.mainMenuPanel.Controls.Add(this.soloButton);
            this.mainMenuPanel.Controls.Add(this.exitButton);
            this.mainMenuPanel.Controls.Add(this.onlineButton);
            this.mainMenuPanel.Controls.Add(this.tutorialButton);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.UseWaitCursor = true;
            this.mainMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.passwordBox);
            this.loginPanel.Controls.Add(this.usernameBox);
            resources.ApplyResources(this.loginPanel, "loginPanel");
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.UseWaitCursor = true;
            // 
            // loginButton
            // 
            this.loginButton.BackgroundImage = global::$safeprojectname$.Properties.Resources.loginButton;
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.Name = "loginButton";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.UseWaitCursor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.UseWaitCursor = true;
            this.passwordLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Name = "label1";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordBox
            // 
            resources.ApplyResources(this.passwordBox, "passwordBox");
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.UseWaitCursor = true;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // usernameBox
            // 
            resources.ApplyResources(this.usernameBox, "usernameBox");
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.UseWaitCursor = true;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // gameplayPanel
            // 
            this.gameplayPanel.BackColor = System.Drawing.Color.Transparent;
            this.gameplayPanel.Controls.Add(this.inventoryPanel);
            this.gameplayPanel.Controls.Add(this.label2);
            this.gameplayPanel.Controls.Add(this.BoardPanel);
            this.gameplayPanel.Controls.Add(this.goBackButton);
            this.gameplayPanel.Controls.Add(this.rotateLeftButton);
            this.gameplayPanel.Controls.Add(this.rotateRightButton);
            this.gameplayPanel.Controls.Add(this.flipButton);
            this.gameplayPanel.Controls.Add(this.refreshButton);
            this.gameplayPanel.Controls.Add(this.button1);
            this.gameplayPanel.Controls.Add(this.numberOfMovesLabel);
            resources.ApplyResources(this.gameplayPanel, "gameplayPanel");
            this.gameplayPanel.Name = "gameplayPanel";
            this.gameplayPanel.UseWaitCursor = true;
            // 
            // BoardPanel
            // 
            resources.ApplyResources(this.BoardPanel, "BoardPanel");
            this.BoardPanel.Name = "BoardPanel";
            this.BoardPanel.UseWaitCursor = true;
            // 
            // goBackButton
            // 
            resources.ApplyResources(this.goBackButton, "goBackButton");
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.UseWaitCursor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // rotateLeftButton
            // 
            this.rotateLeftButton.BackgroundImage = global::$safeprojectname$.Properties.Resources.rotateLeftButton;
            resources.ApplyResources(this.rotateLeftButton, "rotateLeftButton");
            this.rotateLeftButton.Name = "rotateLeftButton";
            this.rotateLeftButton.UseVisualStyleBackColor = true;
            this.rotateLeftButton.UseWaitCursor = true;
            // 
            // rotateRightButton
            // 
            this.rotateRightButton.BackgroundImage = global::$safeprojectname$.Properties.Resources.rotateRightButton;
            resources.ApplyResources(this.rotateRightButton, "rotateRightButton");
            this.rotateRightButton.Name = "rotateRightButton";
            this.rotateRightButton.UseVisualStyleBackColor = true;
            this.rotateRightButton.UseWaitCursor = true;
            this.rotateRightButton.Click += new System.EventHandler(this.rotateRight_Click);
            // 
            // flipButton
            // 
            this.flipButton.BackgroundImage = global::$safeprojectname$.Properties.Resources.flipButton;
            resources.ApplyResources(this.flipButton, "flipButton");
            this.flipButton.Name = "flipButton";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.UseWaitCursor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImage = global::$safeprojectname$.Properties.Resources.refreshButton;
            resources.ApplyResources(this.refreshButton, "refreshButton");
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::$safeprojectname$.Properties.Resources.getHintButton;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // numberOfMovesLabel
            // 
            resources.ApplyResources(this.numberOfMovesLabel, "numberOfMovesLabel");
            this.numberOfMovesLabel.Name = "numberOfMovesLabel";
            this.numberOfMovesLabel.UseWaitCursor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // inventoryPanel
            // 
            resources.ApplyResources(this.inventoryPanel, "inventoryPanel");
            this.inventoryPanel.Name = "inventoryPanel";
            this.inventoryPanel.UseWaitCursor = true;
            // 
            // IqPuzzlerPro
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::$safeprojectname$.Properties.Resources.backgroundImage;
            this.Controls.Add(this.gameplayPanel);
            this.Controls.Add(this.mainMenuPanel);
            this.Name = "IqPuzzlerPro";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenuPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.gameplayPanel.ResumeLayout(false);
            this.gameplayPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel gameplayPanel;
        private System.Windows.Forms.Button soloButton;
        private System.Windows.Forms.Button onlineButton;
        private System.Windows.Forms.Button logoGameButton;
        private System.Windows.Forms.Button tutorialButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label numberOfMovesLabel;
        private System.Windows.Forms.Label label2; 
	private System.Windows.Forms.Panel BoardPanel;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button rotateLeftButton;
        private System.Windows.Forms.Button rotateRightButton;
        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel inventoryPanel;
    }
}

