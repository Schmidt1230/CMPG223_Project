namespace CMPG223_Project
{
    partial class frmDevices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevices));
            this.pnlAddDevice = new System.Windows.Forms.Panel();
            this.grpbxRemove = new System.Windows.Forms.GroupBox();
            this.txtUpdateID = new System.Windows.Forms.TextBox();
            this.lblDeviceID = new System.Windows.Forms.Label();
            this.pnlDevices = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFind = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.lstDevices = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateDetails = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.chbRepairable = new System.Windows.Forms.CheckBox();
            this.grpbxAddDevices = new System.Windows.Forms.GroupBox();
            this.lblWords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtNewDetails = new System.Windows.Forms.TextBox();
            this.chbFixable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.pnlAddDevice.SuspendLayout();
            this.grpbxRemove.SuspendLayout();
            this.pnlDevices.SuspendLayout();
            this.grpbxAddDevices.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddDevice
            // 
            this.pnlAddDevice.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlAddDevice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAddDevice.BackgroundImage")));
            this.pnlAddDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAddDevice.Controls.Add(this.grpbxRemove);
            this.pnlAddDevice.Controls.Add(this.grpbxAddDevices);
            this.pnlAddDevice.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAddDevice.Location = new System.Drawing.Point(0, 0);
            this.pnlAddDevice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAddDevice.Name = "pnlAddDevice";
            this.pnlAddDevice.Size = new System.Drawing.Size(1332, 544);
            this.pnlAddDevice.TabIndex = 1;
            // 
            // grpbxRemove
            // 
            this.grpbxRemove.BackColor = System.Drawing.Color.Transparent;
            this.grpbxRemove.Controls.Add(this.txtUpdateID);
            this.grpbxRemove.Controls.Add(this.lblDeviceID);
            this.grpbxRemove.Controls.Add(this.pnlDevices);
            this.grpbxRemove.Controls.Add(this.btnUpdate);
            this.grpbxRemove.Controls.Add(this.label4);
            this.grpbxRemove.Controls.Add(this.txtRemove);
            this.grpbxRemove.Controls.Add(this.label7);
            this.grpbxRemove.Controls.Add(this.txtUpdateDetails);
            this.grpbxRemove.Controls.Add(this.btnRemove);
            this.grpbxRemove.Controls.Add(this.chbRepairable);
            this.grpbxRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbxRemove.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxRemove.ForeColor = System.Drawing.Color.White;
            this.grpbxRemove.Location = new System.Drawing.Point(315, 44);
            this.grpbxRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbxRemove.Name = "grpbxRemove";
            this.grpbxRemove.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbxRemove.Size = new System.Drawing.Size(672, 399);
            this.grpbxRemove.TabIndex = 13;
            this.grpbxRemove.TabStop = false;
            this.grpbxRemove.Text = "Manage Devices";
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.Location = new System.Drawing.Point(159, 35);
            this.txtUpdateID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.Size = new System.Drawing.Size(76, 31);
            this.txtUpdateID.TabIndex = 12;
            // 
            // lblDeviceID
            // 
            this.lblDeviceID.AutoSize = true;
            this.lblDeviceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceID.Location = new System.Drawing.Point(34, 35);
            this.lblDeviceID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeviceID.Name = "lblDeviceID";
            this.lblDeviceID.Size = new System.Drawing.Size(107, 25);
            this.lblDeviceID.TabIndex = 11;
            this.lblDeviceID.Text = "Device ID :";
            // 
            // pnlDevices
            // 
            this.pnlDevices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDevices.Controls.Add(this.label6);
            this.pnlDevices.Controls.Add(this.cmbFind);
            this.pnlDevices.Controls.Add(this.label5);
            this.pnlDevices.Controls.Add(this.label3);
            this.pnlDevices.Controls.Add(this.txtFind);
            this.pnlDevices.Controls.Add(this.lstDevices);
            this.pnlDevices.Location = new System.Drawing.Point(298, 24);
            this.pnlDevices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDevices.Name = "pnlDevices";
            this.pnlDevices.Size = new System.Drawing.Size(370, 368);
            this.pnlDevices.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Filter Device Types :";
            // 
            // cmbFind
            // 
            this.cmbFind.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFind.FormattingEnabled = true;
            this.cmbFind.Location = new System.Drawing.Point(197, 64);
            this.cmbFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Size = new System.Drawing.Size(155, 28);
            this.cmbFind.TabIndex = 13;
            this.cmbFind.TextChanged += new System.EventHandler(this.cmbFind_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 1);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Select a Device";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search for a Device (ID) : ";
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(197, 31);
            this.txtFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(155, 26);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // lstDevices
            // 
            this.lstDevices.FormattingEnabled = true;
            this.lstDevices.ItemHeight = 24;
            this.lstDevices.Location = new System.Drawing.Point(15, 108);
            this.lstDevices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(351, 220);
            this.lstDevices.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(14, 225);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(266, 35);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 13.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter a Device ID";
            // 
            // txtRemove
            // 
            this.txtRemove.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemove.Location = new System.Drawing.Point(14, 299);
            this.txtRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(266, 26);
            this.txtRemove.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(133, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Device/Repair details";
            // 
            // txtUpdateDetails
            // 
            this.txtUpdateDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateDetails.Location = new System.Drawing.Point(14, 120);
            this.txtUpdateDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUpdateDetails.Multiline = true;
            this.txtUpdateDetails.Name = "txtUpdateDetails";
            this.txtUpdateDetails.Size = new System.Drawing.Size(266, 101);
            this.txtUpdateDetails.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(30, 338);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(238, 39);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Device";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // chbRepairable
            // 
            this.chbRepairable.AutoSize = true;
            this.chbRepairable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbRepairable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRepairable.ForeColor = System.Drawing.Color.White;
            this.chbRepairable.Location = new System.Drawing.Point(38, 71);
            this.chbRepairable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbRepairable.Name = "chbRepairable";
            this.chbRepairable.Size = new System.Drawing.Size(166, 22);
            this.chbRepairable.TabIndex = 2;
            this.chbRepairable.Text = "Is Device Repairable?";
            this.chbRepairable.UseVisualStyleBackColor = true;
            // 
            // grpbxAddDevices
            // 
            this.grpbxAddDevices.BackColor = System.Drawing.Color.Transparent;
            this.grpbxAddDevices.Controls.Add(this.lblWords);
            this.grpbxAddDevices.Controls.Add(this.label2);
            this.grpbxAddDevices.Controls.Add(this.btnSubmit);
            this.grpbxAddDevices.Controls.Add(this.txtNewDetails);
            this.grpbxAddDevices.Controls.Add(this.chbFixable);
            this.grpbxAddDevices.Controls.Add(this.label1);
            this.grpbxAddDevices.Controls.Add(this.cmbDevices);
            this.grpbxAddDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbxAddDevices.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxAddDevices.ForeColor = System.Drawing.Color.White;
            this.grpbxAddDevices.Location = new System.Drawing.Point(14, 44);
            this.grpbxAddDevices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbxAddDevices.Name = "grpbxAddDevices";
            this.grpbxAddDevices.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbxAddDevices.Size = new System.Drawing.Size(297, 399);
            this.grpbxAddDevices.TabIndex = 12;
            this.grpbxAddDevices.TabStop = false;
            this.grpbxAddDevices.Text = "Device Information";
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWords.ForeColor = System.Drawing.Color.Red;
            this.lblWords.Location = new System.Drawing.Point(99, 288);
            this.lblWords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(184, 19);
            this.lblWords.TabIndex = 6;
            this.lblWords.Text = "Character Left  = 100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Device/Repair details";
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSubmit.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(17, 338);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(255, 39);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit Device";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtNewDetails
            // 
            this.txtNewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewDetails.Location = new System.Drawing.Point(17, 155);
            this.txtNewDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewDetails.Multiline = true;
            this.txtNewDetails.Name = "txtNewDetails";
            this.txtNewDetails.Size = new System.Drawing.Size(266, 131);
            this.txtNewDetails.TabIndex = 3;
            this.txtNewDetails.TextChanged += new System.EventHandler(this.txtNewDetails_TextChanged);
            // 
            // chbFixable
            // 
            this.chbFixable.AutoSize = true;
            this.chbFixable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbFixable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFixable.Location = new System.Drawing.Point(69, 93);
            this.chbFixable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbFixable.Name = "chbFixable";
            this.chbFixable.Size = new System.Drawing.Size(166, 22);
            this.chbFixable.TabIndex = 2;
            this.chbFixable.Text = "Is Device Repairable?";
            this.chbFixable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select a device:";
            // 
            // cmbDevices
            // 
            this.cmbDevices.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Items.AddRange(new object[] {
            "Tablet",
            "Cellphone",
            "Desktop",
            "Monitor",
            "Notebook",
            "Laptop",
            "Mac"});
            this.cmbDevices.Location = new System.Drawing.Point(63, 55);
            this.cmbDevices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(162, 27);
            this.cmbDevices.TabIndex = 0;
            // 
            // frmDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 544);
            this.Controls.Add(this.pnlAddDevice);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDevices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients\' Devices Information";
            this.Load += new System.EventHandler(this.frmDevices_Load);
            this.pnlAddDevice.ResumeLayout(false);
            this.grpbxRemove.ResumeLayout(false);
            this.grpbxRemove.PerformLayout();
            this.pnlDevices.ResumeLayout(false);
            this.pnlDevices.PerformLayout();
            this.grpbxAddDevices.ResumeLayout(false);
            this.grpbxAddDevices.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAddDevice;
        private System.Windows.Forms.GroupBox grpbxRemove;
        private System.Windows.Forms.Label lblDeviceID;
        private System.Windows.Forms.Panel pnlDevices;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.ListBox lstDevices;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdateDetails;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox chbRepairable;
        private System.Windows.Forms.GroupBox grpbxAddDevices;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtNewDetails;
        private System.Windows.Forms.CheckBox chbFixable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.TextBox txtUpdateID;
    }
}