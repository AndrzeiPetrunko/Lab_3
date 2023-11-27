using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Nadwozie { get; set; }
        public string Kolor { set; get; }
        public int rokProdukcji { get; set; }
        private double _Przebieg;
        public double Przebieg
        {
            get { return _Przebieg; }
            set
            {
                if (value > 0)
                {
                    this._Przebieg = value;
                }
                else
                {
                    Console.WriteLine("Przebieg nie może być ujemny !");
                }
            }
        }
        public Samochod(string Marka, string Model, string Nadwozie, string Kolor, int rokProdukcji, double Przebieg)
        {
            this.Marka = Marka;
            this.Model = Model;
            this.Nadwozie = Nadwozie;
            this.Kolor = Kolor;
            this.rokProdukcji = rokProdukcji;
            this.Przebieg = Przebieg;
        }
        public virtual void SamochodInfo()
        {
            Console.WriteLine($"Marka oraz model: {this.Marka} {this.Model}");
            Console.WriteLine($"Nadwozie, kolor: {this.Nadwozie}, {this.Kolor}");
            Console.WriteLine($"Rok produkcji i obecny przebieg: {this.rokProdukcji} ({this.Przebieg}km)");
        }
    }
}
