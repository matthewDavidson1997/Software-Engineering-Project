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

        static SqlConnection connection = new SqlConnection("Data Source=rmas-server.database.windows.net;Initial Catalog=RelationshipManagerAdministrationSystemDB;User ID=FreddieFaulkner;Password=Goonerfred03;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public static bool rmLoginBackend(String role, String username, String password)
        {
            if (checkCredentials(role, username, password))
            {
                DataSet potentialUser = new DataSet();
                potentialUser = LoadPotentialUser(role, username, password);

                if (loginInfoCorrect(potentialUser, role, username, password))
                {
                    return true;
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


        protected static DataSet LoadPotentialUser(string role, string username, string password)
        {
            Debug.WriteLine("LBU RAN");

            connection.Open();
            DataSet potentialUser = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand("SELECT Email, [Password] FROM [dbo].[tblRelationshipManagers] WHERE Email = '" + username + "'", connection);
            adapter.Fill(potentialUser, "RM");

            connection.Close();

            Debug.WriteLine(potentialUser.Tables["RM"].Rows[0][0]);
            Debug.WriteLine(potentialUser.Tables["RM"].Rows[0][0]);

            return potentialUser;


        }

        protected static bool checkUserExists(DataSet potentialUser)
        {
            Debug.WriteLine("CUE RAN");

            if (potentialUser.Tables["RM"].Rows.Count == 0)
            {
                return false;
            }

            return true;
        }

        protected static bool loginInfoCorrect(DataSet potentialUser, string role, string username, string password)
        {
            Debug.WriteLine("LIC RAN");
            if (password.Equals(potentialUser.Tables["RM"].Rows[0][1].ToString()))
            {
                return true;
            }

            return false;
        }



    }
}
