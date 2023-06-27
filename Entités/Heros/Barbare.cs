using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entités.Heros
{
    public class Barbare : Hero
    {
        public Barbare(string nom) : base(nom) { }

        public override void GenererStats()
        {
            PvMax = 150;
            DegatsMin = 10;
            DegatsMax = 15;
        }
    }
}
