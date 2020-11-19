namespace UIFromHell
{
    partial class page1
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
            this.components = new System.ComponentModel.Container();
            this.nameText = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorText = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.page1Panel = new System.Windows.Forms.Panel();
            this.open2Btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.Label();
            this.page2Timer = new System.Windows.Forms.Timer(this.components);
            this.openBtnBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.page1Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(88, 7);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 0;
            this.nameText.Text = "                    ";
            this.nameText.TextChanged += new System.EventHandler(this.nameTextChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(227, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(199, 13);
            this.title.TabIndex = 1;
            this.title.Text = "Complete this form to win $100,000,000!!";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.Red;
            this.nameLabel.Location = new System.Drawing.Point(50, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.Color.Red;
            this.emailLabel.Location = new System.Drawing.Point(50, 40);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email:";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(88, 33);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(100, 20);
            this.emailText.TabIndex = 3;
            this.emailText.Text = "                                      ";
            this.emailText.TextChanged += new System.EventHandler(this.emailTextChanged);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.ForeColor = System.Drawing.Color.Red;
            this.colorLabel.Location = new System.Drawing.Point(10, 92);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(75, 13);
            this.colorLabel.TabIndex = 8;
            this.colorLabel.Text = "Favorite Color:";
            // 
            // colorText
            // 
            this.colorText.Location = new System.Drawing.Point(88, 85);
            this.colorText.Name = "colorText";
            this.colorText.Size = new System.Drawing.Size(100, 20);
            this.colorText.TabIndex = 7;
            this.colorText.Text = "                   ";
            this.colorText.TextChanged += new System.EventHandler(this.colorTextChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneLabel.Location = new System.Drawing.Point(4, 66);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(88, 59);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(100, 20);
            this.phoneText.TabIndex = 5;
            this.phoneText.Text = "                                   ";
            this.phoneText.TextChanged += new System.EventHandler(this.phoneTextChanged);
            // 
            // page1Panel
            // 
            this.page1Panel.Controls.Add(this.emailLabel);
            this.page1Panel.Controls.Add(this.colorLabel);
            this.page1Panel.Controls.Add(this.nameText);
            this.page1Panel.Controls.Add(this.colorText);
            this.page1Panel.Controls.Add(this.nameLabel);
            this.page1Panel.Controls.Add(this.phoneLabel);
            this.page1Panel.Controls.Add(this.emailText);
            this.page1Panel.Controls.Add(this.phoneText);
            this.page1Panel.Location = new System.Drawing.Point(91, 118);
            this.page1Panel.Name = "page1Panel";
            this.page1Panel.Size = new System.Drawing.Size(199, 112);
            this.page1Panel.TabIndex = 9;
            // 
            // open2Btn
            // 
            this.open2Btn.Enabled = false;
            this.open2Btn.Location = new System.Drawing.Point(456, 118);
            this.open2Btn.Name = "open2Btn";
            this.open2Btn.Size = new System.Drawing.Size(112, 112);
            this.open2Btn.TabIndex = 10;
            this.open2Btn.Text = "Open Page 2";
            this.open2Btn.UseVisualStyleBackColor = true;
            this.open2Btn.Click += new System.EventHandler(this.openPage2Clicked);
            this.open2Btn.MouseEnter += new System.EventHandler(this.page2Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 236);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateChanged);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(113, 259);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(153, 13);
            this.date.TabIndex = 12;
            this.date.Text = "ENTER YESTERDAY\'S DATE";
            // 
            // page2Timer
            // 
            this.page2Timer.Interval = 1000;
            // 
            // openBtnBtn
            // 
            this.openBtnBtn.Location = new System.Drawing.Point(32, 37);
            this.openBtnBtn.Name = "openBtnBtn";
            this.openBtnBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtnBtn.TabIndex = 14;
            this.openBtnBtn.Text = "Give it back!";
            this.openBtnBtn.UseVisualStyleBackColor = true;
            this.openBtnBtn.Visible = false;
            this.openBtnBtn.Click += new System.EventHandler(this.btnBtnClicked);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(144, 275);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(100, 23);
            this.submitBtn.TabIndex = 15;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitClicked);
            this.submitBtn.MouseEnter += new System.EventHandler(this.submitEnter);
            // 
            // page1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 378);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.openBtnBtn);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.open2Btn);
            this.Controls.Add(this.page1Panel);
            this.Controls.Add(this.title);
            this.Name = "page1";
            this.Text = "Win the Money!";
            this.page1Panel.ResumeLayout(false);
            this.page1Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TextBox colorText;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Panel page1Panel;
        private System.Windows.Forms.Button open2Btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Timer page2Timer;
        private System.Windows.Forms.Button openBtnBtn;
        private System.Windows.Forms.Button submitBtn;
    }
}

