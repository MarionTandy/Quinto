using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quinto
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void jouerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectionNiveau.Instance().MdiParent = this ;
            SelectionNiveau.Instance().Show();
            SelectionNiveau.Instance().Activate(); 
        }

        private void lexiqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Lexique.Instance().MdiParent = this;
            Lexique.Instance().Show();
            Lexique.Instance().Activate();
        }
    }
}
