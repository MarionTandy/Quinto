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
    public partial class Scores : Form
    {
        private Scores()
        {
            InitializeComponent();
        }



        #region Singleton
        private static Scores singleScores = null;
        public static Scores Instance()
        {
            if (singleScores == null)
            {
                singleScores = new Scores();
            }
            return singleScores;
        }
        private void Scores_FormClosed(object sender, FormClosedEventArgs e)
        {
            singleScores = null;
        }
        #endregion
    }
}
