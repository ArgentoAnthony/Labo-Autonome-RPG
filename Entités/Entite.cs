using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entités
{
    public class Entite
    {
        public string Nom { get; protected set; }
        public int HpMax { get; protected set; }
        public int Hp { get; protected set; }
        public int DegatsMin { get; protected set; }
        public int DegatsMax { get; protected set; }

        public Entite(string nom)
        {
            Nom = nom;
        }

        public void Attaquer()
        {

        }
        //Attaquer
        // Perdrepdv
        // Mort
    }
}
