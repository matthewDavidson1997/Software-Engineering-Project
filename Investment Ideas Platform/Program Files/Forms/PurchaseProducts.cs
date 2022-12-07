using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    public partial class PurchaseProducts : Form
    {
        int rmid;
        public PurchaseProducts(int id)
        {
            InitializeComponent();
            rmid = id;
        }

        private void btnPurchaseIdea_Click(object sender, EventArgs e)
        {
            PurchaseProductBackend.purchaseProduct(dgvIdeas, label1, lblClientReference);
        }

        private void PurchaseProducts_Load(object sender, EventArgs e)
        {
            PurchaseProductBackend.purchaseProductsLoad(rmid, dgvClients, lblLoggedInRM, dgvIdeas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitBackend.buttonClicked(this);
        }

        private void dgvClients_Mouse_Click(object sender, DataGridViewCellEventArgs e)
        {
            PurchaseProductBackend.showClientReference(lblClientReference, dgvClients, dgvIdeas);
        }

        private void btnViewIdeas_Click(object sender, EventArgs e)
        {
            PurchaseProductBackend.viewIdeas(lblClientReference, dgvIdeas);
        }

        private void dgvIdeas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PurchaseProductBackend.showProductReference(label1, dgvIdeas);
        }

        private void PurchaseProducts_Closing(object sender, FormClosingEventArgs e)
        {
            ExitBackend.exitProgram();
        }
    }
}
