using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    public class Zwemmer : Sporter
    {

        public Zwemmer(string naam, DateTime geboorteDatum, Geslacht geslacht) : base(naam, geboorteDatum, geslacht)
        {

        }

        public override void Train()
        {
            
            Belastbaarheid += 3;
        }
    }
}