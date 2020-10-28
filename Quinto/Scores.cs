using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text; 
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quinto
{
    public partial class Scores : Form
    {
        ScoreJoueur[] ListeScores = new ScoreJoueur[] { };
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

        private void Scores_Load(object sender, EventArgs e)
        {
            String directory = Directory.GetCurrentDirectory();
            DirectoryInfo direc = new DirectoryInfo(directory);
            direc = direc.Parent.Parent.Parent;
            ListeScores = (ScoreJoueur[])Serialisation.LoadJson(direc.FullName + "\\Top10Scores.json", typeof(ScoreJoueur[]));
            Array.Sort(ListeScores, ScoreJoueur.TriAscendant());
            foreach (ScoreJoueur item in ListeScores)
            {
                listBox2.Items.Add(item.ToString()); 
            }
        }
    }
}
