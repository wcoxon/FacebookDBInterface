using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FacebookDBInterface
{
    public partial class AccountDetails : Form
    {
        MySqlCommand AccountDetailsCmd;
        MySqlCommand CommitChangesCmd;
        MySqlCommand DeleteAccountCmd;
        MySqlDataAdapter adapter;
        DataTable AccountInfo;
        DataTable WorkplaceTable;
        DataTable UniversityTable;
        uint AccountID;
        
        public AccountDetails(uint accountID)
        {
            AccountID = accountID;
            AccountDetailsCmd = new MySqlCommand("SELECT * FROM userprofiles WHERE UserID = @UserID;",connectionHolder.getConnection());
            
            AccountDetailsCmd.Parameters.AddWithValue("@UserID", accountID);
            
            adapter = new MySqlDataAdapter(AccountDetailsCmd);
            


            AccountInfo = new DataTable();
            WorkplaceTable = new DataTable();
            UniversityTable = new DataTable();
            connectionHolder.openConnection();
            adapter.Fill(AccountInfo);
            AccountDetailsCmd.CommandText = "SELECT Workplace FROM workplaces WHERE UserID = @UserID;";
            adapter.Fill(WorkplaceTable);
            AccountDetailsCmd.CommandText = "SELECT SchoolUniversity FROM schoolsuniversities WHERE UserID = @UserID;";
            adapter.Fill(UniversityTable);
            connectionHolder.closeConnection();

            InitializeComponent();
            UserIDBox.Text = AccountInfo.Rows[0][0].ToString();
            FirstNameBox.Text = AccountInfo.Rows[0][1].ToString();
            LastNameBox.Text = AccountInfo.Rows[0][2].ToString();
            HometownBox.Text = AccountInfo.Rows[0][3].ToString();
            GenderBox.SelectedItem = AccountInfo.Rows[0][4].ToString();
            RelationshipStatusBox.SelectedItem = AccountInfo.Rows[0][5].ToString();
            TownCityBox.Text = AccountInfo.Rows[0][6].ToString();
            WorkplaceList.DataSource = WorkplaceTable;
            UniversityList.DataSource = UniversityTable;
        }

        private void AccountDetails_Load(object sender, EventArgs e)
        {
            WorkplaceList.ClearSelection();
            UniversityList.ClearSelection();
            WorkplaceList.AutoResizeColumns();
            UniversityList.AutoResizeColumns();
            WorkplaceList.Width = WorkplaceList.Columns.GetColumnsWidth(DataGridViewElementStates.None);
            UniversityList.Width = UniversityList.Columns.GetColumnsWidth(DataGridViewElementStates.None);
            //if(UniversityList.Columns.Count)
            WorkplaceList.Columns[0].MinimumWidth = WorkplaceList.MinimumSize.Width;
            UniversityList.Columns[0].MinimumWidth = UniversityList.MinimumSize.Width;
            WorkplaceList.Height = WorkplaceList.Rows.GetRowsHeight(DataGridViewElementStates.None);
            UniversityList.Height = UniversityList.Rows.GetRowsHeight(DataGridViewElementStates.None);

        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            DetailsButton.Enabled = false;
            DetailsPanel.Enabled = true;
            RevertButton.Enabled = true;
            DeleteButton.Enabled = true;
            ConfirmButton.Enabled = true;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            CommitChangesCmd = new MySqlCommand("UPDATE userprofiles SET FirstName=@FirstName, LastName=@LastName, Hometown = @Hometown, Gender=@Gender, RelationshipStatus=@RelationshipStatus, TownCity=@Towncity WHERE UserID=@UserID;",connectionHolder.getConnection());
            CommitChangesCmd.Parameters.AddWithValue("@FirstName",FirstNameBox.Text);
            CommitChangesCmd.Parameters.AddWithValue("@LastName",LastNameBox.Text);
            CommitChangesCmd.Parameters.AddWithValue("@Hometown",HometownBox.Text);
            CommitChangesCmd.Parameters.AddWithValue("@Gender",GenderBox.SelectedItem);
            CommitChangesCmd.Parameters.AddWithValue("@RelationshipStatus",RelationshipStatusBox.SelectedItem);
            CommitChangesCmd.Parameters.AddWithValue("@TownCity",TownCityBox.Text);
            CommitChangesCmd.Parameters.AddWithValue("@UserID", AccountID);
            connectionHolder.openConnection();
            try
            {
                CommitChangesCmd.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connectionHolder.closeConnection();

        }

        private void RevertButton_Click(object sender, EventArgs e)
        {
            UserIDBox.Text = AccountInfo.Rows[0][0].ToString();
            FirstNameBox.Text = AccountInfo.Rows[0][1].ToString();
            LastNameBox.Text = AccountInfo.Rows[0][2].ToString();
            HometownBox.Text = AccountInfo.Rows[0][3].ToString();
            GenderBox.SelectedItem = AccountInfo.Rows[0][4].ToString();
            RelationshipStatusBox.SelectedItem = AccountInfo.Rows[0][5].ToString();
            TownCityBox.Text = AccountInfo.Rows[0][6].ToString();
            WorkplaceList.DataSource = WorkplaceTable;
            UniversityList.DataSource = UniversityTable;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteAccountCmd = new MySqlCommand("DELETE FROM userprofiles WHERE UserID = @UserID", connectionHolder.getConnection());
            DeleteAccountCmd.Parameters.AddWithValue("@UserID", AccountID);
            connectionHolder.openConnection();
            DeleteAccountCmd.ExecuteNonQuery();
            connectionHolder.closeConnection();
            
            Application.Restart();
            this.Close();
        }
    }
}
