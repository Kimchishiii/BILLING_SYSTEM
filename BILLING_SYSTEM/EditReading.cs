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
    public partial class EditReading : Form
    {
        GenerateReading generateReading;
        ReadingsUI ui;
        public EditReading()
        {
            InitializeComponent();
        }
        public EditReading(GenerateReading generateReading, ReadingsUI ui):this()
        {
            this.ui = ui;
            this.generateReading = generateReading;
            txtPreviousReading.Text = generateReading.PreviousReading.ToString("n2");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ui.UpdateDisplayRecord(PassData());
            this.Dispose();
        }
        public GenerateReading PassData()
        {
            return new GenerateReading
            {
                HomeOwnerId = generateReading.HomeOwnerId,
                PreviousReading = generateReading.PreviousReading,
                CurrentReading = Convert.ToDecimal(txtCurrentReading.Text)
            };
        }
    }
}
