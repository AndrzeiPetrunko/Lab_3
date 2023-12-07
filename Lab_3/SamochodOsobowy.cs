using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class SamochodOsobowy : Samochod
    {
        private double _Waga;
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
        public double Waga
        {
            get { return Waga; }
            set { if (value > 2.0 && value < 4.5) { this._Waga = value; } else { Console.WriteLine("Waga jest za duża / za mała !"); } }
        }
        public SamochodOsobowy(string Marka, string Model, string Nadwozie, string Kolor, int rokProdukcji, double Przebieg, double Waga, double PojemnoscSilnika, int IloscOsob) : base(Marka, Model, Nadwozie, Kolor, rokProdukcji, Przebieg)
        {
            this.Waga = Waga;
            this.PojemnoscSilnika = PojemnoscSilnika;
            this.IloscOsob = IloscOsob;
        }
        public SamochodOsobowy() : base()
        {
            Console.WriteLine("Stworzyłeś samochód osobowy !!!");
        }
        public override void SamochodInfo()
        {
            base.SamochodInfo();
        }
    }
}
