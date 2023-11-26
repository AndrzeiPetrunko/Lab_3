using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class SamochodOsobowy : Samochod
    {
        public int Waga
        {
            get { return Waga; }
            set { if (Waga > 2 && Waga < 4.5) { this.Waga = value; } }
        }
        public SamochodOsobowy(string Marka, string Model, string Nadwozie, int rokProdukcji, int Przebieg) : base(Marka,Model,Nadwozie,rokProdukcji,Przebieg) { }
    }
}
