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
            this.howToTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
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
            this.Name = "HowScreen";
            this.Size = new System.Drawing.Size(1300, 730);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HowScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HowScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.HowScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer howToTimer;
    }
}
