using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VN_Lib_v1
{
    public class Stationing
    {
        /*
         * -----------------------------
         * Переменная, хранящая значение
         * в пикселях или процентах
         * -----------------------------
         */
        private uint _value;

        //--Свойства--
        public uint value
        {
            set { _value = value; }
            get { return _value; }
        }
        //------------

        /*
         * ------------
         * Тип значения
         * ------------
         */
        private uint _type;

        //--Свойства--
        public uint type
        {
            set { _type = value; }
            get { return _type; }
        }
        //------------

        //--Конструкторы класса--

        public Stationing()
        {
            _value = 0;
            _type = Constants.PIXEL;
        }

        public Stationing(Stationing s)
        {
            _value = s.value;
            _type = s.type;
        }

        public Stationing(uint newValue, uint newType)
        {
            _value = newValue;
            _type = newType;
        }

        //-----------------------
    }
}
