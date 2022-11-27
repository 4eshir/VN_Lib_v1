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
         * Стиль элементов меню
         */

        //----------------------------

        //----------------------------

        //--Конструкторы класса--

        public SpecialConfigMenu()
        {
            _menuType = 0;
            _menuItems = new List<Button>();
        }

        public SpecialConfigMenu(SpecialConfigMenu new_config)
        {
            _menuType = new_config.menuType;
            _menuItems = new_config.menuItems;
        }

        public SpecialConfigMenu(int menuType, List<Button> menuItems, int row, int col)
        {
            _menuType = menuType;
            _menuItems = menuItems;
        }

        //-----------------------

        

        //----------------------------
    }
}
