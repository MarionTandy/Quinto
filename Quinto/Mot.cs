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
        public static bool IsMotOk(string value)
        {
            
            if (value == null || value.Length < 5 || value.Length > 25) return false;
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]) && value[i] != '-') return false;
            }
            return true;
        }

        public static int Count(Mot mot)
        {
            int count = 0; 
            foreach (char c in mot.Texte)
            {
                count ++; 
            }

            return count; 
        }

    }

}
