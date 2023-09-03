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
    public partial class frmNavigate : Form
    {
        public frmNavigate()
        {
            InitializeComponent();
        }

        private void btnDevices_Click(object sender, EventArgs e)
        {
            pnldashBoard.Controls.Clear();
            frmDevices deviForm = new frmDevices() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            deviForm.FormBorderStyle = FormBorderStyle.None;
            this.pnldashBoard.Controls.Add(deviForm);
            deviForm.Show();

        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            pnldashBoard.Controls.Clear();
            frmClients clientsForm = new frmClients() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            clientsForm.FormBorderStyle = FormBorderStyle.None;
            this.pnldashBoard.Controls.Add(clientsForm);
            clientsForm.Show();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            pnldashBoard.Controls.Clear();
            frmInvoices invoiForm = new frmInvoices() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            invoiForm.FormBorderStyle = FormBorderStyle.None;
            this.pnldashBoard.Controls.Add(invoiForm);
            invoiForm.Show();
        }

        private void btnTechnicians_Click(object sender, EventArgs e)
        {
            pnldashBoard.Controls.Clear();
            Technician frmtechnician = new Technician() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmtechnician.FormBorderStyle = FormBorderStyle.None;
            this.pnldashBoard.Controls.Add(frmtechnician);
            frmtechnician.Show();
        }
    }
}
