namespace Quinto
{
    partial class Victoire
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblScoreGlobal = new System.Windows.Forms.Label();
            this.pnlSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Victoire !!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 10);
            this.label2.MaximumSize = new System.Drawing.Size(500, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 160);
            this.label2.TabIndex = 1;
            this.label2.Text = "Félicitation ! Vous faites partie des 10 meilleurs scores ! Si vous souhaitez l\'e" +
    "nregistrer, renseignez votre pseudo ci-dessous.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(92, 185);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(156, 20);
            this.txtPseudo.TabIndex = 2;
            // 
            // pnlSave
            // 
            this.pnlSave.Controls.Add(this.label2);
            this.pnlSave.Controls.Add(this.btnEnregistrer);
            this.pnlSave.Controls.Add(this.lblPseudo);
            this.pnlSave.Controls.Add(this.txtPseudo);
            this.pnlSave.Location = new System.Drawing.Point(156, 125);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(512, 230);
            this.pnlSave.TabIndex = 3;
            this.pnlSave.Visible = false;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(359, 182);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(104, 23);
            this.btnEnregistrer.TabIndex = 4;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Location = new System.Drawing.Point(37, 188);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(49, 13);
            this.lblPseudo.TabIndex = 3;
            this.lblPseudo.Text = "Pseudo :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Retour au menu principal";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Score : ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(245, 89);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(30, 33);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Score au classement global :";
            // 
            // lblScoreGlobal
            // 
            this.lblScoreGlobal.AutoSize = true;
            this.lblScoreGlobal.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreGlobal.Location = new System.Drawing.Point(611, 89);
            this.lblScoreGlobal.Name = "lblScoreGlobal";
            this.lblScoreGlobal.Size = new System.Drawing.Size(30, 33);
            this.lblScoreGlobal.TabIndex = 8;
            this.lblScoreGlobal.Text = "0";
            // 
            // Victoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScoreGlobal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlSave);
            this.Controls.Add(this.label1);
            this.Name = "Victoire";
            this.Text = "Victoire";
            this.Load += new System.EventHandler(this.Victoire_Load);
            this.pnlSave.ResumeLayout(false);
            this.pnlSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblScoreGlobal;
    }
}