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
            decimal cellTotal = 0;

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
            listBoxInvoice.Items.Add($"Component Total (excluding VAT): ${compTotal.ToString("0.00")}");
            listBoxInvoice.Items.Add($"Component VAT (15%): ${compVat.ToString("0.00")}");
            listBoxInvoice.Items.Add($"Component Total (including VAT): ${compTotalWithVat.ToString("0.00")}");
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
                    listBoxInvoice.Items.Add("Charging Port Repair - R350.00");
                }

                decimal cellTotal = decimal.Parse(txtCellExcVAT.Text);
                decimal cellVat = decimal.Parse(txtCellVAT.Text);
                decimal cellTotalWithVat = decimal.Parse(txtCellTotal.Text);

               
                listBoxInvoice.Items.Add("***************************************************************************************************************************");
                listBoxInvoice.Items.Add($"\nComponent Total (excluding VAT): R{cellTotal.ToString("R0.00")}");
                listBoxInvoice.Items.Add($"Component VAT (15%): R{cellVat.ToString("0.00")}");
                listBoxInvoice.Items.Add($"Component Total (including VAT): R{cellTotalWithVat.ToString("0.00")}");
                listBoxInvoice.Items.Add(" ");
            }
            catch(Exception)
            {
                MessageBox.Show("Please select item to View Invoice");
            }
            
        }
    }
}
