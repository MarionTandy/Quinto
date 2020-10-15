namespace Quinto
{
    partial class MDI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.jeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lexiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jouerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lexiqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(92, 26);
            // 
            // jeuToolStripMenuItem
            // 
            this.jeuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lexiqueToolStripMenuItem});
            this.jeuToolStripMenuItem.Name = "jeuToolStripMenuItem";
            this.jeuToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.jeuToolStripMenuItem.Text = "Jeu";
            // 
            // lexiqueToolStripMenuItem
            // 
            this.lexiqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scoresToolStripMenuItem});
            this.lexiqueToolStripMenuItem.Name = "lexiqueToolStripMenuItem";
            this.lexiqueToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.lexiqueToolStripMenuItem.Text = "Lexique";
            // 
            // scoresToolStripMenuItem
            // 
            this.scoresToolStripMenuItem.Name = "scoresToolStripMenuItem";
            this.scoresToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.scoresToolStripMenuItem.Text = "Scores";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jouerToolStripMenuItem,
            this.lexiqueToolStripMenuItem1,
            this.scoresToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jouerToolStripMenuItem
            // 
            this.jouerToolStripMenuItem.Name = "jouerToolStripMenuItem";
            this.jouerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.jouerToolStripMenuItem.Text = "Jouer";
            this.jouerToolStripMenuItem.Click += new System.EventHandler(this.jouerToolStripMenuItem_Click);
            // 
            // lexiqueToolStripMenuItem1
            // 
            this.lexiqueToolStripMenuItem1.Name = "lexiqueToolStripMenuItem1";
            this.lexiqueToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.lexiqueToolStripMenuItem1.Text = "Lexique";
            this.lexiqueToolStripMenuItem1.Click += new System.EventHandler(this.lexiqueToolStripMenuItem1_Click);
            // 
            // scoresToolStripMenuItem1
            // 
            this.scoresToolStripMenuItem1.Name = "scoresToolStripMenuItem1";
            this.scoresToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.scoresToolStripMenuItem1.Text = "Scores";
            this.scoresToolStripMenuItem1.Click += new System.EventHandler(this.scoresToolStripMenuItem1_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.MDI_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lexiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoresToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jouerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lexiqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scoresToolStripMenuItem1;
    }
}

