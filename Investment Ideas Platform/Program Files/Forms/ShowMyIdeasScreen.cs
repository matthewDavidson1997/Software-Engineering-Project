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
        // class level variable
        int ideaCreatorID;
        public ShowMyIdeasScreen(int id)
        {
            InitializeComponent();
            // class level variable populated by parameter
            ideaCreatorID = id;
        }

        private void ShowMyIdeasScreen_Load(object sender, EventArgs e)
        {
            // runs backend code to load datagrid view with ideas
            ShowMyIdeasBackend.loadTable(dataGridView1, ideaCreatorID, lblIdeaCreatorID);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // runs backend code to start exit process
            ExitBackend.buttonClicked(this);
        }

        private void ShowMyIdeasScreen_Closing(object sender, FormClosingEventArgs e)
        {
            // runs backend code to start exit process
            ExitBackend.exitProgram();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // runs backend home to get back to home screen
            ShowMyIdeasBackend.goHome(ideaCreatorID, this);
        }
    }
}
