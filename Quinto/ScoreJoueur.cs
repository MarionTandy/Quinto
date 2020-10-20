using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quinto
{
    [Serializable]
    class ScoreJoueur
    {

        private string _pseudo;
        private int _points;

        public string Pseudo { get => _pseudo; set => _pseudo = value; }
        public int Points { get => _points; set => _points = value; }

        public ScoreJoueur(string pseudo , int points) 
        {
            Pseudo = pseudo;
            Points = points;
        }

        public class TriAscendantHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                ScoreJoueur score1 = (ScoreJoueur)a;
                ScoreJoueur score2 = (ScoreJoueur)b;

                if (score1.Points > score2.Points)
                    return 1;

                if (score1.Points < score2.Points)
                    return -1;

                else
                    return 0;
            }
        }

        public static IComparer TriAscendant()
        {
            return (IComparer)new TriAscendantHelper();
        }

        public override string ToString()
        {
            return String.Format("{0} : {1}", Pseudo, Points); 
        }





        /*public static void SaveScore( ScoreJoueur score,Niveau niveauselectionne,List<ScoreJoueur> scorefacile, List<ScoreJoueur> scoredifficile, List<ScoreJoueur> scoreexpert)
        {

            switch ( niveauselectionne.Difficulte )
            {
                case "facile ":
                    scorefacile = (List<ScoreJoueur>)Serialisation.LoadJson(@"C:\Users\CDA\source\repos\Scorefacile.json", typeof(ScoreJoueur));
                    foreach (ScoreJoueur scoresave in scorefacile)
                    {

                    }
                    Serialisation.SaveJson(@"C:\Users\CDA\source\repos\Scorefacile.json", scorefacile);
                    break;

                case "difficile":
                    Serialisation.SaveJson(@"C:\Users\CDA\source\repos\Scoredifficile.json", scoredifficile);
                    break;

                case "expert":
                    Serialisation.SaveJson(@"C:\Users\CDA\source\repos\Scoreexpert.json", scoreexpert);
                    break;
            }
        }*/
        public static void VerifScore()
        {
            
        }
    }
}
