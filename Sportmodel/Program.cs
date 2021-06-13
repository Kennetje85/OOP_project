using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Sporter Michiel = new Sporter("Michel", new DateTime(1973, 4, 12), Geslacht.man);
            Zwemmer Melita = new Zwemmer("Melita", new DateTime(1985, 4, 2), Geslacht.vrouw);
            Trainer rob = new Trainer("Rob", default(DateTime), Geslacht.man);

            Michiel.Belastbaarheid = 20;
            Melita.Belastbaarheid = 17;
            Console.WriteLine($"Belastbaarheid {Michiel.Naam}: {Michiel.Belastbaarheid}");
            Console.WriteLine($"Belastbaarheid {Melita}: {Melita.Belastbaarheid}");
            Console.WriteLine($"Trainer {rob.Naam} traint {Michiel.Naam}");
            Console.WriteLine($"Trainer {rob.Naam} traint {Melita.Naam}");
            rob.Train(Michiel);
            rob.Train(Melita);
            Console.WriteLine($"Belastbaarheid {Michiel.Naam}: {Michiel.Belastbaarheid}");
            Console.WriteLine($"Belastbaarheid {Melita.Naam}: {Melita.Belastbaarheid}");
            Melita.ZoekHulp(rob, Michiel);
        }
    }
}
