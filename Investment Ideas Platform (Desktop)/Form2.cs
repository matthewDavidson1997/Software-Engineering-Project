using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    public partial class ExitPopUp : Form
    {
        // class level variable used to help reinable login form if exit prompt is cancelled: https://social.msdn.microsoft.com/Forums/vstudio/en-US/be3e3811-ad66-45d9-a14e-6a379fb0cdb1/c-how-to-disable-a-form-when-another-form-is-open?forum=winforms
        private Form form;
        public ExitPopUp(Form1 form1)
        {
            // giving the class level variable our form1 value which is the login form
            form = form1;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // used to reinable original form is cancell button is clicked
            form.Enabled = true;
            // closes this form
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // closes this form
            this.Close();
            // exits program with return code 0 no faults
            Environment.Exit(0);
        }

        
    }
}
