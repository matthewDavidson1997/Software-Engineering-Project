using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    public partial class Form2 : Form
    {
        User user;

        public Form2(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // runs code to start exit process
            ExitBackend.buttonClicked(this);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // runs the backend code to go home
            ClientAdminBackend.goHome(user.id, this);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            lblRmId.Text = $"RM ID: {user.id}";
            DataTable ideas = new DataTable();
            ideas = DatabaseClass.getShortIdea();
            foreach (DataRow row in ideas.Rows) {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3]);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            lblClientId.Text = $"Client ID: {dataGridView1.Rows[index].Cells[3].Value.ToString()}";
        }


    }

}
