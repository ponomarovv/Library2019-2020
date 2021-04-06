/////////////////////////////////
//Для опису журналів у файлі потрібно зберігати таку інформацію:
//-	назва(наприклад, «Мир ПК»);
//-	тематика(наприклад, комп’ютери, мережі тощо);
//-	періодичність(кількість випусків на рік);
//-	кількість сторінок;
//-	номер;
//-	рік;
//-	мова;
//-	вартість підписки на рік.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проект1
{
    class Zhurnal : Biblioteka
    {
        public double Period { get; set; } //Періодичність видання. Скілки разів на рік.
        public int Nomer { get; set; } //Номер журналу.
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
        public Zhurnal(double period, int nomer, string name, int year, string tema, string lang, int pages, int price) : base(name, year, tema, lang, pages, price)
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
            return $"Назва = {Name,22}, Тематика = {Tema,25}, Періодичність = {Period,2} на рік, Сторінок = {Pages,3},  Номер = {Nomer,3}, Рік виходу = {Year}, Мова ={Lang,16}, Ціна на рік = {Price,3} грн.";
        }
    }
}
