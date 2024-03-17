namespace BILLING_SYSTEM
{
    partial class homeOwner_Save
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtLastCollected = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cboGarbageCollectionStatus = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtLastReading = new System.Windows.Forms.DateTimePicker();
            this.txtPreviousReading = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboWaterServiceStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtMoveInDate = new System.Windows.Forms.DateTimePicker();
            this.cbPhaseName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBlock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtGenerateId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dtMoveInDate);
            this.panel1.Controls.Add(this.cbPhaseName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtContactNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtLot);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBlock);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txtGenerateId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 662);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtLastCollected);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cboGarbageCollectionStatus);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(13, 465);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(500, 111);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Garbage";
            // 
            // dtLastCollected
            // 
            this.dtLastCollected.Location = new System.Drawing.Point(131, 36);
            this.dtLastCollected.Margin = new System.Windows.Forms.Padding(4);
            this.dtLastCollected.Name = "dtLastCollected";
            this.dtLastCollected.Size = new System.Drawing.Size(348, 22);
            this.dtLastCollected.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "LastCollected:";
            // 
            // cboGarbageCollectionStatus
            // 
            this.cboGarbageCollectionStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGarbageCollectionStatus.FormattingEnabled = true;
            this.cboGarbageCollectionStatus.Items.AddRange(new object[] {
            "resumed",
            "suspended"});
            this.cboGarbageCollectionStatus.Location = new System.Drawing.Point(129, 66);
            this.cboGarbageCollectionStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cboGarbageCollectionStatus.Name = "cboGarbageCollectionStatus";
            this.cboGarbageCollectionStatus.Size = new System.Drawing.Size(349, 24);
            this.cboGarbageCollectionStatus.TabIndex = 21;
            this.cboGarbageCollectionStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 69);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtLastReading);
            this.groupBox1.Controls.Add(this.txtPreviousReading);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboWaterServiceStatus);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(13, 311);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(500, 146);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Water";
            // 
            // dtLastReading
            // 
            this.dtLastReading.Location = new System.Drawing.Point(131, 36);
            this.dtLastReading.Margin = new System.Windows.Forms.Padding(4);
            this.dtLastReading.Name = "dtLastReading";
            this.dtLastReading.Size = new System.Drawing.Size(348, 22);
            this.dtLastReading.TabIndex = 22;
            // 
            // txtPreviousReading
            // 
            this.txtPreviousReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreviousReading.Location = new System.Drawing.Point(131, 68);
            this.txtPreviousReading.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreviousReading.Name = "txtPreviousReading";
            this.txtPreviousReading.Size = new System.Drawing.Size(348, 26);
            this.txtPreviousReading.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "PreviousReading:";
            // 
            // cboWaterServiceStatus
            // 
            this.cboWaterServiceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWaterServiceStatus.FormattingEnabled = true;
            this.cboWaterServiceStatus.Items.AddRange(new object[] {
            "connected",
            "disconnected"});
            this.cboWaterServiceStatus.Location = new System.Drawing.Point(131, 102);
            this.cboWaterServiceStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cboWaterServiceStatus.Name = "cboWaterServiceStatus";
            this.cboWaterServiceStatus.Size = new System.Drawing.Size(349, 24);
            this.cboWaterServiceStatus.TabIndex = 21;
            this.cboWaterServiceStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "LastReading:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 105);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Status:";
            // 
            // dtMoveInDate
            // 
            this.dtMoveInDate.Location = new System.Drawing.Point(143, 279);
            this.dtMoveInDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtMoveInDate.Name = "dtMoveInDate";
            this.dtMoveInDate.Size = new System.Drawing.Size(349, 22);
            this.dtMoveInDate.TabIndex = 22;
            // 
            // cbPhaseName
            // 
            this.cbPhaseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhaseName.FormattingEnabled = true;
            this.cbPhaseName.Items.AddRange(new object[] {
            "Phase II",
            "Phase I"});
            this.cbPhaseName.Location = new System.Drawing.Point(143, 118);
            this.cbPhaseName.Margin = new System.Windows.Forms.Padding(4);
            this.cbPhaseName.Name = "cbPhaseName";
            this.cbPhaseName.Size = new System.Drawing.Size(349, 24);
            this.cbPhaseName.TabIndex = 21;
            this.cbPhaseName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 283);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "MoveInDate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(143, 235);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(349, 26);
            this.txtEmail.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "ContactNo.";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(143, 194);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(349, 26);
            this.txtContactNo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lot:";
            // 
            // txtLot
            // 
            this.txtLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLot.Location = new System.Drawing.Point(376, 155);
            this.txtLot.Margin = new System.Windows.Forms.Padding(4);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(116, 26);
            this.txtLot.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Block:";
            // 
            // txtBlock
            // 
            this.txtBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlock.Location = new System.Drawing.Point(191, 155);
            this.txtBlock.Margin = new System.Windows.Forms.Padding(4);
            this.txtBlock.Name = "txtBlock";
            this.txtBlock.Size = new System.Drawing.Size(122, 26);
            this.txtBlock.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Full Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(143, 73);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(349, 26);
            this.txtFullName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "IDNo.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(376, 584);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 59);
            this.button3.TabIndex = 3;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtGenerateId
            // 
            this.txtGenerateId.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtGenerateId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenerateId.Location = new System.Drawing.Point(143, 33);
            this.txtGenerateId.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenerateId.Name = "txtGenerateId";
            this.txtGenerateId.ReadOnly = true;
            this.txtGenerateId.Size = new System.Drawing.Size(136, 26);
            this.txtGenerateId.TabIndex = 0;
            this.txtGenerateId.TextChanged += new System.EventHandler(this.txtGenerateId_TextChanged);
            // 
            // homeOwner_Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 662);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "homeOwner_Save";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homeOwner_Save";
            this.Load += new System.EventHandler(this.homeOwner_Save_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtGenerateId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBlock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPhaseName;
        private System.Windows.Forms.DateTimePicker dtMoveInDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPreviousReading;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtLastCollected;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtLastReading;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboWaterServiceStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboGarbageCollectionStatus;
        private System.Windows.Forms.Label label13;
    }
}