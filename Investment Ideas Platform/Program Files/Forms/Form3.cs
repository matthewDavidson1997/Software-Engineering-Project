using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    public partial class ClientAdmin : Form
    {
        public ClientAdmin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitPopUp exitPopUp = new ExitPopUp(this);
            // displays the pop up form
            exitPopUp.Show();
            // disables the current form so you cant use this form while exit prompt is active
            this.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClientAdminBackend.ClearClick(txtClientName, txtEmail, txtContactName, txtContactNumber, lblClientReference);
        }

        private void ClientAdmin_Load(object sender, EventArgs e)
        {
            dgvClients.Rows.Clear();
            ClientAdminBackend.ClearClick(txtClientName, txtEmail, txtContactName, txtContactNumber, lblClientReference);
            ClientAdminBackend.getdatafromDB(dgvClients);
        }

        private void dgvClients_MouseClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientAdminBackend.FillTextBoxes(dgvClients, txtClientName, txtEmail, txtContactName, txtContactNumber, lblClientReference);
        }
    }
}
