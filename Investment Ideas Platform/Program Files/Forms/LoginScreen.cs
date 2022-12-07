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

        private void btnExit_Click(object sender, EventArgs e)
        {
            // runs backend code to exit code
            ExitBackend.buttonClicked(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // runs backend code to start login process
            RMLoginBackend.rmLoginBackend(this, lblLoginFail, cbAccountType, txtEmail, txtPassword);
        }
    }
}