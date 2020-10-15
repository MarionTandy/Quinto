using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
           


        }
        string MotATrouver;
        int essaisRestants;// VARIABLE INUTILE? JE PEUX DIRECT UTILISER int.Parse(lblEssais.Text) ou niveau.nbEssais.ToString() ? */
        int nbErreurs = 0;//Pareil que pour essais restants non ? 
        string[] strArr = { "bateau", "chaise", "framboise", "catapulte", "montagne", "stylo", "porte-clef" };

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
            button.Enabled = false; //penser à repasser les boutons en enable sur Manche suivante
            VerifierInputUtilisateur(button.Text);
            MotComplet(MotATrouver, txtMotATrouver.Text);
            VerifierVictoire(lblNbMancheJouees.Text, lblNbManchesTotal.Text, MotATrouver, txtMotATrouver.Text);
            VerifierDefaite(lblEssais.Text);
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
           
            essaisRestants = 3/*= Niveau.NbEssais*/;
            lblEssais.Text = essaisRestants.ToString();
            nbErreurs = 0;
            lblNbErreurs.Text = nbErreurs.ToString();
            timer.Enabled = true;
            lblNbMancheJouees.Text = (int.Parse(lblNbMancheJouees.Text) + 1).ToString(); 
            GenererMotCache(/*listeDeMots, MotAtrouver, txtMotAtrouver.Text*/); 
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            i++;
            lblTimer.Text = i.ToString();

        }

        #endregion

        #region Méthodes
        public void VerifierInputUtilisateur(string input)
        {
            if (MotATrouver.Contains(input))
            {
                for (int i = 0; i < MotATrouver.Length; i++)
                {
                    if (MotATrouver[i].Equals(Convert.ToChar(input)))
                    {
                        int j = i;
                        txtMotATrouver.Text = txtMotATrouver.Text.Remove(j, 1).Insert(j, MotATrouver[i].ToString());
                    }
                }
                
            }

            else
            {
                    nbErreurs++;
                    lblNbErreurs.Text = nbErreurs.ToString();
                    essaisRestants--;
                    lblEssais.Text = essaisRestants.ToString();
                   
            }
        }

        public void GenererMotCache(/*IEnumerable<string> listeDeMots, string motATrouver, string motCache*/)
        {
            Random rand = new Random();
            MotATrouver = strArr[rand.Next(strArr.Length)]; 
            //MotATrouver = listeDeMots[rand.Next(listeDeMots.Lenght)] ; 
            foreach (char c in MotATrouver)
                if (c == '-')
                {
                    txtMotATrouver.Text += '-'; 
                }
                else 
                {
                txtMotATrouver.Text += '*';
                }
        }

        public bool MotComplet(string motATrouver, string motCache)
        {
            if (motATrouver.Equals(motCache))
            {
                lblBravo.Visible = true;
                btnStart.Enabled = false;
                btnManche.Enabled = true;
                btnManche.Focus();
                timer.Stop();
                int score = int.Parse(lblPoints.Text) + int.Parse(lblTimer.Text) + int.Parse(lblNbErreurs.Text);
                lblPoints.Text = CalculerScore(int.Parse(lblPoints.Text), int.Parse(lblTimer.Text), int.Parse(lblNbErreurs.Text));
                return true; 
            }
            else { return false; }
        }

        public void VerifierVictoire(string manchesJouees, string manchesTotales, string motATrouver, string motCache)
        {
            if ((int.Parse(manchesJouees) == int.Parse(manchesTotales)) && MotComplet(motATrouver, motCache))
            {
                Victoire victoire = new Victoire();
                victoire.Show(); 
            }
        }
        public void VerifierDefaite(string essaisRestant)
        {
            if (int.Parse(essaisRestant) == 0)
            {
                singleJeu.Close();
                MessageBox.Show("Perdu ! Dommage, vous ferez mieux la prochaine fois :)", "Perdu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        public string CalculerScore(int pointsManchePrecedente, int timer, int nombreErreurs)
        {
            int score = pointsManchePrecedente + timer + nombreErreurs;
            return score.ToString(); 
        }
        #endregion

        public void txtMotATrouver_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
