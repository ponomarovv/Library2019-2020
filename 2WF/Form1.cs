using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace _2WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //конструктор форми
            InitializeComponent();
            //Doit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            CreateLists();  //створення об'єктів класів і створення колекцій   
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        static LinkedList<Kniga> knList = new LinkedList<Kniga>();
        static LinkedList<Zhurnal> zhuList = new LinkedList<Zhurnal>();

        LinkedListNode<Kniga> nodeK;
        LinkedListNode<Zhurnal> nodeZ;

        


        public void CreateLists()
        {
            //читання даних з файлу і створення 2 колекцій
            string s;
            int Oznaka_bib;  //ознака книги=1, журналі =2
            using (StreamReader f = new StreamReader("библиотека1.txt"))
            {
                while ((s = f.ReadLine()) != null)
                {
                    string[] split = s.Split(new Char[] { '*' });
                    Oznaka_bib = int.Parse(split[0].Trim());
                    if (Oznaka_bib == 1)
                        knList.AddLast(new Kniga(s));
                    else
                        zhuList.AddLast(new Zhurnal(s));
                }
            }
            nodeK = knList.First;           //вибір першого елементу списку Книжок
            nodeZ = zhuList.First;     //вибір першого елементу списку Журналів
            SetNode();
        }
        private void SetNode()
        {
            //txtMonPay.Text = "";
            if (radioButton1.Checked)   //якщо вибрані книжки
            {
                if (nodeK == null)
                {
                    MessageBox.Show("Упс, закінчилися книжки.");
                    return;
                }
                else
                {
                    Номер.Enabled = false;
                    Періодичність.Enabled = false;
                    tNomer.Enabled = false;
                    tPeriod.Enabled = false;
                    tNomer.Text = "";
                    tPeriod.Text = "";

                    Автор.Enabled = true;
                    Видавництво.Enabled = true;
                    tAuthor.Enabled = true;
                    tPublisher.Enabled = true;

                    //Автор.Text = "Автор";
                    //Видавництво.Text = "Видавництво";
                    Вартість.Text = "Вартість";
                    //виведення на форму першого елемента списку Книжок
                    tName.Text = nodeK.Value.Name;
                    tAuthor.Text = nodeK.Value.Author;
                    tTema.Text = nodeK.Value.Tema;
                    tYear.Text = Convert.ToString(nodeK.Value.Year);
                    tPublisher.Text = nodeK.Value.Publisher;
                    tLang.Text = nodeK.Value.Lang;
                    tPages.Text = nodeK.Value.Pages.ToString();
                    tPrice.Text = nodeK.Value.Price.ToString();
                }
            }
            else
            if (radioButton2.Checked)
            {           //якщо вибрані Журнали
                if (nodeZ == null)
                {
                    MessageBox.Show("Упс, закінчилися журнали.");
                    return;
                }
                else
                {
                    Номер.Enabled = true;
                    Періодичність.Enabled = true;
                    tNomer.Enabled = true;
                    //tNomer.Text = "";
                    tPeriod.Enabled = true;
                    //tPeriod.Text = "";

                    Автор.Enabled = false;
                    Видавництво.Enabled = false;
                    tAuthor.Enabled = false;
                    tPublisher.Enabled = false;
                    tAuthor.Text = "";
                    tPublisher.Text = "";


                    //Автор.Text = "Періодичність";
                    //Видавництво.Text = "Номер";
                    Вартість.Text = "Вартість за рік";
                    //виведення на форму першого елемента списку Журналів
                    tName.Text = nodeZ.Value.Name;
                    tPeriod.Text = nodeZ.Value.Period.ToString();
                    tTema.Text = nodeZ.Value.Tema;
                    tYear.Text = Convert.ToString(nodeZ.Value.Year);
                    tNomer.Text = nodeZ.Value.Nomer.ToString();
                    tLang.Text = nodeZ.Value.Lang;
                    tPages.Text = nodeZ.Value.Pages.ToString();
                    tPrice.Text = nodeZ.Value.Price.ToString();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //SetNode();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SetNode();
        }

        private void First_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                nodeK = knList.First;
            else
                nodeZ = zhuList.First;
            SetNode();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (nodeK != knList.Last)
                {
                    nodeK = nodeK.Next;
                }
                else
                {
                    nodeK = knList.Last;
                }

            }
            else
            {
                if (nodeZ != zhuList.Last)
                {
                    nodeZ = nodeZ.Next;
                }
                else
                {
                    nodeZ = zhuList.Last;
                }
            }            
            SetNode();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (nodeK != knList.First)
                {
                    nodeK = nodeK.Previous;
                }
                else
                {
                    nodeK = knList.First;
                }
            }
            else
            {
                if (nodeZ != zhuList.First)
                {
                    nodeZ = nodeZ.Previous;
                }
                else
                {
                    nodeZ = zhuList.First;
                }
            }
            SetNode();        
        }

        private void Last_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                nodeK = knList.Last;
            else
                nodeZ = zhuList.Last;
            SetNode();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (tName.Text.Length != 0)
            {
                //Delete from List
                if (radioButton1.Checked)
                {
                    knList.Remove(nodeK);
                    nodeK = knList.First;                     
                }
                else
                {
                    zhuList.Remove(nodeZ);
                    nodeZ = zhuList.First;
                }
                ReFile();
                ClearForm();
                
            }
            else
                MessageBox.Show("Немає запису для видалення");
        }

        private void ReFile()
        {
            string line;
            //переписування файлу з колекцій
            using (StreamWriter f1 = new StreamWriter("библиотека1.txt"))
            {
                foreach (var node in knList)
                {
                    line = $"1*{node.Name}*{node.Author}*{node.Tema}*{node.Year}*{node.Publisher}*{node.Lang}*{node.Pages}*{node.Price}";
                    //         MessageBox.Show(line);
                    f1.WriteLine(line);
                }
                foreach (var node in zhuList)
                {
                    line = $"2*{node.Name}*{node.Tema}*{node.Period}*{node.Pages}*{node.Nomer}*{node.Year}*{node.Lang}*{node.Price}";

                    f1.WriteLine(line);
                }
            }
        }
        private void ClearForm()
        {
            //очистка полів форми
            tName.Text = "";
            tAuthor.Text = "";
            tTema.Text = "";
            tYear.Text = "";
            tPublisher.Text = "";
            tLang.Text = "";
            tPages.Text = "";
            tPrice.Text = "";

            tPeriod.Text = "";
            tNomer.Text = "";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string lineToAdd;
            // Add to List
            if (radioButton1.Checked)
            {    //додавання до списку Книг
                try
                {
                    knList.AddLast(new Kniga(tName.Text, tAuthor.Text, tTema.Text, int.Parse(tYear.Text), tPublisher.Text, tLang.Text, int.Parse(tPages.Text), double.Parse(tPrice.Text)));
                    lineToAdd = $"1*{tName.Text}*{tAuthor.Text}*{tTema.Text}*{tYear.Text}*{tPublisher.Text}*{tLang.Text}*{tPages.Text}*{tPrice.Text}";
                    UpdateFile(lineToAdd);
                }
                catch
                {
                    MessageBox.Show("Помилка. Не вийшло перетворити string в int або double.");
                }
            }
            else
            {    //додавання до списку службовців
                try
                {
                    zhuList.AddLast(new Zhurnal(tName.Text, tTema.Text, int.Parse(tPeriod.Text), int.Parse(tPages.Text), int.Parse(tNomer.Text), int.Parse(tYear.Text), tLang.Text, int.Parse(tPrice.Text)));
                    lineToAdd = $"2*{tName.Text}*{tTema.Text}*{tPeriod.Text}*{tPages.Text}*{tNomer.Text}*{tYear.Text}*{tLang.Text}*{tPrice.Text}";
                    UpdateFile(lineToAdd);
                }
                catch
                {
                    MessageBox.Show("Помилка. Не вийшло перетворити string в int або double.");
                }
            }
        }
        private void UpdateFile(string line)
        {//додавання рядка до файлу
            using (StreamWriter f1 = new StreamWriter("библиотека1.txt", append: true))
            {
                f1.WriteLine(line);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    nodeK.Value.Name = tName.Text;
                    nodeK.Value.Author = tAuthor.Text;
                    nodeK.Value.Tema = tTema.Text;
                    nodeK.Value.Year = int.Parse(tYear.Text);
                    nodeK.Value.Publisher = tPublisher.Text;
                    nodeK.Value.Lang = tLang.Text;
                    nodeK.Value.Pages = int.Parse(tPages.Text);
                    nodeK.Value.Price = double.Parse(tPrice.Text);
                }
                catch
                {
                    MessageBox.Show("Помилка. Не вийшло перетворити string в int або double.");
                }
            }
            else
            {
                try
                {
                    nodeZ.Value.Name = tName.Text;
                    nodeZ.Value.Period = int.Parse(tPeriod.Text);
                    nodeZ.Value.Tema = tTema.Text;
                    nodeZ.Value.Year = int.Parse(tYear.Text);
                    nodeZ.Value.Nomer = int.Parse(tNomer.Text);
                    nodeZ.Value.Lang = tLang.Text;
                    nodeZ.Value.Pages = int.Parse(tPages.Text);
                    nodeZ.Value.Price = double.Parse(tPrice.Text);
                }
                catch
                {
                    MessageBox.Show("Помилка. Не вийшло перетворити string в int або double.");
                }
            }
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var knigi = from n in knList
                        orderby n.Name
                        select n;

            //knList.Clear();
            
            foreach (var kn in knigi)
            {
                //knList.AddLast(kn);
                listBox2.Items.Add(kn.Name);
            }
            
            //nodeK = knList.First;
            //SetNode();
        }

        private void Journals_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var zhurnali = from n in zhuList
                        //orderby n.Name
                        select n;

            //knList.Clear();
            
            foreach (var zh in zhurnali)
            {                
                listBox2.Items.Add(zh.Name);
            }

            //nodeK = knList.First;
            //SetNode();
        }

        private void ComputerJournals_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var zhurnali = from n in zhuList
                           where n.Tema == "Комп’ютери"
                           select n;

            //knList.Clear();
            
            foreach (var zh in zhurnali)
            {
                listBox2.Items.Add(zh.Name);
            }

            //nodeK = knList.First;
            //SetNode();
        }

        private void Знайтижурнали_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int nom = 0;
            if (textBox1.Text != "")
            {
                try
                {
                    nom = int.Parse(textBox1.Text);
                }
                catch
                {
                    MessageBox.Show("Надо было ввести номер(число).");
                }
                var zhurnali = from n in zhuList
                               where n.Nomer == nom
                               select n;

                //knList.Clear();
                
                foreach (var zh in zhurnali)
                {
                    listBox2.Items.Add(zh.Name);
                }
            }
        }

        private void Знайтикниги_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string author = textBox2.Text;
            var kn = from n in knList
                     where n.Author.ToLowerInvariant() == author.ToLowerInvariant()
                     select n;

            //knList.Clear();
            
            foreach (var k in kn)
            {
                listBox2.Items.Add(k.Name);
            }
        }

        private void Вартістьодногожурналу_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string nazva = textBox4.Text;

            var zhurnali = from n in zhuList
                           where n.Name == nazva
                           select n;

            double b;
            Zhurnal zhurnal = new Zhurnal();
            //knList.Clear();
            
            foreach (var zh in zhurnali)
            {
                b = zhurnal.Over(zh.Price, zh.Period);
                listBox2.Items.Add($"{zh.Name}. Ціна на місяць: {b:f2}");
            }

        }

        private void Знайтикниги2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var knigi = from n in knList
                        where n.Price > 300
                        //orderby n.Name
                        select n;

            double b = 0;
            Kniga kniga = new Kniga();

            foreach (var i in knigi)
            {
                b = kniga.Over(i.Price, i.Year);
                listBox2.Items.Add($"\"{i.Name}\".Ціна:  {i.Price} грн. Можна купити в кредит на 6 місяців.");
                listBox2.Items.Add($"Щомісячний платіж дорівнює {b:F2} грн.");
                listBox2.Items.Add($"");
                //Console.Write($"Ціна \"{i.Name,35}\" більше 300 грн і становить {i.Price} грн. Можна купити в кредит на 6 місяців. ");
                //Console.Write($"Щомісячний платіж дорівнює {b:F2} грн.");
                //Console.WriteLine();
            }
            

        }
    }
}



