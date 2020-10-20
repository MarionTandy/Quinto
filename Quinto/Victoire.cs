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

namespace Quinto
{
    public partial class Victoire : Form
    {
        static int count = 0;
        
        List<ScoreJoueur> ListeScores =  new List<ScoreJoueur>() ; 
        public Victoire()
        {
            InitializeComponent();
            lblScore.Text = Jeu.Instance().CalculerScore();
            lblScoreGlobal.Text = Jeu.Instance().CalculerScoreGlobal(); 
            
        }
        
       

        private void Victoire_Load(object sender, EventArgs e)
        {
          
            ListeScores = (List<ScoreJoueur>)Serialisation.LoadJson(@"C:\Users\CDA\source\repos\Top10Scores.json", typeof(List<ScoreJoueur>));
           
            if (ListeScores.Count < 10)
            {
                pnlSave.Visible = true; 
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (ListeScores.Count < 10)
            {
                ScoreJoueur scoreASauv = new ScoreJoueur(txtPseudo.Text, int.Parse(lblScore.Text));
                ListeScores.Add(scoreASauv); 
                Serialisation.SaveJson(@"C:\Users\CDA\source\repos\Top10Scores.json", ListeScores);
                count++; //verifier que le count augmente bien.
            }
            else
            {
                int scoreLePLusBas = ListeScores.Min(score => score.Points);

                    if (int.Parse(lblScoreGlobal.Text) > scoreLePLusBas)
                    {
                         
                        
                        ScoreJoueur scoreASauv = new ScoreJoueur(txtPseudo.Text, int.Parse(lblScore.Text));
                        ListeScores.Add(scoreASauv); 
                    }
                
            }
        }
    }
}
