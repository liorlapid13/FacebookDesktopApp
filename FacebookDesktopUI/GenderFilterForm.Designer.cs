namespace FacebookDesktopUI
{
    public partial class GenderFilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenderFilterForm));
            this.topLoginFormPanel = new System.Windows.Forms.Panel();
            this.facebookLogo = new System.Windows.Forms.PictureBox();
            this.filterByGenderLabel = new System.Windows.Forms.Label();
            this.genderSelectionPanel = new System.Windows.Forms.Panel();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.topLoginFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).BeginInit();
            this.genderSelectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLoginFormPanel
            // 
            this.topLoginFormPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.topLoginFormPanel.Controls.Add(this.facebookLogo);
            this.topLoginFormPanel.Controls.Add(this.filterByGenderLabel);
            this.topLoginFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLoginFormPanel.Location = new System.Drawing.Point(0, 0);
            this.topLoginFormPanel.Name = "topLoginFormPanel";
            this.topLoginFormPanel.Size = new System.Drawing.Size(611, 137);
            this.topLoginFormPanel.TabIndex = 4;
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
            // filterByGenderLabel
            // 
            this.filterByGenderLabel.AutoSize = true;
            this.filterByGenderLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterByGenderLabel.ForeColor = System.Drawing.Color.Snow;
            this.filterByGenderLabel.Location = new System.Drawing.Point(168, 41);
            this.filterByGenderLabel.Name = "filterByGenderLabel";
            this.filterByGenderLabel.Size = new System.Drawing.Size(395, 62);
            this.filterByGenderLabel.TabIndex = 0;
            this.filterByGenderLabel.Text = "Filter by Gender";
            this.filterByGenderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // genderSelectionPanel
            // 
            this.genderSelectionPanel.Controls.Add(this.genderComboBox);
            this.genderSelectionPanel.Location = new System.Drawing.Point(31, 213);
            this.genderSelectionPanel.Name = "genderSelectionPanel";
            this.genderSelectionPanel.Size = new System.Drawing.Size(315, 53);
            this.genderSelectionPanel.TabIndex = 7;
            // 
            // genderComboBox
            // 
            this.genderComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(0, 0);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(315, 39);
            this.genderComboBox.TabIndex = 8;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(390, 195);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(153, 71);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // GenderFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 321);
            this.ControlBox = false;
            this.Controls.Add(this.genderSelectionPanel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.topLoginFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenderFilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenderFilter";
            this.topLoginFormPanel.ResumeLayout(false);
            this.topLoginFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).EndInit();
            this.genderSelectionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topLoginFormPanel;
        private System.Windows.Forms.PictureBox facebookLogo;
        private System.Windows.Forms.Label filterByGenderLabel;
        private System.Windows.Forms.Panel genderSelectionPanel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Button buttonSubmit;
    }
}