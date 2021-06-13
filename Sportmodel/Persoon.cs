using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    public class Persoon
    {
        public string Naam { get; set; }
        protected Geslacht _geslacht;
        public DateTime GeboorteDatum { get; }

        public Persoon(string naam, DateTime geboorteDatum, Geslacht geslacht)
        {
            Naam = naam;
            GeboorteDatum = geboorteDatum;
            _geslacht = geslacht;

        }

        public int Leeftijd
        {
            get
            {
                DateTime vandaag = System.DateTime.Today;
                int leeftijd = vandaag.Year - GeboorteDatum.Year;

                if (vandaag.Month < GeboorteDatum.Month || (vandaag.Month == GeboorteDatum.Month && vandaag.Day < GeboorteDatum.Day))
                {
                    leeftijd--;
                }
                return leeftijd;
            }
        }
    }
}