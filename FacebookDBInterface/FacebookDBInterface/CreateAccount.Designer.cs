namespace FacebookDBInterface
{
    partial class CreateAccount
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
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.WorkplaceList = new System.Windows.Forms.DataGridView();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.UniversityList = new System.Windows.Forms.DataGridView();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.HometownBox = new System.Windows.Forms.TextBox();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.RelationshipStatusBox = new System.Windows.Forms.ComboBox();
            this.TownCityBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.WorkplaceLabel = new System.Windows.Forms.Label();
            this.HometownLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.RelationshipStatusLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.UniversityLabel = new System.Windows.Forms.Label();
            this.TownCityLabel = new System.Windows.Forms.Label();
            this.Workplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.University = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkplaceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniversityList)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.Controls.Add(this.WorkplaceList);
            this.DetailsPanel.Controls.Add(this.FirstNameBox);
            this.DetailsPanel.Controls.Add(this.UniversityList);
            this.DetailsPanel.Controls.Add(this.LastNameBox);
            this.DetailsPanel.Controls.Add(this.HometownBox);
            this.DetailsPanel.Controls.Add(this.GenderBox);
            this.DetailsPanel.Controls.Add(this.RelationshipStatusBox);
            this.DetailsPanel.Controls.Add(this.TownCityBox);
            this.DetailsPanel.Location = new System.Drawing.Point(295, 12);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(203, 426);
            this.DetailsPanel.TabIndex = 21;
            // 
            // WorkplaceList
            // 
            this.WorkplaceList.AllowUserToOrderColumns = true;
            this.WorkplaceList.AllowUserToResizeColumns = false;
            this.WorkplaceList.AllowUserToResizeRows = false;
            this.WorkplaceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WorkplaceList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.WorkplaceList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.WorkplaceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkplaceList.ColumnHeadersVisible = false;
            this.WorkplaceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Workplace});
            this.WorkplaceList.Location = new System.Drawing.Point(3, 217);
            this.WorkplaceList.MaximumSize = new System.Drawing.Size(0, 87);
            this.WorkplaceList.MinimumSize = new System.Drawing.Size(121, 0);
            this.WorkplaceList.Name = "WorkplaceList";
            this.WorkplaceList.RowHeadersVisible = false;
            this.WorkplaceList.Size = new System.Drawing.Size(121, 87);
            this.WorkplaceList.TabIndex = 6;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(3, 59);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameBox.TabIndex = 0;
            // 
            // UniversityList
            // 
            this.UniversityList.AllowUserToResizeColumns = false;
            this.UniversityList.AllowUserToResizeRows = false;
            this.UniversityList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UniversityList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UniversityList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UniversityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UniversityList.ColumnHeadersVisible = false;
            this.UniversityList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.University});
            this.UniversityList.Location = new System.Drawing.Point(3, 310);
            this.UniversityList.MaximumSize = new System.Drawing.Size(0, 87);
            this.UniversityList.MinimumSize = new System.Drawing.Size(121, 0);
            this.UniversityList.Name = "UniversityList";
            this.UniversityList.RowHeadersVisible = false;
            this.UniversityList.Size = new System.Drawing.Size(121, 87);
            this.UniversityList.TabIndex = 18;
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
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConfirmButton.FlatAppearance.BorderSize = 0;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Location = new System.Drawing.Point(504, 415);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(117, 23);
            this.ConfirmButton.TabIndex = 22;
            this.ConfirmButton.Text = "Create account";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // WorkplaceLabel
            // 
            this.WorkplaceLabel.AutoSize = true;
            this.WorkplaceLabel.Location = new System.Drawing.Point(230, 229);
            this.WorkplaceLabel.Name = "WorkplaceLabel";
            this.WorkplaceLabel.Size = new System.Drawing.Size(62, 13);
            this.WorkplaceLabel.TabIndex = 25;
            this.WorkplaceLabel.Text = "Workplace:";
            // 
            // HometownLabel
            // 
            this.HometownLabel.AutoSize = true;
            this.HometownLabel.Location = new System.Drawing.Point(231, 126);
            this.HometownLabel.Name = "HometownLabel";
            this.HometownLabel.Size = new System.Drawing.Size(61, 13);
            this.HometownLabel.TabIndex = 21;
            this.HometownLabel.Text = "Hometown:";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(250, 152);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(42, 13);
            this.GenderLabel.TabIndex = 22;
            this.GenderLabel.Text = "Gender";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(231, 100);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.LastNameLabel.TabIndex = 20;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // RelationshipStatusLabel
            // 
            this.RelationshipStatusLabel.AutoSize = true;
            this.RelationshipStatusLabel.Location = new System.Drawing.Point(191, 179);
            this.RelationshipStatusLabel.Name = "RelationshipStatusLabel";
            this.RelationshipStatusLabel.Size = new System.Drawing.Size(101, 13);
            this.RelationshipStatusLabel.TabIndex = 23;
            this.RelationshipStatusLabel.Text = "Relationship Status:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(232, 74);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.FirstNameLabel.TabIndex = 19;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // UniversityLabel
            // 
            this.UniversityLabel.AutoSize = true;
            this.UniversityLabel.Location = new System.Drawing.Point(236, 322);
            this.UniversityLabel.Name = "UniversityLabel";
            this.UniversityLabel.Size = new System.Drawing.Size(56, 13);
            this.UniversityLabel.TabIndex = 26;
            this.UniversityLabel.Text = "University:";
            // 
            // TownCityLabel
            // 
            this.TownCityLabel.AutoSize = true;
            this.TownCityLabel.Location = new System.Drawing.Point(265, 206);
            this.TownCityLabel.Name = "TownCityLabel";
            this.TownCityLabel.Size = new System.Drawing.Size(27, 13);
            this.TownCityLabel.TabIndex = 24;
            this.TownCityLabel.Text = "City:";
            // 
            // Workplace
            // 
            this.Workplace.HeaderText = "Workplace";
            this.Workplace.Name = "Workplace";
            // 
            // University
            // 
            this.University.HeaderText = "University";
            this.University.Name = "University";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WorkplaceLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.HometownLabel);
            this.Controls.Add(this.DetailsPanel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.TownCityLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.UniversityLabel);
            this.Controls.Add(this.RelationshipStatusLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.DetailsPanel.ResumeLayout(false);
            this.DetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkplaceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniversityList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.DataGridView WorkplaceList;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.DataGridView UniversityList;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox HometownBox;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.ComboBox RelationshipStatusBox;
        private System.Windows.Forms.TextBox TownCityBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label WorkplaceLabel;
        private System.Windows.Forms.Label HometownLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label RelationshipStatusLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label UniversityLabel;
        private System.Windows.Forms.Label TownCityLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Workplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn University;
    }
}