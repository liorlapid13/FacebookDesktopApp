namespace FacebookDesktopUI
{
    public partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topLoginFormPanel = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.facebookLogo = new System.Windows.Forms.PictureBox();
            this.personalizedWelcomeLabel = new System.Windows.Forms.Label();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonPages = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.panelPostText = new System.Windows.Forms.Panel();
            this.panelFriends = new System.Windows.Forms.Panel();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelGroups = new System.Windows.Forms.Panel();
            this.panelPages = new System.Windows.Forms.Panel();
            this.panelAdvancedFriendFilters = new System.Windows.Forms.Panel();
            this.buttonAdvancedFriendFilters = new System.Windows.Forms.Button();
            this.panelFriendships = new System.Windows.Forms.Panel();
            this.buttonFriendships = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.buttonViewPosts = new System.Windows.Forms.Button();
            this.topLoginFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panelPostText.SuspendLayout();
            this.panelFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            this.panelGroups.SuspendLayout();
            this.panelPages.SuspendLayout();
            this.panelAdvancedFriendFilters.SuspendLayout();
            this.panelFriendships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topLoginFormPanel
            // 
            this.topLoginFormPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.topLoginFormPanel.Controls.Add(this.buttonLogout);
            this.topLoginFormPanel.Controls.Add(this.facebookLogo);
            this.topLoginFormPanel.Controls.Add(this.personalizedWelcomeLabel);
            this.topLoginFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLoginFormPanel.Location = new System.Drawing.Point(0, 0);
            this.topLoginFormPanel.Name = "topLoginFormPanel";
            this.topLoginFormPanel.Size = new System.Drawing.Size(1245, 137);
            this.topLoginFormPanel.TabIndex = 2;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft YaHei", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(1031, 32);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(180, 71);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
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
            // personalizedWelcomeLabel
            // 
            this.personalizedWelcomeLabel.AutoSize = true;
            this.personalizedWelcomeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalizedWelcomeLabel.ForeColor = System.Drawing.Color.Snow;
            this.personalizedWelcomeLabel.Location = new System.Drawing.Point(168, 41);
            this.personalizedWelcomeLabel.Name = "personalizedWelcomeLabel";
            this.personalizedWelcomeLabel.Size = new System.Drawing.Size(0, 62);
            this.personalizedWelcomeLabel.TabIndex = 0;
            this.personalizedWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonGroups
            // 
            this.buttonGroups.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGroups.ForeColor = System.Drawing.Color.White;
            this.buttonGroups.Location = new System.Drawing.Point(0, 0);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(302, 52);
            this.buttonGroups.TabIndex = 5;
            this.buttonGroups.Text = "Groups";
            this.buttonGroups.UseVisualStyleBackColor = false;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonPages
            // 
            this.buttonPages.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonPages.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPages.ForeColor = System.Drawing.Color.White;
            this.buttonPages.Location = new System.Drawing.Point(0, 0);
            this.buttonPages.Name = "buttonPages";
            this.buttonPages.Size = new System.Drawing.Size(302, 52);
            this.buttonPages.TabIndex = 6;
            this.buttonPages.Text = "Pages";
            this.buttonPages.UseVisualStyleBackColor = false;
            this.buttonPages.Click += new System.EventHandler(this.pagesButton_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.userBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 31;
            this.listBoxFriends.Location = new System.Drawing.Point(0, 58);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(302, 500);
            this.listBoxFriends.TabIndex = 7;
            this.listBoxFriends.ValueMember = "About";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(3, 3);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(700, 192);
            this.textBoxPost.TabIndex = 0;
            this.textBoxPost.Text = "What\'s on your mind?";
            this.textBoxPost.Click += new System.EventHandler(this.postTextBox_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonPost.Enabled = false;
            this.buttonPost.ForeColor = System.Drawing.Color.White;
            this.buttonPost.Location = new System.Drawing.Point(709, 0);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(126, 192);
            this.buttonPost.TabIndex = 8;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonFriends
            // 
            this.buttonFriends.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonFriends.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFriends.ForeColor = System.Drawing.Color.White;
            this.buttonFriends.Location = new System.Drawing.Point(0, 0);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(302, 52);
            this.buttonFriends.TabIndex = 11;
            this.buttonFriends.Text = "Friends";
            this.buttonFriends.UseVisualStyleBackColor = false;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // panelPostText
            // 
            this.panelPostText.Controls.Add(this.buttonViewPosts);
            this.panelPostText.Controls.Add(this.buttonPost);
            this.panelPostText.Controls.Add(this.textBoxPost);
            this.panelPostText.Location = new System.Drawing.Point(265, 153);
            this.panelPostText.Name = "panelPostText";
            this.panelPostText.Size = new System.Drawing.Size(973, 192);
            this.panelPostText.TabIndex = 12;
            // 
            // panelFriends
            // 
            this.panelFriends.Controls.Add(this.buttonFriends);
            this.panelFriends.Controls.Add(this.listBoxFriends);
            this.panelFriends.Location = new System.Drawing.Point(268, 372);
            this.panelFriends.Name = "panelFriends";
            this.panelFriends.Size = new System.Drawing.Size(302, 558);
            this.panelFriends.TabIndex = 14;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.DataSource = this.groupBindingSource;
            this.listBoxGroups.DisplayMember = "Name";
            this.listBoxGroups.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 31;
            this.listBoxGroups.Location = new System.Drawing.Point(0, 58);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(302, 500);
            this.listBoxGroups.TabIndex = 15;
            this.listBoxGroups.ValueMember = "Description";
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // listBoxPages
            // 
            this.listBoxPages.DataSource = this.pageBindingSource;
            this.listBoxPages.DisplayMember = "Name";
            this.listBoxPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 31;
            this.listBoxPages.Location = new System.Drawing.Point(0, 58);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(302, 500);
            this.listBoxPages.TabIndex = 16;
            this.listBoxPages.ValueMember = "AccessToken";
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // panelGroups
            // 
            this.panelGroups.Controls.Add(this.buttonGroups);
            this.panelGroups.Controls.Add(this.listBoxGroups);
            this.panelGroups.Location = new System.Drawing.Point(588, 372);
            this.panelGroups.Name = "panelGroups";
            this.panelGroups.Size = new System.Drawing.Size(302, 558);
            this.panelGroups.TabIndex = 17;
            // 
            // panelPages
            // 
            this.panelPages.Controls.Add(this.buttonPages);
            this.panelPages.Controls.Add(this.listBoxPages);
            this.panelPages.Location = new System.Drawing.Point(909, 372);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(302, 558);
            this.panelPages.TabIndex = 18;
            // 
            // panelAdvancedFriendFilters
            // 
            this.panelAdvancedFriendFilters.Controls.Add(this.buttonAdvancedFriendFilters);
            this.panelAdvancedFriendFilters.Location = new System.Drawing.Point(28, 430);
            this.panelAdvancedFriendFilters.Name = "panelAdvancedFriendFilters";
            this.panelAdvancedFriendFilters.Size = new System.Drawing.Size(202, 182);
            this.panelAdvancedFriendFilters.TabIndex = 19;
            // 
            // buttonAdvancedFriendFilters
            // 
            this.buttonAdvancedFriendFilters.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdvancedFriendFilters.BackgroundImage = global::FacebookDesktopUI.Properties.Resources.Advanced_Friend_Filters_Logo2;
            this.buttonAdvancedFriendFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdvancedFriendFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdvancedFriendFilters.ForeColor = System.Drawing.Color.White;
            this.buttonAdvancedFriendFilters.Location = new System.Drawing.Point(0, 0);
            this.buttonAdvancedFriendFilters.Name = "buttonAdvancedFriendFilters";
            this.buttonAdvancedFriendFilters.Size = new System.Drawing.Size(202, 182);
            this.buttonAdvancedFriendFilters.TabIndex = 10;
            this.buttonAdvancedFriendFilters.UseVisualStyleBackColor = false;
            this.buttonAdvancedFriendFilters.Click += new System.EventHandler(this.buttonAdvancedFriendFilters_Click);
            // 
            // panelFriendships
            // 
            this.panelFriendships.Controls.Add(this.buttonFriendships);
            this.panelFriendships.Location = new System.Drawing.Point(28, 677);
            this.panelFriendships.Name = "panelFriendships";
            this.panelFriendships.Size = new System.Drawing.Size(202, 282);
            this.panelFriendships.TabIndex = 20;
            // 
            // buttonFriendships
            // 
            this.buttonFriendships.BackColor = System.Drawing.Color.Transparent;
            this.buttonFriendships.BackgroundImage = global::FacebookDesktopUI.Properties.Resources.Friendships_Logo;
            this.buttonFriendships.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFriendships.ForeColor = System.Drawing.Color.White;
            this.buttonFriendships.Location = new System.Drawing.Point(0, 0);
            this.buttonFriendships.Name = "buttonFriendships";
            this.buttonFriendships.Size = new System.Drawing.Size(202, 182);
            this.buttonFriendships.TabIndex = 9;
            this.buttonFriendships.UseVisualStyleBackColor = false;
            this.buttonFriendships.Click += new System.EventHandler(this.buttonFriendships_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(28, 153);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(202, 195);
            this.profilePictureBox.TabIndex = 3;
            this.profilePictureBox.TabStop = false;
            // 
            // buttonViewPosts
            // 
            this.buttonViewPosts.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonViewPosts.ForeColor = System.Drawing.Color.White;
            this.buttonViewPosts.Location = new System.Drawing.Point(833, 0);
            this.buttonViewPosts.Name = "buttonViewPosts";
            this.buttonViewPosts.Size = new System.Drawing.Size(113, 192);
            this.buttonViewPosts.TabIndex = 9;
            this.buttonViewPosts.Text = "View My Posts";
            this.buttonViewPosts.UseVisualStyleBackColor = false;
            this.buttonViewPosts.Click += new System.EventHandler(this.buttonViewPosts_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1245, 971);
            this.Controls.Add(this.panelFriendships);
            this.Controls.Add(this.panelAdvancedFriendFilters);
            this.Controls.Add(this.panelPages);
            this.Controls.Add(this.panelGroups);
            this.Controls.Add(this.panelFriends);
            this.Controls.Add(this.panelPostText);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.topLoginFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacebookDesktop";
            this.topLoginFormPanel.ResumeLayout(false);
            this.topLoginFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panelPostText.ResumeLayout(false);
            this.panelPostText.PerformLayout();
            this.panelFriends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            this.panelGroups.ResumeLayout(false);
            this.panelPages.ResumeLayout(false);
            this.panelAdvancedFriendFilters.ResumeLayout(false);
            this.panelFriendships.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topLoginFormPanel;
        private System.Windows.Forms.PictureBox facebookLogo;
        private System.Windows.Forms.Label personalizedWelcomeLabel;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonPages;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonAdvancedFriendFilters;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Panel panelPostText;
        private System.Windows.Forms.Panel panelFriends;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.Panel panelGroups;
        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.Button buttonFriendships;
        private System.Windows.Forms.Panel panelAdvancedFriendFilters;
        private System.Windows.Forms.Panel panelFriendships;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.Button buttonViewPosts;
    }
}