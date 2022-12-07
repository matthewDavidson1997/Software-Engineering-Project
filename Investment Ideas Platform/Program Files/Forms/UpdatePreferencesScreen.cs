using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    public partial class UpdatePreferencesScreen : Form
    {
        // 2 class level variables
        int clientID, rmID;
        public UpdatePreferencesScreen(int clientId, int rmId)
        {
            InitializeComponent();
            // 2 class level variables populated by passed parameters
            clientID = clientId;
            rmID = rmId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // runs backend code to close the program
            ExitBackend.buttonClicked(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // runs backend code to update the clients preferences
            UpdatePreferences.packagePreferences(cbMajorSector, cbMinorSector, cbCurrency, cbCountry, cbProductType, cbRiskRaiting, clientID);
        }

        private void UpdatePreferencesScreen_Load(object sender, EventArgs e)
        {
            // runs backend code to load the default values for boxes
            UpdatePreferences.loadWindow(cbMajorSector, cbMinorSector, cbCurrency, cbCountry, cbProductType, cbRiskRaiting, lblClientReference, lblLoggedInRm, clientID, rmID);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // runs the backend code to go home
            ClientAdminBackend.goHome(rmID, this);
        }

        private void UpdatePreferencesScreen_Closing(object sender, FormClosingEventArgs e)
        {
            // runs backend code to exit the program
            ExitBackend.exitProgram();
        }
    }
}
