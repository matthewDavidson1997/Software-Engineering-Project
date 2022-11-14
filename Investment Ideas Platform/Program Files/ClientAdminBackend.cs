using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.Diagnostics;

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

		public static void UpdateClientInformation(TextBox txtClient, TextBox txtEmail, TextBox txtContactFirst, TextBox txtContactLast, TextBox txtContactNumber, Label lblClientReference) {
			string client = txtClient.Text.ToString();
			string email = txtEmail.Text.ToString();
			string contactFirst = txtContactFirst.Text.ToString();
			string contactLast = txtContactLast.Text.ToString();
			string contactNumber = txtContactNumber.Text.ToString();
			if (ClientAdminBackend.containsInt(lblClientReference))
			{
				int number = ClientAdminBackend.FormatClientID(lblClientReference);
				DatabaseClass.UpdateClientData(number, client, email, contactFirst, contactLast, contactNumber);
			}
			else {
				Debug.WriteLine("Client was not selected");
			}
		}

		public static void DeleteClient(Label lblClientReference) {
			if (ClientAdminBackend.containsInt(lblClientReference)) {
				int clientReference = ClientAdminBackend.FormatClientID(lblClientReference);
				DatabaseClass.DeleteClient(clientReference);
			} else {
				Debug.WriteLine("Cleint was not selected");
            }
		}

		private static int FormatClientID(Label lblClientReference) {
			string clientReference = lblClientReference.Text.ToString();
			List<char> idNumberList = new List<char>();
			char[] clientReferenceArray = clientReference.ToCharArray();

			foreach (char c in clientReference)
			{
				if (char.IsDigit(c))
				{
					idNumberList.Add(c);
				}

			}

			string number = string.Join(",", idNumberList);
			return Convert.ToInt32(number);
		}

		private static bool containsInt(Label lblClientRefernce) {
			foreach(char c in lblClientRefernce.Text.ToString())
            {
				if (char.IsDigit(c)) {
					return true;
				}
			}
			return false;
		}
	}
}
