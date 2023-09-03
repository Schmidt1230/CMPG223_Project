
namespace CMPG223_Project
{
    partial class frmReports
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
            this.pnlReports = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbAscending = new System.Windows.Forms.RadioButton();
            this.rdbDescending = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbTechnician = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDevice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstReport = new System.Windows.Forms.ListBox();
            this.pnlReports.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReports
            // 
            this.pnlReports.BackColor = System.Drawing.Color.Transparent;
            this.pnlReports.Controls.Add(this.groupBox2);
            this.pnlReports.Controls.Add(this.groupBox1);
            this.pnlReports.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlReports.Location = new System.Drawing.Point(0, 0);
            this.pnlReports.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(352, 429);
            this.pnlReports.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbAscending);
            this.groupBox2.Controls.Add(this.rdbDescending);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.cmbTechnician);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(14, 39);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(320, 184);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Technicians Report";
            // 
            // rdbAscending
            // 
            this.rdbAscending.AutoSize = true;
            this.rdbAscending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAscending.ForeColor = System.Drawing.Color.White;
            this.rdbAscending.Location = new System.Drawing.Point(156, 144);
            this.rdbAscending.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbAscending.Name = "rdbAscending";
            this.rdbAscending.Size = new System.Drawing.Size(102, 24);
            this.rdbAscending.TabIndex = 3;
            this.rdbAscending.TabStop = true;
            this.rdbAscending.Text = "Ascending";
            this.rdbAscending.UseVisualStyleBackColor = true;
            // 
            // rdbDescending
            // 
            this.rdbDescending.AutoSize = true;
            this.rdbDescending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDescending.ForeColor = System.Drawing.Color.White;
            this.rdbDescending.Location = new System.Drawing.Point(38, 144);
            this.rdbDescending.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbDescending.Name = "rdbDescending";
            this.rdbDescending.Size = new System.Drawing.Size(112, 24);
            this.rdbDescending.TabIndex = 4;
            this.rdbDescending.TabStop = true;
            this.rdbDescending.Text = "Descending";
            this.rdbDescending.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select a Technician";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(187, 70);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 26);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show All";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmbTechnician
            // 
            this.cmbTechnician.FormattingEnabled = true;
            this.cmbTechnician.Location = new System.Drawing.Point(157, 33);
            this.cmbTechnician.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTechnician.Name = "cmbTechnician";
            this.cmbTechnician.Size = new System.Drawing.Size(149, 30);
            this.cmbTechnician.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 13F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order By Repairs Completed";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDevice);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 256);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(320, 150);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devices Report";
            // 
            // btnDevice
            // 
            this.btnDevice.BackColor = System.Drawing.Color.Transparent;
            this.btnDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevice.Location = new System.Drawing.Point(30, 50);
            this.btnDevice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.Size = new System.Drawing.Size(248, 62);
            this.btnDevice.TabIndex = 0;
            this.btnDevice.Text = "Most Repaired Device";
            this.btnDevice.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(468, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate a Report";
            // 
            // lstReport
            // 
            this.lstReport.FormattingEnabled = true;
            this.lstReport.Location = new System.Drawing.Point(396, 53);
            this.lstReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(360, 329);
            this.lstReport.TabIndex = 1;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.BackgroundImage = global::CMPG223_Project.Properties.Resources.Back_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 429);
            this.Controls.Add(this.lstReport);
            this.Controls.Add(this.pnlReports);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.pnlReports.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTechnician;
        private System.Windows.Forms.RadioButton rdbAscending;
        private System.Windows.Forms.RadioButton rdbDescending;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstReport;
        private System.Windows.Forms.Button btnDevice;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}