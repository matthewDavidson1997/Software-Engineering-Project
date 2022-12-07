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
        int clientID, rmID;
        public UpdatePreferencesScreen(int clientId, int rmId)
        {
            InitializeComponent();
            clientID = clientId;
            rmID = rmId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitBackend.buttonClicked(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePreferences.packagePreferences(cbMajorSector, cbMinorSector, cbCurrency, cbCountry, cbProductType, cbRiskRaiting, clientID);
        }

        private void UpdatePreferencesScreen_Load(object sender, EventArgs e)
        {
            UpdatePreferences.loadWindow(cbMajorSector, cbMinorSector, cbCurrency, cbCountry, cbProductType, cbRiskRaiting, lblClientReference, lblLoggedInRm, clientID, rmID);
        }

        private void UpdatePreferencesScreen_Closing(object sender, FormClosingEventArgs e)
        {
            ExitBackend.exitProgram();
        }
    }
}
