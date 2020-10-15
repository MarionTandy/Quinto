using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

        public Niveau()
        {

        }

    }
    public class Facile : Niveau
    {
        
    }
    public class Difficile : Niveau
    {

    }
    public class Expert : Niveau
    {

    }
}
