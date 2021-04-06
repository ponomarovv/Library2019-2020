namespace _2WF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Close = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label0 = new System.Windows.Forms.Label();
            this.Назва = new System.Windows.Forms.Label();
            this.Автор = new System.Windows.Forms.Label();
            this.Тематика = new System.Windows.Forms.Label();
            this.Ріквидання = new System.Windows.Forms.Label();
            this.Видавництво = new System.Windows.Forms.Label();
            this.Мова = new System.Windows.Forms.Label();
            this.Кількістьсторінок = new System.Windows.Forms.Label();
            this.Вартість = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.tAuthor = new System.Windows.Forms.TextBox();
            this.tTema = new System.Windows.Forms.TextBox();
            this.tYear = new System.Windows.Forms.TextBox();
            this.tPublisher = new System.Windows.Forms.TextBox();
            this.tLang = new System.Windows.Forms.TextBox();
            this.tPages = new System.Windows.Forms.TextBox();
            this.tPrice = new System.Windows.Forms.TextBox();
            this.First = new System.Windows.Forms.Button();
            this.Prev = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Last = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Sort = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Journals = new System.Windows.Forms.Button();
            this.ComputerJournals = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.номержурнала = new System.Windows.Forms.Label();
            this.Знайтижурнали = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Знайтикнижки = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Авторкниги = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Знайтикниги2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Вартістьодногожурналу = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Періодичність = new System.Windows.Forms.Label();
            this.tPeriod = new System.Windows.Forms.TextBox();
            this.tNomer = new System.Windows.Forms.TextBox();
            this.Номер = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(278, 407);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 0;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Книжки";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Журнали";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(368, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 77);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(7, 16);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(59, 13);
            this.label0.TabIndex = 4;
            this.label0.Text = "Бібліотека";
            // 
            // Назва
            // 
            this.Назва.AutoSize = true;
            this.Назва.Location = new System.Drawing.Point(32, 66);
            this.Назва.Name = "Назва";
            this.Назва.Size = new System.Drawing.Size(39, 13);
            this.Назва.TabIndex = 5;
            this.Назва.Text = "Назва";
            // 
            // Автор
            // 
            this.Автор.AutoSize = true;
            this.Автор.Location = new System.Drawing.Point(32, 102);
            this.Автор.Name = "Автор";
            this.Автор.Size = new System.Drawing.Size(37, 13);
            this.Автор.TabIndex = 6;
            this.Автор.Text = "Автор";
            // 
            // Тематика
            // 
            this.Тематика.AutoSize = true;
            this.Тематика.Location = new System.Drawing.Point(32, 160);
            this.Тематика.Name = "Тематика";
            this.Тематика.Size = new System.Drawing.Size(57, 13);
            this.Тематика.TabIndex = 7;
            this.Тематика.Text = "Тематика";
            // 
            // Ріквидання
            // 
            this.Ріквидання.AutoSize = true;
            this.Ріквидання.Location = new System.Drawing.Point(32, 186);
            this.Ріквидання.Name = "Ріквидання";
            this.Ріквидання.Size = new System.Drawing.Size(67, 13);
            this.Ріквидання.TabIndex = 8;
            this.Ріквидання.Text = "Рік видання";
            // 
            // Видавництво
            // 
            this.Видавництво.AutoSize = true;
            this.Видавництво.Location = new System.Drawing.Point(32, 212);
            this.Видавництво.Name = "Видавництво";
            this.Видавництво.Size = new System.Drawing.Size(73, 13);
            this.Видавництво.TabIndex = 9;
            this.Видавництво.Text = "Видавництво";
            // 
            // Мова
            // 
            this.Мова.AutoSize = true;
            this.Мова.Location = new System.Drawing.Point(32, 267);
            this.Мова.Name = "Мова";
            this.Мова.Size = new System.Drawing.Size(34, 13);
            this.Мова.TabIndex = 10;
            this.Мова.Text = "Мова";
            // 
            // Кількістьсторінок
            // 
            this.Кількістьсторінок.AutoSize = true;
            this.Кількістьсторінок.Location = new System.Drawing.Point(32, 298);
            this.Кількістьсторінок.Name = "Кількістьсторінок";
            this.Кількістьсторінок.Size = new System.Drawing.Size(99, 13);
            this.Кількістьсторінок.TabIndex = 11;
            this.Кількістьсторінок.Text = "Кількість сторінок";
            // 
            // Вартість
            // 
            this.Вартість.AutoSize = true;
            this.Вартість.Location = new System.Drawing.Point(32, 333);
            this.Вартість.Name = "Вартість";
            this.Вартість.Size = new System.Drawing.Size(50, 13);
            this.Вартість.TabIndex = 12;
            this.Вартість.Text = "Вартість";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(166, 59);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(193, 20);
            this.tName.TabIndex = 13;
            // 
            // tAuthor
            // 
            this.tAuthor.Location = new System.Drawing.Point(166, 94);
            this.tAuthor.Name = "tAuthor";
            this.tAuthor.Size = new System.Drawing.Size(193, 20);
            this.tAuthor.TabIndex = 14;
            // 
            // tTema
            // 
            this.tTema.Location = new System.Drawing.Point(166, 153);
            this.tTema.Name = "tTema";
            this.tTema.Size = new System.Drawing.Size(193, 20);
            this.tTema.TabIndex = 15;
            // 
            // tYear
            // 
            this.tYear.Location = new System.Drawing.Point(166, 179);
            this.tYear.Name = "tYear";
            this.tYear.Size = new System.Drawing.Size(193, 20);
            this.tYear.TabIndex = 16;
            // 
            // tPublisher
            // 
            this.tPublisher.Location = new System.Drawing.Point(166, 205);
            this.tPublisher.Name = "tPublisher";
            this.tPublisher.Size = new System.Drawing.Size(193, 20);
            this.tPublisher.TabIndex = 17;
            // 
            // tLang
            // 
            this.tLang.Location = new System.Drawing.Point(166, 260);
            this.tLang.Name = "tLang";
            this.tLang.Size = new System.Drawing.Size(193, 20);
            this.tLang.TabIndex = 18;
            // 
            // tPages
            // 
            this.tPages.Location = new System.Drawing.Point(166, 291);
            this.tPages.Name = "tPages";
            this.tPages.Size = new System.Drawing.Size(193, 20);
            this.tPages.TabIndex = 19;
            // 
            // tPrice
            // 
            this.tPrice.Location = new System.Drawing.Point(166, 326);
            this.tPrice.Name = "tPrice";
            this.tPrice.Size = new System.Drawing.Size(193, 20);
            this.tPrice.TabIndex = 20;
            // 
            // First
            // 
            this.First.Location = new System.Drawing.Point(35, 378);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(75, 23);
            this.First.TabIndex = 21;
            this.First.Text = "First";
            this.First.UseVisualStyleBackColor = true;
            this.First.Click += new System.EventHandler(this.First_Click);
            // 
            // Prev
            // 
            this.Prev.Location = new System.Drawing.Point(116, 378);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(75, 23);
            this.Prev.TabIndex = 22;
            this.Prev.Text = "Prev";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(197, 378);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 23;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Last
            // 
            this.Last.Location = new System.Drawing.Point(278, 378);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(75, 23);
            this.Last.TabIndex = 24;
            this.Last.Text = "Last";
            this.Last.UseVisualStyleBackColor = true;
            this.Last.Click += new System.EventHandler(this.Last_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(35, 407);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 25;
            this.Edit.Text = "Edit/Save";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(116, 407);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 26;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(197, 407);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label0);
            this.groupBox2.Location = new System.Drawing.Point(287, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(72, 41);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(35, 436);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 29;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "4. Реалізувати функції програми:",
            "+\tдодавання, видалення літератури;",
            "+\tредагування даних про літературу;",
            "+\tперегляд назв книг, впорядкованих за абеткою;",
            "+\tвідбір журналів з комп’ютерної тематики; ",
            "+\tвибір тільки журналів; ",
            "+\tпошук журналу за номером; ",
            "+\tпошук книг за автором;",
            "+\tобчислення вартості одного номеру журналу при заданій ціні за рік;",
            "+\tякщо вартість книжки більше 300 гривень, можна купити в кредит."});
            this.listBox1.Location = new System.Drawing.Point(368, 152);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(514, 164);
            this.listBox1.TabIndex = 30;
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(116, 436);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(75, 37);
            this.Sort.TabIndex = 31;
            this.Sort.Text = "Sort Knig за абеткою";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(368, 453);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(514, 95);
            this.listBox2.TabIndex = 32;
            // 
            // Journals
            // 
            this.Journals.Location = new System.Drawing.Point(278, 436);
            this.Journals.Name = "Journals";
            this.Journals.Size = new System.Drawing.Size(75, 37);
            this.Journals.TabIndex = 33;
            this.Journals.Text = "Only Journals";
            this.Journals.UseVisualStyleBackColor = true;
            this.Journals.Click += new System.EventHandler(this.Journals_Click);
            // 
            // ComputerJournals
            // 
            this.ComputerJournals.Location = new System.Drawing.Point(197, 436);
            this.ComputerJournals.Name = "ComputerJournals";
            this.ComputerJournals.Size = new System.Drawing.Size(75, 37);
            this.ComputerJournals.TabIndex = 34;
            this.ComputerJournals.Text = "Computer Journals";
            this.ComputerJournals.UseVisualStyleBackColor = true;
            this.ComputerJournals.Click += new System.EventHandler(this.ComputerJournals_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 35;
            // 
            // номержурнала
            // 
            this.номержурнала.AutoSize = true;
            this.номержурнала.Location = new System.Drawing.Point(6, 10);
            this.номержурнала.Name = "номержурнала";
            this.номержурнала.Size = new System.Drawing.Size(87, 13);
            this.номержурнала.TabIndex = 36;
            this.номержурнала.Text = "Номер журнала";
            // 
            // Знайтижурнали
            // 
            this.Знайтижурнали.Location = new System.Drawing.Point(126, 25);
            this.Знайтижурнали.Name = "Знайтижурнали";
            this.Знайтижурнали.Size = new System.Drawing.Size(98, 20);
            this.Знайтижурнали.TabIndex = 37;
            this.Знайтижурнали.Text = "Знайти журнали";
            this.Знайтижурнали.UseVisualStyleBackColor = true;
            this.Знайтижурнали.Click += new System.EventHandler(this.Знайтижурнали_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.номержурнала);
            this.groupBox3.Controls.Add(this.Знайтижурнали);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(368, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 52);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Знайтикнижки);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.Авторкниги);
            this.groupBox4.Location = new System.Drawing.Point(368, 374);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(231, 56);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            // 
            // Знайтикнижки
            // 
            this.Знайтикнижки.Location = new System.Drawing.Point(126, 26);
            this.Знайтикнижки.Name = "Знайтикнижки";
            this.Знайтикнижки.Size = new System.Drawing.Size(98, 20);
            this.Знайтикнижки.TabIndex = 40;
            this.Знайтикнижки.Text = "Знайти книжки";
            this.Знайтикнижки.UseVisualStyleBackColor = true;
            this.Знайтикнижки.Click += new System.EventHandler(this.Знайтикниги_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 40;
            // 
            // Авторкниги
            // 
            this.Авторкниги.AutoSize = true;
            this.Авторкниги.Location = new System.Drawing.Point(6, 10);
            this.Авторкниги.Name = "Авторкниги";
            this.Авторкниги.Size = new System.Drawing.Size(69, 13);
            this.Авторкниги.TabIndex = 0;
            this.Авторкниги.Text = "Автор книги";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Знайтикниги2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(41, 561);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(318, 56);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            // 
            // Знайтикниги2
            // 
            this.Знайтикниги2.Location = new System.Drawing.Point(9, 30);
            this.Знайтикниги2.Name = "Знайтикниги2";
            this.Знайтикниги2.Size = new System.Drawing.Size(98, 20);
            this.Знайтикниги2.TabIndex = 40;
            this.Знайтикниги2.Text = "Знайти книги";
            this.Знайтикниги2.UseVisualStyleBackColor = true;
            this.Знайтикниги2.Click += new System.EventHandler(this.Знайтикниги2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шукаємо книги, ціна яких >300";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.Вартістьодногожурналу);
            this.groupBox6.Controls.Add(this.textBox4);
            this.groupBox6.Location = new System.Drawing.Point(41, 479);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(318, 82);
            this.groupBox6.TabIndex = 40;
            this.groupBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Назва журналу";
            // 
            // Вартістьодногожурналу
            // 
            this.Вартістьодногожурналу.Location = new System.Drawing.Point(9, 46);
            this.Вартістьодногожурналу.Name = "Вартістьодногожурналу";
            this.Вартістьодногожурналу.Size = new System.Drawing.Size(147, 20);
            this.Вартістьодногожурналу.TabIndex = 37;
            this.Вартістьодногожурналу.Text = "Вартість одного журналу";
            this.Вартістьодногожурналу.UseVisualStyleBackColor = true;
            this.Вартістьодногожурналу.Click += new System.EventHandler(this.Вартістьодногожурналу_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(176, 9);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 35;
            // 
            // Періодичність
            // 
            this.Періодичність.AutoSize = true;
            this.Періодичність.Location = new System.Drawing.Point(32, 134);
            this.Періодичність.Name = "Періодичність";
            this.Періодичність.Size = new System.Drawing.Size(77, 13);
            this.Періодичність.TabIndex = 42;
            this.Періодичність.Text = "Періодичність";
            // 
            // tPeriod
            // 
            this.tPeriod.Location = new System.Drawing.Point(166, 127);
            this.tPeriod.Name = "tPeriod";
            this.tPeriod.Size = new System.Drawing.Size(193, 20);
            this.tPeriod.TabIndex = 43;
            // 
            // tNomer
            // 
            this.tNomer.Location = new System.Drawing.Point(166, 234);
            this.tNomer.Name = "tNomer";
            this.tNomer.Size = new System.Drawing.Size(193, 20);
            this.tNomer.TabIndex = 44;
            // 
            // Номер
            // 
            this.Номер.AutoSize = true;
            this.Номер.Location = new System.Drawing.Point(32, 241);
            this.Номер.Name = "Номер";
            this.Номер.Size = new System.Drawing.Size(41, 13);
            this.Номер.TabIndex = 45;
            this.Номер.Text = "Номер";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 630);
            this.Controls.Add(this.Номер);
            this.Controls.Add(this.tNomer);
            this.Controls.Add(this.tPeriod);
            this.Controls.Add(this.Періодичність);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ComputerJournals);
            this.Controls.Add(this.Journals);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Last);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.First);
            this.Controls.Add(this.tPrice);
            this.Controls.Add(this.tPages);
            this.Controls.Add(this.tLang);
            this.Controls.Add(this.tPublisher);
            this.Controls.Add(this.tYear);
            this.Controls.Add(this.tTema);
            this.Controls.Add(this.tAuthor);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.Вартість);
            this.Controls.Add(this.Кількістьсторінок);
            this.Controls.Add(this.Мова);
            this.Controls.Add(this.Видавництво);
            this.Controls.Add(this.Ріквидання);
            this.Controls.Add(this.Тематика);
            this.Controls.Add(this.Автор);
            this.Controls.Add(this.Назва);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Close);
            this.Name = "Form1";
            this.Text = "Бібліотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label Назва;
        private System.Windows.Forms.Label Автор;
        private System.Windows.Forms.Label Тематика;
        private System.Windows.Forms.Label Ріквидання;
        private System.Windows.Forms.Label Видавництво;
        private System.Windows.Forms.Label Мова;
        private System.Windows.Forms.Label Кількістьсторінок;
        private System.Windows.Forms.Label Вартість;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tAuthor;
        private System.Windows.Forms.TextBox tTema;
        private System.Windows.Forms.TextBox tYear;
        private System.Windows.Forms.TextBox tPublisher;
        private System.Windows.Forms.TextBox tLang;
        private System.Windows.Forms.TextBox tPages;
        private System.Windows.Forms.TextBox tPrice;
        private System.Windows.Forms.Button First;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Last;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button Journals;
        private System.Windows.Forms.Button ComputerJournals;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label номержурнала;
        private System.Windows.Forms.Button Знайтижурнали;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Знайтикнижки;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Авторкниги;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Знайтикниги2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Вартістьодногожурналу;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Періодичність;
        private System.Windows.Forms.TextBox tPeriod;
        private System.Windows.Forms.TextBox tNomer;
        private System.Windows.Forms.Label Номер;
    }
}

