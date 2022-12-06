using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{
    public partial class UpdatePreferencesScreen : Form
    {
        int rmID;
        public UpdatePreferencesScreen(int id)
        {
            InitializeComponent();
            rmID = id;
        }
    }
}
