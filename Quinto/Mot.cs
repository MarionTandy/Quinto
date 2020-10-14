using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinto
{
    public class Mot
    {
        int longueur = 0;
        string texte;

        public string Texte { get => texte; set => texte = value; }


        public Mot() { }

        public override bool Equals(object obj)
        {
            Mot tocompare = obj as Mot;
            return (this.Texte == tocompare.Texte);

        }
        public override int GetHashCode()
        {
            return (texte != null) ? texte.GetHashCode() : 0;
        }
    }

}
