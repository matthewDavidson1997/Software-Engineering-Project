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

        // runs if exi button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitBackend.buttonClicked(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RMLoginBackend.rmLoginBackend(this, lblAccountType, cbAccountType, txtEmail, txtPassword);
        }
    }
}