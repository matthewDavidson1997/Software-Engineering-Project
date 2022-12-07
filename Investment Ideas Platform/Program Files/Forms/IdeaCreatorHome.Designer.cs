
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
            this.SuspendLayout();
            // 
            // lblIdeaCreatorLoggedIn
            // 
            this.lblIdeaCreatorLoggedIn.AutoSize = true;
            this.lblIdeaCreatorLoggedIn.Location = new System.Drawing.Point(653, 412);
            this.lblIdeaCreatorLoggedIn.Name = "lblIdeaCreatorLoggedIn";
            this.lblIdeaCreatorLoggedIn.Size = new System.Drawing.Size(91, 20);
            this.lblIdeaCreatorLoggedIn.TabIndex = 0;
            this.lblIdeaCreatorLoggedIn.Text = "Idea Creator";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 62);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMyIdeas
            // 
            this.btnMyIdeas.Location = new System.Drawing.Point(325, 132);
            this.btnMyIdeas.Name = "btnMyIdeas";
            this.btnMyIdeas.Size = new System.Drawing.Size(129, 58);
            this.btnMyIdeas.TabIndex = 2;
            this.btnMyIdeas.Text = "My Ideas";
            this.btnMyIdeas.UseVisualStyleBackColor = true;
            this.btnMyIdeas.Click += new System.EventHandler(this.btnMyIdeas_Click);
            // 
            // btnNewIdeas
            // 
            this.btnNewIdeas.Location = new System.Drawing.Point(325, 208);
            this.btnNewIdeas.Name = "btnNewIdeas";
            this.btnNewIdeas.Size = new System.Drawing.Size(129, 58);
            this.btnNewIdeas.TabIndex = 3;
            this.btnNewIdeas.Text = "New Idea";
            this.btnNewIdeas.UseVisualStyleBackColor = true;
            this.btnNewIdeas.Click += new System.EventHandler(this.btnNewIdeas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Idea Creator Home";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(12, 10);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(113, 62);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // IdeaCreatorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewIdeas);
            this.Controls.Add(this.btnMyIdeas);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblIdeaCreatorLoggedIn);
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
    }
}