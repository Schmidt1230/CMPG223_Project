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
        SqlConnection conn = new SqlConnection(@"");
        SqlCommand com = new SqlCommand();
        String query;
        SqlDataAdapter dataAdapter = new SqlDataAdapter();

        //Declare public variables.
        public string clientFN;
        public string clientLN;
        public string clientCN;
        public string clientEmail;

        public string clientFNUpdate;
        public string clientLNUpdate;
        public string clientCNUpdate;
        public string clientEmailUpdate;

        public int clientID;

        public frmClients()
        {
            InitializeComponent();
        }

        //addClient Method.
        private void addClient(String query)
        {
            try
            {
                conn.Open();

                query = "";
                com = new SqlCommand(query, conn);
                dataAdapter.InsertCommand = com;
                com.ExecuteNonQuery();

                MessageBox.Show("Client added successfully");

                conn.Close();
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        //UpdateClient Method
        private void UpdateClient(String query)
        {
            try
            {
                conn.Open();

                query = "";
                com = new SqlCommand(query, conn);
                dataAdapter.UpdateCommand = com;
                com.ExecuteNonQuery();

                MessageBox.Show("Client information updated successfully.");

                conn.Close();
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        //DeleteClient Method
        private void DeleteClient(string query, int clientID)
        {
            try
            {
                conn.Open();

                query = $"DELETE FROM Clients WHERE ClientID = {clientID}";
                com = new SqlCommand(query, conn);
                dataAdapter.DeleteCommand = com;
                com.ExecuteNonQuery();

                MessageBox.Show("Client information deleted successfully.");

                conn.Close();
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        //MessageBox method.
        private void showMessage(string message, string title)
        {
            int clientID = int.Parse(txtRemoveClient.Text);

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            //Display messagebox.
            if (result == DialogResult.Yes)
            {
                //Call Remove/Update Method using delegate. !!!!
            }
            else
            {
                this.Close();
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            clientFN = txtFirstName.Text;
            clientLN = txtLastName.Text;
            clientCN = txtCellNumber.Text;
            clientEmail = txtEmail.Text;

            //Call addClient Method
            addClient($"INSERT INTO Clients (FirstName, LastName, ContactNumber, Email) VALUES ({clientFN}, {clientLN}, {clientCN}, {clientEmail})");

            MessageBox.Show("Client added successfully.");

            txtFirstName.Clear();
            txtLastName.Clear();
            txtCellNumber.Clear();
            txtEmail.Clear();
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            clientID = int.Parse(txtRemoveClient.Text);
            
            //Call showMessage method.
            showMessage("Permanently remove client information?", "Remove Client");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clientFNUpdate = txtFNUpdate.Text;
            clientLNUpdate = txtLNUpdate.Text;
            clientCNUpdate = txtCNUpdate.Text;
            clientEmailUpdate = txtEmailUpdate.Text;

            //Call showMessage Method
            showMessage("Update client information?", "Update Client Information");

            //Call Update Method
            UpdateClient($"UPDATE Clients SET FirstName = {clientFNUpdate}, LastName = {clientLNUpdate}, ContactNumber = {clientCNUpdate}, Email = {clientEmailUpdate} WHERE FirstName = {clientFNUpdate}");
        }
    }
}
