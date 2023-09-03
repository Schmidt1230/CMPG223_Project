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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void chbShow_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chbShow.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
             
         }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;           //Hide the password Characters for Privacy and Security Purposes.
            lblDate.Text = DateTime.Today.ToString("d");        //Display todays date.
        }
        private Boolean verifyUser(string Username,String password)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=SCHMIDTL\SQLEXPRESS05;Integrated Security=True");
            SqlDataReader read;
            SqlCommand comm;

            try
            {
                conn.Open();
                String sqlstatement = "Select user_name,user_password From Users";
                comm = new SqlCommand(sqlstatement, conn);
                read= comm.ExecuteReader();
                Boolean match = false;

                while (read.Read()) 
                {//While
                    if((read.GetString(0)==Username) && (read.GetString(1)!= password)) 
                        {
                            MessageBox.Show("Password was incorrect for " + Username);
                            conn.Close();
                        match = false;
                        }
                     if ((read.GetString(0)==Username)) //&& (read.GetString(1)==password)
                    {
                            MessageBox.Show("Login Successfull");
                            conn.Close();
                        match = true;
                        }
                }//While

                //If User was not found and while loop execution has finished
                conn.Close();
                return match;
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
                conn.Close();
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            
            //Validate if user has entered details
            if (username.Length < 0)
                MessageBox.Show("Please enter your user name");
            else if (password.Length < 0)
                MessageBox.Show("Please enter your password");
            else
                if (verifyUser(username,password) == true)
                {
                MessageBox.Show("Success");
                 }
        }

        private void chbForm_CheckedChanged(object sender, EventArgs e)
        {
            frmNavigate n1 = new frmNavigate();
            n1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //IGNORE THIS
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmInvoices invoices = new frmInvoices();
            invoices.Show();
        }

        private void chbForm_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
