using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class DocumentaryBook : Book
    {
        public int price { get; set; }
        public DocumentaryBook(string tytul, Person author, int price) : base(tytul, author)
        {
            this.price = price;
        }
        public override void View()
        {
            Console.WriteLine($"Cena: {this.price}");
            base.View();
        }
    }
}
