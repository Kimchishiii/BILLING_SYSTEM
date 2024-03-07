namespace BILLING_SYSTEM
{
    partial class ReportsUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_fromReport = new System.Windows.Forms.DateTimePicker();
            this.dtp_toReport = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_PrintReport = new System.Windows.Forms.Button();
            this.txtbox_SearchReport = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ViewReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_ViewReport);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.txtbox_SearchReport);
            this.panel1.Controls.Add(this.btn_PrintReport);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtp_toReport);
            this.panel1.Controls.Add(this.dtp_fromReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 104);
            this.panel1.TabIndex = 0;
            // 
            // dtp_fromReport
            // 
            this.dtp_fromReport.Location = new System.Drawing.Point(386, 26);
            this.dtp_fromReport.Name = "dtp_fromReport";
            this.dtp_fromReport.Size = new System.Drawing.Size(200, 20);
            this.dtp_fromReport.TabIndex = 0;
            // 
            // dtp_toReport
            // 
            this.dtp_toReport.Location = new System.Drawing.Point(386, 60);
            this.dtp_toReport.Name = "dtp_toReport";
            this.dtp_toReport.Size = new System.Drawing.Size(200, 20);
            this.dtp_toReport.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date from:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date to:";
            // 
            // btn_PrintReport
            // 
            this.btn_PrintReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_PrintReport.Location = new System.Drawing.Point(712, 25);
            this.btn_PrintReport.Name = "btn_PrintReport";
            this.btn_PrintReport.Size = new System.Drawing.Size(107, 54);
            this.btn_PrintReport.TabIndex = 4;
            this.btn_PrintReport.Text = "Print Report";
            this.btn_PrintReport.UseVisualStyleBackColor = false;
            // 
            // txtbox_SearchReport
            // 
            this.txtbox_SearchReport.Location = new System.Drawing.Point(58, 42);
            this.txtbox_SearchReport.Name = "txtbox_SearchReport";
            this.txtbox_SearchReport.Size = new System.Drawing.Size(164, 20);
            this.txtbox_SearchReport.TabIndex = 5;
            // 
            // btn_Search
            // 
            this.btn_Search.AutoSize = true;
            this.btn_Search.Location = new System.Drawing.Point(8, 47);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(44, 13);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Search:";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 523);
            this.panel2.TabIndex = 1;
            // 
            // btn_ViewReport
            // 
            this.btn_ViewReport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ViewReport.Location = new System.Drawing.Point(228, 34);
            this.btn_ViewReport.Name = "btn_ViewReport";
            this.btn_ViewReport.Size = new System.Drawing.Size(75, 38);
            this.btn_ViewReport.TabIndex = 7;
            this.btn_ViewReport.Text = "View";
            this.btn_ViewReport.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(592, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ReportsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportsUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btn_Search;
        private System.Windows.Forms.TextBox txtbox_SearchReport;
        private System.Windows.Forms.Button btn_PrintReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_toReport;
        private System.Windows.Forms.DateTimePicker dtp_fromReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ViewReport;
        private System.Windows.Forms.Panel panel2;
    }
}