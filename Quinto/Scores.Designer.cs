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
            this.lblScoreFacile = new System.Windows.Forms.Label();
            this.lblScoreDifficile = new System.Windows.Forms.Label();
            this.lblScoreExpert = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblScoreFacile
            // 
            this.lblScoreFacile.AutoSize = true;
            this.lblScoreFacile.Location = new System.Drawing.Point(149, 60);
            this.lblScoreFacile.Name = "lblScoreFacile";
            this.lblScoreFacile.Size = new System.Drawing.Size(35, 13);
            this.lblScoreFacile.TabIndex = 0;
            this.lblScoreFacile.Text = "Facile";
            // 
            // lblScoreDifficile
            // 
            this.lblScoreDifficile.AutoSize = true;
            this.lblScoreDifficile.Location = new System.Drawing.Point(332, 60);
            this.lblScoreDifficile.Name = "lblScoreDifficile";
            this.lblScoreDifficile.Size = new System.Drawing.Size(41, 13);
            this.lblScoreDifficile.TabIndex = 1;
            this.lblScoreDifficile.Text = "Difficile";
            // 
            // lblScoreExpert
            // 
            this.lblScoreExpert.AutoSize = true;
            this.lblScoreExpert.Location = new System.Drawing.Point(525, 60);
            this.lblScoreExpert.Name = "lblScoreExpert";
            this.lblScoreExpert.Size = new System.Drawing.Size(37, 13);
            this.lblScoreExpert.TabIndex = 2;
            this.lblScoreExpert.Text = "Expert";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(88, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 251);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(279, 91);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(160, 251);
            this.listBox2.TabIndex = 4;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(469, 91);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(160, 251);
            this.listBox3.TabIndex = 5;
            // 
            // Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblScoreExpert);
            this.Controls.Add(this.lblScoreDifficile);
            this.Controls.Add(this.lblScoreFacile);
            this.Name = "Scores";
            this.Text = "Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScoreFacile;
        private System.Windows.Forms.Label lblScoreDifficile;
        private System.Windows.Forms.Label lblScoreExpert;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}