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
        private static User user;
        public IdeaCreatorHome(User passedUser)
        {
            InitializeComponent();
            user = passedUser;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitBackend.buttonClicked(this);
        }

        private void IdeaCreatorHome_Load(object sender, EventArgs e)
        {
            IdeaCreatorHomeBackend.IdeaCreatorHome_Load(lblIdeaCreatorLoggedIn, user.id);
        }

        private void btnMyIdeas_Click(object sender, EventArgs e)
        {
            IdeaCreatorHomeBackend.GoToShowMyIdeas(this, user.id);
        }

        private void btnNewIdeas_Click(object sender, EventArgs e)
        {
            IdeaCreatorHomeBackend.ShowAddIdea(this, user.id);
        }
    }
}
