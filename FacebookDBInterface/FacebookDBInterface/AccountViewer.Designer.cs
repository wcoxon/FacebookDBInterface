namespace FacebookDBInterface
{
    partial class AccountViewer
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
            this.AccountsGrid = new System.Windows.Forms.DataGridView();
            this.AccountsLabel = new System.Windows.Forms.Label();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountsGrid
            // 
            this.AccountsGrid.AllowUserToAddRows = false;
            this.AccountsGrid.AllowUserToDeleteRows = false;
            this.AccountsGrid.AllowUserToOrderColumns = true;
            this.AccountsGrid.AllowUserToResizeColumns = false;
            this.AccountsGrid.AllowUserToResizeRows = false;
            this.AccountsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AccountsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AccountsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AccountsGrid.Location = new System.Drawing.Point(12, 51);
            this.AccountsGrid.MultiSelect = false;
            this.AccountsGrid.Name = "AccountsGrid";
            this.AccountsGrid.RowHeadersVisible = false;
            this.AccountsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AccountsGrid.Size = new System.Drawing.Size(192, 294);
            this.AccountsGrid.TabIndex = 0;
            // 
            // AccountsLabel
            // 
            this.AccountsLabel.AutoSize = true;
            this.AccountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AccountsLabel.Location = new System.Drawing.Point(13, 13);
            this.AccountsLabel.Name = "AccountsLabel";
            this.AccountsLabel.Size = new System.Drawing.Size(74, 18);
            this.AccountsLabel.TabIndex = 1;
            this.AccountsLabel.Text = "Accounts:";
            // 
            // DetailsButton
            // 
            this.DetailsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DetailsButton.FlatAppearance.BorderSize = 0;
            this.DetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailsButton.Location = new System.Drawing.Point(12, 351);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(90, 23);
            this.DetailsButton.TabIndex = 2;
            this.DetailsButton.Text = "View Details...";
            this.DetailsButton.UseVisualStyleBackColor = false;
            this.DetailsButton.Visible = false;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreateAccountButton.FlatAppearance.BorderSize = 0;
            this.CreateAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAccountButton.Location = new System.Drawing.Point(114, 12);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(90, 23);
            this.CreateAccountButton.TabIndex = 3;
            this.CreateAccountButton.Text = "Create New Account";
            this.CreateAccountButton.UseVisualStyleBackColor = false;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // AccountViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.AccountsLabel);
            this.Controls.Add(this.AccountsGrid);
            this.Name = "AccountViewer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AccountViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AccountsGrid;
        private System.Windows.Forms.Label AccountsLabel;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.Button CreateAccountButton;
    }
}

