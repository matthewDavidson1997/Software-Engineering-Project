using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    class RMLoginBackend : Form
    {
        private static DataTable potentialUser;

        public static void rmLoginBackend(Form form, Label lblLoginFail, ComboBox cbAccountType, TextBox txtEmail, TextBox txtPassword) {

            String role = cbAccountType.Text.ToString();
            String email = txtEmail.Text.ToString();
            String password = txtPassword.Text.ToString();

            if (cbAccountType.Text == "Relationship Manager")
            {
                if (RMLoginBackend.rmLoginBackendReturn(role, email, password))
                {
                    int id = RMLoginBackend.ReturnID();
                    lblLoginFail.Visible = false;
                    User user = new User(id, email, password, role);
                    RmHomeScreen rmHomeScreen = new RmHomeScreen(user);
                    rmHomeScreen.Show();
                    form.Hide();
                }
                else
                {
                    lblLoginFail.Visible = true;
                }
            }
        }
        private static bool rmLoginBackendReturn(String role, String username, String password)
        {
            if (checkCredentials(role, username, password))
            {
                Debug.WriteLine("got to LPU");
                LoadPotentialUser(username);

                if (checkUserExists()) {
                    if (loginInfoCorrect(password))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool checkCredentials(string role, string username, string password)
        {
            Debug.WriteLine("CC RAN");

            if (isBlank(role, username, password))
            {
                return false;
            }
            else if (hasSpace(username, password))
            {
                return false;
            }

            return true;
        }

        private static bool isBlank(string role, string username, string password)
        {
            Debug.WriteLine("IB RAN");

            Debug.WriteLine(String.IsNullOrEmpty(role));

            if ((String.IsNullOrEmpty(role) || String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)))
            {
                return true;
            }

            return false;
        }

        private static bool hasSpace(string username, string password)
        {
            Debug.WriteLine("HS RAN");

            if (username.Contains(" ") || password.Contains(" "))
            {
                return true;
            }

            return false;
        }


        private static void LoadPotentialUser(string username)
        {
            Debug.WriteLine("LPU RAN");
            potentialUser = DatabaseClass.GetPotentialUser(username);
        }

        private static bool checkUserExists() {
            Debug.WriteLine("CUE RAN");

            if (potentialUser.Rows.Count == 0)
            {
                return false;
            }

            return true;
        }

        private static bool loginInfoCorrect(string password)
        {
            Debug.WriteLine("LIC RAN");
            if (checkUserExists() && password.Equals(potentialUser.Rows[0][2].ToString()))
            {
                return true;
            }

            return false;
        }

        private static int ReturnID() {
            return Convert.ToInt32(potentialUser.Rows[0][0].ToString());
        }
    }
}
