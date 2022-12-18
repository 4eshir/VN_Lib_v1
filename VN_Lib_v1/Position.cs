using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace VN_Lib_v1
{
    public class Position
    {
        /*
         * Тип позиционирования
         * 0 - абсолютное позиционирование (x/y)
         * 1 - позиционирование в таблице (row/col)
         */
        private uint _positionType;

        //--Свойства--
        public uint positionType
        {
            set { _positionType = value; }
            get { return _positionType; }
        }
        //------------

        /*
         * Позиция элемента
         */
        private List<Pair<int>> _positionValue;

        //--Свойства--
        public List<Pair<int>> positionValue
        {
            set { _positionValue = value; }
            get { return _positionValue; }
        }
        //------------

        //------------------------------------------------

        //--Конструкторы класса--

        public Position(uint newType, int first, int second)
        {
            _positionType = newType;
            _positionValue = new List<Pair<int>>();
            _positionValue.Add(new Pair<int>());
            _positionValue.Add(new Pair<int>());

            _positionValue[(int)newType] = new Pair<int>(first, second);
        }

        //-----------------------

        //------------------------------------------------
    }
}
