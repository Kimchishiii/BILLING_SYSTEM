﻿namespace BILLING_SYSTEM
{
    partial class HomeownersUI
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
            this.ShowBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.EditBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgRecords = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ShowBTN);
            this.panel1.Controls.Add(this.deleteBTN);
            this.panel1.Controls.Add(this.EditBTN);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 57);
            this.panel1.TabIndex = 0;
            // 
            // ShowBTN
            // 
            this.ShowBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowBTN.Location = new System.Drawing.Point(241, 14);
            this.ShowBTN.Name = "ShowBTN";
            this.ShowBTN.Size = new System.Drawing.Size(63, 29);
            this.ShowBTN.TabIndex = 0;
            this.ShowBTN.Text = "Show";
            this.ShowBTN.UseVisualStyleBackColor = true;
            this.ShowBTN.Click += new System.EventHandler(this.ShowBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBTN.Location = new System.Drawing.Point(488, 16);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(81, 23);
            this.deleteBTN.TabIndex = 5;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // EditBTN
            // 
            this.EditBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBTN.Location = new System.Drawing.Point(314, 16);
            this.EditBTN.Name = "EditBTN";
            this.EditBTN.Size = new System.Drawing.Size(81, 23);
            this.EditBTN.TabIndex = 4;
            this.EditBTN.Text = "New";
            this.EditBTN.UseVisualStyleBackColor = true;
            this.EditBTN.Click += new System.EventHandler(this.EditBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 26);
            this.textBox1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgRecords);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 460);
            this.panel2.TabIndex = 1;
            // 
            // dtgRecords
            // 
            this.dtgRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRecords.Location = new System.Drawing.Point(0, 0);
            this.dtgRecords.Name = "dtgRecords";
            this.dtgRecords.ReadOnly = true;
            this.dtgRecords.Size = new System.Drawing.Size(895, 460);
            this.dtgRecords.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(401, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // HomeownersUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomeownersUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeownersUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeownersUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ShowBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button EditBTN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgRecords;
        private System.Windows.Forms.Button button1;
    }
}