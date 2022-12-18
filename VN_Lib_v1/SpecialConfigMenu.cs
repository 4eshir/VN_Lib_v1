using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
        private uint _menuType;

        //--Свойства--
        public uint menuType
        {
            set { _menuType = value; }
            get { return _menuType; }
        }
        //------------

        /* Высоты кнопок меню
         * 1 элемент - одна высота для всех кнопок
         * 1+ элементов - различные высоты для всех кнопок
         */
        private List<uint> _menuButtonHeihgts;

        //--Свойства--
        public List<uint> buttonHeights
        {
            set { _menuButtonHeihgts = value; }
            get { return _menuButtonHeihgts; }
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
         * Список элементов меню
         */
        private Position _menuPosition;

        //--Свойства--
        public Position menuPosition
        {
            set { _menuPosition = value; }
            get { return _menuPosition; }
        }
        //------------

        /*
         * Отступы 
         * * слева-справа
         * * сверху-снизу
         * от пунктов меню
         */
        private uint _leftRightMargin;
        private uint _upDownMargin;

        //--Свойства--
        public uint leftRightMargin
        {
            set { _leftRightMargin = value; }
            get { return _leftRightMargin; }
        }
        //------------

        //--Свойства--
        public uint upDownMargin
        {
            set { _upDownMargin = value; }
            get { return _upDownMargin; }
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
            _menuPosition = new_config.menuPosition;
            _leftRightMargin = new_config.leftRightMargin;
            _upDownMargin = new_config.upDownMargin;

            SetButtonMargins();
        }

        public SpecialConfigMenu(uint menuType, List<Button> menuItems, List<uint> buttonHeights, Position newPosition, uint newLeftRightMargin, uint newUpDownMargin)
        {
            _menuType = menuType;
            _menuItems = menuItems;
            _menuButtonHeihgts = buttonHeights;
            _menuPosition = newPosition;
            _leftRightMargin = newLeftRightMargin;
            _upDownMargin = newUpDownMargin;

            SetButtonMargins();
        }

        //-----------------------


        //--Установка высоты кнопок меню--
        public bool SetButtonHeights()
        {
            if (_menuButtonHeihgts.Count > 1)
            {
                if (_menuButtonHeihgts.Count != _menuItems.Count)
                    return false;

                for (int i = 0; i < _menuItems.Count; i++)
                    _menuItems[i].Height = _menuButtonHeihgts[i];

                return true;
            }

            for (int i = 0; i < _menuItems.Count; i++)
                _menuItems[i].Height = _menuButtonHeihgts[0];

            return true;
        }
        //--------------------------------

        //--Установка отступов--
        public bool SetButtonMargins()
        {
            if (_menuItems.Count < 1) return false;

            foreach (Button btn in _menuItems)
                btn.Margin = new Thickness(_leftRightMargin, _upDownMargin, _leftRightMargin, _upDownMargin);

            return true;
        }
        //----------------------


        //----------------------------
    }
}
