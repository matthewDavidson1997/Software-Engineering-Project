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
        // class level variable
        private static User user;
        public RmHomeScreen(User passedUser)
        {
            InitializeComponent();
            // parameter used to populate class level variable
            user = passedUser;
        }

        private void RmHomeScreen_Load(object sender, EventArgs e)
        {
            // runs code to load which rm is logged in
            RmHomeScreenBackend.rmHomeScreen_Load(lblLoggedInRmId, user);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // runs code to start exit process
            ExitBackend.buttonClicked(this);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            // runs backend code to take rms to client admin page
            RmHomeScreenBackend.clientsButtonClicked(this, user);
        }

       //used to close the program found at: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.closing?view=windowsdesktop-6.0
        private void RmHomeScreen_Closing(object sender, FormClosingEventArgs e) {
            // runs backend code to start exit process
            ExitBackend.exitProgram();
        }

        private void btnPurchaseIdeas_Click(object sender, EventArgs e)
        {
            // runs backend code to take rm to purchas products
            RmHomeScreenBackend.purchaseIdeasButtonClicked(user.id, this);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // runs the backend code to logout
            IdeaCreatorHomeBackend.logOut(this);
        }

        private void BTNRemoveIdea_Click(object sender, EventArgs e)
        {
            RmHomeScreenBackend.gotoremoveidea(this, user.id);
        }
    }
}
