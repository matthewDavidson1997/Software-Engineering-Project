using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.Diagnostics;
// USED FOR VALIDATING EMAIL ADDRESS https://learn.microsoft.com/en-us/dotnet/api/system.net.mail.mailaddress?view=netcore-3.1
using System.Net.Mail;

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
			string clientReferenceStr = lblClientReference.Text.ToString();

			if (ClientAdminBackend.containsInt(clientReferenceStr))
			{
				int number = ClientAdminBackend.FormatClientID(lblClientReference);
				DatabaseClass.UpdateClientData(number, client, email, contactFirst, contactLast, contactNumber);
			}
			else {
				Debug.WriteLine("Client was not selected");
			}
		}

		public static void DeleteClient(Label lblClientReference) {
			string clientReferenceStr = lblClientReference.Text.ToString();
			if (ClientAdminBackend.containsInt(clientReferenceStr)) {
				int clientReference = ClientAdminBackend.FormatClientID(lblClientReference);
				DatabaseClass.DeleteClient(clientReference);
			} else {
				Debug.WriteLine("Cleint was not selected");
			}
		}

		public static int FormatClientID(Label lblClientReference) {
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

		public static bool containsInt(string passedString) {
			foreach (char c in passedString)
			{
				if (char.IsDigit(c)) {
					return true;
				}
			}
			return false;
		}

		private static bool isNumerical(string passedString) {
			foreach (char c in passedString) {
				if (!(char.IsDigit(c))) {
					return false;
				}
			}
			return true;
		}

		public static void CreateClient(TextBox txtClient, TextBox txtEmail, TextBox txtContactFirst, TextBox txtContactLast, TextBox txtContactNumber, int rmID) {
			string client = txtClient.Text.ToString();
			string email = txtEmail.Text.ToString();
			string contactFirstName = txtContactFirst.Text.ToString();
			string contactLastName = txtContactLast.Text.ToString();
			string contactNumber = txtContactNumber.Text.ToString();

			if (checkCredentials(client, email, contactFirstName, contactLastName, contactNumber))
			{
				DatabaseClass.createClient(client, email, contactFirstName, contactLastName, contactNumber, rmID);
			}
			else {
				Debug.WriteLine("Client not made invalid info provided");
			}


		}

		private static bool isBlank(string client, string email, string contactFirstName, string contactLastName, string contactNumber) {
			string[] newClientDetials = { client, email, contactFirstName, contactLastName, contactNumber };

			foreach (string detail in newClientDetials) {
				if (String.IsNullOrWhiteSpace(detail)) {
					Debug.WriteLine("ib true");
					return true;
				}
			}
			Debug.WriteLine("ib false");
			return false;
		}

		private static bool checkContactNumber(string contactNumber) {
			if (contactNumber.Contains(" ") || contactNumber.Length != 11 || !isNumerical(contactNumber)) {
				Debug.WriteLine("ccn false");
				return false;
			}
			Debug.WriteLine("ccn true");
			return true;
		}
		// USED FOR VALIDATING EMAIL ADDRESS https://learn.microsoft.com/en-us/dotnet/api/system.net.mail.mailaddress?view=netcore-3.1
		private static bool isEmailValid(string email) {
			try
			{
				MailAddress mailAddress = new MailAddress(email);
				Debug.WriteLine("iev true");
				return true;
			}
			catch {
				Debug.WriteLine("iev false");
				return false;
			}

		}

		private static bool doesAccountAlreadyExist(string email) {
			DataTable emails = DatabaseClass.getClientEmails();
			foreach (DataRow row in emails.Rows) {
				if (row[0].Equals(email)) {
					Debug.WriteLine("daae true");
					return true;
				}
			}
			Debug.WriteLine("daae false");
			return false;
		}

		private static bool checkCredentials(string client, string email, string contactFirstName, string contactLastName, string contactNumber) {
			if ((!isBlank(client, email, contactFirstName, contactLastName, contactNumber)) && (!containsInt(contactFirstName)) && (!containsInt(contactLastName)) && (isEmailValid(email)) && (checkContactNumber(contactNumber)) && (!doesAccountAlreadyExist(email))) {
				return true;
			}

			return false;
		}

		public static void updatePreferences(Form passedForm, Label lblClientReference, Label lblLoggedInRM) {
			if (ClientAdminBackend.containsInt(lblClientReference.Text.ToString()) && ClientAdminBackend.containsInt(lblLoggedInRM.Text.ToString()))
			{
				int clientId = ClientAdminBackend.FormatClientID(lblClientReference);
				int rmID = ClientAdminBackend.FormatClientID(lblLoggedInRM);
				UpdatePreferencesScreen updatePreferencesScreen = new UpdatePreferencesScreen(clientId, rmID);
				updatePreferencesScreen.Show();
				passedForm.Hide();
			}
			else {
				Debug.WriteLine("Client ID not selected");
			}

		}
	}
}
