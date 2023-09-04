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

        public string role;

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
            SqlConnection conn = new SqlConnection(@"Data Source=SCHMIDTL\SQLEXPRESS05;Initial Catalog=Data;Integrated Security=True;Pooling=False");
            SqlDataReader read;
            SqlCommand comm;
            Boolean flag = false;


            try
            {
                conn.Open();
                String sqlstatement = $"Select * From Users";
                comm = new SqlCommand(sqlstatement, conn);
                read= comm.ExecuteReader();

                while (read.Read()) 
                {//While
                    String dUser = read.GetString(1);
                    String dPassword = read.GetString(2);
                    if(dUser==Username && dPassword != password) 
                        {
                            MessageBox.Show("Password was incorrect for " + Username);
                            flag = false;
                        }
                    else if (dUser==Username && dPassword==password) 
                        {
                            MessageBox.Show("Login Successfull");
                            flag = true;
                            role = read.GetString(3);
                        }
                }//While

                if (flag == false)
                    MessageBox.Show("System Access Denied");

                conn.Close();
                return flag;
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
            string username = txtUsername.Text, password = txtPassword.Text;
            if (verifyUser(username,password) == true)
            {
                MessageBox.Show("Welcome " + txtUsername.Text);
                frmNavigate frmNavi = new frmNavigate();
                frmNavi.lblRole.Text = role;
                frmNavi.Show();
                this.Hide();
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
