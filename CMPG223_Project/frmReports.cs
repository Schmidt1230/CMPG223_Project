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
    public partial class frmReports : Form
    {

        SqlDataAdapter adap;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\OneDrive\Desktop\CMPG223_Project\CMPG223_Project\AlexandersDatabase.mdf;Integrated Security=True");
        String sqlStatement;
        SqlDataReader read;
        SqlCommand comm;


        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            getTechnicians();
        }

        private int calcTotalRepairs(int tech_id)
        {
            int repairs = 0;
            try
            {
                conn.Close();
                conn.Open();
                sqlStatement = $"Select * from Repair_Orders WHERE Technician_ID = {tech_id}";
                comm = new SqlCommand(sqlStatement, conn);
                read = comm.ExecuteReader();
                while (read.Read())
                {
                    repairs += 1;
                }
                conn.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }

            return repairs;
        }

        private void getTechnicians()
        {
            try
            {
                conn.Open();
                sqlStatement = "Select Distinct FirstName from Technicians";
                comm = new SqlCommand(sqlStatement, conn);

                read = comm.ExecuteReader();

                while (read.Read())
                    cmbTechnician.Items.Add(read.GetString(0));

                conn.Close();
            }
            catch (SqlException exception)
            {
                conn.Close();
                MessageBox.Show(exception.Message);
            }
        }

        private int getID(string name)
        {
            try
            {
                conn.Open();
                sqlStatement = $"Select Technician_ID From Technicians Where FirstName = '{name}'";
                comm = new SqlCommand(sqlStatement,conn);
                read = comm.ExecuteReader();
                while (read.Read())
                {
                    return read.GetInt32(0);    
                }

                read.Close();
                return 0;
                conn.Close();
            }
            catch (SqlException sqe)
            {
                MessageBox.Show(sqe.Message);
            }

            return 0;
        }

        private void dispReport(string sql)
        {
            try
            {
                conn.Open();
                
                conn.Close();

            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private string getName(int id)
        {
            String name = "";
            try
            {
                conn.Open();
                sqlStatement = $"Select FirstName From Technicians Where Technician_ID = {id}";
                comm = new SqlCommand(sqlStatement, conn);

                read = comm.ExecuteReader();

                while (read.Read())
                { 
                    name = read.GetString(0);
                }
                conn.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }

            return name;
        }


        private void cmbTechnician_TextChanged(object sender, EventArgs e)
        {
            lstReport.Items.Clear();
            lstReport.Items.Add("Technician Name : "+cmbTechnician.Text);
            lstReport.Items.Add("Total Repairs : " + calcTotalRepairs(getID(cmbTechnician.Text)));
            lstReport.Items.Add("............................................................");
        }

        private void chbAllTechnicians_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rdbDescending_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBestPerforming_Click(object sender, EventArgs e)
        {
            int highest = 0;
            int index = -1;
            MessageBox.Show(countTechnicians().ToString());
            for (int i = 1; i < countTechnicians(); i++)
            {
                if (highest < calcTotalRepairs(i))
                {
                    highest = calcTotalRepairs(i);
                    index = i;                                                      //Store Most repairs index
                }
            }

            lstReport.Items.Add("Report for Most Repairs by a technician");
            lstReport.Items.Add("Technician : " + getName(index));
            lstReport.Items.Add("Total Repairs Completed : " + calcTotalRepairs(index));
            lstReport.Items.Add(".....................................................");
            
            
        }

        private int countTechnicians()
        {
            int count = 0;
            try
            {
                conn.Open();
                sqlStatement = "Select * from Technicians";
                comm = new SqlCommand(sqlStatement, conn);
                read = comm.ExecuteReader();

                while (read.Read())
                    count++;

                conn.Close();
            }
            catch (SqlException sqe)
            {
                MessageBox.Show(sqe.Message);
            }

            return count;
        }

        private void chbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAll.Checked)
            {
                lstReport.Items.Clear();
                for (int i = 1; i <= countTechnicians(); i++)
                {
                    lstReport.Items.Add("Report for : " + getName(i));
                    lstReport.Items.Add("Total Repairs : " + calcTotalRepairs(i));
                    lstReport.Items.Add("........................................");
                }
            }
        }
    }
}
