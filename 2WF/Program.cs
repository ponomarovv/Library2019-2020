//4. Реалізувати функції програми:
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2WF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
