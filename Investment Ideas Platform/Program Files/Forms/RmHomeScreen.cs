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
            lblLoggedInRmId.Text = "Logged In RM ID: " + user.id;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitBackend.buttonClicked(this);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientAdmin clientAdmin = new ClientAdmin(user);
            clientAdmin.Show();
            this.Hide();
        }

        private void RmHomeScreen_Closing(object sender, FormClosingEventArgs e) {
            ExitBackend.exitProgram();
        }

    }
}
