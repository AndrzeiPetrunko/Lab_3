using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class AdventureBook : Book
    {
        public string Series { set; get; }
        Random rand = new Random();
        public AdventureBook(string tytul, Person author, string Series) : base(tytul, author)
        {
            this.author = author;
            this.Series = Series;
        }
        public override void View()
        {
            Console.WriteLine($"Tytuł książki: {this.title} ({DateTime.Parse(DateTime.Now.ToString()).Year.ToString()})\nAuthor: {author.firstName} {author.lastName}\nOcena: {rand.Next(0, 10)}");
            Console.WriteLine();
        }
    }
}
