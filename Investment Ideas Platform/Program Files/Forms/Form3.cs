using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Relationship_manager_administration_system.Forms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitPopUp exitPopUp = new ExitPopUp(this);
            // displays the pop up form
            exitPopUp.Show();
            // disables the current form so you cant use this form while exit prompt is active
            this.Enabled = false;
        }
    }
}
