namespace FacebookDBInterface
{
    partial class AccountDetails
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
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.HometownBox = new System.Windows.Forms.TextBox();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.RelationshipStatusBox = new System.Windows.Forms.ComboBox();
            this.TownCityBox = new System.Windows.Forms.TextBox();
            this.WorkplaceList = new System.Windows.Forms.DataGridView();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.HometownLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.RelationshipStatusLabel = new System.Windows.Forms.Label();
            this.TownCityLabel = new System.Windows.Forms.Label();
            this.WorkplaceLabel = new System.Windows.Forms.Label();
            this.UniversityLabel = new System.Windows.Forms.Label();
            this.UserIDBox = new System.Windows.Forms.TextBox();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.UniversityList = new System.Windows.Forms.DataGridView();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.RevertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WorkplaceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniversityList)).BeginInit();
            this.DetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(3, 59);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameBox.TabIndex = 0;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(3, 85);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameBox.TabIndex = 1;
            // 
            // HometownBox
            // 
            this.HometownBox.Location = new System.Drawing.Point(3, 111);
            this.HometownBox.Name = "HometownBox";
            this.HometownBox.Size = new System.Drawing.Size(100, 20);
            this.HometownBox.TabIndex = 2;
            // 
            // GenderBox
            // 
            this.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Unspecified"});
            this.GenderBox.Location = new System.Drawing.Point(3, 137);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(121, 21);
            this.GenderBox.TabIndex = 3;
            // 
            // RelationshipStatusBox
            // 
            this.RelationshipStatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RelationshipStatusBox.FormattingEnabled = true;
            this.RelationshipStatusBox.Items.AddRange(new object[] {
            "Single",
            "Engaged",
            "Married",
            "It\'s Complicated"});
            this.RelationshipStatusBox.Location = new System.Drawing.Point(3, 164);
            this.RelationshipStatusBox.Name = "RelationshipStatusBox";
            this.RelationshipStatusBox.Size = new System.Drawing.Size(121, 21);
            this.RelationshipStatusBox.TabIndex = 4;
            // 
            // TownCityBox
            // 
            this.TownCityBox.Location = new System.Drawing.Point(3, 191);
            this.TownCityBox.Name = "TownCityBox";
            this.TownCityBox.Size = new System.Drawing.Size(100, 20);
            this.TownCityBox.TabIndex = 5;
            // 
            // WorkplaceList
            // 
            this.WorkplaceList.AllowUserToAddRows = false;
            this.WorkplaceList.AllowUserToDeleteRows = false;
            this.WorkplaceList.AllowUserToResizeColumns = false;
            this.WorkplaceList.AllowUserToResizeRows = false;
            this.WorkplaceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WorkplaceList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.WorkplaceList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.WorkplaceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkplaceList.ColumnHeadersVisible = false;
            this.WorkplaceList.Location = new System.Drawing.Point(3, 217);
            this.WorkplaceList.MaximumSize = new System.Drawing.Size(0, 87);
            this.WorkplaceList.MinimumSize = new System.Drawing.Size(121, 0);
            this.WorkplaceList.Name = "WorkplaceList";
            this.WorkplaceList.RowHeadersVisible = false;
            this.WorkplaceList.Size = new System.Drawing.Size(121, 87);
            this.WorkplaceList.TabIndex = 6;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(228, 74);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.FirstNameLabel.TabIndex = 8;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(227, 100);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.LastNameLabel.TabIndex = 9;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // HometownLabel
            // 
            this.HometownLabel.AutoSize = true;
            this.HometownLabel.Location = new System.Drawing.Point(227, 126);
            this.HometownLabel.Name = "HometownLabel";
            this.HometownLabel.Size = new System.Drawing.Size(61, 13);
            this.HometownLabel.TabIndex = 10;
            this.HometownLabel.Text = "Hometown:";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(246, 152);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(42, 13);
            this.GenderLabel.TabIndex = 11;
            this.GenderLabel.Text = "Gender";
            // 
            // RelationshipStatusLabel
            // 
            this.RelationshipStatusLabel.AutoSize = true;
            this.RelationshipStatusLabel.Location = new System.Drawing.Point(187, 179);
            this.RelationshipStatusLabel.Name = "RelationshipStatusLabel";
            this.RelationshipStatusLabel.Size = new System.Drawing.Size(101, 13);
            this.RelationshipStatusLabel.TabIndex = 12;
            this.RelationshipStatusLabel.Text = "Relationship Status:";
            // 
            // TownCityLabel
            // 
            this.TownCityLabel.AutoSize = true;
            this.TownCityLabel.Location = new System.Drawing.Point(261, 206);
            this.TownCityLabel.Name = "TownCityLabel";
            this.TownCityLabel.Size = new System.Drawing.Size(27, 13);
            this.TownCityLabel.TabIndex = 13;
            this.TownCityLabel.Text = "City:";
            // 
            // WorkplaceLabel
            // 
            this.WorkplaceLabel.AutoSize = true;
            this.WorkplaceLabel.Location = new System.Drawing.Point(226, 229);
            this.WorkplaceLabel.Name = "WorkplaceLabel";
            this.WorkplaceLabel.Size = new System.Drawing.Size(62, 13);
            this.WorkplaceLabel.TabIndex = 14;
            this.WorkplaceLabel.Text = "Workplace:";
            // 
            // UniversityLabel
            // 
            this.UniversityLabel.AutoSize = true;
            this.UniversityLabel.Location = new System.Drawing.Point(232, 322);
            this.UniversityLabel.Name = "UniversityLabel";
            this.UniversityLabel.Size = new System.Drawing.Size(56, 13);
            this.UniversityLabel.TabIndex = 15;
            this.UniversityLabel.Text = "University:";
            // 
            // UserIDBox
            // 
            this.UserIDBox.Enabled = false;
            this.UserIDBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserIDBox.Location = new System.Drawing.Point(3, 33);
            this.UserIDBox.Name = "UserIDBox";
            this.UserIDBox.Size = new System.Drawing.Size(100, 20);
            this.UserIDBox.TabIndex = 16;
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Location = new System.Drawing.Point(242, 48);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(46, 13);
            this.UserIDLabel.TabIndex = 17;
            this.UserIDLabel.Text = "User ID:";
            // 
            // UniversityList
            // 
            this.UniversityList.AllowUserToAddRows = false;
            this.UniversityList.AllowUserToDeleteRows = false;
            this.UniversityList.AllowUserToResizeColumns = false;
            this.UniversityList.AllowUserToResizeRows = false;
            this.UniversityList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UniversityList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UniversityList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UniversityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UniversityList.ColumnHeadersVisible = false;
            this.UniversityList.Location = new System.Drawing.Point(3, 310);
            this.UniversityList.MaximumSize = new System.Drawing.Size(0, 87);
            this.UniversityList.MinimumSize = new System.Drawing.Size(121, 0);
            this.UniversityList.Name = "UniversityList";
            this.UniversityList.RowHeadersVisible = false;
            this.UniversityList.Size = new System.Drawing.Size(121, 87);
            this.UniversityList.TabIndex = 18;
            // 
            // DetailsButton
            // 
            this.DetailsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DetailsButton.FlatAppearance.BorderSize = 0;
            this.DetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailsButton.Location = new System.Drawing.Point(503, 43);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(117, 23);
            this.DetailsButton.TabIndex = 19;
            this.DetailsButton.Text = "Edit Account Details";
            this.DetailsButton.UseVisualStyleBackColor = false;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.Controls.Add(this.WorkplaceList);
            this.DetailsPanel.Controls.Add(this.FirstNameBox);
            this.DetailsPanel.Controls.Add(this.UniversityList);
            this.DetailsPanel.Controls.Add(this.LastNameBox);
            this.DetailsPanel.Controls.Add(this.HometownBox);
            this.DetailsPanel.Controls.Add(this.UserIDBox);
            this.DetailsPanel.Controls.Add(this.GenderBox);
            this.DetailsPanel.Controls.Add(this.RelationshipStatusBox);
            this.DetailsPanel.Controls.Add(this.TownCityBox);
            this.DetailsPanel.Enabled = false;
            this.DetailsPanel.Location = new System.Drawing.Point(294, 12);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(203, 426);
            this.DetailsPanel.TabIndex = 20;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConfirmButton.Enabled = false;
            this.ConfirmButton.FlatAppearance.BorderSize = 0;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Location = new System.Drawing.Point(503, 415);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(117, 23);
            this.ConfirmButton.TabIndex = 21;
            this.ConfirmButton.Text = "Confirm Changes";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // RevertButton
            // 
            this.RevertButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RevertButton.Enabled = false;
            this.RevertButton.FlatAppearance.BorderSize = 0;
            this.RevertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevertButton.Location = new System.Drawing.Point(503, 74);
            this.RevertButton.Name = "RevertButton";
            this.RevertButton.Size = new System.Drawing.Size(117, 23);
            this.RevertButton.TabIndex = 22;
            this.RevertButton.Text = "Revert Changes";
            this.RevertButton.UseVisualStyleBackColor = false;
            this.RevertButton.Click += new System.EventHandler(this.RevertButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteButton.Enabled = false;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(503, 322);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(117, 23);
            this.DeleteButton.TabIndex = 23;
            this.DeleteButton.Text = "Delete Account";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.RevertButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.DetailsPanel);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.WorkplaceLabel);
            this.Controls.Add(this.HometownLabel);
            this.Controls.Add(this.UserIDLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.RelationshipStatusLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.UniversityLabel);
            this.Controls.Add(this.TownCityLabel);
            this.Name = "AccountDetails";
            this.Text = "Account Details";
            this.Load += new System.EventHandler(this.AccountDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WorkplaceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniversityList)).EndInit();
            this.DetailsPanel.ResumeLayout(false);
            this.DetailsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox HometownBox;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.ComboBox RelationshipStatusBox;
        private System.Windows.Forms.TextBox TownCityBox;
        private System.Windows.Forms.DataGridView WorkplaceList;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label HometownLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label RelationshipStatusLabel;
        private System.Windows.Forms.Label TownCityLabel;
        private System.Windows.Forms.Label WorkplaceLabel;
        private System.Windows.Forms.Label UniversityLabel;
        private System.Windows.Forms.TextBox UserIDBox;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.DataGridView UniversityList;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button RevertButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}