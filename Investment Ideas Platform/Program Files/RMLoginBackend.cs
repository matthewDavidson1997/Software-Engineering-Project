using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Relationship_manager_administration_system
{
    class RMLoginBackend
    {
        private static DataTable potentialUser;

        public static bool rmLoginBackend(String role, String username, String password)
        {
            if (checkCredentials(role, username, password))
            {
                Debug.WriteLine("got to LPU");
                LoadPotentialUser(role, username, password);

                if (checkUserExists()) {
                    if (loginInfoCorrect(role, username, password))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        protected static bool checkCredentials(string role, string username, string password)
        {
            Debug.WriteLine("CC RAN");

            if (isBlank(role, username, password))
            {
                return false;
            }
            else if (hasSpace(role, username, password))
            {
                return false;
            }

            return true;
        }

        protected static bool isBlank(string role, string username, string password)
        {
            Debug.WriteLine("IB RAN");

            Debug.WriteLine(String.IsNullOrEmpty(role));

            if ((String.IsNullOrEmpty(role) || String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)))
            {
                return true;
            }

            return false;
        }

        protected static bool hasSpace(string role, string username, string password)
        {
            Debug.WriteLine("HS RAN");

            if (username.Contains(" ") || password.Contains(" "))
            {
                return true;
            }

            return false;
        }


        protected static void LoadPotentialUser(string role, string username, string password)
        {
            Debug.WriteLine("LPU RAN");
            potentialUser = DatabaseClass.GetPotentialUser(username);
        }

        protected static bool checkUserExists() {
            Debug.WriteLine("CUE RAN");

            if (potentialUser.Rows.Count == 0)
            {
                return false;
            }

            return true;
        }

        protected static bool loginInfoCorrect(string role, string username, string password)
        {
            Debug.WriteLine("LIC RAN");
            if (checkUserExists() && password.Equals(potentialUser.Rows[0][1].ToString()))
            {
                return true;
            }

            return false;
        }
    }
}
