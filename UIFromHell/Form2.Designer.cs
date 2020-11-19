namespace UIFromHell
{
    partial class Quiz
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
            this.mathBox = new System.Windows.Forms.GroupBox();
            this.wordBox = new System.Windows.Forms.GroupBox();
            this.mathButton1 = new System.Windows.Forms.RadioButton();
            this.mathButton2 = new System.Windows.Forms.RadioButton();
            this.mathButton3 = new System.Windows.Forms.RadioButton();
            this.hairButton1 = new System.Windows.Forms.RadioButton();
            this.hairButton2 = new System.Windows.Forms.RadioButton();
            this.hairButton3 = new System.Windows.Forms.RadioButton();
            this.quizLabel = new System.Windows.Forms.Label();
            this.mathBox.SuspendLayout();
            this.wordBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mathBox
            // 
            this.mathBox.Controls.Add(this.mathButton3);
            this.mathBox.Controls.Add(this.mathButton2);
            this.mathBox.Controls.Add(this.mathButton1);
            this.mathBox.Location = new System.Drawing.Point(12, 60);
            this.mathBox.Name = "mathBox";
            this.mathBox.Size = new System.Drawing.Size(111, 100);
            this.mathBox.TabIndex = 0;
            this.mathBox.TabStop = false;
            this.mathBox.Text = "What is 2 plus 2?";
            // 
            // wordBox
            // 
            this.wordBox.Controls.Add(this.hairButton3);
            this.wordBox.Controls.Add(this.hairButton2);
            this.wordBox.Controls.Add(this.hairButton1);
            this.wordBox.Location = new System.Drawing.Point(152, 60);
            this.wordBox.Name = "wordBox";
            this.wordBox.Size = new System.Drawing.Size(137, 100);
            this.wordBox.TabIndex = 0;
            this.wordBox.TabStop = false;
            this.wordBox.Text = "How\'s my hair?";
            this.wordBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // mathButton1
            // 
            this.mathButton1.AutoSize = true;
            this.mathButton1.Location = new System.Drawing.Point(7, 20);
            this.mathButton1.Name = "mathButton1";
            this.mathButton1.Size = new System.Drawing.Size(43, 17);
            this.mathButton1.TabIndex = 0;
            this.mathButton1.TabStop = true;
            this.mathButton1.Text = "100";
            this.mathButton1.UseVisualStyleBackColor = true;
            // 
            // mathButton2
            // 
            this.mathButton2.AutoSize = true;
            this.mathButton2.Location = new System.Drawing.Point(7, 44);
            this.mathButton2.Name = "mathButton2";
            this.mathButton2.Size = new System.Drawing.Size(31, 17);
            this.mathButton2.TabIndex = 1;
            this.mathButton2.TabStop = true;
            this.mathButton2.Text = "4";
            this.mathButton2.UseVisualStyleBackColor = true;
            // 
            // mathButton3
            // 
            this.mathButton3.AutoSize = true;
            this.mathButton3.Location = new System.Drawing.Point(7, 68);
            this.mathButton3.Name = "mathButton3";
            this.mathButton3.Size = new System.Drawing.Size(31, 17);
            this.mathButton3.TabIndex = 2;
            this.mathButton3.TabStop = true;
            this.mathButton3.Text = "7";
            this.mathButton3.UseVisualStyleBackColor = true;
            this.mathButton3.CheckedChanged += new System.EventHandler(this.sevenChanged);
            // 
            // hairButton1
            // 
            this.hairButton1.AutoSize = true;
            this.hairButton1.Location = new System.Drawing.Point(7, 20);
            this.hairButton1.Name = "hairButton1";
            this.hairButton1.Size = new System.Drawing.Size(99, 17);
            this.hairButton1.TabIndex = 0;
            this.hairButton1.TabStop = true;
            this.hairButton1.Text = "Looks amazing!";
            this.hairButton1.UseVisualStyleBackColor = true;
            // 
            // hairButton2
            // 
            this.hairButton2.AutoSize = true;
            this.hairButton2.Location = new System.Drawing.Point(7, 44);
            this.hairButton2.Name = "hairButton2";
            this.hairButton2.Size = new System.Drawing.Size(121, 17);
            this.hairButton2.TabIndex = 1;
            this.hairButton2.TabStop = true;
            this.hairButton2.Text = "AWFUL! HIDEOUS!";
            this.hairButton2.UseVisualStyleBackColor = true;
            // 
            // hairButton3
            // 
            this.hairButton3.AllowDrop = true;
            this.hairButton3.AutoSize = true;
            this.hairButton3.Location = new System.Drawing.Point(7, 68);
            this.hairButton3.Name = "hairButton3";
            this.hairButton3.Size = new System.Drawing.Size(68, 17);
            this.hairButton3.TabIndex = 2;
            this.hairButton3.TabStop = true;
            this.hairButton3.Text = "Average.";
            this.hairButton3.UseVisualStyleBackColor = true;
            this.hairButton3.CheckedChanged += new System.EventHandler(this.avgChanged);
            // 
            // quizLabel
            // 
            this.quizLabel.AutoSize = true;
            this.quizLabel.Location = new System.Drawing.Point(52, 22);
            this.quizLabel.Name = "quizLabel";
            this.quizLabel.Size = new System.Drawing.Size(190, 13);
            this.quizLabel.TabIndex = 1;
            this.quizLabel.Text = "Pick incorrectly, but not too incorrectly!";
            this.quizLabel.Click += new System.EventHandler(this.quizLabel_Click);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 204);
            this.ControlBox = false;
            this.Controls.Add(this.quizLabel);
            this.Controls.Add(this.wordBox);
            this.Controls.Add(this.mathBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Quiz";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            this.mathBox.ResumeLayout(false);
            this.mathBox.PerformLayout();
            this.wordBox.ResumeLayout(false);
            this.wordBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mathBox;
        private System.Windows.Forms.GroupBox wordBox;
        private System.Windows.Forms.RadioButton mathButton3;
        private System.Windows.Forms.RadioButton mathButton2;
        private System.Windows.Forms.RadioButton mathButton1;
        private System.Windows.Forms.RadioButton hairButton3;
        private System.Windows.Forms.RadioButton hairButton2;
        private System.Windows.Forms.RadioButton hairButton1;
        private System.Windows.Forms.Label quizLabel;
    }
}