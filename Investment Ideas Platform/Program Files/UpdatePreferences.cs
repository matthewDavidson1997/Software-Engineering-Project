using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    class UpdatePreferences
    {
        public static void loadWindow(ComboBox cbMajorSector, ComboBox cbMinorSector, ComboBox cbCurrency, ComboBox cbCountry, ComboBox cbProdcutType, ComboBox cbRiskRaiting, Label lblClientReference, Label lblLoggedInRm, int clientId, int rmID) {
            cbMajorSector.SelectedIndex = 0;
            cbMinorSector.SelectedIndex = 0;
            cbCurrency.SelectedIndex = 0;
            cbCountry.SelectedIndex = 0;
            cbProdcutType.SelectedIndex = 0;
            cbRiskRaiting.SelectedIndex = 0;

            lblClientReference.Text = $"Referencing Client: {clientId}";
            lblLoggedInRm.Text = $"Logged In RM: {rmID}";

        }

        public static void packagePreferences(ComboBox cbMajorSector, ComboBox cbMinorSector, ComboBox cbCurrency, ComboBox cbCountry, ComboBox cbProductType, ComboBox cbRiskRaiting, int clientId) {
            Preferences newPreferences = new Preferences(cbMajorSector.Text.ToString(), cbMinorSector.Text.ToString(), cbCurrency.Text.ToString(), cbCountry.Text.ToString(), cbProductType.Text.ToString(), Convert.ToInt32(cbRiskRaiting.Text.ToString()));
            DatabaseClass.updatePreferences(newPreferences, clientId);
        }


    }
}
