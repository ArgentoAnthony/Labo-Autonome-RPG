using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entités.Heros
{
    public class Sorcier : Hero
    {
        public Sorcier(string nom) : base(nom) { }
        public override void GenererStats()
        {
            PvMax = 80;
            DegatsMin = 15;
            DegatsMax = 25;
        }
    }
}
