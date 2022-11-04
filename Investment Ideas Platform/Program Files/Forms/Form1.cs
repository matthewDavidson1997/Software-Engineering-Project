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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // runs if cancel button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            // creates new instance of exit pop up form
            ExitPopUp exitPopUp = new ExitPopUp(this);
            // displays the pop up form
            exitPopUp.Show();
            // disables the current form so you cant use this form while exit prompt is active
            this.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String role = cbAccountType.Text.ToString();
            String email = txtEmail.Text.ToString();
            String password = txtPassword.Text.ToString();

            if (cbAccountType.Text == "Relationship Manager") { 
                if(RMLoginBackend.rmLoginBackend(role, email, password))
                {
                    lblLoginFail.Visible = false;
                } else {
                    lblLoginFail.Visible = true;
                }
            }
            
        }
    }
}
