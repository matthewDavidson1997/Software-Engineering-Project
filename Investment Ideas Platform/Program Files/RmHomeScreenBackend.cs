using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    class RmHomeScreenBackend
    {
        public static void clientsButtonClicked(Form formPassed, User user) {
            ClientAdmin clientAdmin = new ClientAdmin(user);
            clientAdmin.Show();
            formPassed.Hide();
        }

        public static void rmHomeScreen_Load(Label lblLoggedInRmId, User user) {
            lblLoggedInRmId.Text = "Logged In RM ID: " + user.id;
        }

    }
}
