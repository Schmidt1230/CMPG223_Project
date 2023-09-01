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

namespace CMPG223_Project
{
    public partial class frmClients : Form
    {
        public frmClients()
        {
            InitializeComponent();
        }

        //MessageBox method.
        public void showMessage(string message, string title)
        {
            int clientID = int.Parse(txtRemoveClient.Text);

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

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string clientFN = txtFirstName.Text;
            string clientLN = txtLastName.Text;
            string clientCN = txtCellNumber.Text;
            string clientEmail = txtEmail.Text;

            //Call Add Method

            MessageBox.Show("Client added successfully.");
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            //Call showMessage method.
            showMessage("Permanently remove client information?", "Remove Client");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string clientFNUpdate = txtFNUpdate.Text;
            string clientLNUpdate = txtLNUpdate.Text;
            string clientCNUpdate = txtCNUpdate.Text;
            string clientEmailUpdate = txtEmailUpdate.Text;

            //Call Update Method

            //Call showMessage Method
            showMessage("Update client information?", "Update Client Information");
        }
    }
}
