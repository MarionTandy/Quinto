namespace Quinto
{
    partial class Scores
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
            this.lblScoreDifficile = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblScoreDifficile
            // 
            this.lblScoreDifficile.AutoSize = true;
            this.lblScoreDifficile.Location = new System.Drawing.Point(275, 52);
            this.lblScoreDifficile.Name = "lblScoreDifficile";
            this.lblScoreDifficile.Size = new System.Drawing.Size(200, 13);
            this.lblScoreDifficile.TabIndex = 1;
            this.lblScoreDifficile.Text = "Top 10 des scores au classement global:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(288, 92);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(175, 316);
            this.listBox2.TabIndex = 4;
            // 
            // Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quinto.Properties.Resources.frm_background;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lblScoreDifficile);
            this.Name = "Scores";
            this.Text = "Scores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Scores_FormClosed);
            this.Load += new System.EventHandler(this.Scores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblScoreDifficile;
        private System.Windows.Forms.ListBox listBox2;
    }
}