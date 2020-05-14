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
    public partial class CreateAccount : Form
    {
        MySqlCommand CreateCmd;
        int AccountID;
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            foreach(Control c in DetailsPanel.Controls)
            {
                if ((c.GetType() == typeof(TextBox) || c.GetType()== typeof(ComboBox)) && c.Text.Length <= 0)
                {
                    MessageBox.Show("please provide information in the '" + c.Name + "' field");
                    return;
                }
            }

            CreateCmd = new MySqlCommand("INSERT INTO userprofiles (FirstName,LastName,Hometown,Gender,RelationshipStatus,TownCity) VALUES (@FirstName,@LastName,@Hometown,@Gender,@RelationshipStatus, @TownCity);SELECT @@identity", connectionHolder.getConnection());
            CreateCmd.Parameters.AddWithValue("@FirstName", FirstNameBox.Text);
            CreateCmd.Parameters.AddWithValue("@LastName", LastNameBox.Text);
            CreateCmd.Parameters.AddWithValue("@Hometown", HometownBox.Text);
            CreateCmd.Parameters.AddWithValue("@Gender", GenderBox.SelectedItem);
            CreateCmd.Parameters.AddWithValue("@RelationshipStatus", RelationshipStatusBox.SelectedItem);
            CreateCmd.Parameters.AddWithValue("@TownCity", TownCityBox.Text);
            connectionHolder.openConnection();
            AccountID = Int32.Parse(CreateCmd.ExecuteScalar().ToString());
            CreateCmd.CommandText = "INSERT INTO workplaces (UserID,Workplace) VALUES (@UserID, @Workplace);";
            CreateCmd.Parameters.AddWithValue("@UserID", AccountID);
            CreateCmd.Parameters.AddWithValue("@Workplace", "");
            foreach(DataGridViewRow wrow in WorkplaceList.Rows)
            {
                if (wrow.Cells[0].Value != null)
                {
                    CreateCmd.Parameters["@Workplace"].Value = wrow.Cells[0].Value.ToString();
                    CreateCmd.ExecuteNonQuery();
                }
            }
            CreateCmd.CommandText = "INSERT INTO schoolsuniversities VALUES (@UserID, @SchoolUniversity);";
            CreateCmd.Parameters.AddWithValue("@SchoolUniversity", "");
            foreach (DataGridViewRow urow in UniversityList.Rows)
            {
                if (urow.Cells[0].Value != null)
                {
                    CreateCmd.Parameters["@SchoolUniversity"].Value = urow.Cells[0].Value.ToString();
                    CreateCmd.ExecuteNonQuery();
                }
            }
            connectionHolder.closeConnection();
            
            



        }
    }
}
