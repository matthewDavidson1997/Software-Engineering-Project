using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    class RemoveIdeaBackend
    {
        public static void populateGrid(DataGridView dgvIdeas) {
            dgvIdeas.Rows.Clear();

            DataTable ideas = new DataTable();
            ideas = DatabaseClass.getIdeas();

            foreach (DataRow row in ideas.Rows) {
                dgvIdeas.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11]);
            }
        }

        public static void SelectIdea(DataGridView dgvIdea, Label lblIdeaTitle){
            int ideaRow = dgvIdea.CurrentRow.Index;
            lblIdeaTitle.Text = dgvIdea.Rows[ideaRow].Cells[0].Value.ToString(); ;
        }

        public static void removeIdea(DataGridView dgvIdeas, Label lblIdeaTitle)
        {
            if (!(lblIdeaTitle.Text.ToString() == ""))
            {
                DatabaseClass.removeIdea(lblIdeaTitle.Text.ToString());
                RemoveIdeaBackend.populateGrid(dgvIdeas);
                lblIdeaTitle.Text = "";
            }
        }
        public static void goHome(int rmID, Form passedForm)
        {
            DataTable rm = new DataTable();
            rm = DatabaseClass.getIC(rmID);
            User user = new User(rmID, rm.Rows[0][1].ToString(), rm.Rows[0][2].ToString(), "Relationship Mnager");
            RmHomeScreen rmHomeScreen = new RmHomeScreen(user);
            rmHomeScreen.Show();
            passedForm.Dispose();
            passedForm.Hide();
        }
    }
}
