using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entités.Heros
{
    public class Classes : Entite
    {
        public int Or { get; protected set; }
        public int Cuir { get; protected set; }
        public int Niveau { get; protected set; }
        public int Experience { get; protected set; }

        //public double ExperienceRequise { get => Math.Round(4 * (Math.Pow(Niveau, 3) / 5)); }
        public double ExperienceRequise
        {
            get
            {
                return Math.Round(4 * (Math.Pow(Niveau, 3) / 5));
                //return experienceRequise();
            }
        }



        public Classes(string nom) : base(nom)
        {
            Nom = nom;
            Niveau = 1;
            Experience = 0;
        }
        //TO DO Gagner exp


        //public double experienceRequise()
        //{
        //    // L'exp requise est donc (niveau³/5)*4 soit (0.8*N³). Formule utilise sur Pokémon
        //    return Math.Round(4 * (Math.Pow(Niveau, 3) / 5));
        //}


        // TO DO override tostring Caractéristiques
    }
}
