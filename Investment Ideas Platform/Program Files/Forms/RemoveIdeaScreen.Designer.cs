
namespace Relationship_manager_administration_system
{
    partial class RemoveIdeaScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvIdeas = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expiary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RiskRaiting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instruments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MajorSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinorSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.btnRemoveIdea = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.BTNHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdeas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIdeas
            // 
            this.dgvIdeas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdeas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Summary,
            this.Expiary,
            this.Description,
            this.RiskRaiting,
            this.ProductType,
            this.Instruments,
            this.Currency,
            this.MajorSector,
            this.MinorSector,
            this.Region});
            this.dgvIdeas.Location = new System.Drawing.Point(-2, 33);
            this.dgvIdeas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvIdeas.Name = "dgvIdeas";
            this.dgvIdeas.RowHeadersWidth = 51;
            this.dgvIdeas.RowTemplate.Height = 29;
            this.dgvIdeas.Size = new System.Drawing.Size(742, 141);
            this.dgvIdeas.TabIndex = 0;
            this.dgvIdeas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIdeas_Mouse_Click);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // Summary
            // 
            this.Summary.HeaderText = "Summary";
            this.Summary.MinimumWidth = 6;
            this.Summary.Name = "Summary";
            this.Summary.Width = 125;
            // 
            // Expiary
            // 
            this.Expiary.HeaderText = "Expiary";
            this.Expiary.MinimumWidth = 6;
            this.Expiary.Name = "Expiary";
            this.Expiary.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // RiskRaiting
            // 
            this.RiskRaiting.HeaderText = "Risk Raiting";
            this.RiskRaiting.MinimumWidth = 6;
            this.RiskRaiting.Name = "RiskRaiting";
            this.RiskRaiting.Width = 125;
            // 
            // ProductType
            // 
            this.ProductType.HeaderText = "Product Type";
            this.ProductType.MinimumWidth = 6;
            this.ProductType.Name = "ProductType";
            this.ProductType.Width = 125;
            // 
            // Instruments
            // 
            this.Instruments.HeaderText = "Instruments";
            this.Instruments.MinimumWidth = 6;
            this.Instruments.Name = "Instruments";
            this.Instruments.Width = 125;
            // 
            // Currency
            // 
            this.Currency.HeaderText = "Currency";
            this.Currency.MinimumWidth = 6;
            this.Currency.Name = "Currency";
            this.Currency.Width = 125;
            // 
            // MajorSector
            // 
            this.MajorSector.HeaderText = "Major Sector";
            this.MajorSector.MinimumWidth = 6;
            this.MajorSector.Name = "MajorSector";
            this.MajorSector.Width = 125;
            // 
            // MinorSector
            // 
            this.MinorSector.HeaderText = "Minor Sector";
            this.MinorSector.MinimumWidth = 6;
            this.MinorSector.Name = "MinorSector";
            this.MinorSector.Width = 125;
            // 
            // Region
            // 
            this.Region.HeaderText = "Country";
            this.Region.MinimumWidth = 6;
            this.Region.Name = "Region";
            this.Region.Width = 125;
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Location = new System.Drawing.Point(11, 179);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(0, 15);
            this.lblProductTitle.TabIndex = 1;
            // 
            // btnRemoveIdea
            // 
            this.btnRemoveIdea.Location = new System.Drawing.Point(324, 277);
            this.btnRemoveIdea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveIdea.Name = "btnRemoveIdea";
            this.btnRemoveIdea.Size = new System.Drawing.Size(89, 37);
            this.btnRemoveIdea.TabIndex = 3;
            this.btnRemoveIdea.Text = "Remove Idea";
            this.btnRemoveIdea.UseVisualStyleBackColor = true;
            this.btnRemoveIdea.Click += new System.EventHandler(this.btnRemoveIdea_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.Location = new System.Drawing.Point(12, 277);
            this.BTNExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(89, 37);
            this.BTNExit.TabIndex = 4;
            this.BTNExit.Text = "Exit";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // BTNHome
            // 
            this.BTNHome.Location = new System.Drawing.Point(637, 274);
            this.BTNHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNHome.Name = "BTNHome";
            this.BTNHome.Size = new System.Drawing.Size(89, 37);
            this.BTNHome.TabIndex = 5;
            this.BTNHome.Text = "Home";
            this.BTNHome.UseVisualStyleBackColor = true;
            this.BTNHome.Click += new System.EventHandler(this.BTNHome_Click);
            // 
            // RemoveIdeaScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 322);
            this.Controls.Add(this.BTNHome);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.btnRemoveIdea);
            this.Controls.Add(this.lblProductTitle);
            this.Controls.Add(this.dgvIdeas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RemoveIdeaScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdeas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIdeas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expiary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn RiskRaiting;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instruments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn MajorSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinorSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.Button btnRemoveIdea;
        private System.Windows.Forms.Button BTNExit;
        private System.Windows.Forms.Button BTNHome;
    }
}

