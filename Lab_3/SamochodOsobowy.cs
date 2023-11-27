using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class SamochodOsobowy : Samochod
    {
        private int _Waga;
        private double _PojemnoscSilnika;
        public int IloscOsob { set; get; }
        public double PojemnoscSilnika
        {
            get { return _PojemnoscSilnika; }
            set
            {
                if (value > 0.8 && value < 3.0)
                {
                    this._PojemnoscSilnika = value;
                }
            }
        }
        public int Waga
        {
            get { return Waga; }
            set { if (value > 2 && value < 4.5) { this.Waga = value; } else { Console.WriteLine("Waga jest za duża / za mała !"); } }
        }
        public SamochodOsobowy(string Marka, string Model, string Nadwozie, int rokProdukcji, int Przebieg, int Waga, double PojemnoscSilnika, int IloscOsob) : base(Marka, Model, Nadwozie, rokProdukcji, Przebieg)
        {
            this.Waga = Waga;
            this.PojemnoscSilnika = PojemnoscSilnika;
            this.IloscOsob = IloscOsob;
        }
    }
}
