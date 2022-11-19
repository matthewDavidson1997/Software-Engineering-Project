
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
            this.btnIdeas = new System.Windows.Forms.Button();
            this.btnYourDetails = new System.Windows.Forms.Button();
            this.lblLoggedInRmId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relationship Manager Home";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 49);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(311, 113);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(146, 47);
            this.btnClients.TabIndex = 2;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnIdeas
            // 
            this.btnIdeas.Location = new System.Drawing.Point(311, 175);
            this.btnIdeas.Name = "btnIdeas";
            this.btnIdeas.Size = new System.Drawing.Size(146, 47);
            this.btnIdeas.TabIndex = 3;
            this.btnIdeas.Text = "Ideas";
            this.btnIdeas.UseVisualStyleBackColor = true;
            // 
            // btnYourDetails
            // 
            this.btnYourDetails.Location = new System.Drawing.Point(311, 239);
            this.btnYourDetails.Name = "btnYourDetails";
            this.btnYourDetails.Size = new System.Drawing.Size(146, 47);
            this.btnYourDetails.TabIndex = 4;
            this.btnYourDetails.Text = "Your Details";
            this.btnYourDetails.UseVisualStyleBackColor = true;
            // 
            // lblLoggedInRmId
            // 
            this.lblLoggedInRmId.AutoSize = true;
            this.lblLoggedInRmId.Location = new System.Drawing.Point(12, 9);
            this.lblLoggedInRmId.Name = "lblLoggedInRmId";
            this.lblLoggedInRmId.Size = new System.Drawing.Size(124, 20);
            this.lblLoggedInRmId.TabIndex = 5;
            this.lblLoggedInRmId.Text = "Logged In RM ID:";
            // 
            // RmHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLoggedInRmId);
            this.Controls.Add(this.btnYourDetails);
            this.Controls.Add(this.btnIdeas);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button btnIdeas;
        private System.Windows.Forms.Button btnYourDetails;
        private System.Windows.Forms.Label lblLoggedInRmId;
    }
}