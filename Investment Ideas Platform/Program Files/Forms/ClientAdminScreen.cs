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
        // class level of user
        private User user;
        public ClientAdmin(User passedUser)
        {
            InitializeComponent();
            // uses the parameter to populate the user variable
            user = passedUser;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // runs bckend code for you to exit the program
            ExitBackend.buttonClicked(this);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // runs backend code to clear textboxes
            ClientAdminBackend.ClearClick(txtClientName, txtEmail, txtContactFirst, txtContactLast, txtContactNumber, lblClientReference);
        }

        private void ClientAdmin_Load(object sender, EventArgs e)
        {
            // runs backend code to fill text boxes
            ClientAdminBackend.clientAdmin_Load(dgvClients, txtClientName, txtEmail, txtContactFirst, txtContactLast, txtContactNumber, lblClientReference, user.id, lblLoggedInRM);
        }

        private void dgvClients_MouseClick(object sender, DataGridViewCellEventArgs e)
        {
            // runs backend code to fill textboxes based on what you have clicked on in the data grid view
            ClientAdminBackend.FillTextBoxes(dgvClients, txtClientName, txtEmail, txtContactFirst, txtContactLast, txtContactNumber, lblClientReference);
        }

        //used to close the program found at: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.closing?view=windowsdesktop-6.0
        private void ClientAdmin_Closing(object sender, FormClosingEventArgs e)
        {
            // runs backend code to exit program
            ExitBackend.exitProgram();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // runs backend code to update client information
            ClientAdminBackend.UpdateClientInformation(txtClientName, txtEmail, txtContactFirst, txtContactLast, txtContactNumber, lblClientReference);
            // runs backend code to update the datagrid view
            ClientAdminBackend.clientAdmin_Load(dgvClients, txtClientName, txtEmail, txtContactFirst, txtContactLast, txtContactNumber, lblClientReference, user.id, lblLoggedInRM);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // runs code to delete a client from database
            ClientAdminBackend.DeleteClient(lblClientReference);
            // runs backend code to update the datagridview
            ClientAdminBackend.clientAdmin_Load(dgvClients, txtClientName, txtEmail, txtContactFirst, txtContactLast, txtContactNumber, lblClientReference, user.id, lblLoggedInRM);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // runs backend code to create a client
            ClientAdminBackend.CreateClient(txtClientName, txtEmail, txtContactFirst, txtContactLast, txtContactNumber, user.id);
            // runs backend code to update the datagridview
            ClientAdminBackend.clientAdmin_Load(dgvClients, txtClientName, txtEmail, txtContactFirst, txtContactLast, txtContactNumber, lblClientReference, user.id, lblLoggedInRM);
        }

        private void btnUpdatePreferences_Click(object sender, EventArgs e)
        {
            // runs backend code to update clients preferences
            ClientAdminBackend.updatePreferences(this, lblClientReference, lblLoggedInRM);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // runs backend code to go to the home screen
            ClientAdminBackend.goHome(user.id, this);
        }
    }
}
