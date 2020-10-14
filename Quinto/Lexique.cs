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
        private Lexique()
        {
            InitializeComponent();
        }

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
            Mot mot = new Mot();
            mot.Texte = txtMotAAjouter.Text;
            SaveJson(mot);
            txtMotAAjouter.Clear();


        }

        private void txtMotAAjouter_TextChanged(object sender, EventArgs e)
        {

        }

        public void SaveJson(Mot mot)
        {
            string filepath = @"C:\Users\CDA\source\repos\Lexique.json";
            JsonSerializer j = new JsonSerializer();
            using(StreamWriter sw = new StreamWriter(filepath,true))
            using(JsonWriter writer = new JsonTextWriter(sw)) { j.Serialize(writer, mot); }
        }
    }
}
