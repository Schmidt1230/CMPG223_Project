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
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\OneDrive\Desktop\CMPG223_Project\CMPG223_Project\AlexandersDatabase.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        String query;
        SqlDataAdapter dataAdapter = new SqlDataAdapter();

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
        private void addClient()
        {
            try
            {
                conn.Open();

                query = $"INSERT INTO Clients (FirstName, LastName, ContactNumber, Email) VALUES ('{txtFirstName.Text}', '{txtLastName.Text}', '{txtCellNumber.Text}', '{txtEmail.Text}')";
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
        private void UpdateClient()
        {
            try
            {
                conn.Open();

                int clientID = int.Parse(txtRemoveClient.Text);

                string message = "Update client information?";
                string title = "Update Client Information";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                //Display messagebox.
                if (result == DialogResult.Yes)
                {
                    query = $"UPDATE Clients SET FirstName = '{txtFNUpdate.Text}', LastName = '{txtLNUpdate.Text}', ContactNumber = '{txtCNUpdate.Text}', Email = '{txtEmailUpdate.Text}' WHERE FirstName = '{txtFirstName.Text}'";
                    com = new SqlCommand(query, conn);
                    dataAdapter.UpdateCommand = com;
                    com.ExecuteNonQuery();

                    MessageBox.Show("Client information updated successfully.");
                }
                else
                {
                    this.Close();
                }

                conn.Close();
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        //DeleteClient Method
        private void DeleteClient()
        {
            try
            {
                conn.Open();

                string message = "Permanently remove client information?";
                string title = "Remove Client Information";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                //Display messagebox.
                if (result == DialogResult.Yes)
                {
                    query = $"DELETE FROM Clients WHERE Client_ID = {clientID}";
                    com = new SqlCommand(query, conn);
                    dataAdapter.DeleteCommand = com;
                    com.ExecuteNonQuery();

                    MessageBox.Show("Client information updated successfully.");
                }
                else
                {
                    this.Close();
                }

                conn.Close();
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            //Call addClient Method
            addClient();

            txtFirstName.Clear();
            txtLastName.Clear();
            txtCellNumber.Clear();
            txtEmail.Clear();
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            clientID = int.Parse(txtRemoveClient.Text);

            //Call DeleteClient Method
            DeleteClient();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clientFNUpdate = txtFNUpdate.Text;
            clientLNUpdate = txtLNUpdate.Text;
            clientCNUpdate = txtCNUpdate.Text;
            clientEmailUpdate = txtEmailUpdate.Text;

            //Call Update Method
            UpdateClient();
        }

        private void frmClients_Load(object sender, EventArgs e)
        {
            //Display Clients table in DataGridView.
            query = "SELECT * FROM Clients";
            com = new SqlCommand(query, conn);
            DataSet ds = new DataSet();
            dataAdapter.SelectCommand = com;
            dataAdapter.Fill(ds, "Clients");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Clients";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
