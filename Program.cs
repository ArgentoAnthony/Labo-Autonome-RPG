using RPG.Entités.Heros;
using RPG.Entités.Images;
using RPG.Entités.Monstres;

Menu();


static void Jouer(Hero monPerso)
{
    bool victoire = true;
    bool suivant = false;
    List<Monstre> monstres = new List<Monstre>();

    for (int i= 0; i < 100; i++)
    {
        Random r = new Random();
        int rng = r.Next(100);
        //switch (rng)
        //{
        //    case <= 10:
        //        Monstre loup = new Loup();
        //        monstres.Add(loup);
        //        break;
        //    case >10:
        //        Monstre orc = new Orc();
        //        monstres.Add(orc);
        //        break;
        //    case >17:
        //        Monstre dragon = new Dragon();
        //        monstres.Add(dragon);
        //        break;
        //}
        if (rng < 50)
        {
            Monstre loup = new Loup();
            monstres.Add(loup);
        }
        else if (rng >= 50 && rng <99)
        {
            Monstre orc = new Orc();
            monstres.Add(orc);
        }
        else
        {
            Monstre dragon = new Dragon();
            monstres.Add(dragon);
        }


    }
    
    for (int i= 0; i<monstres.Count; i++)
    {
        while (!monstres[i].estMort())
        {            
            if (monPerso.estMort())
            {
                victoire = false;
                break;
            }
            // Tour du personnage
            Console.ForegroundColor = ConsoleColor.Green;
            monPerso.Attaquer(monstres[i]);
            Console.WriteLine();
            //Console.ReadKey(true);

            if (!monstres[i].estMort())
            {
                //tour du monstre
                Console.ForegroundColor = ConsoleColor.Red;
                monstres[i].Attaquer(monPerso);
                Console.WriteLine();
                //Console.ReadKey(true);
            }
            
        }
        if (victoire)
        {
            if (monstres[i] is Loup) { monPerso.gagnerExperience(10); }
            else if (monstres[i] is Orc) { monPerso.gagnerExperience(20); }
            else { monPerso.gagnerExperience(50); }
            monPerso.Loot(monstres[i]);
            monstres.RemoveAt(i);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.Write(monPerso.Caracteristiques());

            Console.ForegroundColor = (ConsoleColor)ConsoleColor.Yellow;
            Console.WriteLine();

            //while (!suivant)
            //{
            //    Console.WriteLine("Salle suivante? O/N");
            //    string saisie = Console.ReadLine().ToUpper();
            //    if(saisie == "O")
            //    {
            //        suivant = true;
            //        Jouer(monPerso);
            //    }
            //    else if (saisie == "N")
            //    {
            //        Environment.Exit(0);
            //    }
            //}
        }
        else
        {
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine("c'est perdu...");
            Console.WriteLine($"Vous avez battu {100-monstres.Count} monstres");
            DeadImg.AfficheImg();
            break;
            Console.WriteLine();
        }
    }
 
    if(!monPerso.estMort())
    {
        Console.WriteLine("Salle suivante? O/N");
        string saisie = Console.ReadLine().ToUpper();
        if (saisie == "O")
        {
            suivant = true;
            Jouer(monPerso);
        }
        else if (saisie == "N")
        {
            Environment.Exit(0);
        }
    }
        




}

static void Menu()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Le jeu");
    Console.WriteLine();
    Console.WriteLine("Quel est ton pseudo?");
    string pseudo = Console.ReadLine();
    Console.WriteLine("Choisis ta classe");
    Console.WriteLine("1. Barbare");
    Console.WriteLine("2. Sorcier");
    Console.WriteLine("3. Archer");
    Console.WriteLine("4 Quitter");
    Console.WriteLine();

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Vous avez choisis Barbare!");
            Console.WriteLine();
            Jouer(new Barbare(pseudo));
            break;
        case "2":
            Console.WriteLine("Vous avez choisis Sorcier!");
            Console.WriteLine();
            Jouer(new Sorcier(pseudo));
            break;
        case "3":
            Console.WriteLine("Vous avez choisis Archer!");
            Console.WriteLine();
            Jouer(new Archer(pseudo));
            break;
        case "4":
            break;
    }
}
