using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VN_Lib_v1
{
    public class SpecialConfigMenu
    {
        //----------------------------

        //--Конфигурация главного меню

        /*
         * Тип меню
         * 0 - вертикальное
         * 1 - горизонтальное
         */
        private int _menuType;

        //--Свойства--
        public int menuType
        {
            set { _menuType = value; }
            get { return _menuType; }
        }
        //------------

        /*
         * Список элементов меню
         */
        private List<Button> _menuItems;

        //--Свойства--
        public List<Button> menuItems
        {
            set { _menuItems = value; }
            get { return _menuItems; }
        }
        //------------

        /*
         * Размерность Grid
         * _row - количество строк
         * _col - количество столбцов
         */
        private int _row;
        private int _col;

        //--Свойства--
        public int row
        {
            set { _row = value; }
            get { return _row; }
        }

        public int col
        {
            set { _col = value; }
            get { return _col; }
        }
        //------------

        /*
         * Стиль элементов меню
         */

        //----------------------------

        //----------------------------

        //--Конструкторы класса--

        public SpecialConfigMenu()
        {
            _menuType = 0;
            _menuItems = new List<Button>();
            _row = 0;
            _col = 0;
        }

        public SpecialConfigMenu(SpecialConfigMenu new_config)
        {
            _menuType = new_config.menuType;
            _menuItems = new_config.menuItems;
            _row = new_config.row;
            _col = new_config.col;
        }

        public SpecialConfigMenu(int menuType, List<Button> menuItems, int row, int col)
        {
            _menuType = menuType;
            _menuItems = menuItems;
            _row = row;
            _col = col;
        }

        //-----------------------

        

        //----------------------------
    }
}
