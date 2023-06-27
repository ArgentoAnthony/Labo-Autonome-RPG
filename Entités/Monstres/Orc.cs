using RPG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entités.Monstres
{
    public class Orc : Monstre, IOr
    {
        public int Or { get; } = GestionDés.Lancer(TypeDés.D6);
        public Orc() : base("Orc") { }
        public override void GenererStats()
        {
            PvMax = 80;
            DegatsMin = 15;
            DegatsMax = 20;
        }
    }
}
