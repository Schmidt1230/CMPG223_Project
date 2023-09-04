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


                //Display Clients table in DataGridView.
                query = "SELECT * FROM Clients";
                com = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                dataAdapter.SelectCommand = com;
                dataAdapter.Fill(ds, "Clients");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Clients";
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

                string message = "Update client information?";
                string title = "Update Client Information";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                //Display messagebox.
                if (result == DialogResult.Yes)
                {
                    string place = "";
                    query = $"UPDATE Clients SET ";

                    if (txtFNUpdate.Text.Length > 0)
                    {
                        query = query + $"FirstName = '{txtFNUpdate.Text}";
                        place = ",";
                    }

                    if (txtLNUpdate.Text.Length > 0)
                    {
                        query = query + place + $" LastName = '{txtLNUpdate.Text}'";
                        place = ",";    //Adds a coma between each set if the First part of Query is full
                    }
                    if (txtCellNumber.Text.Length > 0)
                    {
                        query = query + place + $" ContactNumber = '{txtCNUpdate.Text}'";
                        place = ",";   //Adds a coma between each set if the First part of Query is full
                    }

                    if (txtEmail.Text.Length > 5)
                    {
                        query = query + $" Email = '{txtEmailUpdate.Text}'";
                        place = ",";  //Adds a coma between each set if the First part of Query is full
                    }
                    
                    query = query + $" WHERE ClientID = '{txtClientUpdateID.Text}'";
                    
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
                    query = $"DELETE FROM Clients WHERE Client_ID = {txtRemoveClient.Text}";
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
            if (verifyUserInput() == true)      //Only proceed if user entered all input
            {
                //Call addClient Method
                addClient();

                txtFirstName.Clear();
                txtLastName.Clear();
                txtCellNumber.Clear();
                txtEmail.Clear();
            }
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            if (txtRemoveClient.Text == "")
            {
                MessageBox.Show("Please enter valid values.");
            }
            else
            {
                //Call DeleteClient Method
                DeleteClient();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFNUpdate.Text == "" || txtLNUpdate.Text == "" || txtCNUpdate.Text == "" || txtEmailUpdate.Text == "")
            {
                MessageBox.Show("Please enter valid values.");
            }
            else
            {
                //Call Update Method
                UpdateClient();

                //Clear textboxes after successfull update.
                txtFNUpdate.Clear();
                txtLNUpdate.Clear();
                txtCNUpdate.Clear();
                txtEmailUpdate.Clear();
            }
        }

        private void frmClients_Load(object sender, EventArgs e)
        {
            //Display Clients table in DataGridView.
            conn.Open();

            query = "SELECT * FROM Clients";
            com = new SqlCommand(query, conn);
            DataSet ds = new DataSet();
            dataAdapter.SelectCommand = com;
            dataAdapter.Fill(ds, "Clients");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Clients";

            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFNUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private bool verifyUserInput()
        {
            bool flag = false;
            if (txtFirstName.Text.Length < 0)
                MessageBox.Show("Please enter a name for the client");
            else if (txtLastName.Text.Length < 0)
                MessageBox.Show("Please enter a last name for the client");
            else if (txtCellNumber.Text.Length != 10)
                MessageBox.Show("Please enter a valid 10 digit cellphone number");
            else if (txtEmail.Text.Length < 5)
                MessageBox.Show("Please enter a valid Email for the client");
            else
                flag = true;            //If input validation succeeds

            return flag;
        }
    }
}
