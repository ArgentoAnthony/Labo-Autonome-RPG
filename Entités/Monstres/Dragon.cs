using RPG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entités.Monstres
{
    public class Dragon : Monstre, IOr, ICuir
    {
        public int Cuir { get; } = GestionDés.Lancer(TypeDés.D10);
        public int Or { get; } = GestionDés.Lancer(TypeDés.D20);
        public Dragon() : base("Dragon") { }

        public override void GenererStats()
        {
            PvMax = 105;
            DegatsMin = 20;
            DegatsMax = 25;
        }
    }
}
