using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WF
{
    class Zhurnal : Biblioteka
    {
        public double Period { get; set; } //Періодичність
        public int Nomer { get; set; } //Номер
        public Zhurnal() { }
        public Zhurnal(string s)
        {
            string[] split = s.Split(new Char[] { '*' });

            Name = split[1].Trim();
            Tema = split[2].Trim();
            Period = int.Parse(split[3].Trim());
            Pages = int.Parse(split[4].Trim());
            Nomer = int.Parse(split[5].Trim());
            Year = int.Parse(split[6].Trim());
            Lang = split[7].Trim();
            Price = int.Parse(split[8].Trim());
        }
        public Zhurnal(string name, string tema, double period, int pages, int nomer,  int year,  string lang,  double price) : base(name, year, tema, lang, pages, price)
        {
            Period = period;
            Nomer = nomer;
        }
        public override double Over(double price, double period)
        {
            double costUnit = 0;
            Price = price;
            Period = period;
            //обчислити вартість 1 номеру журналу, якщо відомі кількість номерів на рік
            //і ціна річної підписки.
            costUnit = Price / Period;
            return costUnit;
        }
        public override string ToString()
        {
            return $"Name = {Name,22}, Tema = {Tema,25}, Period = {Period,2} на рік, Pages = {Pages,3},  Nomer = {Nomer,3}, Year = {Year}, Lang ={Lang,16}, Price = {Price,3} грн на рік.";
        }
    }
}
