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
    public partial class Form1 : Form
    {
        int icid;
        public Form1(int id)
        {
            InitializeComponent();
            icid = id;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UpdateDeleteBackend.DeleteIdea(lblIdeaTitle, dgvIdeas, icid);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDeleteBackend.UpdateIdea(lblIdeaTitle, dgvIdeas, icid, txtTitle, txtSummary, txtDescription, cbInstruments, cbCountry, cbRegion, cbMajorSector, cbMinorSector, cbProductType, cbRiskRaiting, dtpExpiary, cbCurrency);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDeleteBackend.getIdeas(dgvIdeas, icid);
        }

        private void dgvIdeas_Mouse_Click(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteBackend.selectIdea(dgvIdeas, lblIdeaTitle, txtTitle, txtSummary, txtDescription, cbInstruments, cbCountry, cbRegion, cbMajorSector, cbMinorSector, cbProductType, cbRiskRaiting, dtpExpiary, cbCurrency);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitBackend.buttonClicked(this);
        }
    }
}
