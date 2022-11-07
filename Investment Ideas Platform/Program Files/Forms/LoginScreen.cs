using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        // runs if cancel button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitBackend.buttonClicked(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String role = cbAccountType.Text.ToString();
            String email = txtEmail.Text.ToString();
            String password = txtPassword.Text.ToString();

            if (cbAccountType.Text == "Relationship Manager")
            {
                if (RMLoginBackend.rmLoginBackend(role, email, password))
                {
                    int id = RMLoginBackend.ReturnID();
                    lblLoginFail.Visible = false;
                    User user = new User(id, email, password, role);
                    ClientAdmin clientAdmin = new ClientAdmin(user);
                    clientAdmin.Show();
                }
                else
                {
                    lblLoginFail.Visible = true;
                }
            }


        }
    }
}