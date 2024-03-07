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
            
               
            
        }
    }
}
