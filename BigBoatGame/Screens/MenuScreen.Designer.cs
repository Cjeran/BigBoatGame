namespace BigBoatGame.Screens
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.highscoreButton = new System.Windows.Forms.Button();
            this.howButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.flipperButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(63, 649);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(79, 42);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "stort button";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // highscoreButton
            // 
            this.highscoreButton.Location = new System.Drawing.Point(338, 649);
            this.highscoreButton.Name = "highscoreButton";
            this.highscoreButton.Size = new System.Drawing.Size(77, 42);
            this.highscoreButton.TabIndex = 1;
            this.highscoreButton.Text = "HIGH button";
            this.highscoreButton.UseVisualStyleBackColor = true;
            this.highscoreButton.Click += new System.EventHandler(this.highscoreButton_Click);
            // 
            // howButton
            // 
            this.howButton.Location = new System.Drawing.Point(800, 649);
            this.howButton.Name = "howButton";
            this.howButton.Size = new System.Drawing.Size(91, 42);
            this.howButton.TabIndex = 2;
            this.howButton.Text = "sHow";
            this.howButton.UseVisualStyleBackColor = true;
            this.howButton.Click += new System.EventHandler(this.howButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1106, 649);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 42);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "leave";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // flipperButton
            // 
            this.flipperButton.BackColor = System.Drawing.Color.Navy;
            this.flipperButton.Font = new System.Drawing.Font("OfficePlanning", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.flipperButton.ForeColor = System.Drawing.Color.White;
            this.flipperButton.Location = new System.Drawing.Point(1078, 73);
            this.flipperButton.Name = "flipperButton";
            this.flipperButton.Size = new System.Drawing.Size(127, 74);
            this.flipperButton.TabIndex = 4;
            this.flipperButton.Text = "Flop";
            this.flipperButton.UseVisualStyleBackColor = false;
            this.flipperButton.Click += new System.EventHandler(this.flipperButton_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.Controls.Add(this.flipperButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.howButton);
            this.Controls.Add(this.highscoreButton);
            this.Controls.Add(this.startButton);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1300, 734);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button highscoreButton;
        private System.Windows.Forms.Button howButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button flipperButton;
    }
}
