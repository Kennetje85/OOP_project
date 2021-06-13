using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    public class Hardloper: Sporter
    {

        public Hardloper(string naam, DateTime geboorteDatum, Geslacht geslacht, float gewicht, int belastbaarheid) : base(naam, geboorteDatum, geslacht,gewicht,belastbaarheid)
        {
            
        }

        public Hardloper(string naam, DateTime geboorteDatum, Geslacht geslacht) : base(naam, geboorteDatum, geslacht)
        {
            Belastbaarheid = 0;
        }
    }
}
