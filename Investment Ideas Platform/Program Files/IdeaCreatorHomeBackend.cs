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

        public static void ShowAddIdea(Form passedForm, int id) {
            AddIdeaScreen addIdeaScreen = new AddIdeaScreen(id);
            addIdeaScreen.Show();
            passedForm.Close();
        }

        public static void GoToShowMyIdeas(Form passedForm, int id) {
            ShowMyIdeasScreen showMyIdeasScreen = new ShowMyIdeasScreen(id);
            showMyIdeasScreen.Show();
            passedForm.Close();
        }

    }
}
