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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Date_Readings = new System.Windows.Forms.DateTimePicker();
            this.SearchBarTextBox = new System.Windows.Forms.TextBox();
            this.Show_BTN = new System.Windows.Forms.Button();
            this.Edit_BTN = new System.Windows.Forms.Button();
            this.Delete_BTN = new System.Windows.Forms.Button();
            this.printBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.printBTN);
            this.panel1.Controls.Add(this.Delete_BTN);
            this.panel1.Controls.Add(this.Edit_BTN);
            this.panel1.Controls.Add(this.Show_BTN);
            this.panel1.Controls.Add(this.SearchBarTextBox);
            this.panel1.Controls.Add(this.Date_Readings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 55);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 541);
            this.panel2.TabIndex = 1;
            // 
            // Date_Readings
            // 
            this.Date_Readings.Location = new System.Drawing.Point(311, 18);
            this.Date_Readings.Name = "Date_Readings";
            this.Date_Readings.Size = new System.Drawing.Size(200, 20);
            this.Date_Readings.TabIndex = 0;
            // 
            // SearchBarTextBox
            // 
            this.SearchBarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBarTextBox.Location = new System.Drawing.Point(12, 15);
            this.SearchBarTextBox.Name = "SearchBarTextBox";
            this.SearchBarTextBox.Size = new System.Drawing.Size(198, 26);
            this.SearchBarTextBox.TabIndex = 1;
            // 
            // Show_BTN
            // 
            this.Show_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_BTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Show_BTN.Location = new System.Drawing.Point(216, 18);
            this.Show_BTN.Name = "Show_BTN";
            this.Show_BTN.Size = new System.Drawing.Size(75, 23);
            this.Show_BTN.TabIndex = 2;
            this.Show_BTN.Text = "Show";
            this.Show_BTN.UseVisualStyleBackColor = true;
            // 
            // Edit_BTN
            // 
            this.Edit_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit_BTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Edit_BTN.Location = new System.Drawing.Point(527, 15);
            this.Edit_BTN.Name = "Edit_BTN";
            this.Edit_BTN.Size = new System.Drawing.Size(75, 23);
            this.Edit_BTN.TabIndex = 3;
            this.Edit_BTN.Text = "Edit";
            this.Edit_BTN.UseVisualStyleBackColor = true;
            // 
            // Delete_BTN
            // 
            this.Delete_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_BTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Delete_BTN.Location = new System.Drawing.Point(608, 15);
            this.Delete_BTN.Name = "Delete_BTN";
            this.Delete_BTN.Size = new System.Drawing.Size(75, 23);
            this.Delete_BTN.TabIndex = 4;
            this.Delete_BTN.Text = "Delete";
            this.Delete_BTN.UseVisualStyleBackColor = true;
            // 
            // printBTN
            // 
            this.printBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.printBTN.Location = new System.Drawing.Point(849, 15);
            this.printBTN.Name = "printBTN";
            this.printBTN.Size = new System.Drawing.Size(75, 23);
            this.printBTN.TabIndex = 5;
            this.printBTN.Text = "Print";
            this.printBTN.UseVisualStyleBackColor = true;
            // 
            // ReadingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 596);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReadingsUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadingsUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker Date_Readings;
        private System.Windows.Forms.Button printBTN;
        private System.Windows.Forms.Button Delete_BTN;
        private System.Windows.Forms.Button Edit_BTN;
        private System.Windows.Forms.Button Show_BTN;
        private System.Windows.Forms.TextBox SearchBarTextBox;
    }
}