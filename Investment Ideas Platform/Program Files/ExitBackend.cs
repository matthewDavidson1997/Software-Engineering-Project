using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    class ExitBackend
    {
        private static Form form;
        public static void buttonClicked(Form passedForm) {
            form = passedForm;
            form.Enabled = false;
            ExitPopUp exitPopUp = new ExitPopUp(form);
            exitPopUp.Show();
        }
        public static void exitProgram() {
            // exits program with return code 0 no faults
            Environment.Exit(0);
        }

        public static void cancelExit(Form form, ExitPopUp exitPopUp) {
            // used to reinable original form is cancell button is clicked
            form.Enabled = true;
            // closes this form
            exitPopUp.Close();
        }
    }
}
