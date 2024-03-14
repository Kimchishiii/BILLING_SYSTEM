using BILLING_SYSTEM.Models;
using System;
using System.Collections;
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
    public partial class HomeownersUI : Form
    {
        List<HomeOwners> homeOwners;
        SqlConnection conn;
        SqlCommand cmd;
        public HomeownersUI()
        {
            InitializeComponent();
        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            homeOwner_Save displayhomeOwner_SaveForm = new homeOwner_Save();
            displayhomeOwner_SaveForm.Show();

            this.Show();
        }

        private void HomeownersUI_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dbServer.ServerName);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            FetchData();
        }
        private void FetchData()
        {
            string selectquery = "select * from HomeOwners";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            homeOwners = new List<HomeOwners>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                HomeOwners homeOwner = new HomeOwners();
                homeOwner.HomeOwnerId = Convert.ToInt32(table.Rows[i]["HomeOwnerId"]);
                homeOwner.FullName = Convert.ToString(table.Rows[i]["FullName"]);
                homeOwner.ContactNo = Convert.ToString(table.Rows[i]["ContactNo"]);
                homeOwner.Email = Convert.ToString(table.Rows[i]["Email"]);
                homeOwner.PhaseName = Convert.ToString(table.Rows[i]["PhaseName"]);
                homeOwner.Block = Convert.ToString(table.Rows[i]["Block"]);
                homeOwner.Lot = Convert.ToString(table.Rows[i]["Lot"]);
                homeOwner.MoveInDate = Convert.ToDateTime(table.Rows[i]["MoveInDate"]);
                homeOwner.Created_at = Convert.ToDateTime(table.Rows[i]["Created_at"]);
                homeOwners.Add(homeOwner);
            }
            dtgRecords.DataSource = homeOwners;
        }

        private void ShowBTN_Click(object sender, EventArgs e)
        {
            FetchData();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            var query = "DELETE FROM HomeOwners WHERE HomeOwnerId = @HomeOwnerId";
            cmd.CommandText = query;

            cmd.Parameters.AddWithValue("@HomeOwnerId", selectedId);

            conn.Open();
            DialogResult dr = MessageBox.Show("Are you sure you want to delete the row?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Row deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FetchData(); 
                    }
                    else
                    {
                        MessageBox.Show("No rows were deleted. Verify the selected ID.", "No Rows Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                conn.Close();
            }
        }


        public void btn_Edit_Click(object sender, EventArgs e)
            {
                HomeOwners data = GetData();
                UpdateHomeowner displayUpdateHomeownerForm = new UpdateHomeowner(data);
                displayUpdateHomeownerForm.Show();
            }
            string selectedId;
            DataGridViewRow row;
            public void dtgRecords_CellClick(object sender, DataGridViewCellEventArgs e)
            {
               
            }
            private HomeOwners GetData()
            {
                return new HomeOwners
                {
                    HomeOwnerId = int.Parse(selectedId),
                    FullName = row.Cells[1].Value.ToString(),
                    ContactNo = row.Cells[2].Value.ToString(),
                    Email = row.Cells[3].Value.ToString(),
                    PhaseName = row.Cells[4].Value.ToString(),
                    Block = row.Cells[5].Value.ToString(),
                    Lot = row.Cells[6].Value.ToString(),
                    MoveInDate = Convert.ToDateTime(row.Cells[7].Value),
                };
            }

        private void dtgRecords_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            this.row = dtgRecords.Rows[index];
            this.selectedId = row.Cells[0].Value.ToString();
        }
    }
    }

