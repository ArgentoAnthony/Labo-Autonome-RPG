using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public enum TypeDés
    {
        D4 = 4,
        D6 = 6,
        D8 = 8,
        D10 = 10,
        D20 = 20,
        D100 = 100
    }
    public class GestionDés
    {
        private static int Lance(TypeDés d)
        {
            Random r = new Random();
            return r.Next((int)d) + 1;
            // Va renvoyer la valeur comprise entre 0 et la taille du dé
        }
        public static int Lancer(TypeDés d, int nbDice = 1, int nbToKeep = 1)
        {
            Random r = new Random();
            List<int> throws = new List<int>();

            for (int i = 0; i < nbDice; i++)
            {
                throws.Add(Lance(d));
            }
            return throws.OrderByDescending(nb => nb).Take(nbToKeep).Sum();
        }
    }
}
