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
        // class level varaible needed to store idea creator id
        int ideaCreatorID;
        public AddIdeaScreen(int id)
        {
            InitializeComponent();
            //populates class level variable with the id passed by the backend
            ideaCreatorID = id;
        }

        private void AddIdeaScreen_Load(object sender, EventArgs e)
        {
            // populates the idea creator label with its id
            lblIdeaCreatorID.Text = $"Idea Creator: {ideaCreatorID}";
            // runs the backend code to clear the boxes
            AddIdeaBackend.ClearBoxes(txtTitle, txtSummary, txtLongDescription, dtpExpirayDate, cbRiskRaiting, cbInstruments, cbMajorSector, cbRegion, cbCountry, cbMinorSector, cbProductType, cbCurrency);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // runs backend code the start the closing process
            ExitBackend.buttonClicked(this);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // runs the backend code to clear forms textboxes
            AddIdeaBackend.ClearBoxes(txtTitle, txtSummary, txtLongDescription, dtpExpirayDate, cbRiskRaiting, cbInstruments, cbMajorSector, cbRegion, cbCountry, cbMinorSector, cbProductType, cbCurrency);
        }

        private void btnAddIdea_Click(object sender, EventArgs e)
        {
            // runs the code to package the idea then send it to the backend to be added to the database
            AddIdeaBackend.packageText(txtTitle, txtSummary, txtLongDescription, dtpExpirayDate, cbRiskRaiting, cbInstruments, cbMajorSector, cbRegion, cbCountry, cbMinorSector, cbProductType, cbCurrency, ideaCreatorID);
        }

        private void AddIdeaScreen_Closing(object sender, FormClosingEventArgs e)
        {
            // runs the exit code to close the program
            ExitBackend.exitProgram();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // runs backend code for home screen
            ShowMyIdeasBackend.goHome(ideaCreatorID, this);
        }
    }
}
