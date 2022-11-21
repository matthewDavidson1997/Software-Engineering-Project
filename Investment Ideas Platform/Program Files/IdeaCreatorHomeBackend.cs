using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    class IdeaCreatorHomeBackend : Form
    {
        public static void IdeaCreatorHome_Load(Label lblIdeaCreatorLoggedIn, int id) {
            lblIdeaCreatorLoggedIn.Text = $"Idea Creator: {id}";
        }
    }
}
