using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CMPG223_Project
{
    public partial class Technician : Form
    {
        public Technician()
        {
            InitializeComponent();
        }

        //MessageBox method.
        private void showMessage(string message, string title)
        {
            int technicianID = int.Parse(txtTech_ID.Text);

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            //Display messagebox.
            if (result == DialogResult.Yes)
            {
                //Call Remove Method
            }
            else
            {
                this.Close();
            }
        }

        private void gbxAddClient_Enter(object sender, EventArgs e)
        {

        }

        private void Technician_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTechnician_Click(object sender, EventArgs e)
        {
            string technicianFN = txtFirstName.Text;
            string technicianLN = txtLastName.Text;
            string technicianCN = txtCellNumber.Text;
            string technicianEmail = txtEmail.Text;

            //Call Add Method

            MessageBox.Show("Technician added successfully.");
        }

        private void btnUpdateTechnician_Click(object sender, EventArgs e)
        {
            string technicianFNUpdate = txtFNUpdate.Text;
            string technicianLNUpdate = txtLNUpdate.Text;
            string technicianCNUpdate = txtCNUpdate.Text;
            string technicianEmailUpdate = txtEmailUpdate.Text;

            //Call Update Method

            //Call showMessage Method
            showMessage("Update client information?", "Update Client Information");
        }

        private void btnRemoveTechnician_Click(object sender, EventArgs e)
        {
            //Call showMessage method.
            showMessage("Permanently remove technician information?", "Remove Technician Information");
        }
    }
}
