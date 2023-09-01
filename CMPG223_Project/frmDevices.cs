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
    public partial class frmDevices : Form
    {
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
            lblWords.Text = "Characters left = "+Characters;

            if(Characters<0)
                lblWords.ForeColor= Color.Red;
            else
                lblWords.ForeColor= Color.LimeGreen;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void rdbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            lblNavigate.Text = "Update Devices";
            grpbxRemove.Visible = false;
            grpbxAddDevices.Visible = false;
            grpEdit.Visible = true;
        }

        private void rdbAdd_CheckedChanged(object sender, EventArgs e)
        {
            lblNavigate.Text = "Add Devices";
            grpbxAddDevices.Visible = true;
            grpbxRemove.Visible = false;
            grpEdit.Visible = false;
        }

        private void rdbRemove_CheckedChanged(object sender, EventArgs e)
        {
            lblNavigate.Text = "Remove Devices";
            grpbxRemove.Visible = true;
            grpbxAddDevices.Visible = false;
            grpEdit.Visible = false;
        }
    }
}
