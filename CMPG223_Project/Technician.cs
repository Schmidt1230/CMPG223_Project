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
        SqlConnection conn = new SqlConnection(@"Data Source=SCHMIDTL\SQLEXPRESS05;Initial Catalog=Data;Integrated Security=True;Pooling=False");
        SqlCommand com = new SqlCommand();
        String query;
        SqlDataAdapter dataAdapter = new SqlDataAdapter();

        //Declare public variables.
        public string technicianFN;
        public string technicianLN;
        public string technicianCN;
        public string technicianEmail;

        public string technicianFNUpdate;
        public string technicianLNUpdate;
        public string technicianCNUpdate;
        public string technicianEmailUpdate;

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
                query = $"INSERT INTO Technicians (First_Name, Last_Name, Cellphone_Number, Email) VALUES ('{txtFirstName.Text}', '{txtLastName.Text}', '{txtCellNumber.Text}', '{txtEmail.Text}')";
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

                int technicianID = int.Parse(txtTech_ID.Text);
                string message = "Update technician information?";
                string title = "Update Technician Information";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                //Display messagebox.
                if (result == DialogResult.Yes)
                {
                    query = $"UPDATE Technicians SET First_Name = '{txtFirstName.Text}', Last_Name = '{txtLastName.Text}', Cellphone_Number = '{txtCellNumber.Text}', Email = '{txtEmail.Text}'";
                    com = new SqlCommand(query, conn);
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
                    query = $"DELETE FROM Technicians WHERE TechnicianID = {technicianID}";
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

        }

        private void btnAddTechnician_Click(object sender, EventArgs e)
        {
            technicianFN = txtFirstName.Text;
            technicianLN = txtLastName.Text;
            technicianCN = txtCellNumber.Text;
            technicianEmail = txtEmail.Text;

            //Call Add Method
            AddTechnician();

            //Clear textboxes
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCellNumber.Clear();
            txtEmail.Clear();
        }

        private void btnUpdateTechnician_Click(object sender, EventArgs e)
        {
            technicianFNUpdate = txtFNUpdate.Text;
            technicianLNUpdate = txtLNUpdate.Text;
            technicianCNUpdate = txtCNUpdate.Text;
            technicianEmailUpdate = txtEmailUpdate.Text;

            //Call Update Method
            UpdateTechnician();

            txtFNUpdate.Clear();
            txtLNUpdate.Clear();
            txtCNUpdate.Clear();
            txtEmailUpdate.Clear();
        }

        private void btnRemoveTechnician_Click(object sender, EventArgs e)
        {
            //Call RemoveTechnician Method
            RemoveTechnician();
        }
    }
}
