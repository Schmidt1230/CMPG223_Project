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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAddDevice = new System.Windows.Forms.Panel();
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.grpbxRemove = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lblNavigate = new System.Windows.Forms.Label();
            this.rdbRemove = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.grpbxAddDevices = new System.Windows.Forms.GroupBox();
            this.lblWords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtNewDetails = new System.Windows.Forms.TextBox();
            this.chbFixable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAddDevice.SuspendLayout();
            this.grpEdit.SuspendLayout();
            this.grpbxRemove.SuspendLayout();
            this.grpbxAddDevices.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnAddDevice);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 658);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 87);
            this.button2.TabIndex = 1;
            this.button2.Text = "Devices Information";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDevice.Font = new System.Drawing.Font("Yu Gothic Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDevice.Location = new System.Drawing.Point(0, 174);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(186, 74);
            this.btnAddDevice.TabIndex = 1;
            this.btnAddDevice.Text = "Add Device";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlAddDevice
            // 
            this.pnlAddDevice.BackColor = System.Drawing.Color.White;
            this.pnlAddDevice.Controls.Add(this.grpEdit);
            this.pnlAddDevice.Controls.Add(this.grpbxRemove);
            this.pnlAddDevice.Controls.Add(this.lblNavigate);
            this.pnlAddDevice.Controls.Add(this.rdbRemove);
            this.pnlAddDevice.Controls.Add(this.rdbUpdate);
            this.pnlAddDevice.Controls.Add(this.rdbAdd);
            this.pnlAddDevice.Controls.Add(this.grpbxAddDevices);
            this.pnlAddDevice.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAddDevice.Location = new System.Drawing.Point(186, 0);
            this.pnlAddDevice.Name = "pnlAddDevice";
            this.pnlAddDevice.Size = new System.Drawing.Size(1253, 658);
            this.pnlAddDevice.TabIndex = 1;
            // 
            // grpEdit
            // 
            this.grpEdit.Controls.Add(this.label6);
            this.grpEdit.Controls.Add(this.label7);
            this.grpEdit.Controls.Add(this.button4);
            this.grpEdit.Controls.Add(this.textBox2);
            this.grpEdit.Controls.Add(this.checkBox2);
            this.grpEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEdit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grpEdit.Location = new System.Drawing.Point(839, 35);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(396, 464);
            this.grpEdit.TabIndex = 8;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "Edit Device";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Location = new System.Drawing.Point(202, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Character Left  = 100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(176, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Device/Repair details";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button4.Location = new System.Drawing.Point(67, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(287, 75);
            this.button4.TabIndex = 4;
            this.button4.Text = "Submit Device";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(18, 164);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(353, 123);
            this.textBox2.TabIndex = 3;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(18, 107);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(219, 29);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Is Device Repairable?";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // grpbxRemove
            // 
            this.grpbxRemove.Controls.Add(this.button3);
            this.grpbxRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbxRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxRemove.Location = new System.Drawing.Point(420, 35);
            this.grpbxRemove.Name = "grpbxRemove";
            this.grpbxRemove.Size = new System.Drawing.Size(396, 464);
            this.grpbxRemove.TabIndex = 7;
            this.grpbxRemove.TabStop = false;
            this.grpbxRemove.Text = "Remove Device";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(64, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(287, 75);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remove Device";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblNavigate
            // 
            this.lblNavigate.AutoSize = true;
            this.lblNavigate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavigate.Location = new System.Drawing.Point(125, 502);
            this.lblNavigate.Name = "lblNavigate";
            this.lblNavigate.Size = new System.Drawing.Size(123, 25);
            this.lblNavigate.TabIndex = 7;
            this.lblNavigate.Text = "Add Devices";
            // 
            // rdbRemove
            // 
            this.rdbRemove.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRemove.Location = new System.Drawing.Point(154, 530);
            this.rdbRemove.Name = "rdbRemove";
            this.rdbRemove.Size = new System.Drawing.Size(68, 57);
            this.rdbRemove.TabIndex = 4;
            this.rdbRemove.TabStop = true;
            this.rdbRemove.UseVisualStyleBackColor = true;
            this.rdbRemove.CheckedChanged += new System.EventHandler(this.rdbRemove_CheckedChanged);
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUpdate.Location = new System.Drawing.Point(80, 530);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(68, 57);
            this.rdbUpdate.TabIndex = 3;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.UseVisualStyleBackColor = true;
            this.rdbUpdate.CheckedChanged += new System.EventHandler(this.rdbUpdate_CheckedChanged);
            // 
            // rdbAdd
            // 
            this.rdbAdd.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.rdbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdd.Location = new System.Drawing.Point(6, 529);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(68, 57);
            this.rdbAdd.TabIndex = 2;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.UseVisualStyleBackColor = false;
            this.rdbAdd.CheckedChanged += new System.EventHandler(this.rdbAdd_CheckedChanged);
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
            this.grpbxAddDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxAddDevices.Location = new System.Drawing.Point(6, 35);
            this.grpbxAddDevices.Name = "grpbxAddDevices";
            this.grpbxAddDevices.Size = new System.Drawing.Size(396, 464);
            this.grpbxAddDevices.TabIndex = 0;
            this.grpbxAddDevices.TabStop = false;
            this.grpbxAddDevices.Text = "Device Information";
            this.grpbxAddDevices.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWords.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblWords.Location = new System.Drawing.Point(202, 318);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(169, 20);
            this.lblWords.TabIndex = 6;
            this.lblWords.Text = "Character Left  = 100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Device/Repair details";
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSubmit.Location = new System.Drawing.Point(64, 362);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(287, 75);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit Device";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtNewDetails
            // 
            this.txtNewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewDetails.Location = new System.Drawing.Point(23, 192);
            this.txtNewDetails.Multiline = true;
            this.txtNewDetails.Name = "txtNewDetails";
            this.txtNewDetails.Size = new System.Drawing.Size(353, 123);
            this.txtNewDetails.TabIndex = 3;
            this.txtNewDetails.TextChanged += new System.EventHandler(this.txtNewDetails_TextChanged);
            // 
            // chbFixable
            // 
            this.chbFixable.AutoSize = true;
            this.chbFixable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbFixable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFixable.Location = new System.Drawing.Point(23, 123);
            this.chbFixable.Name = "chbFixable";
            this.chbFixable.Size = new System.Drawing.Size(219, 29);
            this.chbFixable.TabIndex = 2;
            this.chbFixable.Text = "Is Device Repairable?";
            this.chbFixable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select a device";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbDevices
            // 
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(23, 69);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(181, 33);
            this.cmbDevices.TabIndex = 0;
            // 
            // frmDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 658);
            this.Controls.Add(this.pnlAddDevice);
            this.Controls.Add(this.panel1);
            this.Name = "frmDevices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDevices";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAddDevice.ResumeLayout(false);
            this.pnlAddDevice.PerformLayout();
            this.grpEdit.ResumeLayout(false);
            this.grpEdit.PerformLayout();
            this.grpbxRemove.ResumeLayout(false);
            this.grpbxAddDevices.ResumeLayout(false);
            this.grpbxAddDevices.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.Panel pnlAddDevice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpbxAddDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.CheckBox chbFixable;
        private System.Windows.Forms.TextBox txtNewDetails;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.RadioButton rdbRemove;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.Label lblNavigate;
        private System.Windows.Forms.GroupBox grpbxRemove;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}