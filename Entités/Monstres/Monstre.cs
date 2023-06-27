using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entités.Monstres
{
    public abstract class Monstre : Entite
    {
        public Monstre(string nom) : base(nom)
        {
        }
    }
}
