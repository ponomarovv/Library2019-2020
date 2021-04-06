//ТМ, как сделать если повторяются? В 2

//Для опису книжок у файлі потрібно зберігати таку інформацію:
//-	назва;
//-	автор;
//-	тематика(наприклад, техніка, детективи, фентезі);
//-	рік видання;
//-	видавництво;
//-	мова;
//-	кількість сторінок;
//-	вартість.

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

///////////////////////
//Реалізувати функції програми:

//-	додавання, видалення літератури;
//-	редагування даних про літературу;
//-	перегляд назв книг, впорядкованих за абеткою;
//-	відбір журналів з комп’ютерної тематики; 
//-	вибір тільки журналів; 
//-	пошук журналу за номером; 
//-	пошук книг за автором;
//-	обчислення вартості одного номеру журналу при заданій ціні за рік;
//-	якщо вартість книжки більше 300 гривень, можна купити в кредит.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace проект1
{

    class Program
    {        
        static List<Kniga> knList = new List<Kniga>();
        static List<Zhurnal> zhuList = new List<Zhurnal>();
                     
        //запихиваем содержимое файла в два листа. Лист книг и лист журналов.
        static void Doit()
        {
            knList.Clear();
            zhuList.Clear();
            string s;
            int Oznaka_bib;  //ознака видання: 1 - книга, 2 - журнал  
            using (StreamReader f = new StreamReader("библиотека1.txt"))
            {
                while ((s = f.ReadLine()) != null)
                {
                    string[] split = s.Split(new Char[] { '*' });
                    Oznaka_bib = int.Parse(split[0].Trim());
                    if (Oznaka_bib == 1)
                    {
                        knList.Add(new Kniga(s));
                    }
                    else
                    if (Oznaka_bib == 2)
                    {
                        zhuList.Add(new Zhurnal(s));
                    }
                }
            }
        }
        //выводим только книги.
        static void WRkn(List<Kniga> b)
        {
            Console.WriteLine("Список книг");
            foreach (var a in b)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
        }
        //выводим только журналы, без сортировки.
        static void WRzh(List<Zhurnal> b)
        {
            Console.WriteLine("Список журналів");
            foreach (var a in b)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
        }
        //cписок дел.
        static void SD()
        {
            string s = "";
            do
            {
                Doit();
                int x;
            label0:
                Console.WriteLine("Що будемо робити? Введи число або введи літеру q, щоб вийти.");
                Console.WriteLine("0. Подивимося список книг і журналів?");
                Console.WriteLine("1. Додавання літератури.");
                Console.WriteLine("2. Видалення літератури.");
                Console.WriteLine("3. Редагування даних про літературу.");
                Console.WriteLine("4. Перегляд назв книг, впорядкованих за абеткою.");
                Console.WriteLine("5. Відбір журналів з комп’ютерної тематики.");
                Console.WriteLine("6. Вибір тільки журналів.");
                Console.WriteLine("7. Пошук журналу за номером.");
                Console.WriteLine("8. Пошук книг за автором.");
                Console.WriteLine("9. Обчислення вартості одного номеру журналу при заданій ціні за рік.");
                Console.WriteLine("10. Якщо вартість книжки більше 300 гривень, можна купити в кредит.");                
                Console.WriteLine();
                s = Console.ReadLine();                
                if (s.ToLower() == "q") 
                {
                    goto exit;
                }
                try
                {
                    x = int.Parse(s);
                }
                catch
                {
                    goto label0;
                }
                Console.WriteLine();
                switch (x)
                {
                    case 0:
                        WRkn(knList);
                        WRzh(zhuList);
                        break;

                    case 1:
                        Case1();
                        break;
                    case 2:
                        Case2();
                        break;
                    case 3:
                        Case3();
                        break;
                    case 4:
                        Case4();
                        break;
                    case 5:
                        Case5();
                        break;
                    case 6:
                        Case6();
                        break;
                    case 7:
                        Case7();
                        break;
                    case 8:
                        Case8();
                        break;
                    case 9:
                        Case9();
                        break;
                    case 10:
                        Case10();
                        break;

                    default:
                        Console.WriteLine("default");
                        break;
                }
            exit:;
            } while (s.ToLower() != "q");
        }
        //додавання літератури
        static void Case1()
        {
            string s;
            Console.WriteLine("Введіть нову строку в форматі:");
            Console.WriteLine("Для книги  : 1*назва*автор*тематика*рік видання*видавництво*мова*к-сть сторінок*вартість");
            Console.WriteLine("Для журналу: 2*назва*тематика*періодичність*к-сть сторінок*номер*рік*мова*вартість на рік");
            s = Console.ReadLine();
            Console.WriteLine(s);
            Console.ReadLine();
            using (StreamWriter f1 = new StreamWriter("библиотека1.txt", append: true))
            {
                f1.WriteLine(s);
            }
        }
        //видалення літератури
        static void Case2()
        {
            Console.WriteLine("Введіть назву книги або журналу:");
            string s = Console.ReadLine();
            int knListCount = knList.Count();
            int zhuListCount = zhuList.Count();
            knList.RemoveAll(x => x.Name.ToLowerInvariant() == s.ToLowerInvariant());
            zhuList.RemoveAll(x => x.Name.ToLowerInvariant() == s.ToLowerInvariant());            
            string ss;
            //переписуємо файл
            using (StreamWriter f1 = new StreamWriter("библиотека1.txt"))
            {                
                foreach (var a in knList)
                {
                    ss = $"1*{a.Name}*{a.Author}*{a.Tema}*{a.Year}*{a.Publisher}*{a.Lang}*{a.Pages}*{a.Price}";                    
                    f1.WriteLine(ss);
                }
                foreach (var a in zhuList)
                {
                    ss = $"2*{a.Name}*{a.Tema}*{a.Period}*{a.Pages}*{a.Nomer}*{a.Year}*{a.Lang}*{a.Price}";
                    f1.WriteLine(ss);                    
                }                
            }
        }

        //"-3. Редагування даних про літературу.");
        static void Case3()
        {
            int x, y, z;
            string s3;            
        label31:
            Console.WriteLine("Редагуємо книгу(1) чи журнал(2)? Введіть цифру:");
            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch 
            {
                goto label31;
            }
            if ((x != 1) && (x != 2))
            {
                goto label31;
            }
        label32:
            Console.WriteLine("Введіть номер рядка, який будемо редагувати:");
            try
            {
                y = int.Parse(Console.ReadLine());
            }
            catch
            {
                goto label32;
            }
            y = y - 1; 
            try
            {
                s3 = knList[y].Name;
                s3 = zhuList[y].Name;
            }
            catch
            {
                goto label32;
            }
            //книгу
            if (x == 1)
            {
            label33:
                Console.WriteLine("Що редагуємо? Назву(1), автора(2), тематику(3), рік видання(4), видавництво(5), мову(6), кількість сторінок(7), вартість(8)?");
                try
                {
                    z = int.Parse(Console.ReadLine());
                }
                catch
                {
                    goto label33;
                }                
                switch (z)
                {
                    case 1:
                        Console.WriteLine("Введи нову назву:");
                        knList[y].Name = Console.ReadLine();                        
                        break;
                    case 2:
                        Console.WriteLine("Введи нового автора:");
                        knList[y].Author = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Введи нову тематику:");
                        knList[y].Tema = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Введи новий рік видання:");
                        knList[y].Year = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Введи видавництво:");
                        knList[y].Publisher = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Введи нову мову:");
                        knList[y].Lang = Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Введи кількість сторінок:");
                        knList[y].Pages = int.Parse(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("Введи нову вартість:");
                        knList[y].Price = int.Parse(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("default");
                        break;
                }
            }
            //журнал.
            if (x == 2)
            {
            label33:
                Console.WriteLine("Що редагуємо? Назву(1), тематику(2), періодичність(3), кількість сторінок(4), номер(5), рік(6), мову(7), вартість підписки на рік(8)?");
                try
                {
                    z = int.Parse(Console.ReadLine());
                }
                catch
                {
                    goto label33;
                }
                switch (z)
                {
                    case 1:
                        Console.WriteLine("Введи нову назву:");
                        zhuList[y].Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Введи тематику:");
                        zhuList[y].Tema = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Введи періодичність:");
                        zhuList[y].Period = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Введи кількість сторінок:");
                        zhuList[y].Pages = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Введи номер:");
                        zhuList[y].Nomer = int.Parse(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Введи рік:");
                        zhuList[y].Year = int.Parse(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Введи мову:");
                        zhuList[y].Lang = Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("Введи нову вартість підписки на рік:");
                        zhuList[y].Price = int.Parse(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("default");
                        break;
                }
            }
            using (StreamWriter f1 = new StreamWriter("библиотека1.txt"))
            {
                string ss;
                foreach (var a in knList)
                {
                    ss = $"1*{a.Name}*{a.Author}*{a.Tema}*{a.Year}*{a.Publisher}*{a.Lang}*{a.Pages}*{a.Price}";
                    f1.WriteLine(ss);
                }
                foreach (var a in zhuList)
                {
                    ss = $"2*{a.Name}*{a.Tema}*{a.Period}*{a.Pages}*{a.Nomer}*{a.Year}*{a.Lang}*{a.Price}";
                    f1.WriteLine(ss);
                }
            }
        }
        //4. Перегляд назв книг, впорядкованих за абеткою.
        static void Case4()
        {
            var knigi = from n in knList                        
                        orderby n.Name
                        select n; 
            
            foreach (var i in knigi)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine();
        }
        //Відбір журналів з комп’ютерної тематики.");
        static void Case5()
        {
            var zhurnali = from n in zhuList
                           where n.Tema == "комп’ютери"                           
                           select n;

            foreach (var i in zhurnali)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine();
        }

        //6. Вибір тільки журналів.");
        static void Case6()
        {
            WRzh(zhuList);
        }
        //7. Пошук журналу за номером
        static void Case7()
        {
            int x;
        label71:
            Console.WriteLine("Введи номер журналу");
            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch
            {
                goto label71;
            }
            var zhurnali = from n in zhuList
                           where n.Nomer == x
                           select n;

            foreach (var i in zhurnali)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine();
        }
        //8. пошук книг за автором.
        static void Case8()
        {
            string x;
            Console.WriteLine("Введи автора");
            x = Console.ReadLine(); 
            var knigi = from n in knList
                        where n.Author.ToLowerInvariant() == x.ToLowerInvariant()
                        //orderby n.Name
                        select n;

            foreach (var i in knigi)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine();
        }

        //9. Обчислення вартості одного номеру журналу при заданій ціні за рік.");        
        static void Case9()
        {
            string x;
            Console.WriteLine("Напиши назву журналу");
            x = Console.ReadLine();

            var knigi = from n in zhuList
                        where n.Name.ToLowerInvariant() == x.ToLowerInvariant()
                        //orderby n.Name
                        select n;

            double b;
            Zhurnal zhurnal = new Zhurnal();
            foreach (var i in knigi)
            {
                //b = i.Price / i.Period;
                b = zhurnal.Over(i.Price, i.Period);
                Console.WriteLine($"{b:f2}");
            }
            Console.WriteLine();
        }
        //Якщо вартість книжки більше 300 гривень, можна купити в кредит.");
        static void Case10()
        {
            var knigi = from n in knList
                        where n.Price > 300
                        //orderby n.Name
                        select n;

            double b = 0;
            Kniga kniga = new Kniga();
            foreach (var i in knigi)
            {
                b = kniga.Over(i.Price, i.Year);
                Console.Write($"Ціна \"{i.Name,35}\" більше 300 грн і становить {i.Price} грн. Можна купити в кредит на 6 місяців. ");
                Console.Write($"Щомісячний платіж дорівнює {b:F2} грн.");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            SD();            
        }
    }
}