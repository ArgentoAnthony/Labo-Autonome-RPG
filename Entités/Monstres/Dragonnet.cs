using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entités.Monstres
{
    public class Dragonnet : Entite
    {
        public Dragonnet() : base("Dragonnet")
        {

            HpMax = 50;
            Hp = HpMax;
            DegatsMin = 10;
            DegatsMax = 15;
        }
    }
}
