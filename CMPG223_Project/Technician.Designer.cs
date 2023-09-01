
namespace CMPG223_Project
{
    partial class Technician
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
            this.gbxAddTechnician = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCellNumber = new System.Windows.Forms.Label();
            this.txtCellNumber = new System.Windows.Forms.TextBox();
            this.btnAddTechnician = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.gbxUpdateTechnician = new System.Windows.Forms.GroupBox();
            this.txtEmailUpdate = new System.Windows.Forms.TextBox();
            this.lblEmailUpdate = new System.Windows.Forms.Label();
            this.lblCNUpdate = new System.Windows.Forms.Label();
            this.txtCNUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdateTechnician = new System.Windows.Forms.Button();
            this.txtLNUpdate = new System.Windows.Forms.TextBox();
            this.lblLNUpdate = new System.Windows.Forms.Label();
            this.lblFNUpdate = new System.Windows.Forms.Label();
            this.txtFNUpdate = new System.Windows.Forms.TextBox();
            this.gbxRemoveTechnician = new System.Windows.Forms.GroupBox();
            this.btnRemoveTechnician = new System.Windows.Forms.Button();
            this.lblTechnicianID = new System.Windows.Forms.Label();
            this.txtTech_ID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxAddTechnician.SuspendLayout();
            this.gbxUpdateTechnician.SuspendLayout();
            this.gbxRemoveTechnician.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAddTechnician
            // 
            this.gbxAddTechnician.Controls.Add(this.txtEmail);
            this.gbxAddTechnician.Controls.Add(this.lblEmail);
            this.gbxAddTechnician.Controls.Add(this.lblCellNumber);
            this.gbxAddTechnician.Controls.Add(this.txtCellNumber);
            this.gbxAddTechnician.Controls.Add(this.btnAddTechnician);
            this.gbxAddTechnician.Controls.Add(this.txtLastName);
            this.gbxAddTechnician.Controls.Add(this.lblLastName);
            this.gbxAddTechnician.Controls.Add(this.lblFirstName);
            this.gbxAddTechnician.Controls.Add(this.txtFirstName);
            this.gbxAddTechnician.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxAddTechnician.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddTechnician.Location = new System.Drawing.Point(12, 12);
            this.gbxAddTechnician.Name = "gbxAddTechnician";
            this.gbxAddTechnician.Size = new System.Drawing.Size(248, 451);
            this.gbxAddTechnician.TabIndex = 13;
            this.gbxAddTechnician.TabStop = false;
            this.gbxAddTechnician.Text = "Add Technician";
            this.gbxAddTechnician.Enter += new System.EventHandler(this.gbxAddClient_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEmail.Location = new System.Drawing.Point(29, 313);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 33);
            this.txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Yu Gothic UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(54, 280);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(141, 30);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblCellNumber
            // 
            this.lblCellNumber.AutoSize = true;
            this.lblCellNumber.Font = new System.Drawing.Font("Yu Gothic UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellNumber.Location = new System.Drawing.Point(29, 198);
            this.lblCellNumber.Name = "lblCellNumber";
            this.lblCellNumber.Size = new System.Drawing.Size(186, 30);
            this.lblCellNumber.TabIndex = 9;
            this.lblCellNumber.Text = "Cellphone Number:";
            // 
            // txtCellNumber
            // 
            this.txtCellNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCellNumber.Location = new System.Drawing.Point(29, 231);
            this.txtCellNumber.Name = "txtCellNumber";
            this.txtCellNumber.Size = new System.Drawing.Size(186, 33);
            this.txtCellNumber.TabIndex = 8;
            // 
            // btnAddTechnician
            // 
            this.btnAddTechnician.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTechnician.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTechnician.Location = new System.Drawing.Point(29, 381);
            this.btnAddTechnician.Name = "btnAddTechnician";
            this.btnAddTechnician.Size = new System.Drawing.Size(186, 55);
            this.btnAddTechnician.TabIndex = 7;
            this.btnAddTechnician.Text = "Add Technician";
            this.btnAddTechnician.UseVisualStyleBackColor = true;
            this.btnAddTechnician.Click += new System.EventHandler(this.btnAddTechnician_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLastName.Location = new System.Drawing.Point(29, 144);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(186, 33);
            this.txtLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Yu Gothic UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(69, 111);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(111, 30);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Yu Gothic UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(69, 29);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(112, 30);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFirstName.Location = new System.Drawing.Point(29, 62);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(186, 33);
            this.txtFirstName.TabIndex = 0;
            // 
            // gbxUpdateTechnician
            // 
            this.gbxUpdateTechnician.Controls.Add(this.txtEmailUpdate);
            this.gbxUpdateTechnician.Controls.Add(this.lblEmailUpdate);
            this.gbxUpdateTechnician.Controls.Add(this.lblCNUpdate);
            this.gbxUpdateTechnician.Controls.Add(this.txtCNUpdate);
            this.gbxUpdateTechnician.Controls.Add(this.btnUpdateTechnician);
            this.gbxUpdateTechnician.Controls.Add(this.txtLNUpdate);
            this.gbxUpdateTechnician.Controls.Add(this.lblLNUpdate);
            this.gbxUpdateTechnician.Controls.Add(this.lblFNUpdate);
            this.gbxUpdateTechnician.Controls.Add(this.txtFNUpdate);
            this.gbxUpdateTechnician.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxUpdateTechnician.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdateTechnician.Location = new System.Drawing.Point(545, 12);
            this.gbxUpdateTechnician.Name = "gbxUpdateTechnician";
            this.gbxUpdateTechnician.Size = new System.Drawing.Size(246, 451);
            this.gbxUpdateTechnician.TabIndex = 14;
            this.gbxUpdateTechnician.TabStop = false;
            this.gbxUpdateTechnician.Text = "Update Technician";
            // 
            // txtEmailUpdate
            // 
            this.txtEmailUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEmailUpdate.Location = new System.Drawing.Point(29, 313);
            this.txtEmailUpdate.Name = "txtEmailUpdate";
            this.txtEmailUpdate.Size = new System.Drawing.Size(186, 33);
            this.txtEmailUpdate.TabIndex = 11;
            // 
            // lblEmailUpdate
            // 
            this.lblEmailUpdate.AutoSize = true;
            this.lblEmailUpdate.Font = new System.Drawing.Font("Yu Gothic UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUpdate.Location = new System.Drawing.Point(54, 280);
            this.lblEmailUpdate.Name = "lblEmailUpdate";
            this.lblEmailUpdate.Size = new System.Drawing.Size(141, 30);
            this.lblEmailUpdate.TabIndex = 10;
            this.lblEmailUpdate.Text = "Email Address:";
            // 
            // lblCNUpdate
            // 
            this.lblCNUpdate.AutoSize = true;
            this.lblCNUpdate.Font = new System.Drawing.Font("Yu Gothic UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNUpdate.Location = new System.Drawing.Point(29, 198);
            this.lblCNUpdate.Name = "lblCNUpdate";
            this.lblCNUpdate.Size = new System.Drawing.Size(186, 30);
            this.lblCNUpdate.TabIndex = 9;
            this.lblCNUpdate.Text = "Cellphone Number:";
            // 
            // txtCNUpdate
            // 
            this.txtCNUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCNUpdate.Location = new System.Drawing.Point(29, 231);
            this.txtCNUpdate.Name = "txtCNUpdate";
            this.txtCNUpdate.Size = new System.Drawing.Size(186, 33);
            this.txtCNUpdate.TabIndex = 8;
            // 
            // btnUpdateTechnician
            // 
            this.btnUpdateTechnician.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateTechnician.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTechnician.Location = new System.Drawing.Point(29, 381);
            this.btnUpdateTechnician.Name = "btnUpdateTechnician";
            this.btnUpdateTechnician.Size = new System.Drawing.Size(186, 55);
            this.btnUpdateTechnician.TabIndex = 7;
            this.btnUpdateTechnician.Text = "Update Technician";
            this.btnUpdateTechnician.UseVisualStyleBackColor = true;
            this.btnUpdateTechnician.Click += new System.EventHandler(this.btnUpdateTechnician_Click);
            // 
            // txtLNUpdate
            // 
            this.txtLNUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLNUpdate.Location = new System.Drawing.Point(29, 144);
            this.txtLNUpdate.Name = "txtLNUpdate";
            this.txtLNUpdate.Size = new System.Drawing.Size(186, 33);
            this.txtLNUpdate.TabIndex = 6;
            // 
            // lblLNUpdate
            // 
            this.lblLNUpdate.AutoSize = true;
            this.lblLNUpdate.Font = new System.Drawing.Font("Yu Gothic UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLNUpdate.Location = new System.Drawing.Point(69, 111);
            this.lblLNUpdate.Name = "lblLNUpdate";
            this.lblLNUpdate.Size = new System.Drawing.Size(111, 30);
            this.lblLNUpdate.TabIndex = 5;
            this.lblLNUpdate.Text = "Last Name:";
            // 
            // lblFNUpdate
            // 
            this.lblFNUpdate.AutoSize = true;
            this.lblFNUpdate.Font = new System.Drawing.Font("Yu Gothic UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNUpdate.Location = new System.Drawing.Point(69, 29);
            this.lblFNUpdate.Name = "lblFNUpdate";
            this.lblFNUpdate.Size = new System.Drawing.Size(112, 30);
            this.lblFNUpdate.TabIndex = 4;
            this.lblFNUpdate.Text = "First Name:";
            // 
            // txtFNUpdate
            // 
            this.txtFNUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFNUpdate.Location = new System.Drawing.Point(29, 62);
            this.txtFNUpdate.Name = "txtFNUpdate";
            this.txtFNUpdate.Size = new System.Drawing.Size(186, 33);
            this.txtFNUpdate.TabIndex = 0;
            // 
            // gbxRemoveTechnician
            // 
            this.gbxRemoveTechnician.Controls.Add(this.btnRemoveTechnician);
            this.gbxRemoveTechnician.Controls.Add(this.lblTechnicianID);
            this.gbxRemoveTechnician.Controls.Add(this.txtTech_ID);
            this.gbxRemoveTechnician.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxRemoveTechnician.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRemoveTechnician.Location = new System.Drawing.Point(279, 12);
            this.gbxRemoveTechnician.Name = "gbxRemoveTechnician";
            this.gbxRemoveTechnician.Size = new System.Drawing.Size(248, 202);
            this.gbxRemoveTechnician.TabIndex = 15;
            this.gbxRemoveTechnician.TabStop = false;
            this.gbxRemoveTechnician.Text = "Remove Technician";
            // 
            // btnRemoveTechnician
            // 
            this.btnRemoveTechnician.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveTechnician.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTechnician.Location = new System.Drawing.Point(29, 122);
            this.btnRemoveTechnician.Name = "btnRemoveTechnician";
            this.btnRemoveTechnician.Size = new System.Drawing.Size(186, 55);
            this.btnRemoveTechnician.TabIndex = 7;
            this.btnRemoveTechnician.Text = "Remove Technician";
            this.btnRemoveTechnician.UseVisualStyleBackColor = true;
            this.btnRemoveTechnician.Click += new System.EventHandler(this.btnRemoveTechnician_Click);
            // 
            // lblTechnicianID
            // 
            this.lblTechnicianID.AutoSize = true;
            this.lblTechnicianID.Font = new System.Drawing.Font("Yu Gothic UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnicianID.Location = new System.Drawing.Point(58, 29);
            this.lblTechnicianID.Name = "lblTechnicianID";
            this.lblTechnicianID.Size = new System.Drawing.Size(135, 30);
            this.lblTechnicianID.TabIndex = 4;
            this.lblTechnicianID.Text = "Technician_ID:";
            // 
            // txtTech_ID
            // 
            this.txtTech_ID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTech_ID.Location = new System.Drawing.Point(29, 62);
            this.txtTech_ID.Name = "txtTech_ID";
            this.txtTech_ID.Size = new System.Drawing.Size(186, 33);
            this.txtTech_ID.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 482);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(779, 255);
            this.dataGridView1.TabIndex = 16;
            // 
            // Technician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 749);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbxUpdateTechnician);
            this.Controls.Add(this.gbxRemoveTechnician);
            this.Controls.Add(this.gbxAddTechnician);
            this.Name = "Technician";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Technician_Load);
            this.gbxAddTechnician.ResumeLayout(false);
            this.gbxAddTechnician.PerformLayout();
            this.gbxUpdateTechnician.ResumeLayout(false);
            this.gbxUpdateTechnician.PerformLayout();
            this.gbxRemoveTechnician.ResumeLayout(false);
            this.gbxRemoveTechnician.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAddTechnician;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCellNumber;
        private System.Windows.Forms.TextBox txtCellNumber;
        private System.Windows.Forms.Button btnAddTechnician;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox gbxUpdateTechnician;
        private System.Windows.Forms.TextBox txtEmailUpdate;
        private System.Windows.Forms.Label lblEmailUpdate;
        private System.Windows.Forms.Label lblCNUpdate;
        private System.Windows.Forms.TextBox txtCNUpdate;
        private System.Windows.Forms.Button btnUpdateTechnician;
        private System.Windows.Forms.TextBox txtLNUpdate;
        private System.Windows.Forms.Label lblLNUpdate;
        private System.Windows.Forms.Label lblFNUpdate;
        private System.Windows.Forms.TextBox txtFNUpdate;
        private System.Windows.Forms.GroupBox gbxRemoveTechnician;
        private System.Windows.Forms.Button btnRemoveTechnician;
        private System.Windows.Forms.Label lblTechnicianID;
        private System.Windows.Forms.TextBox txtTech_ID;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}