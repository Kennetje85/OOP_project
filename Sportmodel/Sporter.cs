using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    public class Sporter: Persoon
    {
  
        private Geslacht _geslacht;
        private float _gewicht;
    

        public float Gewicht
        {
            get
            {
                return _gewicht;
            }
            set
            {
                if (value > 0)
                {
                    _gewicht = value;
                }
            }
        }

        public DateTime GeboorteDatum
        {
            get;
        }

       

        public int Belastbaarheid { get; set; }
        public string Naam { get; set; }
        public DateTime geboorteDatum { get; }
      //  public string WedstrijdNaam => $"{Naam} ({_geslacht.ToString().Substring(0, 1)}{Leeftijd})";


        public Sporter(string naam, DateTime geboorteDatum, Geslacht geslacht): base(naam,geboorteDatum,geslacht)
        {
            Belastbaarheid = 0;
        }

        public Sporter(string naam, DateTime geboorteDatum, Geslacht geslacht, float gewicht, int belastbaarheid) : base(naam, geboorteDatum, geslacht)
        {
            _gewicht = gewicht;
            Belastbaarheid = belastbaarheid;
        }

        public virtual void Train()  //add virtual for methods override 
        {
            Belastbaarheid++;
        }

        public void Wedstrijd()
        {
            Belastbaarheid++;
        }

        public void ZoekHulp(IEhbo reanimator, Persoon slachtoffer)
        {
            reanimator.Reanimeer(slachtoffer);
        }
    }
}
