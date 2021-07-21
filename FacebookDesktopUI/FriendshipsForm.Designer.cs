namespace FacebookDesktopUI
{
    public partial class FriendshipsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendshipsForm));
            this.friendshipStatisticsFormPanel = new System.Windows.Forms.Panel();
            this.facebookLogo = new System.Windows.Forms.PictureBox();
            this.friendshipStatisticsLabel = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.friendListPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.showFriendshipButtonPanel = new System.Windows.Forms.Panel();
            this.buttonShowFriendship = new System.Windows.Forms.Button();
            this.friendshipStatisticsPanel = new System.Windows.Forms.Panel();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsLabel = new System.Windows.Forms.Label();
            this.listBoxMutualFriends = new System.Windows.Forms.ListBox();
            this.mutualFriendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.checkInsLabel = new System.Windows.Forms.Label();
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.checkinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exitButtonPanel = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.profilePicturesPanel = new System.Windows.Forms.Panel();
            this.friendProfilePicturePictureBox = new System.Windows.Forms.PictureBox();
            this.userProfilePicturePictureBox = new System.Windows.Forms.PictureBox();
            this.friendshipQuizPanel = new System.Windows.Forms.Panel();
            this.buttonFriendshipQuiz = new System.Windows.Forms.Button();
            this.friendshipStatisticsFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.friendListPanel.SuspendLayout();
            this.showFriendshipButtonPanel.SuspendLayout();
            this.friendshipStatisticsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualFriendBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).BeginInit();
            this.exitButtonPanel.SuspendLayout();
            this.profilePicturesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendProfilePicturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePicturePictureBox)).BeginInit();
            this.friendshipQuizPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // friendshipStatisticsFormPanel
            // 
            this.friendshipStatisticsFormPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.friendshipStatisticsFormPanel.Controls.Add(this.facebookLogo);
            this.friendshipStatisticsFormPanel.Controls.Add(this.friendshipStatisticsLabel);
            this.friendshipStatisticsFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.friendshipStatisticsFormPanel.Location = new System.Drawing.Point(0, 0);
            this.friendshipStatisticsFormPanel.Name = "friendshipStatisticsFormPanel";
            this.friendshipStatisticsFormPanel.Size = new System.Drawing.Size(1761, 137);
            this.friendshipStatisticsFormPanel.TabIndex = 4;
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
            // friendshipStatisticsLabel
            // 
            this.friendshipStatisticsLabel.AutoSize = true;
            this.friendshipStatisticsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendshipStatisticsLabel.ForeColor = System.Drawing.Color.Snow;
            this.friendshipStatisticsLabel.Location = new System.Drawing.Point(168, 41);
            this.friendshipStatisticsLabel.Name = "friendshipStatisticsLabel";
            this.friendshipStatisticsLabel.Size = new System.Drawing.Size(290, 62);
            this.friendshipStatisticsLabel.TabIndex = 0;
            this.friendshipStatisticsLabel.Text = "Friendships";
            this.friendshipStatisticsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.userBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 31;
            this.listBoxFriends.Location = new System.Drawing.Point(0, 37);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(531, 717);
            this.listBoxFriends.TabIndex = 5;
            this.listBoxFriends.ValueMember = "About";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // friendListPanel
            // 
            this.friendListPanel.Controls.Add(this.label1);
            this.friendListPanel.Controls.Add(this.listBoxFriends);
            this.friendListPanel.Location = new System.Drawing.Point(31, 155);
            this.friendListPanel.Name = "friendListPanel";
            this.friendListPanel.Size = new System.Drawing.Size(531, 754);
            this.friendListPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please select a friend:";
            // 
            // showFriendshipButtonPanel
            // 
            this.showFriendshipButtonPanel.Controls.Add(this.buttonShowFriendship);
            this.showFriendshipButtonPanel.Location = new System.Drawing.Point(31, 916);
            this.showFriendshipButtonPanel.Name = "showFriendshipButtonPanel";
            this.showFriendshipButtonPanel.Size = new System.Drawing.Size(531, 105);
            this.showFriendshipButtonPanel.TabIndex = 7;
            // 
            // buttonShowFriendship
            // 
            this.buttonShowFriendship.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonShowFriendship.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShowFriendship.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowFriendship.ForeColor = System.Drawing.Color.White;
            this.buttonShowFriendship.Location = new System.Drawing.Point(0, 0);
            this.buttonShowFriendship.Name = "buttonShowFriendship";
            this.buttonShowFriendship.Size = new System.Drawing.Size(531, 105);
            this.buttonShowFriendship.TabIndex = 0;
            this.buttonShowFriendship.Text = "Show friendship";
            this.buttonShowFriendship.UseVisualStyleBackColor = false;
            this.buttonShowFriendship.Click += new System.EventHandler(this.buttonShowFriendship_Click);
            // 
            // friendshipStatisticsPanel
            // 
            this.friendshipStatisticsPanel.Controls.Add(this.listBoxEvents);
            this.friendshipStatisticsPanel.Controls.Add(this.eventsLabel);
            this.friendshipStatisticsPanel.Controls.Add(this.listBoxMutualFriends);
            this.friendshipStatisticsPanel.Controls.Add(this.label3);
            this.friendshipStatisticsPanel.Controls.Add(this.listBoxLikedPages);
            this.friendshipStatisticsPanel.Controls.Add(this.label2);
            this.friendshipStatisticsPanel.Controls.Add(this.checkInsLabel);
            this.friendshipStatisticsPanel.Controls.Add(this.listBoxCheckins);
            this.friendshipStatisticsPanel.Location = new System.Drawing.Point(866, 155);
            this.friendshipStatisticsPanel.Name = "friendshipStatisticsPanel";
            this.friendshipStatisticsPanel.Size = new System.Drawing.Size(868, 754);
            this.friendshipStatisticsPanel.TabIndex = 8;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.DisplayMember = "Name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 31;
            this.listBoxEvents.Location = new System.Drawing.Point(467, 415);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(377, 314);
            this.listBoxEvents.TabIndex = 13;
            this.listBoxEvents.ValueMember = "AttendingCount";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // eventsLabel
            // 
            this.eventsLabel.AutoSize = true;
            this.eventsLabel.Location = new System.Drawing.Point(461, 372);
            this.eventsLabel.Name = "eventsLabel";
            this.eventsLabel.Size = new System.Drawing.Size(201, 32);
            this.eventsLabel.TabIndex = 12;
            this.eventsLabel.Text = "Shared Events";
            // 
            // listBoxMutualFriends
            // 
            this.listBoxMutualFriends.DataSource = this.mutualFriendBindingSource;
            this.listBoxMutualFriends.DisplayMember = "Name";
            this.listBoxMutualFriends.FormattingEnabled = true;
            this.listBoxMutualFriends.ItemHeight = 31;
            this.listBoxMutualFriends.Location = new System.Drawing.Point(0, 415);
            this.listBoxMutualFriends.Name = "listBoxMutualFriends";
            this.listBoxMutualFriends.Size = new System.Drawing.Size(377, 314);
            this.listBoxMutualFriends.TabIndex = 11;
            this.listBoxMutualFriends.ValueMember = "About";
            // 
            // mutualFriendBindingSource
            // 
            this.mutualFriendBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-6, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mutual Friends";
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.DataSource = this.pageBindingSource;
            this.listBoxLikedPages.DisplayMember = "Name";
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 31;
            this.listBoxLikedPages.Location = new System.Drawing.Point(467, 43);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(377, 314);
            this.listBoxLikedPages.TabIndex = 9;
            this.listBoxLikedPages.ValueMember = "AccessToken";
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Common Liked Pages";
            // 
            // checkInsLabel
            // 
            this.checkInsLabel.AutoSize = true;
            this.checkInsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkInsLabel.Location = new System.Drawing.Point(0, 0);
            this.checkInsLabel.Name = "checkInsLabel";
            this.checkInsLabel.Size = new System.Drawing.Size(240, 32);
            this.checkInsLabel.TabIndex = 7;
            this.checkInsLabel.Text = "Shared Check-Ins";
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.DataSource = this.checkinBindingSource;
            this.listBoxCheckins.DisplayMember = "Place";
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.ItemHeight = 31;
            this.listBoxCheckins.Location = new System.Drawing.Point(0, 43);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(377, 314);
            this.listBoxCheckins.TabIndex = 0;
            this.listBoxCheckins.ValueMember = "Caption";
            // 
            // checkinBindingSource
            // 
            this.checkinBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Checkin);
            // 
            // exitButtonPanel
            // 
            this.exitButtonPanel.Controls.Add(this.buttonExit);
            this.exitButtonPanel.Location = new System.Drawing.Point(1464, 930);
            this.exitButtonPanel.Name = "exitButtonPanel";
            this.exitButtonPanel.Size = new System.Drawing.Size(270, 91);
            this.exitButtonPanel.TabIndex = 9;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(0, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(270, 91);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // profilePicturesPanel
            // 
            this.profilePicturesPanel.Controls.Add(this.friendProfilePicturePictureBox);
            this.profilePicturesPanel.Controls.Add(this.userProfilePicturePictureBox);
            this.profilePicturesPanel.Location = new System.Drawing.Point(578, 155);
            this.profilePicturesPanel.Name = "profilePicturesPanel";
            this.profilePicturesPanel.Size = new System.Drawing.Size(276, 754);
            this.profilePicturesPanel.TabIndex = 10;
            // 
            // friendProfilePicturePictureBox
            // 
            this.friendProfilePicturePictureBox.Location = new System.Drawing.Point(3, 415);
            this.friendProfilePicturePictureBox.Name = "friendProfilePicturePictureBox";
            this.friendProfilePicturePictureBox.Size = new System.Drawing.Size(269, 314);
            this.friendProfilePicturePictureBox.TabIndex = 1;
            this.friendProfilePicturePictureBox.TabStop = false;
            // 
            // userProfilePicturePictureBox
            // 
            this.userProfilePicturePictureBox.Location = new System.Drawing.Point(4, 37);
            this.userProfilePicturePictureBox.Name = "userProfilePicturePictureBox";
            this.userProfilePicturePictureBox.Size = new System.Drawing.Size(269, 320);
            this.userProfilePicturePictureBox.TabIndex = 0;
            this.userProfilePicturePictureBox.TabStop = false;
            // 
            // friendshipQuizPanel
            // 
            this.friendshipQuizPanel.Controls.Add(this.buttonFriendshipQuiz);
            this.friendshipQuizPanel.Location = new System.Drawing.Point(578, 916);
            this.friendshipQuizPanel.Name = "friendshipQuizPanel";
            this.friendshipQuizPanel.Size = new System.Drawing.Size(276, 105);
            this.friendshipQuizPanel.TabIndex = 11;
            // 
            // buttonFriendshipQuiz
            // 
            this.buttonFriendshipQuiz.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonFriendshipQuiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFriendshipQuiz.Enabled = false;
            this.buttonFriendshipQuiz.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFriendshipQuiz.ForeColor = System.Drawing.Color.White;
            this.buttonFriendshipQuiz.Location = new System.Drawing.Point(0, 0);
            this.buttonFriendshipQuiz.Name = "buttonFriendshipQuiz";
            this.buttonFriendshipQuiz.Size = new System.Drawing.Size(276, 105);
            this.buttonFriendshipQuiz.TabIndex = 0;
            this.buttonFriendshipQuiz.Text = "Friendship Quiz";
            this.buttonFriendshipQuiz.UseVisualStyleBackColor = false;
            this.buttonFriendshipQuiz.Click += new System.EventHandler(this.buttonFriendshipQuiz_Click);
            // 
            // FriendshipsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1761, 1045);
            this.ControlBox = false;
            this.Controls.Add(this.friendshipQuizPanel);
            this.Controls.Add(this.profilePicturesPanel);
            this.Controls.Add(this.exitButtonPanel);
            this.Controls.Add(this.friendshipStatisticsPanel);
            this.Controls.Add(this.showFriendshipButtonPanel);
            this.Controls.Add(this.friendListPanel);
            this.Controls.Add(this.friendshipStatisticsFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FriendshipsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Friendships";
            this.friendshipStatisticsFormPanel.ResumeLayout(false);
            this.friendshipStatisticsFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.friendListPanel.ResumeLayout(false);
            this.friendListPanel.PerformLayout();
            this.showFriendshipButtonPanel.ResumeLayout(false);
            this.friendshipStatisticsPanel.ResumeLayout(false);
            this.friendshipStatisticsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualFriendBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).EndInit();
            this.exitButtonPanel.ResumeLayout(false);
            this.profilePicturesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.friendProfilePicturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePicturePictureBox)).EndInit();
            this.friendshipQuizPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel friendshipStatisticsFormPanel;
        private System.Windows.Forms.PictureBox facebookLogo;
        private System.Windows.Forms.Label friendshipStatisticsLabel;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Panel friendListPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel showFriendshipButtonPanel;
        private System.Windows.Forms.Button buttonShowFriendship;
        private System.Windows.Forms.Panel friendshipStatisticsPanel;
        private System.Windows.Forms.Panel exitButtonPanel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label eventsLabel;
        private System.Windows.Forms.ListBox listBoxMutualFriends;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label checkInsLabel;
        private System.Windows.Forms.ListBox listBoxCheckins;
        private System.Windows.Forms.Panel profilePicturesPanel;
        private System.Windows.Forms.PictureBox friendProfilePicturePictureBox;
        private System.Windows.Forms.PictureBox userProfilePicturePictureBox;
        private System.Windows.Forms.Panel friendshipQuizPanel;
        private System.Windows.Forms.Button buttonFriendshipQuiz;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource mutualFriendBindingSource;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.BindingSource checkinBindingSource;
    }
}