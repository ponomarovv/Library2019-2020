using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WF
{
    class Kniga : Biblioteka
    {
        public string Author { get; set; } // Автор
        public string Publisher { get; set; } //Видання
        public Kniga() { }
        public Kniga(string s)
        {
            string[] split = s.Split(new Char[] { '*' });

            Name = split[1].Trim();
            Author = split[2].Trim();
            Tema = split[3].Trim();
            Year = int.Parse(split[4].Trim());
            Publisher = split[5].Trim();
            Lang = split[6].Trim();
            Pages = int.Parse(split[7].Trim());
            Price = int.Parse(split[8].Trim());
        }
        public Kniga(string name, string author, string tema, int year, string publisher, string lang, int pages, double price) : base(name, year, tema, lang, pages, price)
        {
            Author = author;
            Publisher = publisher;
        }
        public override double Over(double price, double year)
        {
            double costUnit = 0;
            Price = price;

            //рахуємо платіж на кожний з 6-и місяців безвідсоткового кредиту.
            costUnit = Price / 6;
            return costUnit;
        }
    }
}