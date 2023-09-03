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
        SqlConnection conn = new SqlConnection(@"");
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

        //MessageBox method.
        private void showMessage(string message, string title)
        {
            int technicianID = int.Parse(txtTech_ID.Text);

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            //Display messagebox.
            if (result == DialogResult.Yes)
            {
                //Call Remove/Update Method using delegate.
            }
            else
            {
                this.Close();
            }
        }

        //AddTechnician Client
        private void AddTechnician(string query)
        {
            try
            {
                conn.Open();

                query = "";
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
        private void UpdateTechnician(string query)
        {
            try
            {
                conn.Open();

                query = "";
                com = new SqlCommand(query, conn);
                dataAdapter.UpdateCommand = com;
                com.ExecuteNonQuery();

                MessageBox.Show("Technician information updated successfully.");

                conn.Close();
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        //RemoveTechnician Method
        private void RemoveTechnician(string query, int technicianID)
        {
            try
            {
                conn.Open();

                query = $"DELETE FROM Technicians WHERE TechnicianID = {technicianID}";
                com = new SqlCommand(query, conn);
                dataAdapter.DeleteCommand = com;
                com.ExecuteNonQuery();

                MessageBox.Show("Technician information deleted successfully.");

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
            AddTechnician($"INSERT INTO Technicians (TechnicianName, TechnicianLastName, TechnicianCellNumber, TechnicianEmail) VALUES ({technicianFN}, {technicianLN}, {technicianCN}, {technicianEmail})");

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

            //Call Update Method using delegate.

            //Call showMessage Method
            showMessage("Update client information?", "Update Client Information");
        }

        private void btnRemoveTechnician_Click(object sender, EventArgs e)
        {
            //Call showMessage method.
            showMessage("Permanently remove technician information?", "Remove Technician Information");

            //Call remove method using delegate above.
        }
    }
}
