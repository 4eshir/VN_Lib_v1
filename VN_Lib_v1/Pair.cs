using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VN_Lib_v1
{
    public class Pair<T>
    {
        /*
         * Элементы класса
         */
        private T _first;
        private T _second;

        //--Свойства--
        public T first
        {
            set { _first = value; }
            get { return _first; }
        }
        //------------

        //--Свойства--
        public T second
        {
            set { _second = value; }
            get { return _second; }
        }
        //------------

        //------------------------------------------------

        //--Конструкторы класса--

        public Pair()
        {
            _first = default(T);
            _second = default(T);
        }

        public Pair(T newFirst, T newSecond)
        {
            _first = newFirst;
            _second = newSecond;
        }

        public Pair(Pair<T> newPair)
        {
            _first = newPair.first;
            _second = newPair.second;
        }

        //-----------------------

        //------------------------------------------------
    }
}
