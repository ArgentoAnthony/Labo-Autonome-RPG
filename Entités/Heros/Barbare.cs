using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entités.Heros
{
    public class Barbare : Classes
    {
        public Barbare(string nom) : base(nom)
        {
            HpMax = 150;
            DegatsMin = 10;
            DegatsMax = 15;
        }
    }
}
