namespace Cafee_BD_SQL
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Postavshik = new System.Windows.Forms.TabPage();
            this.OrganisationFKBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Change_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.PatronimycBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Patronyc_Label = new System.Windows.Forms.Label();
            this.Surname_Label = new System.Windows.Forms.Label();
            this.NamePostavshik_Label = new System.Windows.Forms.Label();
            this.Prod = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Zakaz = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.TabPage();
            this.LD = new System.Windows.Forms.TabPage();
            this.Otdel = new System.Windows.Forms.TabPage();
            this.Dolj = new System.Windows.Forms.TabPage();
            this.Delivery = new System.Windows.Forms.TabPage();
            this.Organisation = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.DeleteOrganisation_Button = new System.Windows.Forms.Button();
            this.ChangeOrganisation_Button = new System.Windows.Forms.Button();
            this.AddOrganisation_Button = new System.Windows.Forms.Button();
            this.PhoneOfOrganisationBox = new System.Windows.Forms.TextBox();
            this.AdresOfOrganisationBox = new System.Windows.Forms.TextBox();
            this.NameOfOrganisationBox = new System.Windows.Forms.TextBox();
            this.PhoneOfOrganisation = new System.Windows.Forms.Label();
            this.AdresOfOrganisation_Label = new System.Windows.Forms.Label();
            this.NameOfOrganisation_Label = new System.Windows.Forms.Label();
            this.PersonHistory = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Postavshik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Prod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Zakaz.SuspendLayout();
            this.Menu.SuspendLayout();
            this.Organisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Postavshik);
            this.tabControl1.Controls.Add(this.Prod);
            this.tabControl1.Controls.Add(this.Zakaz);
            this.tabControl1.Controls.Add(this.Menu);
            this.tabControl1.Controls.Add(this.LD);
            this.tabControl1.Controls.Add(this.Otdel);
            this.tabControl1.Controls.Add(this.Dolj);
            this.tabControl1.Controls.Add(this.Delivery);
            this.tabControl1.Controls.Add(this.Organisation);
            this.tabControl1.Controls.Add(this.PersonHistory);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 604);
            this.tabControl1.TabIndex = 0;
            // 
            // Postavshik
            // 
            this.Postavshik.Controls.Add(this.OrganisationFKBox);
            this.Postavshik.Controls.Add(this.label1);
            this.Postavshik.Controls.Add(this.dataGridView1);
            this.Postavshik.Controls.Add(this.Delete_Button);
            this.Postavshik.Controls.Add(this.Change_Button);
            this.Postavshik.Controls.Add(this.Add_Button);
            this.Postavshik.Controls.Add(this.PatronimycBox);
            this.Postavshik.Controls.Add(this.SurnameBox);
            this.Postavshik.Controls.Add(this.NameBox);
            this.Postavshik.Controls.Add(this.Patronyc_Label);
            this.Postavshik.Controls.Add(this.Surname_Label);
            this.Postavshik.Controls.Add(this.NamePostavshik_Label);
            this.Postavshik.Location = new System.Drawing.Point(4, 25);
            this.Postavshik.Name = "Postavshik";
            this.Postavshik.Padding = new System.Windows.Forms.Padding(3);
            this.Postavshik.Size = new System.Drawing.Size(910, 575);
            this.Postavshik.TabIndex = 0;
            this.Postavshik.Text = "Поставщик";
            this.Postavshik.UseVisualStyleBackColor = true;
            // 
            // OrganisationFKBox
            // 
            this.OrganisationFKBox.Location = new System.Drawing.Point(154, 197);
            this.OrganisationFKBox.Name = "OrganisationFKBox";
            this.OrganisationFKBox.Size = new System.Drawing.Size(147, 22);
            this.OrganisationFKBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Организация";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(892, 329);
            this.dataGridView1.TabIndex = 9;
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(373, 151);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(112, 24);
            this.Delete_Button.TabIndex = 8;
            this.Delete_Button.Text = "Удалить";
            this.Delete_Button.UseVisualStyleBackColor = true;
            // 
            // Change_Button
            // 
            this.Change_Button.Location = new System.Drawing.Point(373, 98);
            this.Change_Button.Name = "Change_Button";
            this.Change_Button.Size = new System.Drawing.Size(112, 24);
            this.Change_Button.TabIndex = 7;
            this.Change_Button.Text = "Изменить";
            this.Change_Button.UseVisualStyleBackColor = true;
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(373, 48);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(112, 24);
            this.Add_Button.TabIndex = 6;
            this.Add_Button.Text = "Добавить";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // PatronimycBox
            // 
            this.PatronimycBox.Location = new System.Drawing.Point(154, 151);
            this.PatronimycBox.Name = "PatronimycBox";
            this.PatronimycBox.Size = new System.Drawing.Size(147, 22);
            this.PatronimycBox.TabIndex = 5;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(154, 101);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(147, 22);
            this.SurnameBox.TabIndex = 4;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(154, 49);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(147, 22);
            this.NameBox.TabIndex = 3;
            // 
            // Patronyc_Label
            // 
            this.Patronyc_Label.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Patronyc_Label.Location = new System.Drawing.Point(8, 149);
            this.Patronyc_Label.Name = "Patronyc_Label";
            this.Patronyc_Label.Size = new System.Drawing.Size(100, 23);
            this.Patronyc_Label.TabIndex = 2;
            this.Patronyc_Label.Text = "Отчество";
            // 
            // Surname_Label
            // 
            this.Surname_Label.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname_Label.Location = new System.Drawing.Point(8, 99);
            this.Surname_Label.Name = "Surname_Label";
            this.Surname_Label.Size = new System.Drawing.Size(100, 23);
            this.Surname_Label.TabIndex = 1;
            this.Surname_Label.Text = "Фамилия";
            // 
            // NamePostavshik_Label
            // 
            this.NamePostavshik_Label.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NamePostavshik_Label.Location = new System.Drawing.Point(8, 49);
            this.NamePostavshik_Label.Name = "NamePostavshik_Label";
            this.NamePostavshik_Label.Size = new System.Drawing.Size(100, 23);
            this.NamePostavshik_Label.TabIndex = 0;
            this.NamePostavshik_Label.Text = "Имя";
            // 
            // Prod
            // 
            this.Prod.Controls.Add(this.dataGridView3);
            this.Prod.Controls.Add(this.button3);
            this.Prod.Controls.Add(this.button2);
            this.Prod.Controls.Add(this.button1);
            this.Prod.Controls.Add(this.textBox6);
            this.Prod.Controls.Add(this.textBox5);
            this.Prod.Controls.Add(this.textBox4);
            this.Prod.Controls.Add(this.textBox3);
            this.Prod.Controls.Add(this.textBox2);
            this.Prod.Controls.Add(this.textBox1);
            this.Prod.Controls.Add(this.label7);
            this.Prod.Controls.Add(this.label6);
            this.Prod.Controls.Add(this.label5);
            this.Prod.Controls.Add(this.label4);
            this.Prod.Controls.Add(this.label3);
            this.Prod.Controls.Add(this.label2);
            this.Prod.Location = new System.Drawing.Point(4, 25);
            this.Prod.Name = "Prod";
            this.Prod.Padding = new System.Windows.Forms.Padding(3);
            this.Prod.Size = new System.Drawing.Size(910, 575);
            this.Prod.TabIndex = 1;
            this.Prod.Text = "Продукция";
            this.Prod.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 350);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(914, 219);
            this.dataGridView3.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(668, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 27);
            this.button3.TabIndex = 15;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(668, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 27);
            this.button2.TabIndex = 14;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(342, 285);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(212, 22);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(342, 245);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 22);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(342, 197);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(342, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(342, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID продукции в меню";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID поставщика";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество продукции";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Срок годности продукции";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата поставки продукции";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название продукции";
            // 
            // Zakaz
            // 
            this.Zakaz.Controls.Add(this.dataGridView4);
            this.Zakaz.Controls.Add(this.button6);
            this.Zakaz.Controls.Add(this.button5);
            this.Zakaz.Controls.Add(this.button4);
            this.Zakaz.Controls.Add(this.textBox9);
            this.Zakaz.Controls.Add(this.textBox8);
            this.Zakaz.Controls.Add(this.textBox7);
            this.Zakaz.Controls.Add(this.label10);
            this.Zakaz.Controls.Add(this.label9);
            this.Zakaz.Controls.Add(this.label8);
            this.Zakaz.Location = new System.Drawing.Point(4, 25);
            this.Zakaz.Name = "Zakaz";
            this.Zakaz.Size = new System.Drawing.Size(910, 575);
            this.Zakaz.TabIndex = 2;
            this.Zakaz.Text = "Заказ";
            this.Zakaz.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(552, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 27);
            this.button6.TabIndex = 16;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(552, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 27);
            this.button5.TabIndex = 15;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(552, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 27);
            this.button4.TabIndex = 14;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(200, 150);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(212, 22);
            this.textBox9.TabIndex = 10;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(200, 108);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(212, 22);
            this.textBox8.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(200, 71);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(212, 22);
            this.textBox7.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(8, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 27);
            this.label10.TabIndex = 4;
            this.label10.Text = "Номер меню";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(8, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 27);
            this.label9.TabIndex = 3;
            this.label9.Text = "Сумма заказа";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 27);
            this.label8.TabIndex = 2;
            this.label8.Text = "Время заказа";
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.label12);
            this.Menu.Controls.Add(this.label11);
            this.Menu.Location = new System.Drawing.Point(4, 25);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(910, 575);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "Меню";
            this.Menu.UseVisualStyleBackColor = true;
            // 
            // LD
            // 
            this.LD.Location = new System.Drawing.Point(4, 25);
            this.LD.Name = "LD";
            this.LD.Size = new System.Drawing.Size(910, 575);
            this.LD.TabIndex = 4;
            this.LD.Text = "ЛД сотрудника";
            this.LD.UseVisualStyleBackColor = true;
            // 
            // Otdel
            // 
            this.Otdel.Location = new System.Drawing.Point(4, 25);
            this.Otdel.Name = "Otdel";
            this.Otdel.Size = new System.Drawing.Size(910, 575);
            this.Otdel.TabIndex = 5;
            this.Otdel.Text = "Отдел";
            this.Otdel.UseVisualStyleBackColor = true;
            // 
            // Dolj
            // 
            this.Dolj.Location = new System.Drawing.Point(4, 25);
            this.Dolj.Name = "Dolj";
            this.Dolj.Size = new System.Drawing.Size(910, 575);
            this.Dolj.TabIndex = 6;
            this.Dolj.Text = "Должность";
            this.Dolj.UseVisualStyleBackColor = true;
            // 
            // Delivery
            // 
            this.Delivery.Location = new System.Drawing.Point(4, 25);
            this.Delivery.Name = "Delivery";
            this.Delivery.Size = new System.Drawing.Size(910, 575);
            this.Delivery.TabIndex = 7;
            this.Delivery.Text = "Доставка";
            this.Delivery.UseVisualStyleBackColor = true;
            // 
            // Organisation
            // 
            this.Organisation.Controls.Add(this.dataGridView2);
            this.Organisation.Controls.Add(this.IDBox);
            this.Organisation.Controls.Add(this.DeleteOrganisation_Button);
            this.Organisation.Controls.Add(this.ChangeOrganisation_Button);
            this.Organisation.Controls.Add(this.AddOrganisation_Button);
            this.Organisation.Controls.Add(this.PhoneOfOrganisationBox);
            this.Organisation.Controls.Add(this.AdresOfOrganisationBox);
            this.Organisation.Controls.Add(this.NameOfOrganisationBox);
            this.Organisation.Controls.Add(this.PhoneOfOrganisation);
            this.Organisation.Controls.Add(this.AdresOfOrganisation_Label);
            this.Organisation.Controls.Add(this.NameOfOrganisation_Label);
            this.Organisation.Location = new System.Drawing.Point(4, 25);
            this.Organisation.Name = "Organisation";
            this.Organisation.Size = new System.Drawing.Size(910, 575);
            this.Organisation.TabIndex = 8;
            this.Organisation.Text = "Организация";
            this.Organisation.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(11, 300);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(899, 275);
            this.dataGridView2.TabIndex = 10;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(53, 217);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(825, 22);
            this.IDBox.TabIndex = 9;
            // 
            // DeleteOrganisation_Button
            // 
            this.DeleteOrganisation_Button.Location = new System.Drawing.Point(633, 165);
            this.DeleteOrganisation_Button.Name = "DeleteOrganisation_Button";
            this.DeleteOrganisation_Button.Size = new System.Drawing.Size(96, 27);
            this.DeleteOrganisation_Button.TabIndex = 8;
            this.DeleteOrganisation_Button.Text = "Удалить";
            this.DeleteOrganisation_Button.UseVisualStyleBackColor = true;
            // 
            // ChangeOrganisation_Button
            // 
            this.ChangeOrganisation_Button.Location = new System.Drawing.Point(633, 118);
            this.ChangeOrganisation_Button.Name = "ChangeOrganisation_Button";
            this.ChangeOrganisation_Button.Size = new System.Drawing.Size(96, 27);
            this.ChangeOrganisation_Button.TabIndex = 7;
            this.ChangeOrganisation_Button.Text = "Изменить";
            this.ChangeOrganisation_Button.UseVisualStyleBackColor = true;
            // 
            // AddOrganisation_Button
            // 
            this.AddOrganisation_Button.Location = new System.Drawing.Point(633, 62);
            this.AddOrganisation_Button.Name = "AddOrganisation_Button";
            this.AddOrganisation_Button.Size = new System.Drawing.Size(96, 27);
            this.AddOrganisation_Button.TabIndex = 6;
            this.AddOrganisation_Button.Text = "Добавить";
            this.AddOrganisation_Button.UseVisualStyleBackColor = true;
            this.AddOrganisation_Button.Click += new System.EventHandler(this.AddOrganisation_Button_Click);
            // 
            // PhoneOfOrganisationBox
            // 
            this.PhoneOfOrganisationBox.Location = new System.Drawing.Point(331, 170);
            this.PhoneOfOrganisationBox.Name = "PhoneOfOrganisationBox";
            this.PhoneOfOrganisationBox.Size = new System.Drawing.Size(212, 22);
            this.PhoneOfOrganisationBox.TabIndex = 5;
            // 
            // AdresOfOrganisationBox
            // 
            this.AdresOfOrganisationBox.Location = new System.Drawing.Point(331, 118);
            this.AdresOfOrganisationBox.Name = "AdresOfOrganisationBox";
            this.AdresOfOrganisationBox.Size = new System.Drawing.Size(212, 22);
            this.AdresOfOrganisationBox.TabIndex = 4;
            // 
            // NameOfOrganisationBox
            // 
            this.NameOfOrganisationBox.Location = new System.Drawing.Point(331, 62);
            this.NameOfOrganisationBox.Name = "NameOfOrganisationBox";
            this.NameOfOrganisationBox.Size = new System.Drawing.Size(212, 22);
            this.NameOfOrganisationBox.TabIndex = 3;
            // 
            // PhoneOfOrganisation
            // 
            this.PhoneOfOrganisation.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneOfOrganisation.Location = new System.Drawing.Point(3, 167);
            this.PhoneOfOrganisation.Name = "PhoneOfOrganisation";
            this.PhoneOfOrganisation.Size = new System.Drawing.Size(235, 27);
            this.PhoneOfOrganisation.TabIndex = 2;
            this.PhoneOfOrganisation.Text = "Телефон организации";
            // 
            // AdresOfOrganisation_Label
            // 
            this.AdresOfOrganisation_Label.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdresOfOrganisation_Label.Location = new System.Drawing.Point(3, 113);
            this.AdresOfOrganisation_Label.Name = "AdresOfOrganisation_Label";
            this.AdresOfOrganisation_Label.Size = new System.Drawing.Size(235, 27);
            this.AdresOfOrganisation_Label.TabIndex = 1;
            this.AdresOfOrganisation_Label.Text = "Адрес организации";
            // 
            // NameOfOrganisation_Label
            // 
            this.NameOfOrganisation_Label.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameOfOrganisation_Label.Location = new System.Drawing.Point(3, 62);
            this.NameOfOrganisation_Label.Name = "NameOfOrganisation_Label";
            this.NameOfOrganisation_Label.Size = new System.Drawing.Size(235, 27);
            this.NameOfOrganisation_Label.TabIndex = 0;
            this.NameOfOrganisation_Label.Text = "Название организации";
            // 
            // PersonHistory
            // 
            this.PersonHistory.Location = new System.Drawing.Point(4, 25);
            this.PersonHistory.Name = "PersonHistory";
            this.PersonHistory.Size = new System.Drawing.Size(910, 575);
            this.PersonHistory.TabIndex = 9;
            this.PersonHistory.Text = "История сотрудника";
            this.PersonHistory.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(3, 271);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(904, 299);
            this.dataGridView4.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(235, 27);
            this.label11.TabIndex = 3;
            this.label11.Text = "Наименование";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 27);
            this.label12.TabIndex = 4;
            this.label12.Text = "Стоимость";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(920, 619);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Postavshik.ResumeLayout(false);
            this.Postavshik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Prod.ResumeLayout(false);
            this.Prod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Zakaz.ResumeLayout(false);
            this.Zakaz.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Organisation.ResumeLayout(false);
            this.Organisation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Postavshik;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Change_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.TextBox PatronimycBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label Patronyc_Label;
        private System.Windows.Forms.Label Surname_Label;
        private System.Windows.Forms.Label NamePostavshik_Label;
        private System.Windows.Forms.TabPage Prod;
        private System.Windows.Forms.TabPage Zakaz;
        private System.Windows.Forms.TabPage Menu;
        private System.Windows.Forms.TabPage LD;
        private System.Windows.Forms.TabPage Otdel;
        private System.Windows.Forms.TabPage Dolj;
        private System.Windows.Forms.TabPage Delivery;
        private System.Windows.Forms.TabPage Organisation;
        private System.Windows.Forms.TabPage PersonHistory;
        private System.Windows.Forms.DataGridView dataGridView1;
        #endregion

        private System.Windows.Forms.TextBox OrganisationFKBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteOrganisation_Button;
        private System.Windows.Forms.Button ChangeOrganisation_Button;
        private System.Windows.Forms.Button AddOrganisation_Button;
        private System.Windows.Forms.TextBox PhoneOfOrganisationBox;
        private System.Windows.Forms.TextBox AdresOfOrganisationBox;
        private System.Windows.Forms.TextBox NameOfOrganisationBox;
        private System.Windows.Forms.Label PhoneOfOrganisation;
        private System.Windows.Forms.Label AdresOfOrganisation_Label;
        private System.Windows.Forms.Label NameOfOrganisation_Label;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

