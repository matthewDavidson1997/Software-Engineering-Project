using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    public partial class RmHomeScreen : Form
    {
        private static User user;
        public RmHomeScreen(User passedUser)
        {
            InitializeComponent();
            user = passedUser;
        }

        private void RmHomeScreen_Load(object sender, EventArgs e)
        {
            RmHomeScreenBackend.rmHomeScreen_Load(lblLoggedInRmId, user);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitBackend.buttonClicked(this);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            RmHomeScreenBackend.clientsButtonClicked(this, user);
        }

       //used to close the program found at: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.closing?view=windowsdesktop-6.0
        private void RmHomeScreen_Closing(object sender, FormClosingEventArgs e) {
            ExitBackend.exitProgram();
        }

        private void btnPurchaseIdeas_Click(object sender, EventArgs e)
        {
            RmHomeScreenBackend.purchaseIdeasButtonClicked(user.id, this);
        }
    }
}
