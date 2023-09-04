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

                string message = "Update technician information?";
                string title = "Update Technician Information";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                //Display messagebox.
                if (result == DialogResult.Yes)
                {
                    query = $"UPDATE Technicians SET FirstName = '{txtFNUpdate.Text}', LastName = '{txtLNUpdate.Text}', CellphoneNumber = '{txtCNUpdate.Text}', Email = '{txtEmailUpdate.Text}' WHERE Technician_ID = '{txtTechIDUpdate.Text}'";
                    ////////com = new SqlCommand(query, conn);
                    dataAdapter.UpdateCommand = com;
                    com.ExecuteNonQuery();

                    MessageBox.Show("Technician information updated successfully.");
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

        //calcSalary Method
        private void calcSalary()
        {

        }

        private void gbxAddClient_Enter(object sender, EventArgs e)
        {

        }

        private void Technician_Load(object sender, EventArgs e)
        {
            //Display Clients table in DataGridView.
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
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtCellNumber.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please enter valid values.");
            }
            else
            {
                //Call Add Method
                AddTechnician();
            }

            //Clear textboxes
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCellNumber.Clear();
            txtEmail.Clear();
        }

        private void btnUpdateTechnician_Click(object sender, EventArgs e)
        {
            if (txtFNUpdate.Text == "" || txtLNUpdate.Text == "" || txtCNUpdate.Text == "" || txtEmailUpdate.Text == "")
            {
                MessageBox.Show("Please enter valid values.");
            }
            else
            {
                //Call Update Method
                UpdateTechnician();
            }

            //Clear textboxes.
            txtFNUpdate.Clear();
            txtLNUpdate.Clear();
            txtCNUpdate.Clear();
            txtEmailUpdate.Clear();
            txtTechIDUpdate.Clear();
        }

        private void btnRemoveTechnician_Click(object sender, EventArgs e)
        {
            if (txtTech_ID.Text == "")
            {
                MessageBox.Show("Please enter valid values.");
            }
            else
            {
                //Call RemoveTechnician Method
                RemoveTechnician();
            }
        }
    }
}
