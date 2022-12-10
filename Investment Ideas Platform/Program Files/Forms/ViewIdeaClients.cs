using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    public partial class viewIdeaClients : Form
    {
        User user;

        public viewIdeaClients(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // runs code to start exit process
            ExitBackend.buttonClicked(this);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // runs the backend code to go home
            ClientAdminBackend.goHome(user.id, this);
        }

        private void viewIdeaClients_Load(object sender, EventArgs e)
        {
            ideasGrid.Rows.Clear();
            lblRmId.Text = $"RM ID: {user.id}";
            DataTable ideas = new DataTable();
            ideas = DatabaseClass.getShortIdea();
            foreach (DataRow row in ideas.Rows) {
                ideasGrid.Rows.Add(row[0], row[1], row[2], row[3]);

            }
        }

        private void ideasGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = ideasGrid.CurrentRow.Index;
            lblClientId.Text = $"Client ID: {ideasGrid.Rows[index].Cells[3].Value.ToString()}";
        }


    }

}
