using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    public class Trainer: Persoon, IEhbo
    {
        public Trainer(string naam,DateTime geboorteDatum, Geslacht geslacht): base(naam,geboorteDatum, geslacht)
        {

        }

        public bool Reanimeer(Persoon persoon)
        {
            Console.WriteLine($"{Naam} heeft {persoon.Naam} gereanimeerd!");
            return true;
        }

        public void Train(Sporter sporter)
        {
            int b1 = sporter.Belastbaarheid;
            sporter.Train();
            int b2 = sporter.Belastbaarheid;
            Console.WriteLine($"{Naam} trainde  {sporter.Naam} ({sporter.GetType().Name}):belastbaarheid nam { b2 - b1} toe");
        }
    }
}
