
namespace Relationship_manager_administration_system
{
    partial class PurchaseProducts
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
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewIdeas = new System.Windows.Forms.Button();
            this.btnPurchaseIdea = new System.Windows.Forms.Button();
            this.lblClientReference = new System.Windows.Forms.Label();
            this.lblLoggedInRM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdeas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Client,
            this.Email,
            this.ContactFirstName,
            this.ContactLastName,
            this.ContactNumber});
            this.dgvClients.Location = new System.Drawing.Point(-2, 48);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 29;
            this.dgvClients.Size = new System.Drawing.Size(895, 188);
            this.dgvClients.TabIndex = 0;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_Mouse_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.MinimumWidth = 6;
            this.Client.Name = "Client";
            this.Client.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // ContactFirstName
            // 
            this.ContactFirstName.HeaderText = "Contact First Name";
            this.ContactFirstName.MinimumWidth = 6;
            this.ContactFirstName.Name = "ContactFirstName";
            this.ContactFirstName.Width = 125;
            // 
            // ContactLastName
            // 
            this.ContactLastName.HeaderText = "Contact Last Name";
            this.ContactLastName.MinimumWidth = 6;
            this.ContactLastName.Name = "ContactLastName";
            this.ContactLastName.Width = 125;
            // 
            // ContactNumber
            // 
            this.ContactNumber.HeaderText = "Contact Number";
            this.ContactNumber.MinimumWidth = 6;
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Width = 125;
            // 
            // dgvIdeas
            // 
            this.dgvIdeas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.dgvIdeas.Location = new System.Drawing.Point(-2, 264);
            this.dgvIdeas.Name = "dgvIdeas";
            this.dgvIdeas.RowHeadersWidth = 51;
            this.dgvIdeas.RowTemplate.Height = 29;
            this.dgvIdeas.Size = new System.Drawing.Size(895, 188);
            this.dgvIdeas.TabIndex = 1;
            this.dgvIdeas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIdeas_CellContentClick);
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
            this.Instruments.HeaderText = "Insturuments";
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
            this.Region.HeaderText = "Region";
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
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 473);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 57);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewIdeas
            // 
            this.btnViewIdeas.Location = new System.Drawing.Point(295, 473);
            this.btnViewIdeas.Name = "btnViewIdeas";
            this.btnViewIdeas.Size = new System.Drawing.Size(114, 57);
            this.btnViewIdeas.TabIndex = 3;
            this.btnViewIdeas.Text = "View Ideas";
            this.btnViewIdeas.UseVisualStyleBackColor = true;
            this.btnViewIdeas.Click += new System.EventHandler(this.btnViewIdeas_Click);
            // 
            // btnPurchaseIdea
            // 
            this.btnPurchaseIdea.Location = new System.Drawing.Point(415, 473);
            this.btnPurchaseIdea.Name = "btnPurchaseIdea";
            this.btnPurchaseIdea.Size = new System.Drawing.Size(114, 57);
            this.btnPurchaseIdea.TabIndex = 4;
            this.btnPurchaseIdea.Text = "Purchase Idea";
            this.btnPurchaseIdea.UseVisualStyleBackColor = true;
            this.btnPurchaseIdea.Click += new System.EventHandler(this.btnPurchaseIdea_Click);
            // 
            // lblClientReference
            // 
            this.lblClientReference.AutoSize = true;
            this.lblClientReference.Location = new System.Drawing.Point(47, 13);
            this.lblClientReference.Name = "lblClientReference";
            this.lblClientReference.Size = new System.Drawing.Size(0, 20);
            this.lblClientReference.TabIndex = 5;
            this.lblClientReference.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLoggedInRM
            // 
            this.lblLoggedInRM.AutoSize = true;
            this.lblLoggedInRM.Location = new System.Drawing.Point(741, 13);
            this.lblLoggedInRM.Name = "lblLoggedInRM";
            this.lblLoggedInRM.Size = new System.Drawing.Size(0, 20);
            this.lblLoggedInRM.TabIndex = 6;
            this.lblLoggedInRM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 7;
            // 
            // PurchaseProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoggedInRM);
            this.Controls.Add(this.lblClientReference);
            this.Controls.Add(this.btnPurchaseIdea);
            this.Controls.Add(this.btnViewIdeas);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvIdeas);
            this.Controls.Add(this.dgvClients);
            this.Name = "PurchaseProducts";
            this.Text = "PurchaseProducts";
            this.Load += new System.EventHandler(this.PurchaseProducts_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PurchaseProducts_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdeas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.DataGridView dgvIdeas;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewIdeas;
        private System.Windows.Forms.Button btnPurchaseIdea;
        private System.Windows.Forms.Label lblClientReference;
        private System.Windows.Forms.Label lblLoggedInRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
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
        private System.Windows.Forms.Label label1;
    }
}