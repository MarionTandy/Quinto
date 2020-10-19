using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Quinto
{
    [Serializable]
    public class Mots : HashSet<Mot>
    {
        public static HashSet<Mot> TrierMotsFaciles(Mots motsATrier)
        {
            HashSet<Mot> motsFaciles = new HashSet<Mot> ();
            foreach (Mot mot in motsATrier)
            {
                if ((Mot.Count(mot) >= 5) && (Mot.Count(mot) < 8))
                {
                    motsFaciles.Add(mot);
                }
            }
            return motsFaciles;
        }

        public static HashSet<Mot> TrierMotsDifficiles(Mots motsATrier)
        {
            HashSet<Mot> motsDifficiles = new HashSet<Mot>();
            foreach (Mot mot in motsATrier)
            {
                if ((Mot.Count(mot) >= 8) && (Mot.Count(mot) <= 10))
                {
                    motsDifficiles.Add(mot);
                }
            }
            return motsDifficiles;
        }

        public static HashSet<Mot> TrierMotsExperts(Mots motsATrier)
        {
            HashSet<Mot> motsExperts = new HashSet<Mot>();
            foreach (Mot mot in motsATrier)
            {
                if ((Mot.Count(mot) > 10))
                {
                    motsExperts.Add(mot);
                }
            }
            return motsExperts;
        }

    }
}
