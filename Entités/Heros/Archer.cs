using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entités.Heros
{
    public class Archer : Classes
    {
        public Archer(string nom) : base(nom)
        {
            HpMax = 100;
            DegatsMin = 15;
            DegatsMax = 20;
        }
    }
}
