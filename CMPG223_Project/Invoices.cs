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
    public partial class frmInvoices : Form
    {
        SqlDataAdapter adap;
        SqlConnection connection = new SqlConnection(@"Data Source=SCHMIDTL\SQLEXPRESS05;Initial Catalog=Data;Integrated Security=True;Pooling=False");
        String sqlStatement;
        SqlDataReader read;
        SqlCommand command;

        private const decimal BASE_FEE = 250.00m;
        private int selectedTechnicianId = -1; 
        private int selectedClientId = -1;


        public frmInvoices()
        {
            InitializeComponent();
        }

        private void PopulateTechniciansComboBox()
        {
            string query = "SELECT First_Name FROM Technicians";


            command = new SqlCommand(query, connection);
                
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
               string technicianName = reader.GetString(0);
               cmbTechnician.Items.Add(technicianName);
            }

            reader.Close();
            connection.Close();
                
            
        }

        private void PopulateClientsComboBox()
        {
            string query = "SELECT Client_Name FROM Clients";
            try
            {
                connection.Open();
                command = new SqlCommand(query,connection);
                read = command.ExecuteReader();
                while (read.Read())
                {
                    cmbClient.Items.Add(read.GetString(0));
                }
                connection.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
            command = new SqlCommand(query, connection);

        }

        private void UpdateCompTotal()
        {
            decimal total = 250;

            if (cbxKeyboard.Checked)
            {                
                total += 500.00m; 
            }

            if (cbxCompScreen.Checked)
            {                
                total += 1200.00m; 
            }

            if (cbxCompBattery.Checked)
            {                
                total += 800.00m; 
            }

            if (cbxCompVirus.Checked)
            {               
                total += 200.00m; 
            }

            if (cbxCompMotherboard.Checked)
            {                
                total += 1500.00m; 
            }

            if (cbxDisk.Checked)
            {                
                total += 600.00m; 
            }
            
            decimal vat = total * 0.15m;            
            decimal totalWithVat = total + vat;
            
            txtCompExcVAT.Text = total.ToString("0.00");
            txtCompVAT.Text = vat.ToString("0.00");
            txtCompTotal.Text = totalWithVat.ToString("0.00");            
        }

        private void cbxKeyboard_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCompTotal();            
        }

        private void cbxScreen_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCompTotal();
        }

        private void cbxBattery_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCompTotal();
        }

        private void cbxVirus_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCompTotal();
        }

        private void cbxMotherboard_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCompTotal();
        }

        private void cbxDisk_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCompTotal();
        }

        private void frmInvoices_Load(object sender, EventArgs e)
        {
            UpdateCompTotal();
            PopulateTechniciansComboBox();
            PopulateClientsComboBox();
        }

        private void UpdateCellTotal()
        {
            decimal cellTotal = 250;

            if (cbxCellScreen.Checked)
            {
                cellTotal += 900.00m; 
            }

            if (cbxCellBattery.Checked)
            {
                cellTotal += 600.00m; 
            }

            if (cbxCellVirus.Checked)
            {
                cellTotal += 200.00m; 
            }

            if (cbxCellMotherboard.Checked)
            {
                cellTotal += 1200.00m; 
            }

            if (cbxCharge.Checked)
            {
                cellTotal += 350.00m;
            }        
                        
            decimal vat = cellTotal * 0.15m;            
            decimal totalWithVat = cellTotal + vat;
            
            txtCellExcVAT.Text = cellTotal.ToString("0.00");
            txtCellVAT.Text = vat.ToString("0.00");
            txtCellTotal.Text = totalWithVat.ToString("0.00");

        }

        private void cbxCellScreen_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCellTotal();
        }

        private void cbxCellBattery_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCellTotal();
        }

        private void cbxCellVirus_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCellTotal();
        }

        private void cbxCellMotherboard_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCellTotal();
        }

        private void cbxCharge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCellTotal();
        }

        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            
            listBoxInvoice.Items.Clear();

            listBoxInvoice.Items.Add("Computer Invoice:\n\n");
            listBoxInvoice.Items.Add("--------------------------------------------------------------------------------------------- ");


            
            if (cbxKeyboard.Checked)
            {
                listBoxInvoice.Items.Add("Keyboard - \tR500.00");
            }

            if (cbxCompScreen.Checked)
            {
                listBoxInvoice.Items.Add("Computer Screen - \tR1200.00");
            }

            if (cbxCompBattery.Checked)
            {
                listBoxInvoice.Items.Add("Computer Battery - \tR800.00");
            }

            if (cbxCompVirus.Checked)
            {
                listBoxInvoice.Items.Add("Virus Removal - \tR200.00");
            }

            if (cbxCompMotherboard.Checked)
            {
                listBoxInvoice.Items.Add("Motherboard - \tR1500.00");
            }

            if (cbxDisk.Checked)
            {
                listBoxInvoice.Items.Add("Hard Drive - \tR600.00");
            }
            
            decimal compTotal = decimal.Parse(txtCompExcVAT.Text);
            decimal compVat = decimal.Parse(txtCompVAT.Text);
            decimal compTotalWithVat = decimal.Parse(txtCompTotal.Text);

           
            listBoxInvoice.Items.Add("***************************************************************************************************************************");
            listBoxInvoice.Items.Add($"Component Total (excluding VAT): \tR{compTotal.ToString("0.00")}");
            listBoxInvoice.Items.Add($"Component VAT (15%): \t\tR{compVat.ToString("0.00")}");
            listBoxInvoice.Items.Add($"Component Total (including VAT): \tR{compTotalWithVat.ToString("0.00")}");
            listBoxInvoice.Items.Add("");
        }

        private void btnCellViewInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxInvoice.Items.Clear();
                listBoxInvoice.Items.Add("Smartphone Invoice:\n\n");
                listBoxInvoice.Items.Add("--------------------------------------------------------------------------------------------- ");


                if (cbxCellScreen.Checked)
                {
                    listBoxInvoice.Items.Add("Screen Replacement - \tR900.00");
                }

                if (cbxCellBattery.Checked)
                {
                    listBoxInvoice.Items.Add("Battery Replacement - \tR600.00");
                }

                if (cbxCellVirus.Checked)
                {
                    listBoxInvoice.Items.Add("Virus Removal - \t\tR200.00");
                }

                if (cbxCellMotherboard.Checked)
                {
                    listBoxInvoice.Items.Add("Motherboard - \t\tR1200.00");
                }

                if (cbxCharge.Checked)
                {
                    listBoxInvoice.Items.Add("Charging Port Repair - \tR350.00");
                }

                decimal cellTotal = decimal.Parse(txtCellExcVAT.Text);
                decimal cellVat = decimal.Parse(txtCellVAT.Text);
                decimal cellTotalWithVat = decimal.Parse(txtCellTotal.Text);

               
                listBoxInvoice.Items.Add("***************************************************************************************************************************");
                listBoxInvoice.Items.Add($"\nComponent Total (excluding VAT): \tR{cellTotal.ToString("R0.00")}");
                listBoxInvoice.Items.Add($"Component VAT (15%): \t\tR{cellVat.ToString("0.00")}");
                listBoxInvoice.Items.Add($"Component Total (including VAT): \tR{cellTotalWithVat.ToString("0.00")}");
                listBoxInvoice.Items.Add(" ");
            }
            catch(Exception)
            {
                MessageBox.Show("Please select item to View Invoice");
            }
            
        }

        private void cmbTechnician_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTechnician.SelectedItem != null)
            {
                // Retrieve the selected technician name
                string technicianName = cmbTechnician.SelectedItem.ToString();

                // Retrieve the selected technician ID based on the name
                selectedTechnicianId = GetTechnicianIdByName(technicianName);
            }
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClient.SelectedItem != null)
            {
                // Retrieve the selected client name
                string clientName = cmbClient.SelectedItem.ToString();

                // Retrieve the selected client ID based on the name
                selectedClientId = GetClientIdByName(clientName);
            }
        }

        private int GetTechnicianIdByName(string name)
        {
            int technicianId = -1; // Initialize with an invalid value
            try
            {
                connection.Open();
                string query = $"SELECT Technician_ID FROM Technicians WHERE First_Name = '{name}'";
                command = new SqlCommand(query, connection);

                read = command.ExecuteReader();

                while (read.Read())
                {
                    technicianId = read.GetInt32(0);
                }
                connection.Close();
            }
            catch (SqlException sqe)
            {
                MessageBox.Show(sqe.Message);
                connection.Close();
            }
            return technicianId;
        }

        private int GetClientIdByName(string name)
        {
            int clientId = -1;
            try
            { 
                connection.Open();
                string query = $"SELECT Client_ID FROM Clients WHERE Client_Name = '{name}'";

                command = new SqlCommand(query, connection);

                read = command.ExecuteReader();

                while (read.Read())
                {
                    clientId = read.GetInt32(0);
                }

                connection.Close();
            }
            catch (SqlException sqe)
            {
                MessageBox.Show(sqe.Message);
            }
            return clientId;
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            if (listBoxInvoice.Items.Count > 0)
            {
                InsertInvoiceData();
            }
            else
            {
                MessageBox.Show("There are no items in the invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertInvoiceData()
        {
            try
            {
                
                    connection.Open();

                  

                    decimal repairCost = 0;
                    decimal total = 0; 

                    
                    if (IsComputerRepair()) 
                    {
                        repairCost = decimal.Parse(txtCompTotal.Text); 
                        total = decimal.Parse(txtCompTotal.Text); 
                    }
                    else
                    {
                        repairCost = decimal.Parse(txtCellTotal.Text); 
                        total = decimal.Parse(txtCellTotal.Text); 
                    }

                    String now = DateTime.Now.ToString("d");
                    string insertQuery = $"INSERT INTO Invoices (Technician_ID, Total_Amount, A_Date, Base_Inspection_Fee, Repair_Cost, Client_ID) VALUES ({selectedTechnicianId}, {250,00}, {DateTime.Today.ToShortDateString()}, {250,00}, {500,00}, {selectedClientId})";

                    command = new SqlCommand(insertQuery, connection);
                    adap = new SqlDataAdapter();
                    adap.InsertCommand = command;


                int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Invoice data has been successfully inserted into the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert invoice data into the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsComputerRepair()
        {
            bool isComputerRepair = cbxKeyboard.Checked || cbxCompScreen.Checked || cbxCompBattery.Checked ||
                            cbxCompVirus.Checked || cbxCompMotherboard.Checked || cbxDisk.Checked;

            return isComputerRepair;
        }


    }
}

