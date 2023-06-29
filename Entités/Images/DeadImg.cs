using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RPG.Entités.Images
{
    public class DeadImg
    {
        public static string Dead = @"
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓          ▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓                 ▓▓▓▓▓
▓▓▓▓▓▓  ▓▓▓         ▓▓▓   ▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓    ▓▓▓▓▓▓▓ ▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓   ▓▓▓▓▓▓▓▓▓▓ ▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓   ▓▓▓▓▓▓▓▓▓▓ ▓▓
▓▓▓ ▓▓▓▓▓▓▓▓▓▓   ▓▓▓▓▓▓▓▓▓▒ ▓▓
▓▓▓    ▓▓▓▓    ▓    ▓▓▓▓    ▓▓
▓▓▓▓▓        ▓▓▓▓         ▓▓▓▓
▓▓▓▓▓▓        ▓▓         ▓▓▓▓▓
▓▓▓▓▓▓▓▓    ▓           ▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓  ▓    ▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓           ▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
";
        public static void AfficheImg()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(DeadImg.Dead);
        }

    }
}
