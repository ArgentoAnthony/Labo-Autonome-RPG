using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entités
{
    public abstract class Entite
    {
        public string Nom { get; protected set; }
        public int PvMax { get; protected set; }
        public int Pv { get; protected set; }
        public int DegatsMin { get; protected set; }
        public int DegatsMax { get; protected set; }

        protected bool EstMort = false;

        protected Random Random = new Random();

        public  Entite(string nom)
        {
            Nom = nom;
            GenererStats();
            Pv = PvMax;
        }

        public void Attaquer(Entite cible)
        {
            int degats = Random.Next(DegatsMin,DegatsMax);

            cible.PerdrePointsDeVie(degats);
            Console.WriteLine($"{this.Nom} attaque {cible.Nom}");
            Console.WriteLine($"{cible.Nom} a perdu {degats} points de vie");
            Console.WriteLine($"Il reste {cible.Pv} points de vie à {cible.Nom}");
            if(cible.EstMort)
            {
                Console.WriteLine(cible.Nom +" est mort");
            }

        }
        //Attaquer
        protected void PerdrePointsDeVie(int Pv)
        {
            this.Pv -= Pv;
            if(this.Pv <= 0)
            {
                this.Pv = 0;
                EstMort = true;
            }
        }
        public bool estMort()
        {
            return this.EstMort;
        }
        public abstract void GenererStats();
        

        
    }
}
