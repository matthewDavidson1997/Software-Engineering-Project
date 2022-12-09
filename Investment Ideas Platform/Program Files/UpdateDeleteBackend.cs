using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Relationship_manager_administration_system
{
    class UpdateDeleteBackend
    {
        public static void getIdeas(DataGridView dgvIdeas, int id) {
            dgvIdeas.Rows.Clear();
            DataTable ideas = new DataTable();
            ideas = DatabaseClass.GetMyIdeas(id);

            foreach(DataRow row in ideas.Rows) {
                dgvIdeas.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11]);
            }
        }

        public static void selectIdea(DataGridView dgvIdeas, Label lblIdeaTitle, TextBox txtTitle, TextBox txtSummary, TextBox txtDescription, ComboBox cbInstruments, ComboBox cbCountry, ComboBox cbRegion, ComboBox cbMajorSector, ComboBox cbMinorSector, ComboBox cbProductType, ComboBox cbRiskRaiting, DateTimePicker dtpExpiary, ComboBox cbCurrency) {
            int index = dgvIdeas.CurrentCell.RowIndex;
            lblIdeaTitle.Text = dgvIdeas.Rows[index].Cells[0].Value.ToString();
            txtTitle.Text = dgvIdeas.Rows[index].Cells[0].Value.ToString();
            txtSummary.Text = dgvIdeas.Rows[index].Cells[1].Value.ToString();
            txtDescription.Text = dgvIdeas.Rows[index].Cells[3].Value.ToString();
            cbInstruments.Text = dgvIdeas.Rows[index].Cells[6].Value.ToString();
            cbCountry.Text = dgvIdeas.Rows[index].Cells[11].Value.ToString();
            cbRegion.Text = dgvIdeas.Rows[index].Cells[10].Value.ToString();
            cbMajorSector.Text = dgvIdeas.Rows[index].Cells[8].Value.ToString();
            cbMinorSector.Text = dgvIdeas.Rows[index].Cells[9].Value.ToString();
            cbProductType.Text = dgvIdeas.Rows[index].Cells[5].Value.ToString();
            cbRiskRaiting.Text = dgvIdeas.Rows[index].Cells[4].Value.ToString();
            dtpExpiary.Value = (DateTime) dgvIdeas.Rows[index].Cells[2].Value;
            cbCurrency.Text = dgvIdeas.Rows[index].Cells[7].Value.ToString();
        }

        public static void DeleteIdea(Label lblIdeaTitle, DataGridView dgvIdeas, int id) {
            if (lblIdeaTitle.Text.ToString() != "") {
                DatabaseClass.deleteIdea(lblIdeaTitle.Text.ToString());
                UpdateDeleteBackend.getIdeas(dgvIdeas, id);
            }
        }

        public static void UpdateIdea(Label lblIdeaTitle, DataGridView dgvIdeas, int id, TextBox txtTitle, TextBox txtSummary, TextBox txtDescription, ComboBox cbInstruments, ComboBox cbCountry, ComboBox cbRegion, ComboBox cbMajorSector, ComboBox cbMinorSector, ComboBox cbProductType, ComboBox cbRiskRaiting, DateTimePicker dtpExpiary, ComboBox cbCurrency)
        {
            if (lblIdeaTitle.Text.ToString() != "")
            {
                Idea updatedIdea = new Idea(txtTitle.Text.ToString(), txtSummary.Text.ToString(), txtDescription.Text.ToString(), cbInstruments.Text.ToString(), cbMajorSector.Text.ToString(), cbCountry.Text.ToString(), cbRegion.Text.ToString(), cbMinorSector.Text.ToString(), cbProductType.Text.ToString(), Convert.ToInt32(cbRiskRaiting.Text.ToString()), dtpExpiary.Value, cbCurrency.Text.ToString()); ;
                DatabaseClass.updateIdea(id, lblIdeaTitle.Text.ToString(), updatedIdea);
                UpdateDeleteBackend.getIdeas(dgvIdeas, id);
            }
        }
    }
}
