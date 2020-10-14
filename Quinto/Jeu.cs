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
    public partial class Jeu : Form
    {
        private Jeu()
        {
            InitializeComponent();
            lblEssais.Text = essaisRestants.ToString();
            lblNbErreurs.Text = nbErreurs.ToString();


        }
        string MotATrouver;
        int essaisRestants;
        int nbErreurs;
        string[] strArr = { "bateau", "chaise", "framboise", "catapulte", "montagne", "stylo" };

        #region Singleton
        private static Jeu singleJeu = null;
        public static Jeu Instance()
        {
            if (singleJeu == null)
            {
                singleJeu = new Jeu();
            }
            return singleJeu;
        }
        private void Jeu_FormClosed(object sender, FormClosedEventArgs e)
        {
            singleJeu = null;
        }
        #endregion


        #region Evennements
        private void bu_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            lstLettres.Items.Add(button.Text);

            for (int i = 0; i < MotATrouver.Length; i++)
            {
                if (MotATrouver[i].Equals(Convert.ToChar(button.Text)))
                {
                    int j = i;
                    txtMotATrouver.Text = txtMotATrouver.Text.Remove(j, 1).Insert(j, MotATrouver[i].ToString());
                }
                else
                {
                    essaisRestants--;
                    lblEssais.Text = essaisRestants.ToString(); 
                    nbErreurs++;
                    lblNbErreurs.Text = nbErreurs.ToString(); 
                }
            }

               


        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            MotATrouver = strArr[rand.Next(strArr.Length)];
            foreach (char c in MotATrouver)
            {
                txtMotATrouver.Text += '*'; 
            }

        }

        #endregion

    }
}
