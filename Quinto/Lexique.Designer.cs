namespace Quinto
{
    partial class Lexique
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
            this.txtMotAAjouter = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lstLexique = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtMotAAjouter
            // 
            this.txtMotAAjouter.Location = new System.Drawing.Point(102, 59);
            this.txtMotAAjouter.Name = "txtMotAAjouter";
            this.txtMotAAjouter.Size = new System.Drawing.Size(100, 20);
            this.txtMotAAjouter.TabIndex = 0;
            this.txtMotAAjouter.TextChanged += new System.EventHandler(this.txtMotAAjouter_TextChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(272, 59);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lstLexique
            // 
            this.lstLexique.FormattingEnabled = true;
            this.lstLexique.Location = new System.Drawing.Point(468, 59);
            this.lstLexique.Name = "lstLexique";
            this.lstLexique.Size = new System.Drawing.Size(252, 368);
            this.lstLexique.TabIndex = 2;
            // 
            // Lexique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstLexique);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtMotAAjouter);
            this.Name = "Lexique";
            this.Text = "Ajoute des mots au lexique";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lexique_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMotAAjouter;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ListBox lstLexique;
    }
}