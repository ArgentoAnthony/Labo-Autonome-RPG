using RPG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entités.Monstres
{
    public class Loup : Monstre, ICuir
    {
        public int Cuir { get; } = GestionDés.Lancer(TypeDés.D4);
        public Loup() : base("Loup") { }

        public override void GenererStats()
        {
            PvMax = 50;
            DegatsMin = 10;
            DegatsMax = 15;
        }
    }
}
