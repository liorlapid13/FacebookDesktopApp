namespace FacebookDesktopUI
{
    public partial class AdvancedFriendFiltersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedFriendFiltersForm));
            this.topLoginFormPanel = new System.Windows.Forms.Panel();
            this.facebookLogo = new System.Windows.Forms.PictureBox();
            this.advancedFriendFiltersLabel = new System.Windows.Forms.Label();
            this.searchCriteriaPanel = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.filtersComboBox = new System.Windows.Forms.ComboBox();
            this.searchResultsPanel = new System.Windows.Forms.Panel();
            this.listBoxSearchResult = new System.Windows.Forms.ListBox();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topLoginFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).BeginInit();
            this.searchCriteriaPanel.SuspendLayout();
            this.searchResultsPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topLoginFormPanel
            // 
            this.topLoginFormPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.topLoginFormPanel.Controls.Add(this.facebookLogo);
            this.topLoginFormPanel.Controls.Add(this.advancedFriendFiltersLabel);
            this.topLoginFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLoginFormPanel.Location = new System.Drawing.Point(0, 0);
            this.topLoginFormPanel.Name = "topLoginFormPanel";
            this.topLoginFormPanel.Size = new System.Drawing.Size(930, 137);
            this.topLoginFormPanel.TabIndex = 3;
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
            // advancedFriendFiltersLabel
            // 
            this.advancedFriendFiltersLabel.AutoSize = true;
            this.advancedFriendFiltersLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancedFriendFiltersLabel.ForeColor = System.Drawing.Color.Snow;
            this.advancedFriendFiltersLabel.Location = new System.Drawing.Point(168, 41);
            this.advancedFriendFiltersLabel.Name = "advancedFriendFiltersLabel";
            this.advancedFriendFiltersLabel.Size = new System.Drawing.Size(566, 62);
            this.advancedFriendFiltersLabel.TabIndex = 0;
            this.advancedFriendFiltersLabel.Text = "Advanced Friend Filters";
            this.advancedFriendFiltersLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchCriteriaPanel
            // 
            this.searchCriteriaPanel.Controls.Add(this.buttonSearch);
            this.searchCriteriaPanel.Controls.Add(this.filtersComboBox);
            this.searchCriteriaPanel.Location = new System.Drawing.Point(21, 407);
            this.searchCriteriaPanel.Name = "searchCriteriaPanel";
            this.searchCriteriaPanel.Size = new System.Drawing.Size(294, 134);
            this.searchCriteriaPanel.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(0, 46);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(294, 88);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // filtersComboBox
            // 
            this.filtersComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.filtersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtersComboBox.FormattingEnabled = true;
            this.filtersComboBox.Items.AddRange(new object[] {
            "Gender",
            "City",
            "Country",
            "Common Liked Pages",
            "Common Groups"});
            this.filtersComboBox.Location = new System.Drawing.Point(0, 0);
            this.filtersComboBox.Name = "filtersComboBox";
            this.filtersComboBox.Size = new System.Drawing.Size(294, 39);
            this.filtersComboBox.TabIndex = 0;
            // 
            // searchResultsPanel
            // 
            this.searchResultsPanel.Controls.Add(this.listBoxSearchResult);
            this.searchResultsPanel.Location = new System.Drawing.Point(334, 160);
            this.searchResultsPanel.Name = "searchResultsPanel";
            this.searchResultsPanel.Size = new System.Drawing.Size(556, 381);
            this.searchResultsPanel.TabIndex = 5;
            // 
            // listBoxSearchResult
            // 
            this.listBoxSearchResult.DataSource = this.userBindingSource;
            this.listBoxSearchResult.DisplayMember = "Name";
            this.listBoxSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSearchResult.FormattingEnabled = true;
            this.listBoxSearchResult.ItemHeight = 31;
            this.listBoxSearchResult.Location = new System.Drawing.Point(0, 0);
            this.listBoxSearchResult.Name = "listBoxSearchResult";
            this.listBoxSearchResult.Size = new System.Drawing.Size(556, 381);
            this.listBoxSearchResult.TabIndex = 0;
            this.listBoxSearchResult.ValueMember = "About";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.buttonExit);
            this.buttonsPanel.Location = new System.Drawing.Point(625, 560);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(265, 74);
            this.buttonsPanel.TabIndex = 6;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(264, 74);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(21, 160);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(294, 229);
            this.profilePictureBox.TabIndex = 7;
            this.profilePictureBox.TabStop = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // AdvancedFriendFiltersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(930, 646);
            this.ControlBox = false;
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.searchResultsPanel);
            this.Controls.Add(this.searchCriteriaPanel);
            this.Controls.Add(this.topLoginFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdvancedFriendFiltersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Friend Filters";
            this.topLoginFormPanel.ResumeLayout(false);
            this.topLoginFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).EndInit();
            this.searchCriteriaPanel.ResumeLayout(false);
            this.searchResultsPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topLoginFormPanel;
        private System.Windows.Forms.PictureBox facebookLogo;
        private System.Windows.Forms.Label advancedFriendFiltersLabel;
        private System.Windows.Forms.Panel searchCriteriaPanel;
        private System.Windows.Forms.ComboBox filtersComboBox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel searchResultsPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.ListBox listBoxSearchResult;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}