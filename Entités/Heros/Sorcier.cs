using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entités.Heros
{
    public class Sorcier : Classes
    {
        public Sorcier(string nom) : base(nom)
        {
            HpMax = 80;
            DegatsMin = 15;
            DegatsMax = 25;
        }
    }
}
