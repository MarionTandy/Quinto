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
        string MotATrouver;
        int nbManches = SelectionNiveau.niveauSelectionne.NbManches;
        string longueurDesMots = SelectionNiveau.niveauSelectionne.LongueurDesMots;
        int nbEssais = SelectionNiveau.niveauSelectionne.NbErreurs;
        int nbErreursTotales = 0; 
        Mots motsrandom = new Mots();
        private Jeu()
        {
            InitializeComponent();
           
        }
       

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
            button.Enabled = false;
            VerifierInputUtilisateur(button.Text);
            MotComplet(MotATrouver, txtMotATrouver.Text);
            VerifierVictoire(lblNbMancheJouees.Text, lblNbManchesTotal.Text, MotATrouver, txtMotATrouver.Text);
            VerifierDefaite(lblEssais.Text);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GestionContextes(Contextes.DebutDeManche);
            RegenererClavier();
            GenererMotCache();
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            i++;
            lblTimer.Text = i.ToString();

        }

        private void btnManche_Click(object sender, EventArgs e)
        {
            GestionContextes(Contextes.InterManche);
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
                lblNbErreurs.Text = (int.Parse(lblNbErreurs.Text) + 1).ToString();
                lblEssais.Text = (int.Parse(lblEssais.Text)-1).ToString();
                nbErreursTotales++;
            }
        }

        public void GenererMotCache()
        {
            motsrandom = (Mots)Serialisation.LoadJson(@"C:\Users\CDA\source\repos\Lexique.json", typeof(Mots));
            Random rand = new Random();
            HashSet<Mot> motsParNiveau = new HashSet<Mot>();
            switch (longueurDesMots)
            {
                case "courts":
                    motsParNiveau = Mots.TrierMotsFaciles(motsrandom);
                    break;
                case "moyens":
                    motsParNiveau = Mots.TrierMotsDifficiles(motsrandom);
                    break;
                case "longs":
                    motsParNiveau = Mots.TrierMotsExperts(motsrandom);
                    break;
            }
            int nb = rand.Next(0, motsParNiveau.Count);
            MotATrouver = motsParNiveau.ElementAt(nb).Texte;

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
                GestionContextes(Contextes.FinDeManche);
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
                
                singleJeu.Enabled = false;
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
            int score = int.Parse(lblTimer.Text) + nbErreursTotales;
            return score.ToString(); 
        }

        public string CalculerScoreGlobal()
        {
            int scoreGlobal = (int.Parse(lblTimer.Text) / nbManches) + nbErreursTotales;
            return scoreGlobal.ToString(); 
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
                    lblNbManchesTotal.Text = nbManches.ToString();
                    lblEssais.Text = nbEssais.ToString();
                    lblEssaisTotaux.Text = nbEssais.ToString();
                    lblNbErreurs.Text = 0.ToString();
                    lblPoints.Text = 0.ToString();
                    txtMotATrouver.Clear();
                    lstLettres.Items.Clear();
                    nbErreursTotales = 0; 
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
                    lblEssais.Text = nbEssais.ToString();
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
