namespace BigBoatGame.Screens
{
    partial class HowScreen
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
            this.components = new System.ComponentModel.Container();
            this.menuButton = new System.Windows.Forms.Button();
            this.howToTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(886, 511);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(215, 53);
            this.menuButton.TabIndex = 0;
            this.menuButton.Text = "Back To Hangar";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            this.menuButton.Paint += new System.Windows.Forms.PaintEventHandler(this.menuButton_Paint);
            // 
            // howToTimer
            // 
            this.howToTimer.Interval = 16;
            this.howToTimer.Tick += new System.EventHandler(this.howToTimer_Tick);
            // 
            // HowScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.Controls.Add(this.menuButton);
            this.Name = "HowScreen";
            this.Size = new System.Drawing.Size(1300, 730);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HowScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.HowScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Timer howToTimer;
    }
}
