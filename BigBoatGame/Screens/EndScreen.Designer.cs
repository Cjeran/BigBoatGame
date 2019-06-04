namespace BigBoatGame.Screens
{
    partial class EndScreen
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
            this.continueButton = new System.Windows.Forms.Button();
            this.carrierBox = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carrierBox)).BeginInit();
            this.SuspendLayout();
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(826, 461);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(185, 54);
            this.continueButton.TabIndex = 0;
            this.continueButton.Text = "CONTINUE";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // carrierBox
            // 
            this.carrierBox.BackgroundImage = global::BigBoatGame.Properties.Resources.Dauntless_Down;
            this.carrierBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carrierBox.Location = new System.Drawing.Point(140, 132);
            this.carrierBox.Name = "carrierBox";
            this.carrierBox.Size = new System.Drawing.Size(168, 350);
            this.carrierBox.TabIndex = 1;
            this.carrierBox.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(423, 132);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(293, 55);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "la ywyeyy";
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.carrierBox);
            this.Controls.Add(this.continueButton);
            this.Name = "EndScreen";
            this.Size = new System.Drawing.Size(1300, 730);
            ((System.ComponentModel.ISupportInitialize)(this.carrierBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.PictureBox carrierBox;
        private System.Windows.Forms.Label scoreLabel;
    }
}
