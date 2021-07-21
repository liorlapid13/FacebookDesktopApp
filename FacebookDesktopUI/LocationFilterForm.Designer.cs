namespace FacebookDesktopUI
{
    public partial class LocationFilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationFilterForm));
            this.topFormPanel = new System.Windows.Forms.Panel();
            this.facebookLogo = new System.Windows.Forms.PictureBox();
            this.filterByLocationLabel = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.enterALocationLabel = new System.Windows.Forms.Label();
            this.submitPanel = new System.Windows.Forms.Panel();
            this.topFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.submitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topFormPanel
            // 
            this.topFormPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.topFormPanel.Controls.Add(this.facebookLogo);
            this.topFormPanel.Controls.Add(this.filterByLocationLabel);
            this.topFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topFormPanel.Location = new System.Drawing.Point(0, 0);
            this.topFormPanel.Name = "topFormPanel";
            this.topFormPanel.Size = new System.Drawing.Size(616, 137);
            this.topFormPanel.TabIndex = 5;
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
            // filterByLocationLabel
            // 
            this.filterByLocationLabel.AutoSize = true;
            this.filterByLocationLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterByLocationLabel.ForeColor = System.Drawing.Color.Snow;
            this.filterByLocationLabel.Location = new System.Drawing.Point(168, 41);
            this.filterByLocationLabel.Name = "filterByLocationLabel";
            this.filterByLocationLabel.Size = new System.Drawing.Size(0, 62);
            this.filterByLocationLabel.TabIndex = 0;
            this.filterByLocationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(0, 0);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(156, 82);
            this.buttonSubmit.TabIndex = 8;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cityTextBox.Location = new System.Drawing.Point(0, 44);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(301, 38);
            this.cityTextBox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.enterALocationLabel);
            this.panel1.Controls.Add(this.cityTextBox);
            this.panel1.Location = new System.Drawing.Point(31, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 82);
            this.panel1.TabIndex = 10;
            // 
            // enterALocationLabel
            // 
            this.enterALocationLabel.AutoSize = true;
            this.enterALocationLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.enterALocationLabel.Location = new System.Drawing.Point(0, 0);
            this.enterALocationLabel.Name = "enterALocationLabel";
            this.enterALocationLabel.Size = new System.Drawing.Size(0, 32);
            this.enterALocationLabel.TabIndex = 10;
            // 
            // submitPanel
            // 
            this.submitPanel.Controls.Add(this.buttonSubmit);
            this.submitPanel.Location = new System.Drawing.Point(375, 179);
            this.submitPanel.Name = "submitPanel";
            this.submitPanel.Size = new System.Drawing.Size(156, 82);
            this.submitPanel.TabIndex = 11;
            // 
            // LocationFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 296);
            this.ControlBox = false;
            this.Controls.Add(this.submitPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LocationFilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocationFilterForm";
            this.topFormPanel.ResumeLayout(false);
            this.topFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.submitPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topFormPanel;
        private System.Windows.Forms.PictureBox facebookLogo;
        private System.Windows.Forms.Label filterByLocationLabel;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label enterALocationLabel;
        private System.Windows.Forms.Panel submitPanel;
    }
}