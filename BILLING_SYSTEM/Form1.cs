using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BILLING_SYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Homeownerbtn_Click(object sender, EventArgs e)
        {
            HomeownersUI displayHomeownersUIForm = new HomeownersUI();
            displayHomeownersUIForm.Show();

            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadingsUI displayReadingsUIForm = new ReadingsUI();
            displayReadingsUIForm.Show();

            this.Show();
        }

        private void BillingsBTN_Click(object sender, EventArgs e)
        {
            Billing displayBillingUIForm = new Billing();
            displayBillingUIForm.Show();

            this.Show();
        }

        private void collectionsBTN_Click(object sender, EventArgs e)
        {
            CollectionsUI displayCollectionsUIForm = new CollectionsUI();
            displayCollectionsUIForm.Show();

            this.Show();
        }

        private void reportBTN_Click(object sender, EventArgs e)
        {
            ReportsUI displayReportsUIForm = new ReportsUI();
            displayReportsUIForm.Show();

            this.Show();
        }

        private void congifBTN_Click(object sender, EventArgs e)
        {
            ConfigUI displayConfigUIForm = ConfigUI();
            displayConfigUIForm.Show();

            this.Show();
        }
    }
}
