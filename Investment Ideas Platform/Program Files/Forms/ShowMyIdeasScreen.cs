using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    public partial class ShowMyIdeasScreen : Form
    {
        int ideaCreatorID;
        public ShowMyIdeasScreen(int id)
        {
            InitializeComponent();
            ideaCreatorID = id;
        }

        private void ShowMyIdeasScreen_Load(object sender, EventArgs e)
        {
            ShowMyIdeasBackend.loadTable(dataGridView1, ideaCreatorID, lblIdeaCreatorID);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitBackend.buttonClicked(this);
        }

        private void ShowMyIdeasScreen_Closing(object sender, FormClosingEventArgs e)
        {
            ExitBackend.exitProgram();
        }
    }
}
