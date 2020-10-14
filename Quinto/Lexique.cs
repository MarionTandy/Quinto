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
    public partial class Lexique : Form
    {
        private Lexique()
        {
            InitializeComponent();
            string[] strArr = { "bateau", "chaise", "framboise", "catapulte", "montagne", "stylo" };
            lstLexique.Items.AddRange(strArr);

        }

        #region Singleton
        private static Lexique singleLexique = null;

        public static Lexique Instance()
        {
            if (singleLexique == null)
            {
                singleLexique = new Lexique();
            }
            return singleLexique;
        }

        private void Lexique_FormClosed(object sender, FormClosedEventArgs e)
        {
            singleLexique = null;
        }
        #endregion
    }
}
