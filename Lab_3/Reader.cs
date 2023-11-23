using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Reader : Person
    {
        protected List<Book> books;
        public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            books = new List<Book>();
        }
        public void AddBook(Book b)
        {
            books.Add(b);
        }
        public void ViewBooks()
        {
            if(books.Count == 0)
            {
                Console.WriteLine("Użytkownik nie posiada książek!");
                return;
            } else
            {
                Console.WriteLine("Lista przeczytanych książek:");
                foreach(var book in books)
                {
                    book.View();
                }
            }
        }
    }
}
