using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Quinto
{
    public partial class Lexique : Form
    {
        Mots mots = new Mots();
        private Lexique()
        {
            InitializeComponent();
            

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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
           


            if (Mot.IsMotOk(txtMotAAjouter.Text))
            {
                
                Mot mot = new Mot();
                mot.Texte = txtMotAAjouter.Text;
                if (!lstLexique.Items.Contains(mot.Texte)){
                    lstLexique.Items.Add(mot.Texte); }
                mots.Add(mot);
                txtMotAAjouter.Clear();
                Serialisation.SaveJson(@"C:\Users\CDA\source\repos\Lexique.json", mots);
            }
            else
            {
                MessageBox.Show("La saisie de votre mot n'est pas valide, rentrer un mot sans chiffre, plus grand que 5 lettres et plus petit que 25", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtMotAAjouter_TextChanged(object sender, EventArgs e)
        {
            if (!Mot.IsMotOk(txtMotAAjouter.Text)) errorProvider1.SetError(txtMotAAjouter, "Ce mot ne peut pas contenir de chiffres, ni etre inférieur a 5 lettres ou supérieur a 25!!");
            else
                errorProvider1.Clear();

        }
        private void Lexique_Load(object sender, EventArgs e)
        {
            mots = (Mots)Serialisation.LoadJson(@"C:\Users\CDA\source\repos\Lexique.json", typeof(Mots));
            foreach (var item in mots)
            {
                lstLexique.Items.Add(item.Texte);
                
            }

        }

        private void Lexique_FormClosed(object sender, FormClosedEventArgs e)
        {
            singleLexique = null;
        }

       
        #endregion
    }
}
