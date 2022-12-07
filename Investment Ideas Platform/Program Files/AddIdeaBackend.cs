using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Diagnostics;
using System.Data;

namespace Relationship_manager_administration_system
{
    class AddIdeaBackend
    {
        public static void ClearBoxes(TextBox txtTitle, TextBox txtSummary, TextBox txtLongDescription, DateTimePicker dtpExpiary, ComboBox cbRiskRaiting, ComboBox cbInstruments, ComboBox cbMajorSector, ComboBox cbRegion, ComboBox cbCountry, ComboBox cbMinorSector, ComboBox cbProductType, ComboBox cbCurrency) {
            txtTitle.Clear();
            txtSummary.Clear();
            txtLongDescription.Clear();
            dtpExpiary.Value = DateTime.UtcNow;
            cbRiskRaiting.SelectedIndex = 0;
            cbInstruments.SelectedIndex = 0;
            cbMajorSector.SelectedIndex = 0;
            cbCountry.SelectedIndex = 0;
            cbRegion.SelectedIndex = 0;
            cbMinorSector.SelectedIndex = 0;
            cbProductType.SelectedIndex = 0;
            cbCurrency.SelectedIndex = 0;
        }

        public static void packageText(TextBox txtTitle, TextBox txtSummary, TextBox txtLongDescription, DateTimePicker dtpExpiary, ComboBox cbRiskRaiting, ComboBox cbInstruments, ComboBox cbMajorSector, ComboBox cbRegion, ComboBox cbCountry, ComboBox cbMinorSector, ComboBox cbProductType, ComboBox cbCurrency, int id) {
            if (checkEntries(txtTitle, txtSummary, txtLongDescription, dtpExpiary)){
                Idea idea = new Idea(txtTitle.Text.ToString(), txtSummary.Text.ToString(), txtLongDescription.Text.ToString(), cbInstruments.Text.ToString(), cbMajorSector.Text.ToString(), cbCountry.Text.ToString(), cbRegion.Text.ToString(), cbMinorSector.Text.ToString(), cbProductType.Text.ToString(), Convert.ToInt32(cbRiskRaiting.Text.ToString()), dtpExpiary.Value, cbCurrency.Text.ToString());
                addToDatabase(idea, id);
            }
            else {
                Debug.WriteLine("Data Not Correct");
            }
        }

        private static void addToDatabase(Idea idea, int id) {
            DatabaseClass.AddIdea(idea, id);
        }

        private static bool checkEntries(TextBox txtTitle, TextBox txtSummary, TextBox txtLongDescription, DateTimePicker dtpExpiary) {
            if (string.IsNullOrEmpty(txtTitle.Text.ToString()) || string.IsNullOrEmpty(txtSummary.Text.ToString()) || string.IsNullOrEmpty(txtLongDescription.Text.ToString()) || dtpExpiary.Value.Date < DateTime.UtcNow) {
                return false;
            }

            return true;
        }
    }
}
