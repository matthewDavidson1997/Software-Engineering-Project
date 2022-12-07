using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace Relationship_manager_administration_system
{
    class PurchaseProductBackend
    {
        public static void purchaseProductsLoad (int rmid, DataGridView dgvClients, Label lblLoggedInRM, DataGridView dgvIdeas){
            dgvClients.Rows.Clear();
            dgvIdeas.Rows.Clear();
            DataTable clients = new DataTable();
            clients = DatabaseClass.GetClients(rmid);

            foreach (DataRow row in clients.Rows) {
                dgvClients.Rows.Add(row[0], row[4], row[3], row[1], row[2], row[5]);
            }

            lblLoggedInRM.Text = $"Logged in RM: {rmid}";
        }

        public static void showClientReference(Label lblClientReference, DataGridView dgvClients, DataGridView dgvIdeas) {
            int index = dgvClients.CurrentRow.Index;

            lblClientReference.Text = $"Referencing Client: {dgvClients.Rows[index].Cells[0].Value.ToString()}";

            dgvIdeas.Rows.Clear();
        }

        public static void viewIdeas(Label lblClientReference, DataGridView dgvIdeas) {
            dgvIdeas.Rows.Clear();
            if (ClientAdminBackend.containsInt(lblClientReference.Text.ToString())) {
                int clientId = ClientAdminBackend.FormatClientID(lblClientReference);

                DataTable preferences = DatabaseClass.getPreferences(clientId);
                Preferences clientPreferences = new Preferences(preferences.Rows[0].ItemArray[3].ToString(), preferences.Rows[0].ItemArray[4].ToString(), preferences.Rows[0].ItemArray[2].ToString(), preferences.Rows[0].ItemArray[5].ToString(), preferences.Rows[0].ItemArray[1].ToString(), Convert.ToInt32(preferences.Rows[0].ItemArray[0].ToString()));

                DataTable releventIdeas = DatabaseClass.getReleventIdeas(clientPreferences);

                foreach (DataRow row in releventIdeas.Rows) {
                    dgvIdeas.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11]);
                }
            }
        }

        public static void showProductReference(Label label1, DataGridView dgvIdeas) {
            int index = dgvIdeas.CurrentRow.Index;
            string selectedProduct = dgvIdeas.Rows[index].Cells[0].Value.ToString();
            label1.Text = $"Selected Product: {selectedProduct}";
        }

        public static void purchaseProduct(DataGridView dgvIdeas, Label label1, Label lblClientReference) {
            if ((ClientAdminBackend.containsInt(lblClientReference.Text.ToString()) && (!label1.Text.ToString().Equals("")))) {
                int clientID = ClientAdminBackend.FormatClientID(lblClientReference);
                if (!(label1.Text.ToString().Equals(""))){
                    string[] productTitleArray = label1.Text.Split(':');
                    string productTitle = productTitleArray[1].Trim(' ');
                    Debug.WriteLine(productTitle);
                    DatabaseClass.purchaseProduct(productTitle, clientID);
                    PurchaseProductBackend.viewIdeas(lblClientReference, dgvIdeas);
                    label1.Text = "";
                }            
            }
        }


        

}
    }
