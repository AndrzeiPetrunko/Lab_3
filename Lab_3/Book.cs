﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Book
    {
        public string title {  set; get; }
        public Person author { protected set; get; }
        protected DateTime date;
        public Book()
        {
            author = new Person();
        }
        public void View()
        {
            Console.WriteLine($"Tytuł książki: {this.title}");
            Console.WriteLine($"Author: {author.firstName} {author.lastName}");
        }
    }
}