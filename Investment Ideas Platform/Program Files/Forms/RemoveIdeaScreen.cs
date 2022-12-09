using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    public partial class RemoveIdeaScreen : Form
    {
        int rmid;
        public RemoveIdeaScreen(int id)
        {
            InitializeComponent();
            rmid = id;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RemoveIdeaBackend.populateGrid(dgvIdeas);
        }

        private void btnRemoveIdea_Click(object sender, EventArgs e)
        {
            RemoveIdeaBackend.removeIdea(dgvIdeas, lblProductTitle);
        }

        private void dgvIdeas_Mouse_Click(object sender, DataGridViewCellEventArgs e)
        {
            RemoveIdeaBackend.SelectIdea(dgvIdeas, lblProductTitle);
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            ExitBackend.buttonClicked(this);
        }

        private void BTNHome_Click(object sender, EventArgs e)
        {
            RemoveIdeaBackend.goHome(rmid, this);
        }
    }
}
