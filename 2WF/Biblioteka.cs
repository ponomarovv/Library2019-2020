using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WF
{
    class Biblioteka
    {  
        public string Name { get; set; } // Назва
        public int Year { get; set; } // Рік видання
        public string Tema { get; set; } // Тематика
        public string Lang { get; set; } // Мова
        public int Pages { get; set; } // Сторінок
        public double Price { get; set; } // Ціна
        public Biblioteka() { }
        public Biblioteka(string name, int year, string tema, string lang, int pages, double price)
        {
            Name = name;
            Year = year;
            Tema = tema;
            Lang = lang;
            Pages = pages;
            Price = price;
        }
        public virtual double Over(double price, double period)
        {
            return price;
        }
    }
}
