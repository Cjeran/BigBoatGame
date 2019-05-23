namespace BigBoatGame.Screens
{
    partial class HighScreen
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
            this.highLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.Location = new System.Drawing.Point(594, 235);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(46, 13);
            this.highLabel.TabIndex = 0;
            this.highLabel.Text = "hightime";
            // 
            // scoreLabel
            // 
            this.scoreLabel.Location = new System.Drawing.Point(112, 106);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(183, 324);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "label1";
            // 
            // HighScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.highLabel);
            this.Name = "HighScreen";
            this.Size = new System.Drawing.Size(1300, 750);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label scoreLabel;
    }
}
