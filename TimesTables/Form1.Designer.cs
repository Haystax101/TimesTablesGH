namespace TimesTables
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblInstructions = new Label();
            txtAnswer = new TextBox();
            btnSubmit = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            lblTimeLeft = new Label();
            lblTitle = new Label();
            lblCorrect = new Label();
            lblIncorrect = new Label();
            lblResults = new Label();
            btnRestart = new Button();
            panel1 = new Panel();
            sadEmoji = new PictureBox();
            elatedEmoji = new PictureBox();
            happyEmoji = new PictureBox();
            clock55 = new PictureBox();
            clock50 = new PictureBox();
            clock45 = new PictureBox();
            clock40 = new PictureBox();
            clock35 = new PictureBox();
            clock30 = new PictureBox();
            clock25 = new PictureBox();
            clock20 = new PictureBox();
            clock15 = new PictureBox();
            clock60 = new PictureBox();
            clock10 = new PictureBox();
            clock5 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblNumOfQuestions = new Label();
            lbltbqnumber = new Label();
            tbNumOfQuestions = new TrackBar();
            btnBackSettings = new Button();
            lblIncludedTimesTablesTitle = new Label();
            checkedListBox1 = new CheckedListBox();
            lblSettingsTitle = new Label();
            menuStrip1 = new MenuStrip();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sadEmoji).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elatedEmoji).BeginInit();
            ((System.ComponentModel.ISupportInitialize)happyEmoji).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clock55).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clock50).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clock45).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clock40).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clock35).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clock30).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clock25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clock20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clock15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clock60).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clock10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clock5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbNumOfQuestions).BeginInit();
            SuspendLayout();
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblInstructions.ForeColor = Color.White;
            lblInstructions.Location = new Point(299, 98);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(252, 55);
            lblInstructions.TabIndex = 0;
            lblInstructions.Text = "9 x ? = 81 ";
            // 
            // txtAnswer
            // 
            txtAnswer.AcceptsReturn = true;
            txtAnswer.CharacterCasing = CharacterCasing.Upper;
            txtAnswer.Location = new Point(382, 191);
            txtAnswer.MaxLength = 2;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(42, 27);
            txtAnswer.TabIndex = 1;
            txtAnswer.KeyPress += CheckEnterKeyPress;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SlateBlue;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.ForeColor = SystemColors.Menu;
            btnSubmit.Location = new Point(366, 224);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 30);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(0, 192, 0);
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.Font = new Font("Broadway", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.DarkOliveGreen;
            btnStart.Location = new Point(350, 58);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 30);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lblTimeLeft
            // 
            lblTimeLeft.AutoSize = true;
            lblTimeLeft.Font = new Font("Imprint MT Shadow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimeLeft.ForeColor = Color.White;
            lblTimeLeft.Location = new Point(593, 382);
            lblTimeLeft.Name = "lblTimeLeft";
            lblTimeLeft.Size = new Size(0, 23);
            lblTimeLeft.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.GradientActiveCaption;
            lblTitle.Location = new Point(49, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(721, 52);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Enter the answers to the questions then press submit/enter. \r\n                         Get 10 before the time runs out!";
            // 
            // lblCorrect
            // 
            lblCorrect.AutoSize = true;
            lblCorrect.Font = new Font("Ravie", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorrect.ForeColor = Color.FromArgb(0, 192, 0);
            lblCorrect.Location = new Point(350, 163);
            lblCorrect.Name = "lblCorrect";
            lblCorrect.Size = new Size(109, 22);
            lblCorrect.TabIndex = 6;
            lblCorrect.Text = "Correct!";
            // 
            // lblIncorrect
            // 
            lblIncorrect.AutoSize = true;
            lblIncorrect.BackColor = Color.Transparent;
            lblIncorrect.Font = new Font("Ravie", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIncorrect.ForeColor = Color.Tomato;
            lblIncorrect.Location = new Point(348, 163);
            lblIncorrect.Name = "lblIncorrect";
            lblIncorrect.Size = new Size(123, 22);
            lblIncorrect.TabIndex = 7;
            lblIncorrect.Text = "Incorrect";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResults.ForeColor = Color.White;
            lblResults.Location = new Point(329, 278);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(0, 18);
            lblResults.TabIndex = 8;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.Purple;
            btnRestart.FlatStyle = FlatStyle.Popup;
            btnRestart.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRestart.ForeColor = Color.White;
            btnRestart.Location = new Point(338, 320);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(133, 29);
            btnRestart.TabIndex = 9;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(sadEmoji);
            panel1.Controls.Add(elatedEmoji);
            panel1.Controls.Add(happyEmoji);
            panel1.Controls.Add(clock55);
            panel1.Controls.Add(clock50);
            panel1.Controls.Add(clock45);
            panel1.Controls.Add(clock40);
            panel1.Controls.Add(clock35);
            panel1.Controls.Add(clock30);
            panel1.Controls.Add(clock25);
            panel1.Controls.Add(clock20);
            panel1.Controls.Add(clock15);
            panel1.Controls.Add(clock60);
            panel1.Controls.Add(clock10);
            panel1.Controls.Add(clock5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTimeLeft);
            panel1.Controls.Add(lblResults);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnRestart);
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(lblInstructions);
            panel1.Controls.Add(lblCorrect);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(lblIncorrect);
            panel1.Controls.Add(txtAnswer);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 10;
            // 
            // sadEmoji
            // 
            sadEmoji.BackgroundImage = (Image)resources.GetObject("sadEmoji.BackgroundImage");
            sadEmoji.BackgroundImageLayout = ImageLayout.Stretch;
            sadEmoji.Location = new Point(311, 94);
            sadEmoji.Name = "sadEmoji";
            sadEmoji.Size = new Size(191, 181);
            sadEmoji.TabIndex = 25;
            sadEmoji.TabStop = false;
            // 
            // elatedEmoji
            // 
            elatedEmoji.BackgroundImage = (Image)resources.GetObject("elatedEmoji.BackgroundImage");
            elatedEmoji.BackgroundImageLayout = ImageLayout.Stretch;
            elatedEmoji.Location = new Point(311, 94);
            elatedEmoji.Name = "elatedEmoji";
            elatedEmoji.Size = new Size(191, 181);
            elatedEmoji.TabIndex = 24;
            elatedEmoji.TabStop = false;
            // 
            // happyEmoji
            // 
            happyEmoji.BackgroundImage = (Image)resources.GetObject("happyEmoji.BackgroundImage");
            happyEmoji.BackgroundImageLayout = ImageLayout.Stretch;
            happyEmoji.InitialImage = (Image)resources.GetObject("happyEmoji.InitialImage");
            happyEmoji.Location = new Point(311, 94);
            happyEmoji.Name = "happyEmoji";
            happyEmoji.Size = new Size(191, 181);
            happyEmoji.TabIndex = 23;
            happyEmoji.TabStop = false;
            // 
            // clock55
            // 
            clock55.BackgroundImage = (Image)resources.GetObject("clock55.BackgroundImage");
            clock55.BackgroundImageLayout = ImageLayout.Stretch;
            clock55.BorderStyle = BorderStyle.Fixed3D;
            clock55.Location = new Point(708, 364);
            clock55.Name = "clock55";
            clock55.Size = new Size(80, 74);
            clock55.TabIndex = 22;
            clock55.TabStop = false;
            // 
            // clock50
            // 
            clock50.BackgroundImage = (Image)resources.GetObject("clock50.BackgroundImage");
            clock50.BackgroundImageLayout = ImageLayout.Stretch;
            clock50.BorderStyle = BorderStyle.Fixed3D;
            clock50.Location = new Point(708, 364);
            clock50.Name = "clock50";
            clock50.Size = new Size(80, 74);
            clock50.TabIndex = 21;
            clock50.TabStop = false;
            // 
            // clock45
            // 
            clock45.BackgroundImage = (Image)resources.GetObject("clock45.BackgroundImage");
            clock45.BackgroundImageLayout = ImageLayout.Stretch;
            clock45.BorderStyle = BorderStyle.Fixed3D;
            clock45.Location = new Point(708, 364);
            clock45.Name = "clock45";
            clock45.Size = new Size(80, 74);
            clock45.TabIndex = 20;
            clock45.TabStop = false;
            // 
            // clock40
            // 
            clock40.BackgroundImage = (Image)resources.GetObject("clock40.BackgroundImage");
            clock40.BackgroundImageLayout = ImageLayout.Stretch;
            clock40.BorderStyle = BorderStyle.Fixed3D;
            clock40.Location = new Point(708, 364);
            clock40.Name = "clock40";
            clock40.Size = new Size(80, 74);
            clock40.TabIndex = 19;
            clock40.TabStop = false;
            // 
            // clock35
            // 
            clock35.BackgroundImage = (Image)resources.GetObject("clock35.BackgroundImage");
            clock35.BackgroundImageLayout = ImageLayout.Stretch;
            clock35.BorderStyle = BorderStyle.Fixed3D;
            clock35.Location = new Point(708, 364);
            clock35.Name = "clock35";
            clock35.Size = new Size(80, 74);
            clock35.TabIndex = 18;
            clock35.TabStop = false;
            // 
            // clock30
            // 
            clock30.BackgroundImage = (Image)resources.GetObject("clock30.BackgroundImage");
            clock30.BackgroundImageLayout = ImageLayout.Stretch;
            clock30.BorderStyle = BorderStyle.Fixed3D;
            clock30.Location = new Point(708, 364);
            clock30.Name = "clock30";
            clock30.Size = new Size(80, 74);
            clock30.TabIndex = 17;
            clock30.TabStop = false;
            // 
            // clock25
            // 
            clock25.BackgroundImage = (Image)resources.GetObject("clock25.BackgroundImage");
            clock25.BackgroundImageLayout = ImageLayout.Stretch;
            clock25.BorderStyle = BorderStyle.Fixed3D;
            clock25.Location = new Point(708, 364);
            clock25.Name = "clock25";
            clock25.Size = new Size(80, 74);
            clock25.TabIndex = 16;
            clock25.TabStop = false;
            // 
            // clock20
            // 
            clock20.BackgroundImage = (Image)resources.GetObject("clock20.BackgroundImage");
            clock20.BackgroundImageLayout = ImageLayout.Stretch;
            clock20.BorderStyle = BorderStyle.Fixed3D;
            clock20.Location = new Point(708, 364);
            clock20.Name = "clock20";
            clock20.Size = new Size(80, 74);
            clock20.TabIndex = 15;
            clock20.TabStop = false;
            // 
            // clock15
            // 
            clock15.BackgroundImage = (Image)resources.GetObject("clock15.BackgroundImage");
            clock15.BackgroundImageLayout = ImageLayout.Stretch;
            clock15.BorderStyle = BorderStyle.Fixed3D;
            clock15.Location = new Point(708, 364);
            clock15.Name = "clock15";
            clock15.Size = new Size(80, 74);
            clock15.TabIndex = 14;
            clock15.TabStop = false;
            // 
            // clock60
            // 
            clock60.BackgroundImage = (Image)resources.GetObject("clock60.BackgroundImage");
            clock60.BackgroundImageLayout = ImageLayout.Stretch;
            clock60.BorderStyle = BorderStyle.Fixed3D;
            clock60.Location = new Point(708, 364);
            clock60.Name = "clock60";
            clock60.Size = new Size(80, 74);
            clock60.TabIndex = 13;
            clock60.TabStop = false;
            // 
            // clock10
            // 
            clock10.BackgroundImage = (Image)resources.GetObject("clock10.BackgroundImage");
            clock10.BackgroundImageLayout = ImageLayout.Stretch;
            clock10.BorderStyle = BorderStyle.Fixed3D;
            clock10.Location = new Point(708, 364);
            clock10.Name = "clock10";
            clock10.Size = new Size(80, 74);
            clock10.TabIndex = 12;
            clock10.TabStop = false;
            // 
            // clock5
            // 
            clock5.BackgroundImage = (Image)resources.GetObject("clock5.BackgroundImage");
            clock5.BackgroundImageLayout = ImageLayout.Stretch;
            clock5.BorderStyle = BorderStyle.Fixed3D;
            clock5.Location = new Point(708, 364);
            clock5.Name = "clock5";
            clock5.Size = new Size(80, 74);
            clock5.TabIndex = 11;
            clock5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = null;
            pictureBox1.ImageLocation = "";
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 48);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblNumOfQuestions);
            panel2.Controls.Add(lbltbqnumber);
            panel2.Controls.Add(tbNumOfQuestions);
            panel2.Controls.Add(btnBackSettings);
            panel2.Controls.Add(lblIncludedTimesTablesTitle);
            panel2.Controls.Add(checkedListBox1);
            panel2.Controls.Add(lblSettingsTitle);
            panel2.Controls.Add(menuStrip1);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Perpetua Titling MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 10;
            // 
            // lblNumOfQuestions
            // 
            lblNumOfQuestions.AutoSize = true;
            lblNumOfQuestions.Font = new Font("Jokerman", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            lblNumOfQuestions.ForeColor = SystemColors.GradientActiveCaption;
            lblNumOfQuestions.Location = new Point(466, 124);
            lblNumOfQuestions.Name = "lblNumOfQuestions";
            lblNumOfQuestions.Size = new Size(213, 28);
            lblNumOfQuestions.TabIndex = 8;
            lblNumOfQuestions.Text = "Number of Questions:";
            // 
            // lbltbqnumber
            // 
            lbltbqnumber.AutoSize = true;
            lbltbqnumber.Font = new Font("qtquickcontrols", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lbltbqnumber.Location = new Point(611, 182);
            lbltbqnumber.Name = "lbltbqnumber";
            lbltbqnumber.Size = new Size(24, 17);
            lbltbqnumber.TabIndex = 7;
            lbltbqnumber.Text = "10";
            // 
            // tbNumOfQuestions
            // 
            tbNumOfQuestions.Location = new Point(466, 173);
            tbNumOfQuestions.Name = "tbNumOfQuestions";
            tbNumOfQuestions.Size = new Size(139, 45);
            tbNumOfQuestions.TabIndex = 6;
            tbNumOfQuestions.Scroll += tbNumOfQuestions_Scroll;
            // 
            // btnBackSettings
            // 
            btnBackSettings.BackColor = Color.Green;
            btnBackSettings.FlatAppearance.BorderColor = Color.White;
            btnBackSettings.FlatAppearance.BorderSize = 4;
            btnBackSettings.FlatStyle = FlatStyle.Popup;
            btnBackSettings.Font = new Font("Jokerman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBackSettings.Location = new Point(708, 27);
            btnBackSettings.Name = "btnBackSettings";
            btnBackSettings.Size = new Size(75, 33);
            btnBackSettings.TabIndex = 5;
            btnBackSettings.Text = "Back";
            btnBackSettings.UseVisualStyleBackColor = false;
            btnBackSettings.Click += btnBackSettings_Click;
            // 
            // lblIncludedTimesTablesTitle
            // 
            lblIncludedTimesTablesTitle.AutoSize = true;
            lblIncludedTimesTablesTitle.Font = new Font("Jokerman", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            lblIncludedTimesTablesTitle.ForeColor = SystemColors.GradientActiveCaption;
            lblIncludedTimesTablesTitle.Location = new Point(155, 122);
            lblIncludedTimesTablesTitle.Name = "lblIncludedTimesTablesTitle";
            lblIncludedTimesTablesTitle.Size = new Size(207, 28);
            lblIncludedTimesTablesTitle.TabIndex = 4;
            lblIncludedTimesTablesTitle.Text = "Include Times Tables:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.SteelBlue;
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Franklin Gothic Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox1.ForeColor = Color.WhiteSmoke;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            checkedListBox1.Location = new Point(166, 153);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(104, 288);
            checkedListBox1.TabIndex = 3;
            // 
            // lblSettingsTitle
            // 
            lblSettingsTitle.AutoSize = true;
            lblSettingsTitle.Font = new Font("Jokerman", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSettingsTitle.ForeColor = Color.BurlyWood;
            lblSettingsTitle.Location = new Point(299, 55);
            lblSettingsTitle.Name = "lblSettingsTitle";
            lblSettingsTitle.Size = new Size(206, 51);
            lblSettingsTitle.TabIndex = 0;
            lblSettingsTitle.Text = "SETTINGS";
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sadEmoji).EndInit();
            ((System.ComponentModel.ISupportInitialize)elatedEmoji).EndInit();
            ((System.ComponentModel.ISupportInitialize)happyEmoji).EndInit();
            ((System.ComponentModel.ISupportInitialize)clock55).EndInit();
            ((System.ComponentModel.ISupportInitialize)clock50).EndInit();
            ((System.ComponentModel.ISupportInitialize)clock45).EndInit();
            ((System.ComponentModel.ISupportInitialize)clock40).EndInit();
            ((System.ComponentModel.ISupportInitialize)clock35).EndInit();
            ((System.ComponentModel.ISupportInitialize)clock30).EndInit();
            ((System.ComponentModel.ISupportInitialize)clock25).EndInit();
            ((System.ComponentModel.ISupportInitialize)clock20).EndInit();
            ((System.ComponentModel.ISupportInitialize)clock15).EndInit();
            ((System.ComponentModel.ISupportInitialize)clock60).EndInit();
            ((System.ComponentModel.ISupportInitialize)clock10).EndInit();
            ((System.ComponentModel.ISupportInitialize)clock5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbNumOfQuestions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblInstructions;
        private TextBox txtAnswer;
        private Button btnSubmit;
        private System.Windows.Forms.Timer timer1;
        private Button btnStart;
        private Label lblTimeLeft;
        private Label lblTitle;
        private Label lblCorrect;
        private Label lblIncorrect;
        private Label lblResults;
        private Button btnRestart;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblSettingsTitle;
        private CheckedListBox checkedListBox1;
        private Label lblIncludedTimesTablesTitle;
        private Button btnBackSettings;
        private Label lblNumOfQuestions;
        private Label lbltbqnumber;
        private TrackBar tbNumOfQuestions;
        private MenuStrip menuStrip1;
        private PictureBox sadEmoji;
        private PictureBox elatedEmoji;
        private PictureBox happyEmoji;
        private PictureBox clock55;
        private PictureBox clock50;
        private PictureBox clock45;
        private PictureBox clock40;
        private PictureBox clock35;
        private PictureBox clock30;
        private PictureBox clock25;
        private PictureBox clock20;
        private PictureBox clock15;
        private PictureBox clock60;
        private PictureBox clock10;
        private PictureBox clock5;
    }
}