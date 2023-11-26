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
        public int _Przebieg;
        public int Przebieg
        {
            get { return _Przebieg; }
            set
            {
                if ( Przebieg > 0)
                {
                    this._Przebieg = Przebieg;
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
