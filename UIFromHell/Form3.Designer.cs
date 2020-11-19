namespace UIFromHell
{
    partial class Form3
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
            this.successLabel = new System.Windows.Forms.Label();
            this.duckPicture = new System.Windows.Forms.PictureBox();
            this.crapLabel = new System.Windows.Forms.Label();
            this.noClickLabel = new System.Windows.Forms.Label();
            this.threadLabel = new System.Windows.Forms.Label();
            this.duckPicture2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.duckPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duckPicture2)).BeginInit();
            this.SuspendLayout();
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Location = new System.Drawing.Point(11, 19);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(366, 13);
            this.successLabel.TabIndex = 0;
            this.successLabel.Text = "YOU DID IT! I don\'t have money for you, but here\'s a cool picture of a duck.";
            // 
            // duckPicture
            // 
            this.duckPicture.Image = global::UIFromHell.Properties.Resources.duck_run;
            this.duckPicture.Location = new System.Drawing.Point(104, 57);
            this.duckPicture.Name = "duckPicture";
            this.duckPicture.Size = new System.Drawing.Size(175, 178);
            this.duckPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.duckPicture.TabIndex = 1;
            this.duckPicture.TabStop = false;
            this.duckPicture.Click += new System.EventHandler(this.duckClicked);
            // 
            // crapLabel
            // 
            this.crapLabel.AutoSize = true;
            this.crapLabel.Location = new System.Drawing.Point(58, 138);
            this.crapLabel.Name = "crapLabel";
            this.crapLabel.Size = new System.Drawing.Size(266, 13);
            this.crapLabel.TabIndex = 2;
            this.crapLabel.Text = "I guess curiosity killed the duck. How do you feel now?";
            this.crapLabel.Visible = false;
            // 
            // noClickLabel
            // 
            this.noClickLabel.AutoSize = true;
            this.noClickLabel.Location = new System.Drawing.Point(142, 41);
            this.noClickLabel.Name = "noClickLabel";
            this.noClickLabel.Size = new System.Drawing.Size(95, 13);
            this.noClickLabel.TabIndex = 3;
            this.noClickLabel.Text = "DO NOT CLICK IT";
            // 
            // threadLabel
            // 
            this.threadLabel.AutoSize = true;
            this.threadLabel.Location = new System.Drawing.Point(153, 161);
            this.threadLabel.Name = "threadLabel";
            this.threadLabel.Size = new System.Drawing.Size(0, 13);
            this.threadLabel.TabIndex = 4;
            // 
            // duckPicture2
            // 
            this.duckPicture2.Image = global::UIFromHell.Properties.Resources.duck_run;
            this.duckPicture2.Location = new System.Drawing.Point(-33, 161);
            this.duckPicture2.Name = "duckPicture2";
            this.duckPicture2.Size = new System.Drawing.Size(168, 115);
            this.duckPicture2.TabIndex = 5;
            this.duckPicture2.TabStop = false;
            this.duckPicture2.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 259);
            this.Controls.Add(this.duckPicture2);
            this.Controls.Add(this.threadLabel);
            this.Controls.Add(this.noClickLabel);
            this.Controls.Add(this.crapLabel);
            this.Controls.Add(this.duckPicture);
            this.Controls.Add(this.successLabel);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.duckPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duckPicture2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.PictureBox duckPicture;
        private System.Windows.Forms.Label crapLabel;
        private System.Windows.Forms.Label noClickLabel;
        private System.Windows.Forms.Label threadLabel;
        private System.Windows.Forms.PictureBox duckPicture2;
    }
}