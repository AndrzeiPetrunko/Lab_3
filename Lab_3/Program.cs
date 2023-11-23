using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                Book b1 = new Book();
                b1.title = "Obcy";
                b1.author.firstName = "AAAA";
                b1.author.lastName = "BBBB";
               // b1.View();
            Reader czytelnik1 = new Reader("Ania", "Kowalska", 19);
            czytelnik1.AddBook(b1);
            czytelnik1.AddBook(new Book("W pustyni i puszczy", new Person("Henryk", "Sienkiewicz", 70)));
            czytelnik1.AddBook(new Book("Dawno temu w Warszawie", new Person("Jakub", "Zulczyk", 45)));
            czytelnik1.ViewBooks();
            Console.ReadKey();
        }
        
    }
}
