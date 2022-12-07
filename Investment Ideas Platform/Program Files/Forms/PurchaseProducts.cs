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
        // class level variable for the rm
        int rmid;
        public PurchaseProducts(int id)
        {
            InitializeComponent();
            // populates variable based on the passed parameter
            rmid = id;
        }

        private void btnPurchaseIdea_Click(object sender, EventArgs e)
        {
            // runs backend code to purchase product for client
            PurchaseProductBackend.purchaseProduct(dgvIdeas, label1, lblClientReference);
        }

        private void PurchaseProducts_Load(object sender, EventArgs e)
        {
            // runs code to load the client related to the rm
            PurchaseProductBackend.purchaseProductsLoad(rmid, dgvClients, lblLoggedInRM, dgvIdeas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // runs code to start exit process
            ExitBackend.buttonClicked(this);
        }

        private void dgvClients_Mouse_Click(object sender, DataGridViewCellEventArgs e)
        {
            // runs backend code to show what client is selected
            PurchaseProductBackend.showClientReference(lblClientReference, dgvClients, dgvIdeas);
        }

        private void btnViewIdeas_Click(object sender, EventArgs e)
        {
            // runs backend code to add ideas to datagridview based on what client is selected
            PurchaseProductBackend.viewIdeas(lblClientReference, dgvIdeas);
        }

        private void dgvIdeas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // runs backend code to show which product is selected
            PurchaseProductBackend.showProductReference(label1, dgvIdeas);
        }

        private void PurchaseProducts_Closing(object sender, FormClosingEventArgs e)
        {
            // runs backend code to exit the program
            ExitBackend.exitProgram();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // runs the backend code to go home
            ClientAdminBackend.goHome(rmid, this);
        }
    }
}
