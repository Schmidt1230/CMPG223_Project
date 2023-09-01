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

        }
    }
}
