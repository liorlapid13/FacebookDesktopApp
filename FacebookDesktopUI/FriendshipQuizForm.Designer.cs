namespace FacebookDesktopUI
{
    public partial class FriendshipQuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendshipQuizForm));
            this.friendshipQuizFormPanel = new System.Windows.Forms.Panel();
            this.facebookLogo = new System.Windows.Forms.PictureBox();
            this.friendshipQuizLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.answerQuestionsLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.birthdayPanel = new System.Windows.Forms.Panel();
            this.cityPanel = new System.Windows.Forms.Panel();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryPanel = new System.Windows.Forms.Panel();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.relationshipStatusPanel = new System.Windows.Forms.Panel();
            this.relationshipStatusComboBox = new System.Windows.Forms.ComboBox();
            this.relationshipStatusLabel = new System.Windows.Forms.Label();
            this.religionPanel = new System.Windows.Forms.Panel();
            this.religionComboBox = new System.Windows.Forms.ComboBox();
            this.religionLabel = new System.Windows.Forms.Label();
            this.submitButtonPanel = new System.Windows.Forms.Panel();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.exitButtonPanel = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.answersPanel = new System.Windows.Forms.Panel();
            this.religionAnswerTextBox = new System.Windows.Forms.TextBox();
            this.relationshipStatusAnswerTextBox = new System.Windows.Forms.TextBox();
            this.cityAnswerTextBox = new System.Windows.Forms.TextBox();
            this.countryAnswerTextBox = new System.Windows.Forms.TextBox();
            this.birthdayAnswerTextBox = new System.Windows.Forms.TextBox();
            this.answersLabel = new System.Windows.Forms.Label();
            this.friendshipQuizFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.birthdayPanel.SuspendLayout();
            this.cityPanel.SuspendLayout();
            this.countryPanel.SuspendLayout();
            this.relationshipStatusPanel.SuspendLayout();
            this.religionPanel.SuspendLayout();
            this.submitButtonPanel.SuspendLayout();
            this.exitButtonPanel.SuspendLayout();
            this.answersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // friendshipQuizFormPanel
            // 
            this.friendshipQuizFormPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.friendshipQuizFormPanel.Controls.Add(this.facebookLogo);
            this.friendshipQuizFormPanel.Controls.Add(this.friendshipQuizLabel);
            this.friendshipQuizFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.friendshipQuizFormPanel.Location = new System.Drawing.Point(0, 0);
            this.friendshipQuizFormPanel.Name = "friendshipQuizFormPanel";
            this.friendshipQuizFormPanel.Size = new System.Drawing.Size(886, 137);
            this.friendshipQuizFormPanel.TabIndex = 5;
            // 
            // facebookLogo
            // 
            this.facebookLogo.Image = ((System.Drawing.Image)(resources.GetObject("facebookLogo.Image")));
            this.facebookLogo.Location = new System.Drawing.Point(31, 29);
            this.facebookLogo.Name = "facebookLogo";
            this.facebookLogo.Size = new System.Drawing.Size(97, 83);
            this.facebookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebookLogo.TabIndex = 1;
            this.facebookLogo.TabStop = false;
            // 
            // friendshipQuizLabel
            // 
            this.friendshipQuizLabel.AutoSize = true;
            this.friendshipQuizLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendshipQuizLabel.ForeColor = System.Drawing.Color.Snow;
            this.friendshipQuizLabel.Location = new System.Drawing.Point(168, 41);
            this.friendshipQuizLabel.Name = "friendshipQuizLabel";
            this.friendshipQuizLabel.Size = new System.Drawing.Size(388, 62);
            this.friendshipQuizLabel.TabIndex = 0;
            this.friendshipQuizLabel.Text = "Friendship Quiz";
            this.friendshipQuizLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.answerQuestionsLabel);
            this.panel1.Location = new System.Drawing.Point(31, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 42);
            this.panel1.TabIndex = 6;
            // 
            // answerQuestionsLabel
            // 
            this.answerQuestionsLabel.AutoSize = true;
            this.answerQuestionsLabel.Location = new System.Drawing.Point(3, 0);
            this.answerQuestionsLabel.Name = "answerQuestionsLabel";
            this.answerQuestionsLabel.Size = new System.Drawing.Size(634, 32);
            this.answerQuestionsLabel.TabIndex = 0;
            this.answerQuestionsLabel.Text = "Answer the following questions about your friend:";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.birthdayLabel.Location = new System.Drawing.Point(0, 0);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(319, 32);
            this.birthdayLabel.TabIndex = 1;
            this.birthdayLabel.Text = "When was he/she born?";
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.birthdayTextBox.Location = new System.Drawing.Point(0, 39);
            this.birthdayTextBox.Multiline = true;
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(490, 40);
            this.birthdayTextBox.TabIndex = 2;
            // 
            // birthdayPanel
            // 
            this.birthdayPanel.Controls.Add(this.birthdayTextBox);
            this.birthdayPanel.Controls.Add(this.birthdayLabel);
            this.birthdayPanel.Location = new System.Drawing.Point(31, 235);
            this.birthdayPanel.Name = "birthdayPanel";
            this.birthdayPanel.Size = new System.Drawing.Size(490, 79);
            this.birthdayPanel.TabIndex = 7;
            // 
            // cityPanel
            // 
            this.cityPanel.Controls.Add(this.cityTextBox);
            this.cityPanel.Controls.Add(this.cityLabel);
            this.cityPanel.Location = new System.Drawing.Point(31, 338);
            this.cityPanel.Name = "cityPanel";
            this.cityPanel.Size = new System.Drawing.Size(404, 88);
            this.cityPanel.TabIndex = 8;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cityTextBox.Location = new System.Drawing.Point(0, 48);
            this.cityTextBox.Multiline = true;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(404, 40);
            this.cityTextBox.TabIndex = 2;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cityLabel.Location = new System.Drawing.Point(0, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(397, 32);
            this.cityLabel.TabIndex = 1;
            this.cityLabel.Text = "In which city does he/she live?";
            // 
            // countryPanel
            // 
            this.countryPanel.Controls.Add(this.countryTextBox);
            this.countryPanel.Controls.Add(this.countryLabel);
            this.countryPanel.Location = new System.Drawing.Point(31, 432);
            this.countryPanel.Name = "countryPanel";
            this.countryPanel.Size = new System.Drawing.Size(457, 91);
            this.countryPanel.TabIndex = 9;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.countryTextBox.Location = new System.Drawing.Point(0, 51);
            this.countryTextBox.Multiline = true;
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(457, 40);
            this.countryTextBox.TabIndex = 2;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.countryLabel.Location = new System.Drawing.Point(0, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(447, 32);
            this.countryLabel.TabIndex = 1;
            this.countryLabel.Text = "In which country does he/she live?";
            // 
            // relationshipStatusPanel
            // 
            this.relationshipStatusPanel.Controls.Add(this.relationshipStatusComboBox);
            this.relationshipStatusPanel.Controls.Add(this.relationshipStatusLabel);
            this.relationshipStatusPanel.Location = new System.Drawing.Point(31, 547);
            this.relationshipStatusPanel.Name = "relationshipStatusPanel";
            this.relationshipStatusPanel.Size = new System.Drawing.Size(457, 79);
            this.relationshipStatusPanel.TabIndex = 10;
            // 
            // relationshipStatusComboBox
            // 
            this.relationshipStatusComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.relationshipStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.relationshipStatusComboBox.FormattingEnabled = true;
            this.relationshipStatusComboBox.Items.AddRange(new object[] {
            "Single",
            "In a Relationship",
            "Engaged",
            "Married"});
            this.relationshipStatusComboBox.Location = new System.Drawing.Point(0, 40);
            this.relationshipStatusComboBox.Name = "relationshipStatusComboBox";
            this.relationshipStatusComboBox.Size = new System.Drawing.Size(457, 39);
            this.relationshipStatusComboBox.TabIndex = 2;
            // 
            // relationshipStatusLabel
            // 
            this.relationshipStatusLabel.AutoSize = true;
            this.relationshipStatusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.relationshipStatusLabel.Location = new System.Drawing.Point(0, 0);
            this.relationshipStatusLabel.Name = "relationshipStatusLabel";
            this.relationshipStatusLabel.Size = new System.Drawing.Size(456, 32);
            this.relationshipStatusLabel.TabIndex = 1;
            this.relationshipStatusLabel.Text = "What is his/her relationship status?";
            // 
            // religionPanel
            // 
            this.religionPanel.Controls.Add(this.religionComboBox);
            this.religionPanel.Controls.Add(this.religionLabel);
            this.religionPanel.Location = new System.Drawing.Point(31, 654);
            this.religionPanel.Name = "religionPanel";
            this.religionPanel.Size = new System.Drawing.Size(328, 91);
            this.religionPanel.TabIndex = 11;
            // 
            // religionComboBox
            // 
            this.religionComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.religionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.religionComboBox.FormattingEnabled = true;
            this.religionComboBox.Items.AddRange(new object[] {
            "Atheist",
            "Jewish",
            "Muslim",
            "Christian",
            "Buddhist"});
            this.religionComboBox.Location = new System.Drawing.Point(0, 52);
            this.religionComboBox.Name = "religionComboBox";
            this.religionComboBox.Size = new System.Drawing.Size(328, 39);
            this.religionComboBox.TabIndex = 3;
            // 
            // religionLabel
            // 
            this.religionLabel.AutoSize = true;
            this.religionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.religionLabel.Location = new System.Drawing.Point(0, 0);
            this.religionLabel.Name = "religionLabel";
            this.religionLabel.Size = new System.Drawing.Size(319, 32);
            this.religionLabel.TabIndex = 1;
            this.religionLabel.Text = "What is his/her religion?";
            // 
            // submitButtonPanel
            // 
            this.submitButtonPanel.Controls.Add(this.buttonSubmit);
            this.submitButtonPanel.Location = new System.Drawing.Point(31, 751);
            this.submitButtonPanel.Name = "submitButtonPanel";
            this.submitButtonPanel.Size = new System.Drawing.Size(270, 135);
            this.submitButtonPanel.TabIndex = 12;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(0, 0);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(270, 99);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // exitButtonPanel
            // 
            this.exitButtonPanel.Controls.Add(this.buttonExit);
            this.exitButtonPanel.Location = new System.Drawing.Point(575, 751);
            this.exitButtonPanel.Name = "exitButtonPanel";
            this.exitButtonPanel.Size = new System.Drawing.Size(270, 99);
            this.exitButtonPanel.TabIndex = 13;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(0, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(270, 99);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // answersPanel
            // 
            this.answersPanel.Controls.Add(this.religionAnswerTextBox);
            this.answersPanel.Controls.Add(this.relationshipStatusAnswerTextBox);
            this.answersPanel.Controls.Add(this.cityAnswerTextBox);
            this.answersPanel.Controls.Add(this.countryAnswerTextBox);
            this.answersPanel.Controls.Add(this.birthdayAnswerTextBox);
            this.answersPanel.Controls.Add(this.answersLabel);
            this.answersPanel.Location = new System.Drawing.Point(575, 216);
            this.answersPanel.Name = "answersPanel";
            this.answersPanel.Size = new System.Drawing.Size(270, 513);
            this.answersPanel.TabIndex = 14;
            this.answersPanel.Visible = false;
            // 
            // religionAnswerTextBox
            // 
            this.religionAnswerTextBox.BackColor = System.Drawing.Color.LightGray;
            this.religionAnswerTextBox.Enabled = false;
            this.religionAnswerTextBox.Location = new System.Drawing.Point(0, 472);
            this.religionAnswerTextBox.Multiline = true;
            this.religionAnswerTextBox.Name = "religionAnswerTextBox";
            this.religionAnswerTextBox.Size = new System.Drawing.Size(273, 38);
            this.religionAnswerTextBox.TabIndex = 5;
            // 
            // relationshipStatusAnswerTextBox
            // 
            this.relationshipStatusAnswerTextBox.BackColor = System.Drawing.Color.LightGray;
            this.relationshipStatusAnswerTextBox.Enabled = false;
            this.relationshipStatusAnswerTextBox.Location = new System.Drawing.Point(0, 366);
            this.relationshipStatusAnswerTextBox.Multiline = true;
            this.relationshipStatusAnswerTextBox.Name = "relationshipStatusAnswerTextBox";
            this.relationshipStatusAnswerTextBox.Size = new System.Drawing.Size(273, 38);
            this.relationshipStatusAnswerTextBox.TabIndex = 4;
            // 
            // cityAnswerTextBox
            // 
            this.cityAnswerTextBox.BackColor = System.Drawing.Color.LightGray;
            this.cityAnswerTextBox.Enabled = false;
            this.cityAnswerTextBox.Location = new System.Drawing.Point(0, 154);
            this.cityAnswerTextBox.Multiline = true;
            this.cityAnswerTextBox.Name = "cityAnswerTextBox";
            this.cityAnswerTextBox.Size = new System.Drawing.Size(270, 38);
            this.cityAnswerTextBox.TabIndex = 3;
            // 
            // countryAnswerTextBox
            // 
            this.countryAnswerTextBox.BackColor = System.Drawing.Color.LightGray;
            this.countryAnswerTextBox.Enabled = false;
            this.countryAnswerTextBox.Location = new System.Drawing.Point(0, 257);
            this.countryAnswerTextBox.Multiline = true;
            this.countryAnswerTextBox.Name = "countryAnswerTextBox";
            this.countryAnswerTextBox.Size = new System.Drawing.Size(273, 38);
            this.countryAnswerTextBox.TabIndex = 2;
            // 
            // birthdayAnswerTextBox
            // 
            this.birthdayAnswerTextBox.BackColor = System.Drawing.Color.LightGray;
            this.birthdayAnswerTextBox.Enabled = false;
            this.birthdayAnswerTextBox.Location = new System.Drawing.Point(3, 60);
            this.birthdayAnswerTextBox.Multiline = true;
            this.birthdayAnswerTextBox.Name = "birthdayAnswerTextBox";
            this.birthdayAnswerTextBox.Size = new System.Drawing.Size(267, 38);
            this.birthdayAnswerTextBox.TabIndex = 1;
            // 
            // answersLabel
            // 
            this.answersLabel.AutoSize = true;
            this.answersLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.answersLabel.Location = new System.Drawing.Point(0, 0);
            this.answersLabel.Name = "answersLabel";
            this.answersLabel.Size = new System.Drawing.Size(230, 32);
            this.answersLabel.TabIndex = 0;
            this.answersLabel.Text = "Correct Answers:";
            // 
            // FriendshipQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(886, 898);
            this.ControlBox = false;
            this.Controls.Add(this.answersPanel);
            this.Controls.Add(this.exitButtonPanel);
            this.Controls.Add(this.submitButtonPanel);
            this.Controls.Add(this.religionPanel);
            this.Controls.Add(this.relationshipStatusPanel);
            this.Controls.Add(this.countryPanel);
            this.Controls.Add(this.cityPanel);
            this.Controls.Add(this.birthdayPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.friendshipQuizFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FriendshipQuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Friendship Quiz";
            this.friendshipQuizFormPanel.ResumeLayout(false);
            this.friendshipQuizFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.birthdayPanel.ResumeLayout(false);
            this.birthdayPanel.PerformLayout();
            this.cityPanel.ResumeLayout(false);
            this.cityPanel.PerformLayout();
            this.countryPanel.ResumeLayout(false);
            this.countryPanel.PerformLayout();
            this.relationshipStatusPanel.ResumeLayout(false);
            this.relationshipStatusPanel.PerformLayout();
            this.religionPanel.ResumeLayout(false);
            this.religionPanel.PerformLayout();
            this.submitButtonPanel.ResumeLayout(false);
            this.exitButtonPanel.ResumeLayout(false);
            this.answersPanel.ResumeLayout(false);
            this.answersPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel friendshipQuizFormPanel;
        private System.Windows.Forms.PictureBox facebookLogo;
        private System.Windows.Forms.Label friendshipQuizLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label answerQuestionsLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.Panel birthdayPanel;
        private System.Windows.Forms.Panel cityPanel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Panel countryPanel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Panel relationshipStatusPanel;
        private System.Windows.Forms.ComboBox relationshipStatusComboBox;
        private System.Windows.Forms.Label relationshipStatusLabel;
        private System.Windows.Forms.Panel religionPanel;
        private System.Windows.Forms.ComboBox religionComboBox;
        private System.Windows.Forms.Label religionLabel;
        private System.Windows.Forms.Panel submitButtonPanel;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Panel exitButtonPanel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel answersPanel;
        private System.Windows.Forms.TextBox religionAnswerTextBox;
        private System.Windows.Forms.TextBox relationshipStatusAnswerTextBox;
        private System.Windows.Forms.TextBox cityAnswerTextBox;
        private System.Windows.Forms.TextBox countryAnswerTextBox;
        private System.Windows.Forms.TextBox birthdayAnswerTextBox;
        private System.Windows.Forms.Label answersLabel;
    }
}