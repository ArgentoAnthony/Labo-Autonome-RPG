using RPG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entités.Heros
{
    public abstract class Hero : Entite
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
        public Hero(string nom) : base(nom)
        {
            Niveau = 1;
            Experience = 0;
        }
       public void gagnerExperience(int experience)
        {
            this.Experience += experience;
            while(this.Experience >= ExperienceRequise )
            {
                Niveau++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Félicitations pour avez atteint le niveau {Niveau}");

                PvMax += (PvMax/5);
                Heal();
                DegatsMin += (DegatsMin/10);
                DegatsMax += (DegatsMax/10);

                Caracteristiques();
            }
        }
        public string Caracteristiques()
        {
            return this.Nom + "\n" +
                $"Points de vie : {Pv}/{PvMax} \n" +
                $"Niveau : {Niveau}\n" +
                $"Points d'expérience : {Experience} / {ExperienceRequise}\n" +
                $"Degats : [{DegatsMin} ; {DegatsMax}]";
        }

        public void Loot(Entite e)
        {
            if (e is IOr or) // Si l'entité possède l'interface Or
            {
                Console.WriteLine($"{this.Nom} obtient {or.Or} or ");
                this.Or += or.Or;
                Console.WriteLine($"{this.Nom} possède {Or} or");
            }
            if (e is ICuir c) // Si l'entité possède l'interface Or
            {
                Console.WriteLine($"{this.Nom} obtient {c.Cuir} {(c.Cuir == 1? "cuir" : "cuirs")} ");
                this.Cuir += c.Cuir;
                Console.WriteLine($"{this.Nom} possède {Cuir} {(Cuir == 1 ? "cuir" : "cuirs")} ");
            }
        }
        public void Heal()
        {
            Pv= PvMax;
        }

        //public double experienceRequise()
        //{
        //    // L'exp requise est donc (niveau³/5)*4 soit (0.8*N³). Formule utilise sur Pokémon
        //    return Math.Round(4 * (Math.Pow(Niveau, 3) / 5));
        //}

    }
}
