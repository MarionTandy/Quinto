using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinto
{
    [Serializable]
    public class Mot
    {
        int longueur = 0;
        string texte;
        string motajouter;

        public string Texte { get => texte; set => texte = value; }
        //public string Motajouter
        //{
        //    get => motajouter; set
        //    {
        //        if (!IsMotOk(value)) throw new Exception("le mot n'est pas valide");
        //        this.motajouter = value;
        //    }
        //}

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
        public static bool IsMotOk(string value)
        {
            if (value == null || value.Length< 5 || value.Length > 25) return false;
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i])) return false;
            }
            return true;
        }

    }

}
