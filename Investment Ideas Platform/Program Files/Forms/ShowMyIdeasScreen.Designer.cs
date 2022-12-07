
namespace Relationship_manager_administration_system
{
    partial class ShowMyIdeasScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.lblIdeaCreatorID = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.Location = new System.Drawing.Point(2, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(799, 303);
            this.dataGridView1.TabIndex = 0;
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
            this.Region.HeaderText = "Reigon";
            this.Region.MinimumWidth = 6;
            this.Region.Name = "Region";
            this.Region.Width = 125;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.Width = 125;
            // 
            // lblIdeaCreatorID
            // 
            this.lblIdeaCreatorID.AutoSize = true;
            this.lblIdeaCreatorID.Location = new System.Drawing.Point(687, 9);
            this.lblIdeaCreatorID.Name = "lblIdeaCreatorID";
            this.lblIdeaCreatorID.Size = new System.Drawing.Size(50, 20);
            this.lblIdeaCreatorID.TabIndex = 1;
            this.lblIdeaCreatorID.Text = "label1";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(673, 376);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 62);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ShowMyIdeasScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblIdeaCreatorID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowMyIdeasScreen";
            this.Text = "ShowMyIdeasScreen";
            this.Load += new System.EventHandler(this.ShowMyIdeasScreen_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowMyIdeasScreen_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblIdeaCreatorID;
        private System.Windows.Forms.Button btnExit;
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
    }
}