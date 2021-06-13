using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    public class Fietser : Sporter
    {

        public Fietser(string naam, DateTime geboorteDatum, Geslacht geslacht) : base(naam, geboorteDatum, geslacht)
        {

        }

        public override void Train()
        {
            base.Train();
            Belastbaarheid++;
        }
     
    }
}