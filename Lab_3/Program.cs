﻿using System;

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
            b1.View();


        }
    }
}
