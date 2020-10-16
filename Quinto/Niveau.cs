using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quinto
{
    public class Niveau
    {
        private int _nbmanche;
        private int _longueurdesmots;
        private int nberreurs;

        public int Nbmanche { get => _nbmanche; set => _nbmanche = value; }
        public int Longueurdesmots { get => _longueurdesmots; set => _longueurdesmots = value; }
        public int Nberreurs { get => nberreurs; set => nberreurs = value; }

        public static bool IsMotFacile(string value)
        {
            if (value.Length >= 5 && value.Length <= 8) return true;
            return false;
        }

        public Niveau() { }


    }
    public class Facile : Niveau
    {
        public Facile()
            : base()
        {
            Nbmanche = 3;
            Longueurdesmots = /*IsMotFacile(Longueurdesmots);*/
            Nberreurs = 7;
        }
            
            
        
    }
    public class Difficile : Niveau
    {
        public Difficile()
            : base()
        {
            Nbmanche = 4;

            Nberreurs = 7;

        }
        
    }
    public class Expert : Niveau
    {
        public Expert() 
            :base()
        {
            Nbmanche = 5;

            Nberreurs = 7;
        }
        
    }
}
