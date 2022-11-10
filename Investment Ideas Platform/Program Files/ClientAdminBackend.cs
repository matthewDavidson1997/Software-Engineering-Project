using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Relationship_manager_administration_system
{

	public class ClientAdminBackend
	{
		public static void clientAdmin_Load(DataGridView dgvClients, TextBox txtClient, TextBox txtEmail, TextBox txtContactFirst, TextBox txtContactLast, TextBox txtContactNumber, Label lblClientReference, int rmId, Label lblLoggedInRM) {
			dgvClients.Rows.Clear();
			ClearClick(txtClient, txtEmail, txtContactFirst, txtContactLast, txtContactNumber, lblClientReference);
			getdatafromDB(dgvClients, rmId);
			lblLoggedInRM.Text = $"Logged In RM ID: {rmId}";
		}
		public static void ClearClick(TextBox txtClient, TextBox txtEmail, TextBox txtContactFirst, TextBox txtContactLast, TextBox txtContactNumber, Label lblClientReference)
		{
			txtClient.Clear();
			txtEmail.Clear();
			txtContactFirst.Clear();
			txtContactLast.Clear();
			txtContactNumber.Clear();
			lblClientReference.Text = "Referecing Client ";
		}

		public static void getdatafromDB(DataGridView dgvClients, int rmid)
		{

			DataTable clients = DatabaseClass.GetClients(rmid);

			foreach (DataRow row in clients.Rows)
			{
				dgvClients.Rows.Add(row[0], row[4], row[3], row[1], row[2], row[5]);
			}

		}

		public static void FillTextBoxes(DataGridView dgvClients, TextBox txtClient, TextBox txtEmail, TextBox txtContactFirst, TextBox txtContactLast, TextBox txtContactNumber, Label lblClientReference)
		{
			int index = dgvClients.CurrentRow.Index;

			lblClientReference.Text = "Referencing Client: " + dgvClients.Rows[index].Cells[0].Value.ToString();
			txtClient.Text = dgvClients.Rows[index].Cells[1].Value.ToString();
			txtEmail.Text = dgvClients.Rows[index].Cells[2].Value.ToString();
			txtContactFirst.Text = dgvClients.Rows[index].Cells[3].Value.ToString();
			txtContactLast.Text = dgvClients.Rows[index].Cells[4].Value.ToString();
			txtContactNumber.Text = dgvClients.Rows[index].Cells[5].Value.ToString();

		}

		public static void UpdateClientInformation(TextBox txtClient, TextBox txtEmail, TextBox txtContactName, TextBox txtContactNumber, Label lblClientReference) {
			string client = txtClient.Text.ToString();
			string email = txtEmail.Text.ToString();
			string contactName = txtContactName.Text.ToString();
			string contactNumber = txtContactNumber.Text.ToString();
			string clientReference = lblClientReference.Text.ToString();

			DatabaseClass.UpdateClientData(clientReference, client, email, contactNumber);


		}
	}
}
