using System;
using System.Collections.Generic;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie1();
            Zadanie2();
            
                
        }
        static void Zadanie1()
        {
            Book b1 = new Book("Obcy", new Person("AAAA", "BBBB", 11));
            //b1.title = "Obcy";
            //b1.author.firstName = "AAAA";
            //b1.author.lastName = "BBBB";
            b1.View();
            Reader czytelnik1 = new Reader("Ania", "Kowalska", 19);
            czytelnik1.AddBook(b1);
            czytelnik1.AddBook(new Book("W pustyni i puszczy", new Person("Henryk", "Sienkiewicz", 70)));
            czytelnik1.AddBook(new Book("Dawno temu w Warszawie", new Person("Jakub", "Zulczyk", 45)));
            czytelnik1.View();
            Reviewer r1 = new Reviewer("Andrii", "Petrunko", 18);
            r1.AddBook(new Book("W pustyni i puszczy", new Person("Henryk", "Sienkiewicz", 70)));
            r1.View();
            List<Person> osoby = new List<Person>();
            osoby.Add(czytelnik1);
            osoby.Add(r1);
            foreach (var osoba in osoby)
            {
                osoba.View();
            }
            AdventureBook ab1 = new AdventureBook("elo",new Person("Anna","Biała",10),"GoT");
            ab1.View();
            DocumentaryBook db1 = new DocumentaryBook("queen of hatred", new Person("Patryk", "Wyczawski", 41), 123);
            db1.View();
            
        }
        static void Zadanie2()
        {
            Samochod s1 = new Samochod("Audi", "A6", "nwm","zielony", 1999, 22);
            Samochod s2 = new Samochod();
            s1.SamochodInfo();
            SamochodOsobowy so1 = new SamochodOsobowy("BMW","X5","tak","fajny",1743,2.2,3,13.7,4);
            so1.SamochodInfo();
            
        }
        
    }
}
