﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Relationship_manager_administration_system
{
    class DatabaseClass
    {
        private static SqlConnection connection = new SqlConnection("Server=tcp:rmas-server.database.windows.net,1433;Initial Catalog=RelationshipManagerAdministrationSystemDB;Persist Security Info=False;User ID=FreddieFaulkner;Password=Goonerfred03;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public static DataTable GetPotentialUser(string username) {
            DataTable potentialUser = new DataTable();

            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT Email, [Password] FROM [dbo].[tblRelationshipManagers] WHERE Email = '" + username + "'", connection);
            adapter.Fill(potentialUser);
            connection.Close();

            Debug.WriteLine("getPotentialUser ran");

            return potentialUser;
        }

        public static DataTable GetClients() {
            DataTable clients = new DataTable();

            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT ClientID, FirstName, LastName, Email, Company, Phone FROM[dbo].[tblClients]", connection);
            adapter.Fill(clients);
            connection.Close();

            return clients;
        }
    }
}