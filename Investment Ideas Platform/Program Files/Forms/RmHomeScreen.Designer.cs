
namespace Relationship_manager_administration_system
{
    partial class RmHomeScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnPurchaseIdeas = new System.Windows.Forms.Button();
            this.lblLoggedInRmId = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.BTNRemoveIdea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relationship Manager Home";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(11, 292);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 37);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(272, 114);
            this.btnClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(128, 35);
            this.btnClients.TabIndex = 2;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnPurchaseIdeas
            // 
            this.btnPurchaseIdeas.Location = new System.Drawing.Point(272, 154);
            this.btnPurchaseIdeas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPurchaseIdeas.Name = "btnPurchaseIdeas";
            this.btnPurchaseIdeas.Size = new System.Drawing.Size(128, 35);
            this.btnPurchaseIdeas.TabIndex = 3;
            this.btnPurchaseIdeas.Text = "Purchase Ideas";
            this.btnPurchaseIdeas.UseVisualStyleBackColor = true;
            this.btnPurchaseIdeas.Click += new System.EventHandler(this.btnPurchaseIdeas_Click);
            // 
            // lblLoggedInRmId
            // 
            this.lblLoggedInRmId.AutoSize = true;
            this.lblLoggedInRmId.Location = new System.Drawing.Point(10, 7);
            this.lblLoggedInRmId.Name = "lblLoggedInRmId";
            this.lblLoggedInRmId.Size = new System.Drawing.Size(98, 15);
            this.lblLoggedInRmId.TabIndex = 5;
            this.lblLoggedInRmId.Text = "Logged In RM ID:";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(577, 292);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(113, 37);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // BTNRemoveIdea
            // 
            this.BTNRemoveIdea.Location = new System.Drawing.Point(272, 194);
            this.BTNRemoveIdea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNRemoveIdea.Name = "BTNRemoveIdea";
            this.BTNRemoveIdea.Size = new System.Drawing.Size(128, 35);
            this.BTNRemoveIdea.TabIndex = 7;
            this.BTNRemoveIdea.Text = "Remove Idea";
            this.BTNRemoveIdea.UseVisualStyleBackColor = true;
            this.BTNRemoveIdea.Click += new System.EventHandler(this.BTNRemoveIdea_Click);
            // 
            // RmHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.BTNRemoveIdea);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblLoggedInRmId);
            this.Controls.Add(this.btnPurchaseIdeas);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RmHomeScreen";
            this.Text = "RmHomeScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RmHomeScreen_Closing);
            this.Load += new System.EventHandler(this.RmHomeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnPurchaseIdeas;
        private System.Windows.Forms.Label lblLoggedInRmId;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button BTNRemoveIdea;
    }
}