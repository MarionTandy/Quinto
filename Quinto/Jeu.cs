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
        Mots motsrandom = new Mots();
        private Jeu()
        {
            InitializeComponent();
           
        }
        string MotATrouver;
        int essaisRestants;// VARIABLE INUTILE? JE PEUX DIRECT UTILISER int.Parse(lblEssais.Text) ou niveau.nbEssais.ToString() ? */
        int nbErreurs = 0;//Pareil que pour essais restants non ? 
       

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

        private void Jeu_Load(object sender, EventArgs e)
        {
            GestionContextes(Contextes.Initial);
        }

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
            //GestionContextes(Contextes.DebutDeManche); //Gère tout ce qui est en dessous
            essaisRestants = 7/*= Niveau.NbEssais*/;
            lblEssais.Text = essaisRestants.ToString();//A supprimmer
            nbErreurs = 0;//A supprimmer
            lblNbErreurs.Text = nbErreurs.ToString();//A supprimer
            timer.Enabled = true;//A supprimer
            pnlClavier.Enabled = true;
            RegenererClavier();
            GenererMotCache(/*listeDeMots, MotAtrouver, txtMotAtrouver.Text*/); 
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            i++;
            lblTimer.Text = i.ToString();

        }

        private void btnManche_Click(object sender, EventArgs e)
        {
         //   GestionContextes(Contextes.InterManche); 
            //lblEssais.Text = niveau.nbEssais ; 
            nbErreurs = 0;
            lblNbErreurs.Text = nbErreurs.ToString();
            lblBravo.Visible = false;
            btnManche.Enabled = false;
            lstLettres.Items.Clear();
            txtMotATrouver.Clear();
            btnStart.Enabled = true;
            btnStart.Focus();
            lblNbMancheJouees.Text = (int.Parse(lblNbMancheJouees.Text) + 1).ToString();
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

        public void GenererMotCache()
        {
            motsrandom = (Mots)Serialisation.LoadJson(@"C:\Users\CDA\source\repos\Lexique.json", typeof(Mots));
            Random rand = new Random();
            

            int nb = rand.Next(0, motsrandom.Count);
            MotATrouver = motsrandom.ElementAt(nb).Texte ; 
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
                //GestionContextes(Contextes.FinDeManche); 
                lblBravo.Visible = true;
                btnStart.Enabled = false;
                btnManche.Enabled = true;
                btnManche.Focus();
                timer.Stop();
                pnlClavier.Enabled = false; 
                int score = int.Parse(lblPoints.Text) + int.Parse(lblTimer.Text) + int.Parse(lblNbErreurs.Text);
                lblPoints.Text = CalculerScore();
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
                MessageBox.Show("Perdu ! Dommage, vous ferez mieux la prochaine fois :)", "Perdu", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        public string CalculerScore()
        {
            int score = int.Parse(lblPoints.Text) + int.Parse(lblTimer.Text) + int.Parse(lblNbErreurs.Text);
            return score.ToString(); 
        }

        public enum Contextes
        {
            Initial = 0,
            DebutDeManche = 1,
            FinDeManche = 2,
            InterManche = 3,


        }
        public void GestionContextes(Contextes contexte)
        {
            switch (contexte)
            {
                case Contextes.Initial: //ouverture de la fenêtre de jeu
                    btnManche.Enabled = false;
                    lblBravo.Visible = false;
                    btnStart.Enabled = true;
                    txtMotATrouver.Enabled = false;
                    pnlClavier.Enabled = false;
                    //lblNbManchesTotal.Text = niveau.NbManches.ToString() ; 
                    //lblEssais.Text = niveau.NbEssais.ToString() ; 
                    //lblEssaisTotaux.Text = niveau.NbEssais.ToString() ;
                    lblNbErreurs.Text = 0.ToString();
                    lblPoints.Text = 0.ToString();
                    txtMotATrouver.Clear();
                    lstLettres.Items.Clear();
                    break;

                case Contextes.DebutDeManche: //btnStart
                    timer.Enabled = true;
                    pnlClavier.Enabled = true;
                    RegenererClavier(); 
                    btnStart.Enabled = false;
                    break;

                case Contextes.FinDeManche://MotComplet()
                    timer.Stop();
                    lblBravo.Visible = true;
                    btnManche.Enabled = true;
                    btnManche.Focus();
                    lblPoints.Text = CalculerScore();
                   
                    pnlClavier.Enabled = false;
                    break;

                case Contextes.InterManche://btnManche
                    lblNbMancheJouees.Text = (int.Parse(lblNbMancheJouees.Text) + 1).ToString();
                    //lblEssais.Text = niveau.NbEssais.ToString() ; 
                    lblNbErreurs.Text = 0.ToString();
                    lstLettres.Items.Clear();
                    txtMotATrouver.Clear();
                    lblBravo.Visible = false;
                    btnManche.Enabled = false;
                    btnStart.Enabled = true;
                    btnStart.Focus();
                    break; 
            }
        }
        public void RegenererClavier()
        {
            foreach (Control button in pnlClavier.Controls)
            {
                button.Enabled = true; 
            }
        }
       

        #endregion

        public void txtMotATrouver_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
