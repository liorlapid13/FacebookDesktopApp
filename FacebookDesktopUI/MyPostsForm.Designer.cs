namespace FacebookDesktopUI
{
    public partial class MyPostsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPostsForm));
            this.formPanelTop = new System.Windows.Forms.Panel();
            this.labelMyPosts = new System.Windows.Forms.Label();
            this.facebookLogo = new System.Windows.Forms.PictureBox();
            this.personalizedWelcomeLabel = new System.Windows.Forms.Label();
            this.panelPostData = new System.Windows.Forms.Panel();
            this.textBoxPostData = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelButtonExit = new System.Windows.Forms.Panel();
            this.formPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).BeginInit();
            this.panelPostData.SuspendLayout();
            this.panelButtonExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // formPanelTop
            // 
            this.formPanelTop.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.formPanelTop.Controls.Add(this.labelMyPosts);
            this.formPanelTop.Controls.Add(this.facebookLogo);
            this.formPanelTop.Controls.Add(this.personalizedWelcomeLabel);
            this.formPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.formPanelTop.Location = new System.Drawing.Point(0, 0);
            this.formPanelTop.Name = "formPanelTop";
            this.formPanelTop.Size = new System.Drawing.Size(944, 137);
            this.formPanelTop.TabIndex = 3;
            // 
            // labelMyPosts
            // 
            this.labelMyPosts.AutoSize = true;
            this.labelMyPosts.Font = new System.Drawing.Font("Microsoft YaHei", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyPosts.ForeColor = System.Drawing.Color.Snow;
            this.labelMyPosts.Location = new System.Drawing.Point(174, 41);
            this.labelMyPosts.Name = "labelMyPosts";
            this.labelMyPosts.Size = new System.Drawing.Size(235, 62);
            this.labelMyPosts.TabIndex = 2;
            this.labelMyPosts.Text = "My Posts";
            this.labelMyPosts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // panelPostData
            // 
            this.panelPostData.Controls.Add(this.textBoxPostData);
            this.panelPostData.Controls.Add(this.buttonNext);
            this.panelPostData.Location = new System.Drawing.Point(31, 170);
            this.panelPostData.Name = "panelPostData";
            this.panelPostData.Size = new System.Drawing.Size(885, 558);
            this.panelPostData.TabIndex = 4;
            // 
            // textBoxPostData
            // 
            this.textBoxPostData.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxPostData.Location = new System.Drawing.Point(0, 0);
            this.textBoxPostData.Multiline = true;
            this.textBoxPostData.Name = "textBoxPostData";
            this.textBoxPostData.ReadOnly = true;
            this.textBoxPostData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPostData.Size = new System.Drawing.Size(885, 457);
            this.textBoxPostData.TabIndex = 4;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonNext.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(0, 469);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(885, 89);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Next Post";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(0, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(294, 87);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelButtonExit
            // 
            this.panelButtonExit.Controls.Add(this.buttonExit);
            this.panelButtonExit.Location = new System.Drawing.Point(622, 745);
            this.panelButtonExit.Name = "panelButtonExit";
            this.panelButtonExit.Size = new System.Drawing.Size(294, 99);
            this.panelButtonExit.TabIndex = 6;
            // 
            // MyPostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(944, 836);
            this.ControlBox = false;
            this.Controls.Add(this.panelButtonExit);
            this.Controls.Add(this.panelPostData);
            this.Controls.Add(this.formPanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MyPostsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostsForm";
            this.formPanelTop.ResumeLayout(false);
            this.formPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).EndInit();
            this.panelPostData.ResumeLayout(false);
            this.panelPostData.PerformLayout();
            this.panelButtonExit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formPanelTop;
        private System.Windows.Forms.PictureBox facebookLogo;
        private System.Windows.Forms.Label personalizedWelcomeLabel;
        private System.Windows.Forms.Label labelMyPosts;
        private System.Windows.Forms.Panel panelPostData;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelButtonExit;
        private System.Windows.Forms.TextBox textBoxPostData;
    }
}