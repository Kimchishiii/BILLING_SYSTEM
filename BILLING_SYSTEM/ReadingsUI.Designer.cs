namespace BILLING_SYSTEM
{
    partial class ReadingsUI
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
            this.Go_BTNRead = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Label();
            this.printBTN = new System.Windows.Forms.Button();
            this.Delete_BTN = new System.Windows.Forms.Button();
            this.Edit_BTN = new System.Windows.Forms.Button();
            this.View_BTN = new System.Windows.Forms.Button();
            this.SearchBarTextBox = new System.Windows.Forms.TextBox();
            this.Date_Readings = new System.Windows.Forms.DateTimePicker();
            this.Readings_Panel = new System.Windows.Forms.Panel();
            this.dgt_Readings = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.Readings_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Readings)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Go_BTNRead);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.printBTN);
            this.panel1.Controls.Add(this.Delete_BTN);
            this.panel1.Controls.Add(this.Edit_BTN);
            this.panel1.Controls.Add(this.View_BTN);
            this.panel1.Controls.Add(this.SearchBarTextBox);
            this.panel1.Controls.Add(this.Date_Readings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 120);
            this.panel1.TabIndex = 0;
            // 
            // Go_BTNRead
            // 
            this.Go_BTNRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Go_BTNRead.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Go_BTNRead.Location = new System.Drawing.Point(279, 69);
            this.Go_BTNRead.Name = "Go_BTNRead";
            this.Go_BTNRead.Size = new System.Drawing.Size(75, 26);
            this.Go_BTNRead.TabIndex = 9;
            this.Go_BTNRead.Text = "Go";
            this.Go_BTNRead.UseVisualStyleBackColor = true;
            this.Go_BTNRead.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date from:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Search
            // 
            this.btn_Search.AutoSize = true;
            this.btn_Search.Location = new System.Drawing.Point(12, 37);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(44, 13);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Search:";
            // 
            // printBTN
            // 
            this.printBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.printBTN.Location = new System.Drawing.Point(579, 29);
            this.printBTN.Name = "printBTN";
            this.printBTN.Size = new System.Drawing.Size(75, 69);
            this.printBTN.TabIndex = 5;
            this.printBTN.Text = "Print";
            this.printBTN.UseVisualStyleBackColor = true;
            // 
            // Delete_BTN
            // 
            this.Delete_BTN.BackColor = System.Drawing.Color.Firebrick;
            this.Delete_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_BTN.Location = new System.Drawing.Point(498, 29);
            this.Delete_BTN.Name = "Delete_BTN";
            this.Delete_BTN.Size = new System.Drawing.Size(75, 69);
            this.Delete_BTN.TabIndex = 4;
            this.Delete_BTN.Text = "Delete";
            this.Delete_BTN.UseVisualStyleBackColor = false;
            // 
            // Edit_BTN
            // 
            this.Edit_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit_BTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Edit_BTN.Location = new System.Drawing.Point(417, 29);
            this.Edit_BTN.Name = "Edit_BTN";
            this.Edit_BTN.Size = new System.Drawing.Size(75, 69);
            this.Edit_BTN.TabIndex = 3;
            this.Edit_BTN.Text = "Edit";
            this.Edit_BTN.UseVisualStyleBackColor = true;
            // 
            // View_BTN
            // 
            this.View_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.View_BTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.View_BTN.Location = new System.Drawing.Point(277, 32);
            this.View_BTN.Name = "View_BTN";
            this.View_BTN.Size = new System.Drawing.Size(75, 23);
            this.View_BTN.TabIndex = 2;
            this.View_BTN.Text = "View";
            this.View_BTN.UseVisualStyleBackColor = true;
            // 
            // SearchBarTextBox
            // 
            this.SearchBarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBarTextBox.Location = new System.Drawing.Point(73, 29);
            this.SearchBarTextBox.Name = "SearchBarTextBox";
            this.SearchBarTextBox.Size = new System.Drawing.Size(198, 26);
            this.SearchBarTextBox.TabIndex = 1;
            // 
            // Date_Readings
            // 
            this.Date_Readings.Location = new System.Drawing.Point(73, 69);
            this.Date_Readings.Name = "Date_Readings";
            this.Date_Readings.Size = new System.Drawing.Size(200, 20);
            this.Date_Readings.TabIndex = 0;
            this.Date_Readings.ValueChanged += new System.EventHandler(this.Date_Readings_ValueChanged);
            // 
            // Readings_Panel
            // 
            this.Readings_Panel.Controls.Add(this.dgt_Readings);
            this.Readings_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Readings_Panel.Location = new System.Drawing.Point(0, 120);
            this.Readings_Panel.Name = "Readings_Panel";
            this.Readings_Panel.Size = new System.Drawing.Size(374, 397);
            this.Readings_Panel.TabIndex = 1;
            // 
            // dgt_Readings
            // 
            this.dgt_Readings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_Readings.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgt_Readings.Location = new System.Drawing.Point(0, 0);
            this.dgt_Readings.Name = "dgt_Readings";
            this.dgt_Readings.Size = new System.Drawing.Size(371, 397);
            this.dgt_Readings.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(386, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 397);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // ReadingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Readings_Panel);
            this.Controls.Add(this.panel1);
            this.Name = "ReadingsUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadingsUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReadingsUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Readings_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Readings)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Readings_Panel;
        private System.Windows.Forms.DateTimePicker Date_Readings;
        private System.Windows.Forms.Button printBTN;
        private System.Windows.Forms.Button Delete_BTN;
        private System.Windows.Forms.Button Edit_BTN;
        private System.Windows.Forms.Button View_BTN;
        private System.Windows.Forms.TextBox SearchBarTextBox;
        private System.Windows.Forms.DataGridView dgt_Readings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Go_BTNRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btn_Search;
    }
}