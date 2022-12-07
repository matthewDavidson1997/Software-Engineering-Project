using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

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
           //  exits program
           Application.Exit();
         }

        public static void cancelExit(Form passedForm, ExitPopUp exitPopUp) {
            // used to reinable original form is cancell button is clicked
            passedForm.Enabled = true;
            // closes this form
            exitPopUp.Close();
        }

        public static void exitWindowClosedUnexpectedly(Form passedForm) {
            passedForm.Enabled = true;
        }
    }
}
