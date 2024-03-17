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
            displayhomeOwner_SaveForm.ShowDialog();
            FetchData();
        }

        private void HomeownersUI_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dbServer.ServerName);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            FetchData();
        }
        public void FetchData()
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
                homeOwner.LastReading = Convert.ToDateTime(table.Rows[i]["LastReading"]);
                homeOwner.PreviousReading = Convert.ToDecimal(table.Rows[i]["PreviousReading"]);
                homeOwner.LastCollected = Convert.ToDateTime(table.Rows[i]["LastCollected"]);
                homeOwner.WaterServiceStatus = Convert.ToString(table.Rows[i]["WaterServiceStatus"]);
                homeOwner.GarbageCollectionStatus = Convert.ToString(table.Rows[i]["GarbageCollectionStatus"]);
                homeOwners.Add(homeOwner);
            }
            dtgRecords.DataSource = homeOwners;
            LimitDataGridView();
        }
        private void LimitDataGridView()
        {
            dtgRecords.Columns["LastReading"].Visible = false;
            dtgRecords.Columns["PreviousReading"].Visible = false;
            dtgRecords.Columns["LastCollected"].Visible = false;
            dtgRecords.Columns["WaterServiceStatus"].Width = 150;
            dtgRecords.Columns["GarbageCollectionStatus"].Width = 176;
        }
        private void ShowBTN_Click(object sender, EventArgs e)
        {
            FetchData();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dtgRecords.CurrentRow;
            int selectedId = Convert.ToInt32(selectedRow.Cells["HomeOwnerId"].Value);
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
            FetchData();
            
        }
        public void dtgRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
               
        }
        private HomeOwners GetData()
        {
            DataGridViewRow selectedRow = dtgRecords.CurrentRow;
            return new HomeOwners
            {
                HomeOwnerId = Convert.ToInt32(selectedRow.Cells["HomeOwnerId"].Value),
                FullName = selectedRow.Cells["FullName"].Value.ToString(),
                ContactNo = selectedRow.Cells["ContactNo"].Value.ToString(),
                Email = selectedRow.Cells["Email"].Value.ToString(),
                PhaseName = selectedRow.Cells["PhaseName"].Value.ToString(),
                Block = selectedRow.Cells["Block"].Value.ToString(),
                Lot = selectedRow.Cells["Lot"].Value.ToString(),
                MoveInDate = Convert.ToDateTime(selectedRow.Cells["MoveInDate"].Value),
                LastReading = Convert.ToDateTime(selectedRow.Cells["LastReading"].Value),
                PreviousReading = Convert.ToDecimal(selectedRow.Cells["PreviousReading"].Value),
                LastCollected = Convert.ToDateTime(selectedRow.Cells["LastCollected"].Value),
                WaterServiceStatus = selectedRow.Cells["WaterServiceStatus"].Value.ToString(),
                GarbageCollectionStatus = selectedRow.Cells["GarbageCollectionStatus"].Value.ToString(),
            };
        }

        private void btn_Edit_Click_1(object sender, EventArgs e)
        {
            HomeOwners data = GetData();
            homeOwner_Save displayUpdateHomeownerForm = new homeOwner_Save(data);
            displayUpdateHomeownerForm.ShowDialog();
            FetchData();
        }

        private void dtgRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgRecords_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

