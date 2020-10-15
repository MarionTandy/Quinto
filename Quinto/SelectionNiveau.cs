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
    public partial class SelectionNiveau : Form
    {
        private SelectionNiveau()
        {
            InitializeComponent();
        }

        #region Singleton
        private static SelectionNiveau singleSelectionNiveau = null;
        public static SelectionNiveau Instance()
        {
            if (singleSelectionNiveau == null)
            {
                singleSelectionNiveau = new SelectionNiveau();
            }
            return singleSelectionNiveau;
        }
        private void SelectionNiveau_FormClosed(object sender, FormClosedEventArgs e)
        {
            singleSelectionNiveau = null;
        }
        #endregion

        #region
        private void btnJouer_Click(object sender, EventArgs e)
        {
            Jeu.Instance().Show();
            Jeu.Instance().Activate();
        }



        #endregion

        private void rdbFacile_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbDifficile_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbExpert_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
