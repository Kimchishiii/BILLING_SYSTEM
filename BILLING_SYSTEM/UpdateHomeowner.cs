using BILLING_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BILLING_SYSTEM
{
    public partial class UpdateHomeowner : Form
    {
        public UpdateHomeowner()
        {
            InitializeComponent();
        }
        public UpdateHomeowner(HomeOwners homeOwners):this()
        {
            txtGenerateId.Text = homeOwners.HomeOwnerId.ToString();
            cbPhaseName.Text = homeOwners.PhaseName;
            txtFullName.Text = homeOwners.FullName;
            txtEmail.Text = homeOwners.Email;
            txtContactNo.Text = homeOwners.ContactNo;
            txtBlock.Text = homeOwners.Block;
            txtLot.Text = homeOwners.Lot;
            dtMoveInDate.Value = homeOwners.MoveInDate; 
        }
        private void UpdateHomeowner_Load(object sender, EventArgs e)
        {

        }
    }
}
