namespace Presidents
{
    partial class PresidentsForm
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.harrisonRadio = new System.Windows.Forms.RadioButton();
            this.harrisonText = new System.Windows.Forms.TextBox();
            this.fdrText = new System.Windows.Forms.TextBox();
            this.fdrRadio = new System.Windows.Forms.RadioButton();
            this.clintonText = new System.Windows.Forms.TextBox();
            this.clintonRadio = new System.Windows.Forms.RadioButton();
            this.buchananText = new System.Windows.Forms.TextBox();
            this.buchananRadio = new System.Windows.Forms.RadioButton();
            this.mckinleyText = new System.Windows.Forms.TextBox();
            this.mckinleyRadio = new System.Windows.Forms.RadioButton();
            this.reaganText = new System.Windows.Forms.TextBox();
            this.reaganRadio = new System.Windows.Forms.RadioButton();
            this.eisenhowerText = new System.Windows.Forms.TextBox();
            this.eisenhowerRadio = new System.Windows.Forms.RadioButton();
            this.burenText = new System.Windows.Forms.TextBox();
            this.burenRadio = new System.Windows.Forms.RadioButton();
            this.pierceText = new System.Windows.Forms.TextBox();
            this.pierceRadio = new System.Windows.Forms.RadioButton();
            this.bushText = new System.Windows.Forms.TextBox();
            this.bushRadio = new System.Windows.Forms.RadioButton();
            this.obamaText = new System.Windows.Forms.TextBox();
            this.obamaRadio = new System.Windows.Forms.RadioButton();
            this.kennedyText = new System.Windows.Forms.TextBox();
            this.kennedyRadio = new System.Windows.Forms.RadioButton();
            this.washingtonText = new System.Windows.Forms.TextBox();
            this.washingtonRadio = new System.Windows.Forms.RadioButton();
            this.adamsText = new System.Windows.Forms.TextBox();
            this.adamsRadio = new System.Windows.Forms.RadioButton();
            this.teddyText = new System.Windows.Forms.TextBox();
            this.teddyRadio = new System.Windows.Forms.RadioButton();
            this.jeffersonText = new System.Windows.Forms.TextBox();
            this.jeffersonRadio = new System.Windows.Forms.RadioButton();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.presImage = new System.Windows.Forms.PictureBox();
            this.federalistRadio = new System.Windows.Forms.RadioButton();
            this.drRadio = new System.Windows.Forms.RadioButton();
            this.republicanRadio = new System.Windows.Forms.RadioButton();
            this.democratRadio = new System.Windows.Forms.RadioButton();
            this.allRadio = new System.Windows.Forms.RadioButton();
            this.filterPanel = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerBar = new System.Windows.Forms.ProgressBar();
            this.presError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.presImage)).BeginInit();
            this.filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presError)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Enabled = false;
            this.exitBtn.Location = new System.Drawing.Point(847, 566);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // harrisonRadio
            // 
            this.harrisonRadio.AutoSize = true;
            this.harrisonRadio.Location = new System.Drawing.Point(13, 13);
            this.harrisonRadio.Name = "harrisonRadio";
            this.harrisonRadio.Size = new System.Drawing.Size(110, 17);
            this.harrisonRadio.TabIndex = 0;
            this.harrisonRadio.TabStop = true;
            this.harrisonRadio.Tag = "presButtons";
            this.harrisonRadio.Text = "Benjamin Harrison";
            this.harrisonRadio.UseVisualStyleBackColor = true;
            this.harrisonRadio.CheckedChanged += new System.EventHandler(this.presButtons_CheckedChanged);
            // 
            // harrisonText
            // 
            this.harrisonText.Location = new System.Drawing.Point(139, 12);
            this.harrisonText.Name = "harrisonText";
            this.harrisonText.Size = new System.Drawing.Size(23, 20);
            this.harrisonText.TabIndex = 1;
            this.harrisonText.Tag = "presText";
            this.harrisonText.Text = "0";
            this.harrisonText.TextChanged += new System.EventHandler(this.harrisonTextChange);
            // 
            // fdrText
            // 
            this.fdrText.Location = new System.Drawing.Point(139, 35);
            this.fdrText.Name = "fdrText";
            this.fdrText.Size = new System.Drawing.Size(23, 20);
            this.fdrText.TabIndex = 3;
            this.fdrText.Tag = "presText";
            this.fdrText.Text = "0";
            this.fdrText.TextChanged += new System.EventHandler(this.fdrTextChange);
            // 
            // fdrRadio
            // 
            this.fdrRadio.AutoSize = true;
            this.fdrRadio.Location = new System.Drawing.Point(12, 35);
            this.fdrRadio.Name = "fdrRadio";
            this.fdrRadio.Size = new System.Drawing.Size(124, 17);
            this.fdrRadio.TabIndex = 2;
            this.fdrRadio.TabStop = true;
            this.fdrRadio.Tag = "presButtons";
            this.fdrRadio.Text = "Franklin D Roosevelt";
            this.fdrRadio.UseVisualStyleBackColor = true;
            this.fdrRadio.CheckedChanged += new System.EventHandler(this.presButtons_CheckedChanged);
            // 
            // clintonText
            // 
            this.clintonText.Location = new System.Drawing.Point(139, 58);
            this.clintonText.Name = "clintonText";
            this.clintonText.Size = new System.Drawing.Size(23, 20);
            this.clintonText.TabIndex = 5;
            this.clintonText.Tag = "presText";
            this.clintonText.Text = "0";
            this.clintonText.TextChanged += new System.EventHandler(this.clintonTextChange);
            // 
            // clintonRadio
            // 
            this.clintonRadio.AutoSize = true;
            this.clintonRadio.Location = new System.Drawing.Point(13, 59);
            this.clintonRadio.Name = "clintonRadio";
            this.clintonRadio.Size = new System.Drawing.Size(101, 17);
            this.clintonRadio.TabIndex = 4;
            this.clintonRadio.TabStop = true;
            this.clintonRadio.Tag = "presButtons";
            this.clintonRadio.Text = "William J Clinton";
            this.clintonRadio.UseVisualStyleBackColor = true;
            this.clintonRadio.CheckedChanged += new System.EventHandler(this.presButtons_CheckedChanged);
            // 
            // buchananText
            // 
            this.buchananText.Location = new System.Drawing.Point(139, 81);
            this.buchananText.Name = "buchananText";
            this.buchananText.Size = new System.Drawing.Size(23, 20);
            this.buchananText.TabIndex = 7;
            this.buchananText.Tag = "presText";
            this.buchananText.Text = "0";
            this.buchananText.TextChanged += new System.EventHandler(this.buchananTextChange);
            // 
            // buchananRadio
            // 
            this.buchananRadio.AutoSize = true;
            this.buchananRadio.Location = new System.Drawing.Point(13, 82);
            this.buchananRadio.Name = "buchananRadio";
            this.buchananRadio.Size = new System.Drawing.Size(107, 17);
            this.buchananRadio.TabIndex = 6;
            this.buchananRadio.TabStop = true;
            this.buchananRadio.Tag = "presButtons";
            this.buchananRadio.Text = "James Buchanan";
            this.buchananRadio.UseVisualStyleBackColor = true;
            this.buchananRadio.CheckedChanged += new System.EventHandler(this.presButtons_CheckedChanged);
            // 
            // mckinleyText
            // 
            this.mckinleyText.Location = new System.Drawing.Point(297, 13);
            this.mckinleyText.Name = "mckinleyText";
            this.mckinleyText.Size = new System.Drawing.Size(23, 20);
            this.mckinleyText.TabIndex = 9;
            this.mckinleyText.Text = "0";
            this.mckinleyText.TextChanged += new System.EventHandler(this.mckinleyTextChange);
            // 
            // mckinleyRadio
            // 
            this.mckinleyRadio.AutoSize = true;
            this.mckinleyRadio.Location = new System.Drawing.Point(168, 13);
            this.mckinleyRadio.Name = "mckinleyRadio";
            this.mckinleyRadio.Size = new System.Drawing.Size(104, 17);
            this.mckinleyRadio.TabIndex = 8;
            this.mckinleyRadio.TabStop = true;
            this.mckinleyRadio.Tag = "presButtons";
            this.mckinleyRadio.Text = "William McKinley";
            this.mckinleyRadio.UseVisualStyleBackColor = true;
            this.mckinleyRadio.CheckedChanged += new System.EventHandler(this.presButtons_CheckedChanged);
            // 
            // reaganText
            // 
            this.reaganText.Location = new System.Drawing.Point(297, 36);
            this.reaganText.Name = "reaganText";
            this.reaganText.Size = new System.Drawing.Size(23, 20);
            this.reaganText.TabIndex = 11;
            this.reaganText.Text = "0";
            this.reaganText.TextChanged += new System.EventHandler(this.reaganTextChange);
            // 
            // reaganRadio
            // 
            this.reaganRadio.AutoSize = true;
            this.reaganRadio.Location = new System.Drawing.Point(168, 36);
            this.reaganRadio.Name = "reaganRadio";
            this.reaganRadio.Size = new System.Drawing.Size(100, 17);
            this.reaganRadio.TabIndex = 10;
            this.reaganRadio.TabStop = true;
            this.reaganRadio.Tag = "presButtons";
            this.reaganRadio.Text = "Ronald Reagan";
            this.reaganRadio.UseVisualStyleBackColor = true;
            this.reaganRadio.CheckedChanged += new System.EventHandler(this.presButtons_CheckedChanged);
            // 
            // eisenhowerText
            // 
            this.eisenhowerText.Location = new System.Drawing.Point(297, 59);
            this.eisenhowerText.Name = "eisenhowerText";
            this.eisenhowerText.Size = new System.Drawing.Size(23, 20);
            this.eisenhowerText.TabIndex = 13;
            this.eisenhowerText.Text = "0";
            this.eisenhowerText.TextChanged += new System.EventHandler(this.eisenhowerTextChange);
            // 
            // eisenhowerRadio
            // 
            this.eisenhowerRadio.AutoSize = true;
            this.eisenhowerRadio.Location = new System.Drawing.Point(168, 59);
            this.eisenhowerRadio.Name = "eisenhowerRadio";
            this.eisenhowerRadio.Size = new System.Drawing.Size(127, 17);
            this.eisenhowerRadio.TabIndex = 12;
            this.eisenhowerRadio.TabStop = true;
            this.eisenhowerRadio.Tag = "presButtons";
            this.eisenhowerRadio.Text = "Dwight D Eisenhower";
            this.eisenhowerRadio.UseVisualStyleBackColor = true;
            this.eisenhowerRadio.CheckedChanged += new System.EventHandler(this.presButtons_CheckedChanged);
            // 
            // burenText
            // 
            this.burenText.Location = new System.Drawing.Point(297, 82);
            this.burenText.Name = "burenText";
            this.burenText.Size = new System.Drawing.Size(23, 20);
            this.burenText.TabIndex = 15;
            this.burenText.Text = "0";
            this.burenText.TextChanged += new System.EventHandler(this.burenTextChange);
            // 
            // burenRadio
            // 
            this.burenRadio.AutoSize = true;
            this.burenRadio.Location = new System.Drawing.Point(168, 82);
            this.burenRadio.Name = "burenRadio";
            this.burenRadio.Size = new System.Drawing.Size(107, 17);
            this.burenRadio.TabIndex = 14;
            this.burenRadio.TabStop = true;
            this.burenRadio.Tag = "presButtons";
            this.burenRadio.Text = "Martin Van Buren";
            this.burenRadio.UseVisualStyleBackColor = true;
            this.burenRadio.CheckedChanged += new System.EventHandler(this.presButtons_CheckedChanged);
            // 
            // pierceText
            // 
            this.pierceText.Location = new System.Drawing.Point(139, 104);
            this.pierceText.Name = "pierceText";
            this.pierceText.Size = new System.Drawing.Size(23, 20);
            this.pierceText.TabIndex = 17;
            this.pierceText.Text = "0";
            this.pierceText.TextChanged += new System.EventHandler(this.pierceTextChange);
            // 
            // pierceRadio
            // 
            this.pierceRadio.AutoSize = true;
            this.pierceRadio.Location = new System.Drawing.Point(13, 105);
            this.pierceRadio.Name = "pierceRadio";
            this.pierceRadio.Size = new System.Drawing.Size(95, 17);
            this.pierceRadio.TabIndex = 16;
            this.pierceRadio.TabStop = true;
            this.pierceRadio.Tag = "presButtons";
            this.pierceRadio.Text = "Franklin Pierce";
            this.pierceRadio.UseVisualStyleBackColor = true;
            this.pierceRadio.CheckedChanged += new System.EventHandler(this.presButtons_CheckedChanged);
            // 
            // bushText
            // 
            this.bushText.Location = new System.Drawing.Point(139, 127);
            this.bushText.Name = "bushText";
            this.bushText.Size = new System.Drawing.Size(23, 20);
            this.bushText.TabIndex = 19;
            this.bushText.Text = "0";
            this.bushText.TextChanged += new System.EventHandler(this.bushTextChange);
            // 
            // bushRadio
            // 
            this.bushRadio.AutoSize = true;
            this.bushRadio.Location = new System.Drawing.Point(13, 128);
            this.bushRadio.Name = "bushRadio";
            this.bushRadio.Size = new System.Drawing.Size(101, 17);
            this.bushRadio.TabIndex = 18;
            this.bushRadio.TabStop = true;
            this.bushRadio.Tag = "presButtons";
            this.bushRadio.Text = "George W Bush";
            this.bushRadio.UseVisualStyleBackColor = true;
            this.bushRadio.CheckedChanged += new System.EventHandler(this.presButtons_CheckedChanged);
            // 
            // obamaText
            // 
            this.obamaText.Location = new System.Drawing.Point(139, 150);
            this.obamaText.Name = "obamaText";
            this.obamaText.Size = new System.Drawing.Size(23, 20);
            this.obamaText.TabIndex = 21;
            this.obamaText.Text = "0";
            this.obamaText.TextChanged += new System.EventHandler(this.obamaTextChange);
            // 
            // obamaRadio
            // 
            this.obamaRadio.AutoSize = true;
            this.obamaRadio.Location = new System.Drawing.Point(13, 151);
            this.obamaRadio.Name = "obamaRadio";
            this.obamaRadio.Size = new System.Drawing.Size(96, 17);
            this.obamaRadio.TabIndex = 20;
            this.obamaRadio.TabStop = true;
            this.obamaRadio.Tag = "presButtons";
            this.obamaRadio.Text = "Barack Obama";
            this.obamaRadio.UseVisualStyleBackColor = true;
            this.obamaRadio.CheckedChanged += new System.EventHandler(this.presButtons_CheckedChanged);
            // 
            // kennedyText
            // 
            this.kennedyText.Location = new System.Drawing.Point(139, 173);
            this.kennedyText.Name = "kennedyText";
            this.kennedyText.Size = new System.Drawing.Size(23, 20);
            this.kennedyText.TabIndex = 23;
            this.kennedyText.Text = "0";
            this.kennedyText.TextChanged += new System.EventHandler(this.kennedyTextChange);
            // 
            // kennedyRadio
            // 
            this.kennedyRadio.AutoSize = true;
            this.kennedyRadio.Location = new System.Drawing.Point(13, 174);
            this.kennedyRadio.Name = "kennedyRadio";
            this.kennedyRadio.Size = new System.Drawing.Size(102, 17);
            this.kennedyRadio.TabIndex = 22;
            this.kennedyRadio.TabStop = true;
            this.kennedyRadio.Tag = "presButtons";
            this.kennedyRadio.Text = "John F Kennedy";
            this.kennedyRadio.UseVisualStyleBackColor = true;
            this.kennedyRadio.CheckedChanged += new System.EventHandler(this.presButtons_CheckedChanged);
            // 
            // washingtonText
            // 
            this.washingtonText.Location = new System.Drawing.Point(297, 105);
            this.washingtonText.Name = "washingtonText";
            this.washingtonText.Size = new System.Drawing.Size(23, 20);
            this.washingtonText.TabIndex = 25;
            this.washingtonText.Text = "0";
            this.washingtonText.TextChanged += new System.EventHandler(this.washingtonTextChange);
            // 
            // washingtonRadio
            // 
            this.washingtonRadio.AutoSize = true;
            this.washingtonRadio.Location = new System.Drawing.Point(168, 105);
            this.washingtonRadio.Name = "washingtonRadio";
            this.washingtonRadio.Size = new System.Drawing.Size(120, 17);
            this.washingtonRadio.TabIndex = 24;
            this.washingtonRadio.TabStop = true;
            this.washingtonRadio.Tag = "presButtons";
            this.washingtonRadio.Text = "George Washington";
            this.washingtonRadio.UseVisualStyleBackColor = true;
            this.washingtonRadio.CheckedChanged += new System.EventHandler(this.presButtons_CheckedChanged);
            // 
            // adamsText
            // 
            this.adamsText.Location = new System.Drawing.Point(297, 128);
            this.adamsText.Name = "adamsText";
            this.adamsText.Size = new System.Drawing.Size(23, 20);
            this.adamsText.TabIndex = 27;
            this.adamsText.Text = "0";
            this.adamsText.TextChanged += new System.EventHandler(this.adamsTextChange);
            // 
            // adamsRadio
            // 
            this.adamsRadio.AutoSize = true;
            this.adamsRadio.Location = new System.Drawing.Point(168, 128);
            this.adamsRadio.Name = "adamsRadio";
            this.adamsRadio.Size = new System.Drawing.Size(83, 17);
            this.adamsRadio.TabIndex = 26;
            this.adamsRadio.TabStop = true;
            this.adamsRadio.Tag = "presButtons";
            this.adamsRadio.Text = "John Adams";
            this.adamsRadio.UseVisualStyleBackColor = true;
            this.adamsRadio.CheckedChanged += new System.EventHandler(this.presButtons_CheckedChanged);
            // 
            // teddyText
            // 
            this.teddyText.Location = new System.Drawing.Point(297, 151);
            this.teddyText.Name = "teddyText";
            this.teddyText.Size = new System.Drawing.Size(23, 20);
            this.teddyText.TabIndex = 29;
            this.teddyText.Text = "0";
            this.teddyText.TextChanged += new System.EventHandler(this.teddyTextChange);
            // 
            // teddyRadio
            // 
            this.teddyRadio.AutoSize = true;
            this.teddyRadio.Location = new System.Drawing.Point(168, 151);
            this.teddyRadio.Name = "teddyRadio";
            this.teddyRadio.Size = new System.Drawing.Size(122, 17);
            this.teddyRadio.TabIndex = 28;
            this.teddyRadio.TabStop = true;
            this.teddyRadio.Tag = "presButtons";
            this.teddyRadio.Text = "Theodore Roosevelt";
            this.teddyRadio.UseVisualStyleBackColor = true;
            this.teddyRadio.CheckedChanged += new System.EventHandler(this.presButtons_CheckedChanged);
            // 
            // jeffersonText
            // 
            this.jeffersonText.Location = new System.Drawing.Point(297, 174);
            this.jeffersonText.Name = "jeffersonText";
            this.jeffersonText.Size = new System.Drawing.Size(23, 20);
            this.jeffersonText.TabIndex = 31;
            this.jeffersonText.Text = "0";
            this.jeffersonText.TextChanged += new System.EventHandler(this.jeffersonTextChange);
            // 
            // jeffersonRadio
            // 
            this.jeffersonRadio.AutoSize = true;
            this.jeffersonRadio.Location = new System.Drawing.Point(168, 174);
            this.jeffersonRadio.Name = "jeffersonRadio";
            this.jeffersonRadio.Size = new System.Drawing.Size(109, 17);
            this.jeffersonRadio.TabIndex = 30;
            this.jeffersonRadio.TabStop = true;
            this.jeffersonRadio.Tag = "presButtons";
            this.jeffersonRadio.Text = "Thomas Jefferson";
            this.jeffersonRadio.UseVisualStyleBackColor = true;
            this.jeffersonRadio.CheckedChanged += new System.EventHandler(this.presButtons_CheckedChanged);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(343, 12);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(579, 536);
            this.webBrowser.TabIndex = 33;
            this.webBrowser.Url = new System.Uri("https://www.youtube.com/watch?v=18212B4yfLg", System.UriKind.Absolute);
            // 
            // presImage
            // 
            this.presImage.Image = global::Presidents.Properties.Resources.BenjaminHarrison;
            this.presImage.Location = new System.Drawing.Point(13, 212);
            this.presImage.Name = "presImage";
            this.presImage.Size = new System.Drawing.Size(124, 189);
            this.presImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.presImage.TabIndex = 34;
            this.presImage.TabStop = false;
            this.presImage.MouseEnter += new System.EventHandler(this.pictureEnter);
            this.presImage.MouseLeave += new System.EventHandler(this.pictureLeave);
            // 
            // federalistRadio
            // 
            this.federalistRadio.AutoSize = true;
            this.federalistRadio.Location = new System.Drawing.Point(13, 111);
            this.federalistRadio.Name = "federalistRadio";
            this.federalistRadio.Size = new System.Drawing.Size(70, 17);
            this.federalistRadio.TabIndex = 40;
            this.federalistRadio.TabStop = true;
            this.federalistRadio.Tag = "partyButtons";
            this.federalistRadio.Text = "Federalist";
            this.federalistRadio.UseVisualStyleBackColor = true;
            this.federalistRadio.CheckedChanged += new System.EventHandler(this.partyButtons_CheckedChanged);
            // 
            // drRadio
            // 
            this.drRadio.AutoSize = true;
            this.drRadio.Location = new System.Drawing.Point(13, 88);
            this.drRadio.Name = "drRadio";
            this.drRadio.Size = new System.Drawing.Size(136, 17);
            this.drRadio.TabIndex = 39;
            this.drRadio.TabStop = true;
            this.drRadio.Tag = "partyButtons";
            this.drRadio.Text = "Democratic-Republican";
            this.drRadio.UseVisualStyleBackColor = true;
            this.drRadio.CheckedChanged += new System.EventHandler(this.partyButtons_CheckedChanged);
            // 
            // republicanRadio
            // 
            this.republicanRadio.AutoSize = true;
            this.republicanRadio.Location = new System.Drawing.Point(13, 65);
            this.republicanRadio.Name = "republicanRadio";
            this.republicanRadio.Size = new System.Drawing.Size(79, 17);
            this.republicanRadio.TabIndex = 38;
            this.republicanRadio.TabStop = true;
            this.republicanRadio.Tag = "partyButtons";
            this.republicanRadio.Text = "Republican";
            this.republicanRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.republicanRadio.UseVisualStyleBackColor = true;
            this.republicanRadio.CheckedChanged += new System.EventHandler(this.partyButtons_CheckedChanged);
            // 
            // democratRadio
            // 
            this.democratRadio.AutoSize = true;
            this.democratRadio.Location = new System.Drawing.Point(13, 42);
            this.democratRadio.Name = "democratRadio";
            this.democratRadio.Size = new System.Drawing.Size(71, 17);
            this.democratRadio.TabIndex = 37;
            this.democratRadio.TabStop = true;
            this.democratRadio.Tag = "partyButtons";
            this.democratRadio.Text = "Democrat";
            this.democratRadio.UseVisualStyleBackColor = true;
            this.democratRadio.CheckedChanged += new System.EventHandler(this.partyButtons_CheckedChanged);
            // 
            // allRadio
            // 
            this.allRadio.AutoSize = true;
            this.allRadio.Location = new System.Drawing.Point(13, 19);
            this.allRadio.Name = "allRadio";
            this.allRadio.Size = new System.Drawing.Size(36, 17);
            this.allRadio.TabIndex = 0;
            this.allRadio.TabStop = true;
            this.allRadio.Tag = "partyButtons";
            this.allRadio.Text = "All";
            this.allRadio.UseVisualStyleBackColor = true;
            this.allRadio.CheckedChanged += new System.EventHandler(this.partyButtons_CheckedChanged);
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.federalistRadio);
            this.filterPanel.Controls.Add(this.allRadio);
            this.filterPanel.Controls.Add(this.drRadio);
            this.filterPanel.Controls.Add(this.democratRadio);
            this.filterPanel.Controls.Add(this.republicanRadio);
            this.filterPanel.Location = new System.Drawing.Point(168, 212);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(152, 140);
            this.filterPanel.TabIndex = 36;
            this.filterPanel.TabStop = false;
            this.filterPanel.Text = "Filter";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.tick);
            // 
            // timerBar
            // 
            this.timerBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timerBar.Location = new System.Drawing.Point(0, 597);
            this.timerBar.Maximum = 1200;
            this.timerBar.Name = "timerBar";
            this.timerBar.Size = new System.Drawing.Size(934, 23);
            this.timerBar.TabIndex = 38;
            // 
            // presError
            // 
            this.presError.ContainerControl = this;
            // 
            // PresidentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 620);
            this.Controls.Add(this.timerBar);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.presImage);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.jeffersonText);
            this.Controls.Add(this.jeffersonRadio);
            this.Controls.Add(this.teddyText);
            this.Controls.Add(this.teddyRadio);
            this.Controls.Add(this.adamsText);
            this.Controls.Add(this.adamsRadio);
            this.Controls.Add(this.washingtonText);
            this.Controls.Add(this.washingtonRadio);
            this.Controls.Add(this.kennedyText);
            this.Controls.Add(this.kennedyRadio);
            this.Controls.Add(this.obamaText);
            this.Controls.Add(this.obamaRadio);
            this.Controls.Add(this.bushText);
            this.Controls.Add(this.bushRadio);
            this.Controls.Add(this.pierceText);
            this.Controls.Add(this.pierceRadio);
            this.Controls.Add(this.burenText);
            this.Controls.Add(this.burenRadio);
            this.Controls.Add(this.eisenhowerText);
            this.Controls.Add(this.eisenhowerRadio);
            this.Controls.Add(this.reaganText);
            this.Controls.Add(this.reaganRadio);
            this.Controls.Add(this.mckinleyText);
            this.Controls.Add(this.mckinleyRadio);
            this.Controls.Add(this.buchananText);
            this.Controls.Add(this.buchananRadio);
            this.Controls.Add(this.clintonText);
            this.Controls.Add(this.clintonRadio);
            this.Controls.Add(this.fdrText);
            this.Controls.Add(this.fdrRadio);
            this.Controls.Add(this.harrisonText);
            this.Controls.Add(this.harrisonRadio);
            this.Controls.Add(this.exitBtn);
            this.Name = "PresidentsForm";
            this.Text = "PresidentsForm";
            this.Load += new System.EventHandler(this.PresidentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.presImage)).EndInit();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.RadioButton harrisonRadio;
        private System.Windows.Forms.TextBox harrisonText;
        private System.Windows.Forms.TextBox fdrText;
        private System.Windows.Forms.RadioButton fdrRadio;
        private System.Windows.Forms.TextBox clintonText;
        private System.Windows.Forms.RadioButton clintonRadio;
        private System.Windows.Forms.TextBox buchananText;
        private System.Windows.Forms.RadioButton buchananRadio;
        private System.Windows.Forms.TextBox mckinleyText;
        private System.Windows.Forms.RadioButton mckinleyRadio;
        private System.Windows.Forms.TextBox reaganText;
        private System.Windows.Forms.RadioButton reaganRadio;
        private System.Windows.Forms.TextBox eisenhowerText;
        private System.Windows.Forms.RadioButton eisenhowerRadio;
        private System.Windows.Forms.TextBox burenText;
        private System.Windows.Forms.RadioButton burenRadio;
        private System.Windows.Forms.TextBox pierceText;
        private System.Windows.Forms.RadioButton pierceRadio;
        private System.Windows.Forms.TextBox bushText;
        private System.Windows.Forms.RadioButton bushRadio;
        private System.Windows.Forms.TextBox obamaText;
        private System.Windows.Forms.RadioButton obamaRadio;
        private System.Windows.Forms.TextBox kennedyText;
        private System.Windows.Forms.RadioButton kennedyRadio;
        private System.Windows.Forms.TextBox washingtonText;
        private System.Windows.Forms.RadioButton washingtonRadio;
        private System.Windows.Forms.TextBox adamsText;
        private System.Windows.Forms.RadioButton adamsRadio;
        private System.Windows.Forms.TextBox teddyText;
        private System.Windows.Forms.RadioButton teddyRadio;
        private System.Windows.Forms.TextBox jeffersonText;
        private System.Windows.Forms.RadioButton jeffersonRadio;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.PictureBox presImage;
        private System.Windows.Forms.RadioButton allRadio;
        private System.Windows.Forms.RadioButton federalistRadio;
        private System.Windows.Forms.RadioButton drRadio;
        private System.Windows.Forms.RadioButton republicanRadio;
        private System.Windows.Forms.RadioButton democratRadio;
        private System.Windows.Forms.GroupBox filterPanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar timerBar;
        private System.Windows.Forms.ErrorProvider presError;
    }
}

