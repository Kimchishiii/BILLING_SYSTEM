using BILLING_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BILLING_SYSTEM
{
    public partial class homeOwner_Save : Form
    {
        List<HomeOwners> homeOwners;
        HomeOwners homeOwner;
        SqlConnection conn;
        SqlCommand cmd;
        public homeOwner_Save()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtGenerateId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomeOwners data = GetData();
            string query = "";
            string msg = "Saved";
            if (button3.Text == "Save")
                query = $"insert into HomeOwners VALUES(@FullName,@ContactNo,@Email,@PhaseName,@Block,@Lot,@MoveInDate,@Created_at)";
            else
            {
                msg = "Updated";
                query = $"update HomeOwners set Username=@Username, Password=@Password, Firstname=@Firstname, Lastname=@Lastname, UserType=@UserType, Age=@Age, Sex=@Sex, Position=@Position where UserId='{homeOwner.HomeOwnerId}'";
            }
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@FullName", data.FullName);
            cmd.Parameters.AddWithValue("@ContactNo", data.ContactNo);
            cmd.Parameters.AddWithValue("@Email", data.Email);
            cmd.Parameters.AddWithValue("@PhaseName", data.PhaseName);
            cmd.Parameters.AddWithValue("@Block", data.Block);
            cmd.Parameters.AddWithValue("@Lot", data.Lot);
            cmd.Parameters.AddWithValue("@MoveInDate", data.MoveInDate);
            cmd.Parameters.AddWithValue("@Created_at", data.Created_at);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully " + msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void homeOwner_Save_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dbServer.ServerName);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
        private HomeOwners GetData()
        {
            return new HomeOwners
            {
                FullName = txtFullName.Text,
                ContactNo = txtContactNo.Text,
                Email = txtEmail.Text,
                PhaseName = cbPhaseName.Text,
                Block = txtBlock.Text,
                Lot = txtLot.Text,
                MoveInDate = dtMoveInDate.Value.Date,
                Created_at = dtCreatedDate.Value.Date
            };
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
