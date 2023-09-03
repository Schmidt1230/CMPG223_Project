﻿using System;
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
                sqlStatement = "Select Distinct First_Name from Technicians";
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
                sqlStatement = $"Select Technician_ID From Technicians Where First_Name = '{name}'";
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

        private void cmbTechnician_TextChanged(object sender, EventArgs e)
        {
            lstReport.Items.Clear();
            lstReport.Items.Add("Technician Name : "+cmbTechnician.Text);
            lstReport.Items.Add("Total Repairs : " + calcTotalRepairs(getID(cmbTechnician.Text)));
            lstReport.Items.Add("............................................................");
        }
    }
}
