using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quinto
{
    public class Niveau
    {
        private string _difficulte; 
        private int _nbManches;
        private string _longueurDesMots;
        private int _nbErreurs;

        public int NbManches { get => _nbManches; set => _nbManches = value; }
        public string LongueurDesMots { get => _longueurDesMots; set => _longueurDesMots = value; }
        public int NbErreurs { get => _nbErreurs; set => _nbErreurs = value; }
        public string Difficulte { get => _difficulte; set => _difficulte = value; }

        public Niveau(int nbManches, string longueurDesMots, int nbErreurs)
        {
            NbManches = nbManches;
            LongueurDesMots = longueurDesMots;
            NbErreurs = nbErreurs;

        }

        public static Niveau SelectionnerNiveau(RadioButton rdb1, RadioButton rdb2, RadioButton rdb3)
        {
            if (rdb1.Checked)
            {
                    return new Niveau(1, "courts", 10);
            }
            if (rdb2.Checked)
            {
                        return new Niveau(4, "moyens", 9);
            }
            if (rdb3.Checked)
            {
                      return new Niveau(5, "longs", 8);
            }
            else
            {
               throw new ApplicationException
               ("La selection du niveau n'est pas valide. Veuillez selectionner un des trois niveaux proposés");
            }
                        
        }
    }
   
}
