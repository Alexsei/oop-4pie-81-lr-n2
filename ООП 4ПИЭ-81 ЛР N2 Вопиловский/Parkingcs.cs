using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4ПИЭ_81_ЛР_N2_Вопиловский
{
    class Parkingcs
    {
        Avto[] avtoMas = new Avto[12];
        int count = 0;


        public void addAvto(string gosNomer, string color, string family, bool here) // добавление нового авто 
        {
            this.avtoMas[this.count] = new Avto(this.count + 1, gosNomer, color, family, here);
            this.count++;
        }

        public int Length()  // размер массива автомобилей на парковке
        {
            return this.avtoMas.Length;
        }

        public void Get(int i, out int nomer, out string gosNomer, out string color, out string family, out bool here)
        { // запрос авто по индексу
            this.avtoMas[i].Get(out int nomerA, out string gosNomerA, out string colorA, out string familyA, out bool hereA);
            nomer = nomerA;
            gosNomer = gosNomerA;
            color = colorA;
            family = familyA;
            here = hereA;
        }

        public int GetFilterLength(int nomer, string gosNomer, string color, string family, bool hereTrue, bool hereFalse)
        { // размер массива автомобилей на парковке по фильтру
            int length = 0;
            for (int i = 0; i < this.avtoMas.Length; i++)
            {
                this.avtoMas[i].Get(out int nomerA, out string gosNomerA, out string colorA, out string familyA, out bool hereA);
                // условия соответствия заданному фильтру
                if (!(((nomer != 0) && (nomer != nomerA))     
                    || ((gosNomer != "") && (gosNomer != gosNomerA))
                    || ((color != "") && (color != colorA))
                    || ((family != "") && (family != familyA))
                    || ((hereTrue != hereFalse) && ((hereTrue != hereA) || (hereFalse == hereA)))
                    ))
                {
                    length++;
                }
            }
            return length;
        }

        public Avto[] GetFilter(int nomer, string gosNomer, string color, string family, bool hereTrue, bool hereFalse)
        { // массив по фильтру
            int leigth = this.GetFilterLength(nomer, gosNomer, color, family, hereTrue, hereFalse); // размер массива
            Avto[] avtoMasFilter = new Avto[leigth];
            int index = 0; 
            for (int i = 0; i < this.avtoMas.Length; i++)
            {
                this.avtoMas[i].Get(out int nomerA, out string gosNomerA, out string colorA, out string familyA, out bool hereA);
                // условия соответствия заданному фильтру
                if (!(((nomer != 0) && (nomer != nomerA)) 
                    || ((gosNomer != "") && (gosNomer != gosNomerA))
                    || ((color != "") && (color != colorA))
                    || ((family != "") && (family != familyA))
                    || ((hereTrue != hereFalse) && ((hereTrue != hereA) || (hereFalse == hereA)))
                    ))
                {
                    avtoMasFilter[index] = new Avto(nomerA, gosNomerA, colorA, familyA, hereA);
                    index++;
                };
            }
            return avtoMasFilter;
        }
    }
}

