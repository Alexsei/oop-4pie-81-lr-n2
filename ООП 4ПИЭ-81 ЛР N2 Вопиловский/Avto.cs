using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4ПИЭ_81_ЛР_N2_Вопиловский
{
    class Avto
    {
        int nomer;              // номер места
        string gosNomer;        // гос номер
        string color;           // цвет
        string family;          // фамилия владельца
        bool here;              // признак наличия на стоянке

        public Avto(int nomer, string gosNomer, string color, string family, bool here) 
        {       // Инициализация
            this.nomer = nomer;
            this.gosNomer = gosNomer;
            this.color = color;
            this.family = family;
            this.here = here;
        }

        public void Get(out int nomer, out string gosNomer, out string color, out string family, out bool here) 
        {   // запрос на чтение
            nomer = this.nomer;
            gosNomer = this.gosNomer;
            color = this.color;
            family = this.family;
            here = this.here;
        }

        public void Set(int nomer, string gosNomer, string color, string family, bool here)
        {   // запрос на запись
            this.nomer = nomer;
            this.gosNomer = gosNomer;
            this.color = color;
            this.family = family;
            this.here = here;
        }
    }
}
