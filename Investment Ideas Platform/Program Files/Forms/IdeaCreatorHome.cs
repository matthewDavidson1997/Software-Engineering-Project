using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    public partial class IdeaCreatorHome : Form
    {
        // class level variable to hold user
        private static User user;
        public IdeaCreatorHome(User passedUser)
        {
            InitializeComponent();
            // populates class level variable with the passed parameter
            user = passedUser;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // runs backend code to start exit process
            ExitBackend.buttonClicked(this);
        }

        private void IdeaCreatorHome_Load(object sender, EventArgs e)
        {
            // runs backend code to save who is logged in
            IdeaCreatorHomeBackend.IdeaCreatorHome_Load(lblIdeaCreatorLoggedIn, user.id);
        }

        private void btnMyIdeas_Click(object sender, EventArgs e)
        {
            // runs backend code to go to show my ideas
            IdeaCreatorHomeBackend.GoToShowMyIdeas(this, user.id);
        }

        private void btnNewIdeas_Click(object sender, EventArgs e)
        {
            // runs backend code to show add idea
            IdeaCreatorHomeBackend.ShowAddIdea(this, user.id);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // runs the backend code to logout of the system
            IdeaCreatorHomeBackend.logOut(this);
        }
    }
}
