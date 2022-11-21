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

        private void IdeaCreatorHome_Closing(object sender, FormClosingEventArgs e)
        {
            ExitBackend.exitProgram();
        }

        private void IdeaCreatorHome_Load(object sender, EventArgs e)
        {
            IdeaCreatorHomeBackend.IdeaCreatorHome_Load(lblIdeaCreatorLoggedIn, user.id);
        }
    }
}
