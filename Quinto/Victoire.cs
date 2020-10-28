using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quinto
{
    public partial class Victoire : Form
    {
        static int count = 0;

        ScoreJoueur[] ListeScores = new ScoreJoueur[] { }; 
        public Victoire()
        {
            InitializeComponent();
            lblScore.Text = Jeu.Instance().CalculerScore();
            lblScoreGlobal.Text = Jeu.Instance().CalculerScoreGlobal(); 
            
        }
        
       

        private void Victoire_Load(object sender, EventArgs e)
        {
            String directory = Directory.GetCurrentDirectory();
            DirectoryInfo direc = new DirectoryInfo(directory);
            direc = direc.Parent.Parent.Parent;
            ListeScores = (ScoreJoueur[])Serialisation.LoadJson(direc + "\\Top10Scores.json", typeof(ScoreJoueur[]));
            Array.Sort(ListeScores, ScoreJoueur.TriAscendant());
            if (int.Parse(lblScoreGlobal.Text)<(ListeScores[9].Points))
            {
                pnlSave.Visible = true; 
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
 
            ScoreJoueur scoreASauv = new ScoreJoueur(txtPseudo.Text, int.Parse(lblScore.Text));
            ListeScores[9]=scoreASauv;
            String directory = Directory.GetCurrentDirectory();
            DirectoryInfo direc = new DirectoryInfo(directory);
            direc = direc.Parent.Parent.Parent;
            Serialisation.SaveJson(direc + "\\Top10Scores.json", ListeScores);
            MessageBox.Show("Ton score a bien été enregistré dans le top 10 !", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtPseudo.Clear();
            btnEnregistrer.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Jeu.Instance().Close();
        }
    }
}
