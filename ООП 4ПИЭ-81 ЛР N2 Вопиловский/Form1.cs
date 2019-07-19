using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_4ПИЭ_81_ЛР_N2_Вопиловский 
{
    public partial class Form1 : Form
    {
        Parkingcs park = new Parkingcs();

        public Form1()
        {
            InitializeComponent();
            initDefault();  // значение по умолчанию
            ListViev();     // вывод данных на экран
        }
        private void ListViev () // вывод данных на экран
        {
            listView1.Items.Clear(); // очистить список авто
            for (int i = 0; i < park.Length(); i++ )
            {
                park.Get(i, out int nomer, out string gosNomer, out string color, out string family, out bool here);
                ListViewItem newAvto = new ListViewItem(Convert.ToString(nomer));
                if (here)  {
                    newAvto.SubItems.Add("Да");
                } else     {
                    newAvto.SubItems.Add("Нет");
                }          
                newAvto.SubItems.Add(gosNomer);
                newAvto.SubItems.Add(color);
                newAvto.SubItems.Add(family);
                listView1.Items.Add(newAvto);
                
            }
        }
        private void initDefault () // Инициализация дефолтных данных
        {
            park.addAvto("Р241ЕМ 78", "Красный", "Петров", true);
            park.addAvto("В666ОР 22", "Черный", "Папиладзе", true);
            park.addAvto("В999ОР 22", "Баклажан", "Папиладзе", true);
            park.addAvto("Д342УР 22", "Розовый", "Самсонова", false);
            park.addAvto("К649ПЕ 22", "Белый", "Иванов", true);
            park.addAvto("В777ОР 22", "Золотой", "Папиладзе", false);
            park.addAvto("С567РУ 54", "Красный", "Сидоров", true);
            park.addAvto("Х001АМ 77", "Черный", "Тулеев", false);
            park.addAvto("В666ОР 23", "Баклажан", "Папиладзе", true);
            park.addAvto("Х777ХХ 22", "Темно синий", "Самсонова", true);
            park.addAvto("К777ОТ 22", "Фиолетовый", "Канделаки", false);
            park.addAvto("Х555ХХ 22", "Черный", "Ургант", false);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); // очистить список авто
            int nom = 0;
            if (FilterNomer.Text != "")
            {
                nom = Convert.ToInt32(FilterNomer.Text);
            }
            Avto[] avtoFilter = park.GetFilter(nom, FilterGosNomer.Text, FilterColor.Text, FilterFamily.Text, FilterYes.Checked, FilterNo.Checked);
            for (int i = 0; i < avtoFilter.Length; i++)
            {
                avtoFilter[i].Get(out int nomer, out string gosNomer, out string color, out string family, out bool here);
                ListViewItem newAvto = new ListViewItem(Convert.ToString(nomer));
                if (here)
                {
                    newAvto.SubItems.Add("Да");
                }
                else
                {
                    newAvto.SubItems.Add("Нет");
                }
                newAvto.SubItems.Add(gosNomer);
                newAvto.SubItems.Add(color);
                newAvto.SubItems.Add(family);
                listView1.Items.Add(newAvto);
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            ListViev();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    
    }
}
