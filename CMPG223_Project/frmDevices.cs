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
    public partial class frmDevices : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SCHMIDTL\SQLEXPRESS05;Initial Catalog=Data;Integrated Security=True;Pooling=False");
        SqlCommand comm = new SqlCommand();
        String sqlstatement;
        SqlDataAdapter adap = new SqlDataAdapter();
        


        public frmDevices()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNewDetails_TextChanged(object sender, EventArgs e)
        {
            int Characters = 100 - txtNewDetails.Text.Length;
            lblWords.Text = "Characters left = "+ Characters;

            if(Characters<0)
                lblWords.ForeColor= Color.Red;
            else
                lblWords.ForeColor= Color.LimeGreen;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String message = "Add device";
            String heading = "Are you sure you wish to ADD Device";
            if (verifyAction(0, message, heading))
            {
                AddDevice();
                sqlstatement = "Select * From Devices";
                dispDevices(sqlstatement);
            }
        }

        private void frmDevices_Load(object sender, EventArgs e)
        {
            sqlstatement = "Select * From Devices";
            dispDevices(sqlstatement);
        }

        private void AddDevice()
        {
            Boolean fixable = false;

            try
            {
                conn.Open();
                if (chbFixable.Checked)
                {
                    fixable = true;
                }
                String sqlstatement = $"Insert Into Devices (Device_Type,Fixable,Details,Repair_History) VALUES ('{cmbDevices.Text}','{fixable}','{txtNewDetails.Text}','{null}')";
                comm = new SqlCommand(sqlstatement, conn);
                adap.InsertCommand = comm;
                comm.ExecuteNonQuery();
                MessageBox.Show("Device was added successfully");
                conn.Close();
            }
            catch (SqlException sqe)
            {
                MessageBox.Show(sqe.Message);

            }
        }
        private void removeDevice(int ID)
        {
            try
            {
                conn.Open();
                sqlstatement = $"Delete FROM Devices where Device_ID = {ID}";
                comm = new SqlCommand(sqlstatement, conn);
                adap.DeleteCommand = comm;
                comm.ExecuteNonQuery();
                MessageBox.Show($"Device with ID : {ID} has been deleted from Devices.");
                conn.Close();
            }
            catch (SqlException sqe)
            {
                MessageBox.Show(sqe.Message);
            }
        }

        private void updateDevices(int ID)
        {
            bool fixable = false;
            if(chbRepairable.Checked)
                fixable= true;
            
            try
            {
                conn.Open();
                sqlstatement = $"Update Devices SET Fixable = '{fixable}'";
                
                //Tests whether the details should be updated asswell
                if (txtUpdateDetails.Text.Length > 0)
                    sqlstatement = sqlstatement + $", Details = '{txtUpdateDetails.Text}' WHERE Device_ID = {ID}";
                else
                    sqlstatement = sqlstatement + $"WHERE Device_ID = {ID}";

                comm = new SqlCommand(sqlstatement, conn);
                adap.UpdateCommand = comm;
                adap.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show($"Device with ID {ID} has been updated successfully!");
                conn.Close();
            }
            catch (SqlException sqe)
            {
                MessageBox.Show(sqe.Message);
            }
        }

        private void dispDevices(String sql)
        {
            try
            {
                lstDevices.Items.Clear();                                                                           //Clear Listbox
                lstDevices.Items.Add("ID\tType\tFixable");                                                         //Add Headings
                conn.Open();
                comm = new SqlCommand(sql, conn);
                SqlDataReader read;
                read = comm.ExecuteReader();

                while (read.Read())
                 {
                    lstDevices.Items.Add($"{read.GetInt32(0)}\t{read.GetString(1)}\t{read.GetString(2)}");          //Populate List Box
                 }

                conn.Close();
            }
            catch (SqlException sqe)
            {
                MessageBox.Show(sqe.Message);
                conn.Close();
            }
        }

        private void pnlDevices_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text.Length > 0)    //Tests wheter the user has entered a Value or not
                sqlstatement = $"Select * from devices where Device_ID = {txtFind.Text}";
            else
                sqlstatement = "Select * from Devices";
                
          dispDevices(sqlstatement);



        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            String heading = "Are you sure you wish to DELETE device ";
            String message = "Delete Confirmation";
            int ID;
            if (int.TryParse(txtRemove.Text, out ID))
                if (verifyAction(ID,heading,message) == true)
                    removeDevice(ID);
                else
                {
                    MessageBox.Show("Please enter a valid ID for the device you wish to delete");
                    txtRemove.Focus();
                }
            sqlstatement = "Select * From Devices";
            dispDevices(sqlstatement);
        }

        private Boolean verifyAction(int ID,String Heading,String message)
        {
            DialogResult result = MessageBox.Show($"{Heading} with ID {ID}?", message, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Action completed");
                return true;
            }
            else
            {
                MessageBox.Show("Action has been aborted");
                return false;

            }
        }

        private void cmbFind_TextChanged(object sender, EventArgs e)
        {
            //Filter Devices by their Type
            sqlstatement = $"Select * From Devices where Device_Type = '{cmbFind.Text}'";
            dispDevices(sqlstatement);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtUpdateDetails.Text, out id))
            {
                String heading = "Are you sure you wish to UPDATE device";
                String message = "Update Device";
                if (verifyAction(id, heading, message) == true)
                {
                    updateDevices(id);
                    sqlstatement = "Select * from Devices";
                    dispDevices(sqlstatement);
                }

            }
            else
                MessageBox.Show("Please enter a valid ID for the device");
        }
    }
}
