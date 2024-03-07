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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Homeownerbtn_Click_1(object sender, EventArgs e)
        {
            CloseCurrentForms();
            HomeownersUI mdiChild = new HomeownersUI();
            mdiChild.MdiParent = this;
            mdiChild.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CloseCurrentForms();
            ReadingsUI mdiChild = new ReadingsUI();
            mdiChild.MdiParent = this;
            mdiChild.Show();
        }

        private void BillingsBTN_Click(object sender, EventArgs e)
        {
            CloseCurrentForms();
            Billing displayBillingForm = new Billing();
            displayBillingForm.MdiParent = this;
            displayBillingForm.Show();
        }

        private void collectionsBTN_Click(object sender, EventArgs e)
        {
            CloseCurrentForms();
            CollectionsUI displayCollectionsUIForm = new CollectionsUI();
            displayCollectionsUIForm.MdiParent = this;
            displayCollectionsUIForm.Show();
        }

        private void reportBTN_Click(object sender, EventArgs e)
        {
            CloseCurrentForms();
            ReportsUI displayReportsUIForm = new ReportsUI();
            displayReportsUIForm.MdiParent = this;
            displayReportsUIForm.Show();
        }

        private void configBTN_Click(object sender, EventArgs e)
        {
            CloseCurrentForms();
           configurationUI displayconfigurationUIForm = new configurationUI();
            displayconfigurationUIForm.MdiParent = this;
            displayconfigurationUIForm.Show();
        }

        public void CloseCurrentForms()
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
