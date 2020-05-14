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
    public partial class AccountViewer : Form
    {
        //MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dataTable;
        uint selectedAccountID;
        //DataRow selectedAccount;
        private void loadAccountsList()
        {
            cmd = new MySqlCommand("SELECT UserID AS 'User ID' ,FirstName AS 'First Name' ,LastName AS 'Last Name' FROM userprofiles;", connectionHolder.getConnection());
            adapter = new MySqlDataAdapter(cmd);
            dataTable = new DataTable();
            connectionHolder.openConnection();
            adapter.Fill(dataTable);
            connectionHolder.closeConnection();
            adapter.Dispose();
        }
        public AccountViewer()
        {
            //con = new MySqlConnection("server=localhost;port=3306;UID=root;password=password;database=test;SslMode=none");
            /*cmd = new MySqlCommand("SELECT UserID AS 'User ID',FirstName AS 'First Name',LastName AS 'Last Name' FROM accounts;", connectionHolder.getConnection());
            adapter = new MySqlDataAdapter(cmd);
            dataTable = new DataTable();
            connectionHolder.openConnection();
            adapter.Fill(dataTable);
            connectionHolder.closeConnection();
            adapter.Dispose();*/
            loadAccountsList();
            InitializeComponent();
            AccountsGrid.DataSource = dataTable;
            

        }
        
        private void AccountViewer_Load(object sender, EventArgs e)
        {
            AccountsGrid.ClearSelection();
            AccountsGrid.SelectionChanged += AccountsGrid_SelectionChanged;
            AccountsGrid.AutoResizeColumns();
            AccountsGrid.Width = AccountsGrid.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            
        }

        private void AccountsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (AccountsGrid.SelectedRows.Count ==0)
            {
                //event is firing because no rows are selected anymore
            }
            else
            {
                DetailsButton.Visible = true;
                DetailsButton.Left = AccountsGrid.Right;
                DetailsButton.Height = AccountsGrid.SelectedRows[0].Height;
                DetailsButton.Top = AccountsGrid.Top + AccountsGrid.ColumnHeadersHeight + AccountsGrid.SelectedRows[0].Index * AccountsGrid.SelectedRows[0].Height;
                //selectedAccount = ((DataRowView)AccountsGrid.SelectedRows[0].DataBoundItem).Row;

                selectedAccountID = ((DataRowView)AccountsGrid.SelectedRows[0].DataBoundItem).Row.Field<uint>("User ID");
            }
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(selectedAccountID.ToString());
            AccountDetails DetailsWindow = new AccountDetails(selectedAccountID);
            
            DetailsWindow.Show(this);
            //MessageBox.Show(selectedAccount[0] + "|" + selectedAccount[1]);
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccount CreatorWindow = new CreateAccount();
            
            CreatorWindow.Show(this);
        }
    }
}
