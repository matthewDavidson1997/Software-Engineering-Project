
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
            this.SuspendLayout();
            // 
            // lblIdeaCreatorLoggedIn
            // 
            this.lblIdeaCreatorLoggedIn.AutoSize = true;
            this.lblIdeaCreatorLoggedIn.Location = new System.Drawing.Point(668, 421);
            this.lblIdeaCreatorLoggedIn.Name = "lblIdeaCreatorLoggedIn";
            this.lblIdeaCreatorLoggedIn.Size = new System.Drawing.Size(50, 20);
            this.lblIdeaCreatorLoggedIn.TabIndex = 0;
            this.lblIdeaCreatorLoggedIn.Text = "label1";
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
            // IdeaCreatorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}