using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Project
{
    public partial class frmInvoices : Form
    {
        public frmInvoices()
        {
            InitializeComponent();
        }

        private void UpdateCompTotal()
        {
            decimal total = 0;

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
        }

        private void UpdateCellTotal()
        {
            decimal total = 0;

            if (cbxCellScreen.Checked)
            {                
                total += 900.00m; 
            }

            if (cbxCellBattery.Checked)
            {                
                total += 600.00m; 
            }

            if (cbxCellVirus.Checked)
            {                
                total += 200.00m; 
            }

            if (cbxCellMotherboard.Checked)
            {                
                total += 1200.00m; 
            }

            if (cbxCharge.Checked)
            {
                total += 350.00m;
            }        
                        
            decimal vat = total * 0.15m;            
            decimal totalWithVat = total + vat;
            
            txtCellExcVAT.Text = total.ToString("0.00");
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

        }
    }
}
