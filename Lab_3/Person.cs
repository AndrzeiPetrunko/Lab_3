using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Person
    {
        public string firstName {  set;  get; }
        public string lastName {  set;  get; }
        protected int age;
        public int getAge()
        {
            return age;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void View()
        {
            Console.WriteLine($"Imię osoby: {this.firstName} Nazwisko: {this.lastName} Wiek: {this.age}");
        }


    }
}
