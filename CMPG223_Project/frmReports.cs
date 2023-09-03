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
        SqlConnection conn = new SqlConnection(@"Data Source=SCHMIDTL\SQLEXPRESS05;Initial Catalog=Data;Integrated Security=True;Pooling=False");
        String sqlStatement;
        SqlDataReader read;
        SqlCommand comm;


        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {

        }

        private int calcTotalRepairs(int tech_id)
        {
            int repairs = 0;
            try
            {
                conn.Open();
                sqlStatement = $"Select * from Repair_Orders WHERE Technician_ID = {tech_id}";
                comm = new SqlCommand(sqlStatement, conn);
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


                conn.Close();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
