
namespace Relationship_manager_administration_system
{
    partial class Form1
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbInstruments = new System.Windows.Forms.ComboBox();
            this.cbMinorSector = new System.Windows.Forms.ComboBox();
            this.cbMajorSector = new System.Windows.Forms.ComboBox();
            this.cbRiskRaiting = new System.Windows.Forms.ComboBox();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
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
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblIdeaTitle = new System.Windows.Forms.Label();
            this.dtpExpiary = new System.Windows.Forms.DateTimePicker();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdeas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(90, 32);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(202, 27);
            this.txtTitle.TabIndex = 0;
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(90, 65);
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(202, 27);
            this.txtSummary.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(90, 98);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(202, 69);
            this.txtDescription.TabIndex = 2;
            // 
            // cbInstruments
            // 
            this.cbInstruments.FormattingEnabled = true;
            this.cbInstruments.Location = new System.Drawing.Point(90, 173);
            this.cbInstruments.Name = "cbInstruments";
            this.cbInstruments.Size = new System.Drawing.Size(202, 28);
            this.cbInstruments.TabIndex = 3;
            // 
            // cbMinorSector
            // 
            this.cbMinorSector.FormattingEnabled = true;
            this.cbMinorSector.Location = new System.Drawing.Point(343, 66);
            this.cbMinorSector.Name = "cbMinorSector";
            this.cbMinorSector.Size = new System.Drawing.Size(202, 28);
            this.cbMinorSector.TabIndex = 4;
            // 
            // cbMajorSector
            // 
            this.cbMajorSector.FormattingEnabled = true;
            this.cbMajorSector.Location = new System.Drawing.Point(343, 32);
            this.cbMajorSector.Name = "cbMajorSector";
            this.cbMajorSector.Size = new System.Drawing.Size(202, 28);
            this.cbMajorSector.TabIndex = 5;
            // 
            // cbRiskRaiting
            // 
            this.cbRiskRaiting.FormattingEnabled = true;
            this.cbRiskRaiting.Location = new System.Drawing.Point(343, 139);
            this.cbRiskRaiting.Name = "cbRiskRaiting";
            this.cbRiskRaiting.Size = new System.Drawing.Size(202, 28);
            this.cbRiskRaiting.TabIndex = 6;
            // 
            // cbProductType
            // 
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Location = new System.Drawing.Point(343, 100);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(202, 28);
            this.cbProductType.TabIndex = 7;
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(90, 241);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(202, 28);
            this.cbRegion.TabIndex = 8;
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(90, 207);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(202, 28);
            this.cbCountry.TabIndex = 9;
            // 
            // dgvIdeas
            // 
            this.dgvIdeas.AllowUserToAddRows = false;
            this.dgvIdeas.AllowUserToDeleteRows = false;
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
            this.Region,
            this.Country});
            this.dgvIdeas.Location = new System.Drawing.Point(-2, 275);
            this.dgvIdeas.Name = "dgvIdeas";
            this.dgvIdeas.ReadOnly = true;
            this.dgvIdeas.RowHeadersWidth = 51;
            this.dgvIdeas.RowTemplate.Height = 29;
            this.dgvIdeas.Size = new System.Drawing.Size(876, 188);
            this.dgvIdeas.TabIndex = 10;
            this.dgvIdeas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIdeas_Mouse_Click);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // Summary
            // 
            this.Summary.HeaderText = "Summary";
            this.Summary.MinimumWidth = 6;
            this.Summary.Name = "Summary";
            this.Summary.ReadOnly = true;
            this.Summary.Width = 125;
            // 
            // Expiary
            // 
            this.Expiary.HeaderText = "Expiary";
            this.Expiary.MinimumWidth = 6;
            this.Expiary.Name = "Expiary";
            this.Expiary.ReadOnly = true;
            this.Expiary.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // RiskRaiting
            // 
            this.RiskRaiting.HeaderText = "Risk Raiting";
            this.RiskRaiting.MinimumWidth = 6;
            this.RiskRaiting.Name = "RiskRaiting";
            this.RiskRaiting.ReadOnly = true;
            this.RiskRaiting.Width = 125;
            // 
            // ProductType
            // 
            this.ProductType.HeaderText = "ProductType";
            this.ProductType.MinimumWidth = 6;
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            this.ProductType.Width = 125;
            // 
            // Instruments
            // 
            this.Instruments.HeaderText = "Insturments";
            this.Instruments.MinimumWidth = 6;
            this.Instruments.Name = "Instruments";
            this.Instruments.ReadOnly = true;
            this.Instruments.Width = 125;
            // 
            // Currency
            // 
            this.Currency.HeaderText = "Currency";
            this.Currency.MinimumWidth = 6;
            this.Currency.Name = "Currency";
            this.Currency.ReadOnly = true;
            this.Currency.Width = 125;
            // 
            // MajorSector
            // 
            this.MajorSector.HeaderText = "MajorSector";
            this.MajorSector.MinimumWidth = 6;
            this.MajorSector.Name = "MajorSector";
            this.MajorSector.ReadOnly = true;
            this.MajorSector.Width = 125;
            // 
            // MinorSector
            // 
            this.MinorSector.HeaderText = "MinorSector";
            this.MinorSector.MinimumWidth = 6;
            this.MinorSector.Name = "MinorSector";
            this.MinorSector.ReadOnly = true;
            this.MinorSector.Width = 125;
            // 
            // Region
            // 
            this.Region.HeaderText = "Region";
            this.Region.MinimumWidth = 6;
            this.Region.Name = "Region";
            this.Region.ReadOnly = true;
            this.Region.Width = 125;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Width = 125;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(766, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 38);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(766, 75);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 38);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblIdeaTitle
            // 
            this.lblIdeaTitle.AutoSize = true;
            this.lblIdeaTitle.Location = new System.Drawing.Point(766, 249);
            this.lblIdeaTitle.Name = "lblIdeaTitle";
            this.lblIdeaTitle.Size = new System.Drawing.Size(0, 20);
            this.lblIdeaTitle.TabIndex = 13;
            // 
            // dtpExpiary
            // 
            this.dtpExpiary.Location = new System.Drawing.Point(343, 174);
            this.dtpExpiary.Name = "dtpExpiary";
            this.dtpExpiary.Size = new System.Drawing.Size(250, 27);
            this.dtpExpiary.TabIndex = 14;
            // 
            // cbCurrency
            // 
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(343, 207);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(202, 28);
            this.cbCurrency.TabIndex = 15;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 469);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 49);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(762, 469);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(106, 49);
            this.btnHome.TabIndex = 17;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 547);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbCurrency);
            this.Controls.Add(this.dtpExpiary);
            this.Controls.Add(this.lblIdeaTitle);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvIdeas);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.cbProductType);
            this.Controls.Add(this.cbRiskRaiting);
            this.Controls.Add(this.cbMajorSector);
            this.Controls.Add(this.cbMinorSector);
            this.Controls.Add(this.cbInstruments);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.txtTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdeas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cbInstruments;
        private System.Windows.Forms.ComboBox cbMinorSector;
        private System.Windows.Forms.ComboBox cbMajorSector;
        private System.Windows.Forms.ComboBox cbRiskRaiting;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.DataGridView dgvIdeas;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblIdeaTitle;
        private System.Windows.Forms.DateTimePicker dtpExpiary;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHome;
    }
}

