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
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\OneDrive\Desktop\CMPG223_Project\CMPG223_Project\AlexandersDatabase.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        String query;
        SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public int technicianID;
        public int hours_worked;

        public Technician()
        {
            InitializeComponent();
        }

        //AddTechnician Client
        private void AddTechnician()
        {
            try
            {
                conn.Open();
                query = $"INSERT INTO Technicians (FirstName, LastName, CellphoneNumber, Email) VALUES ('{txtFirstName.Text}', '{txtLastName.Text}', '{txtCellNumber.Text}', '{txtEmail.Text}')";
                com = new SqlCommand(query, conn);
                dataAdapter.InsertCommand = com;
                com.ExecuteNonQuery();

                MessageBox.Show("Technician added successfully");

                //Display Technicians table in DataGridView.
                query = "SELECT * FROM Technicians";
                com = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                dataAdapter.SelectCommand = com;
                dataAdapter.Fill(ds, "Technicians");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Technicians";

                conn.Close();
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        //UpdateTechnician Method
        private void UpdateTechnician()
        {
            try
            {
                conn.Open();

                string message = "Are you sure you want to update selected technician information?";
                string title = "Update Technician Information";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                //Display messagebox.
                if (result == DialogResult.Yes)
                {
                    string place = "";
                    query = $"UPDATE Technicians SET ";

                    if (txtFNUpdate.Text.Length > 0)
                    {
                        query = query + $"FirstName = '{txtFNUpdate.Text}'";
                        place = ",";
                    }

                    if (txtLNUpdate.Text.Length > 0)
                    {
                        query = query + place + $" LastName = '{txtLNUpdate.Text}'";
                        place = ",";    //Adds a coma between each set if the First part of Query is full
                    }
                    if (txtCNUpdate.Text.Length > 0)
                    {
                        query = query + place + $" CellphoneNumber = '{txtCNUpdate.Text}'";
                        place = ",";   //Adds a coma between each set if the First part of Query is full
                    }

                    if (txtEmailUpdate.Text.Length > 5)
                    {
                        query = query + place + $" Email = '{txtEmailUpdate.Text}'";
                        place = ",";  //Adds a coma between each set if the First part of Query is full
                    }

                    query = query + $" WHERE Technician_ID = '{txtTechIDUpdate.Text}'";


                    com = new SqlCommand(query, conn);
                    dataAdapter.UpdateCommand = com;
                    com.ExecuteNonQuery();

                    MessageBox.Show("Technician information updated successfully.");

                    //Display Technicians table in DataGridView.
                    query = "SELECT * FROM Technicians";
                    com = new SqlCommand(query, conn);
                    DataSet ds = new DataSet();
                    dataAdapter.SelectCommand = com;
                    dataAdapter.Fill(ds, "Technicians");

                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "Technicians";
                }
                else
                {
                    
                }

                conn.Close();
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        //RemoveTechnician Method
        private void RemoveTechnician()
        {
            try
            {
                conn.Open();

                string message = "Permanently remove technician information?";
                string title = "Remove Technician Information";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                //Display messagebox.
                if (result == DialogResult.Yes)
                {
                    query = $"DELETE FROM Technicians WHERE Technician_ID = '{txtTech_ID.Text}'";
                    com = new SqlCommand(query, conn);
                    dataAdapter.DeleteCommand = com;
                    com.ExecuteNonQuery();

                    MessageBox.Show("Technician information deleted successfully.");

                    //Display Technicians table in DataGridView.
                    query = "SELECT * FROM Technicians";
                    com = new SqlCommand(query, conn);
                    DataSet ds = new DataSet();
                    dataAdapter.SelectCommand = com;
                    dataAdapter.Fill(ds, "Technicians");

                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "Technicians";
                }
                else
                {
                    
                }

                conn.Close();
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void gbxAddClient_Enter(object sender, EventArgs e)
        {

        }

        private void Technician_Load(object sender, EventArgs e)
        {
            //Display Technicians table in DataGridView.
            query = "SELECT * FROM Technicians";
            com = new SqlCommand(query, conn);
            DataSet ds = new DataSet();
            dataAdapter.SelectCommand = com;
            dataAdapter.Fill(ds, "Technicians");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Technicians";
        }

        private void btnAddTechnician_Click(object sender, EventArgs e)
        {
           if(verifyUserInput() == true)  // Verify if user input is true
            {
                //Call Add Method
                AddTechnician();

                //Clear textboxes
                txtFirstName.Clear();
                txtLastName.Clear();
                txtCellNumber.Clear();
                txtEmail.Clear();
            }
        }

        private void btnUpdateTechnician_Click(object sender, EventArgs e)
        {
            if (txtFNUpdate.Text == "" && txtLNUpdate.Text == "" && txtCNUpdate.Text == "" && txtEmailUpdate.Text == "" || txtTechIDUpdate.Text == "")
            {
                MessageBox.Show("Please enter valid values.");
            }
            else
            {
                //Call Update Method
                UpdateTechnician();

                //Clear textboxes.
                txtFNUpdate.Clear();
                txtLNUpdate.Clear();
                txtCNUpdate.Clear();
                txtEmailUpdate.Clear();
                txtTechIDUpdate.Clear();
            }
        }

        private void btnRemoveTechnician_Click(object sender, EventArgs e)
        {
            if (txtTech_ID.Text == "")
            {
                MessageBox.Show("Please enter a valid technician ID.");
            }
            else
            {
                //Call RemoveTechnician Method
                RemoveTechnician();

                txtTech_ID.Clear();
            }
        }

        private bool verifyUserInput()
        {
            bool flag = false;
            if (txtFirstName.Text.Length <= 0)
                MessageBox.Show("Please enter a name for the technician");
            else if (txtLastName.Text.Length <= 0)
                MessageBox.Show("Please enter a last name for the technician");
            else if (txtCellNumber.Text.Length != 10)
                MessageBox.Show("Please enter a valid 10 digit cellphone number");
            else if (txtEmail.Text.Length < 5)
                MessageBox.Show("Please enter a valid Email for the technician");
            else
                flag = true;            //If input validation succeeds

            return flag;
        }
    }
}
