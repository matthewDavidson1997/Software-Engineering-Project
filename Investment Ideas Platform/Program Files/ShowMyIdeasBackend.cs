using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    class ShowMyIdeasBackend
    {
        public static void loadTable(DataGridView ideasTable, int id, Label lblIdeaCreatorID) {
            lblIdeaCreatorID.Text = $"Idea Creator: {id}";

            ideasTable.Rows.Clear();

            DataTable ideas = new DataTable();
            ideas = DatabaseClass.GetMyIdeas(id);
            foreach (DataRow row in ideas.Rows) {
                ideasTable.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11]);
            }

        }

        public static void goHome(int icID, Form passedForm) {
            DataTable ic = new DataTable();
            ic = DatabaseClass.getIC(icID);
            User user = new User(icID, ic.Rows[0][1].ToString(), ic.Rows[0][2].ToString(), "Idea Creator");
            IdeaCreatorHome ideaCreatorHome = new IdeaCreatorHome(user);
            ideaCreatorHome.Show();
            passedForm.Dispose();
            passedForm.Hide();
        }
    }
}
