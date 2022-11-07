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
        private User user;
        public ClientAdmin(User passedUser)
        {
            InitializeComponent();
            user = passedUser;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitBackend.buttonClicked(this);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClientAdminBackend.ClearClick(txtClientName, txtEmail, txtContactName, txtContactNumber, lblClientReference);
        }

        private void ClientAdmin_Load(object sender, EventArgs e)
        {
            ClientAdminBackend.clientAdmin_Load(dgvClients, txtClientName, txtEmail, txtContactName, txtContactNumber, lblClientReference, user.id, lblLoggedInRM);
        }

        private void dgvClients_MouseClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientAdminBackend.FillTextBoxes(dgvClients, txtClientName, txtEmail, txtContactName, txtContactNumber, lblClientReference);
        }

    }
}
