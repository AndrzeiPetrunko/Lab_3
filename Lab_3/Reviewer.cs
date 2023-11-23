using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Reviewer : Reader
    {
        public Reviewer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }
        public void Wypisz()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Użytkownik nie posiada książek!");
                return;
            }
            

            Console.WriteLine("Lista przeczytanych książek:");
            foreach (var book in books)
            {
                book.View();
                
            }

        }
    }
}
