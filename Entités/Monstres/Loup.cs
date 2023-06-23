using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entités.Monstres
{
    public class Loup : Entite
    {
        public Loup() : base("Loup")
        {

            HpMax = 50;
            Hp = HpMax;
            DegatsMin = 10;
            DegatsMax = 15;
        }
    }
}
