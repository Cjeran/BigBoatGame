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
            this.fLabel = new System.Windows.Forms.Label();
            this.sLabel = new System.Windows.Forms.Label();
            this.lLabel = new System.Windows.Forms.Label();
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
            // fLabel
            // 
            this.fLabel.Font = new System.Drawing.Font("Kuenst480 Blk BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel.Location = new System.Drawing.Point(704, 223);
            this.fLabel.Name = "fLabel";
            this.fLabel.Size = new System.Drawing.Size(70, 75);
            this.fLabel.TabIndex = 3;
            this.fLabel.Text = "A";
            // 
            // sLabel
            // 
            this.sLabel.Font = new System.Drawing.Font("Kuenst480 Blk BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLabel.Location = new System.Drawing.Point(813, 223);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(70, 75);
            this.sLabel.TabIndex = 4;
            this.sLabel.Text = "A";
            // 
            // lLabel
            // 
            this.lLabel.Font = new System.Drawing.Font("Kuenst480 Blk BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLabel.Location = new System.Drawing.Point(922, 223);
            this.lLabel.Name = "lLabel";
            this.lLabel.Size = new System.Drawing.Size(70, 75);
            this.lLabel.TabIndex = 5;
            this.lLabel.Text = "A";
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lLabel);
            this.Controls.Add(this.sLabel);
            this.Controls.Add(this.fLabel);
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
        private System.Windows.Forms.Label fLabel;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.Label lLabel;
    }
}
