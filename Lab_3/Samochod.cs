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
        public int rokProdukcji { get; set; }
        private int _Przebieg;
        public int Przebieg
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
        public Samochod(string Marka, string Model, string Nadwozie, int rokProdukcji, int Przebieg)
        {
            this.Marka = Marka;
            this.Model = Model;
            this.Nadwozie = Nadwozie;
            this.rokProdukcji = rokProdukcji;
            this.Przebieg = Przebieg;
        }
    }
}
