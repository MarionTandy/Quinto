namespace Quinto
{
    partial class SelectionNiveau
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
            this.btnJouer = new System.Windows.Forms.Button();
            this.rdbFacile = new System.Windows.Forms.RadioButton();
            this.rdbDifficile = new System.Windows.Forms.RadioButton();
            this.rdbExpert = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnJouer
            // 
            this.btnJouer.Location = new System.Drawing.Point(352, 284);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(75, 23);
            this.btnJouer.TabIndex = 3;
            this.btnJouer.Text = "Jouer !";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // rdbFacile
            // 
            this.rdbFacile.AutoSize = true;
            this.rdbFacile.Location = new System.Drawing.Point(221, 112);
            this.rdbFacile.Name = "rdbFacile";
            this.rdbFacile.Size = new System.Drawing.Size(53, 17);
            this.rdbFacile.TabIndex = 4;
            this.rdbFacile.TabStop = true;
            this.rdbFacile.Text = "Facile";
            this.rdbFacile.UseVisualStyleBackColor = true;
            // 
            // rdbDifficile
            // 
            this.rdbDifficile.AutoSize = true;
            this.rdbDifficile.Location = new System.Drawing.Point(352, 112);
            this.rdbDifficile.Name = "rdbDifficile";
            this.rdbDifficile.Size = new System.Drawing.Size(59, 17);
            this.rdbDifficile.TabIndex = 5;
            this.rdbDifficile.TabStop = true;
            this.rdbDifficile.Text = "Difficile";
            this.rdbDifficile.UseVisualStyleBackColor = true;
            // 
            // rdbExpert
            // 
            this.rdbExpert.AutoSize = true;
            this.rdbExpert.Location = new System.Drawing.Point(505, 112);
            this.rdbExpert.Name = "rdbExpert";
            this.rdbExpert.Size = new System.Drawing.Size(55, 17);
            this.rdbExpert.TabIndex = 6;
            this.rdbExpert.TabStop = true;
            this.rdbExpert.Text = "Expert";
            this.rdbExpert.UseVisualStyleBackColor = true;
            // 
            // SelectionNiveau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbExpert);
            this.Controls.Add(this.rdbDifficile);
            this.Controls.Add(this.rdbFacile);
            this.Controls.Add(this.btnJouer);
            this.Name = "SelectionNiveau";
            this.Text = "Sélectionne ton niveau !";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectionNiveau_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.RadioButton rdbFacile;
        private System.Windows.Forms.RadioButton rdbDifficile;
        private System.Windows.Forms.RadioButton rdbExpert;
    }
}