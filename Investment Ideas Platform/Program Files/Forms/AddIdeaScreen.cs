using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    public partial class AddIdeaScreen : Form
    {
        int ideaCreatorID;
        public AddIdeaScreen(int id)
        {
            InitializeComponent();
            ideaCreatorID = id;
        }

        private void AddIdeaScreen_Load(object sender, EventArgs e)
        {
            lblIdeaCreatorID.Text = $"Idea Creator: {ideaCreatorID}";
            AddIdeaBackend.ClearBoxes(txtTitle, txtSummary, txtLongDescription, dtpExpirayDate, cbRiskRaiting, cbInstruments, cbMajorSector, cbRegion, cbCountry, cbMinorSector, cbProductType, cbCurrency);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitBackend.buttonClicked(this);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AddIdeaBackend.ClearBoxes(txtTitle, txtSummary, txtLongDescription, dtpExpirayDate, cbRiskRaiting, cbInstruments, cbMajorSector, cbRegion, cbCountry, cbMinorSector, cbProductType, cbCurrency);
        }

        private void btnAddIdea_Click(object sender, EventArgs e)
        {
            AddIdeaBackend.packageText(txtTitle, txtSummary, txtLongDescription, dtpExpirayDate, cbRiskRaiting, cbInstruments, cbMajorSector, cbRegion, cbCountry, cbMinorSector, cbProductType, cbCurrency, ideaCreatorID);
        }

        private void AddIdeaScreen_Closing(object sender, FormClosingEventArgs e)
        {
            ExitBackend.exitProgram();
        }
    }
}
