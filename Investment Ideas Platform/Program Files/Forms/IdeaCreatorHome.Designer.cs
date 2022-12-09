
namespace Relationship_manager_administration_system
{
    partial class IdeaCreatorHome
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
            this.lblIdeaCreatorLoggedIn = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMyIdeas = new System.Windows.Forms.Button();
            this.btnNewIdeas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdeaCreatorLoggedIn
            // 
            this.lblIdeaCreatorLoggedIn.AutoSize = true;
            this.lblIdeaCreatorLoggedIn.Location = new System.Drawing.Point(571, 309);
            this.lblIdeaCreatorLoggedIn.Name = "lblIdeaCreatorLoggedIn";
            this.lblIdeaCreatorLoggedIn.Size = new System.Drawing.Size(71, 15);
            this.lblIdeaCreatorLoggedIn.TabIndex = 0;
            this.lblIdeaCreatorLoggedIn.Text = "Idea Creator";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(10, 284);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 46);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMyIdeas
            // 
            this.btnMyIdeas.Location = new System.Drawing.Point(284, 99);
            this.btnMyIdeas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMyIdeas.Name = "btnMyIdeas";
            this.btnMyIdeas.Size = new System.Drawing.Size(113, 44);
            this.btnMyIdeas.TabIndex = 2;
            this.btnMyIdeas.Text = "My Ideas";
            this.btnMyIdeas.UseVisualStyleBackColor = true;
            this.btnMyIdeas.Click += new System.EventHandler(this.btnMyIdeas_Click);
            // 
            // btnNewIdeas
            // 
            this.btnNewIdeas.Location = new System.Drawing.Point(284, 156);
            this.btnNewIdeas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewIdeas.Name = "btnNewIdeas";
            this.btnNewIdeas.Size = new System.Drawing.Size(113, 44);
            this.btnNewIdeas.TabIndex = 3;
            this.btnNewIdeas.Text = "New Idea";
            this.btnNewIdeas.UseVisualStyleBackColor = true;
            this.btnNewIdeas.Click += new System.EventHandler(this.btnNewIdeas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Idea Creator Home";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(10, 8);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(99, 46);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(284, 216);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 44);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "update or delete idea";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // IdeaCreatorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewIdeas);
            this.Controls.Add(this.btnMyIdeas);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblIdeaCreatorLoggedIn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IdeaCreatorHome";
            this.Text = "IdeaCreatorHome";
            this.Load += new System.EventHandler(this.IdeaCreatorHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdeaCreatorLoggedIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMyIdeas;
        private System.Windows.Forms.Button btnNewIdeas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnUpdate;
    }
}