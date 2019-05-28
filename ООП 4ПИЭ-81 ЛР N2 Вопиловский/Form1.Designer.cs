namespace ООП_4ПИЭ_81_ЛР_N2_Вопиловский
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FilterGosNomer = new System.Windows.Forms.TextBox();
            this.FilterColor = new System.Windows.Forms.TextBox();
            this.FilterFamily = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FilterNomer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FilterYes = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGosNomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFamily = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilterNo = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автостоянка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Поиск по фильтру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Гос номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цвет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Фамилия владельца";
            // 
            // FilterGosNomer
            // 
            this.FilterGosNomer.Location = new System.Drawing.Point(184, 323);
            this.FilterGosNomer.Name = "FilterGosNomer";
            this.FilterGosNomer.Size = new System.Drawing.Size(69, 20);
            this.FilterGosNomer.TabIndex = 6;
            // 
            // FilterColor
            // 
            this.FilterColor.Location = new System.Drawing.Point(264, 323);
            this.FilterColor.Name = "FilterColor";
            this.FilterColor.Size = new System.Drawing.Size(81, 20);
            this.FilterColor.TabIndex = 7;
            // 
            // FilterFamily
            // 
            this.FilterFamily.Location = new System.Drawing.Point(358, 323);
            this.FilterFamily.Name = "FilterFamily";
            this.FilterFamily.Size = new System.Drawing.Size(113, 20);
            this.FilterFamily.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Номер места";
            // 
            // FilterNomer
            // 
            this.FilterNomer.Location = new System.Drawing.Point(12, 323);
            this.FilterNomer.Name = "FilterNomer";
            this.FilterNomer.Size = new System.Drawing.Size(73, 20);
            this.FilterNomer.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Поиск автомобиля по параметрам";
            // 
            // FilterYes
            // 
            this.FilterYes.AutoSize = true;
            this.FilterYes.Location = new System.Drawing.Point(96, 325);
            this.FilterYes.Name = "FilterYes";
            this.FilterYes.Size = new System.Drawing.Size(41, 17);
            this.FilterYes.TabIndex = 15;
            this.FilterYes.Text = "Да";
            this.FilterYes.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "На стоянке";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colN,
            this.colHere,
            this.colGosNomer,
            this.colColor,
            this.colFamily});
            this.listView1.Location = new System.Drawing.Point(16, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(455, 244);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // colN
            // 
            this.colN.Text = "Номер";
            this.colN.Width = 50;
            // 
            // colHere
            // 
            this.colHere.Text = "На стоянке";
            this.colHere.Width = 70;
            // 
            // colGosNomer
            // 
            this.colGosNomer.Text = "Госномер";
            this.colGosNomer.Width = 100;
            // 
            // colColor
            // 
            this.colColor.Text = "Цвет";
            this.colColor.Width = 100;
            // 
            // colFamily
            // 
            this.colFamily.Text = "Фамилия";
            this.colFamily.Width = 130;
            // 
            // FilterNo
            // 
            this.FilterNo.AutoSize = true;
            this.FilterNo.Location = new System.Drawing.Point(137, 325);
            this.FilterNo.Name = "FilterNo";
            this.FilterNo.Size = new System.Drawing.Size(45, 17);
            this.FilterNo.TabIndex = 17;
            this.FilterNo.Text = "Нет";
            this.FilterNo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Сбросить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 377);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FilterNo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.FilterYes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FilterNomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FilterFamily);
            this.Controls.Add(this.FilterColor);
            this.Controls.Add(this.FilterGosNomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ООП 4ПИЭ-81 ЛР N2 Вопиловский";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FilterGosNomer;
        private System.Windows.Forms.TextBox FilterColor;
        private System.Windows.Forms.TextBox FilterFamily;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FilterNomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox FilterYes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colFamily;
        public System.Windows.Forms.ColumnHeader colGosNomer;
        private System.Windows.Forms.ColumnHeader colHere;
        private System.Windows.Forms.ColumnHeader colColor;
        private System.Windows.Forms.ColumnHeader colN;
        private System.Windows.Forms.CheckBox FilterNo;
        private System.Windows.Forms.Button button2;
    }
}

