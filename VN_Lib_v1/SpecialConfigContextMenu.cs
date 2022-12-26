using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace VN_Lib_v1
{
    public class SpecialConfigContextMenu
    {
        //----------------------------

        //--Конфигурация контекстного меню

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
        private List<Stationing> _menuButtonHeihgts;

        //--Свойства--
        public List<Stationing> buttonHeights
        {
            set { _menuButtonHeihgts = value; }
            get { return _menuButtonHeihgts; }
        }
        //------------

        /*
         * Список элементов меню
         */
        private List<MenuButton> _menuItems;

        //--Свойства--
        public List<MenuButton> menuItems
        {
            set { _menuItems = value; }
            get { return _menuItems; }
        }
        //------------


        /*
         * Отступы 
         * * слева-справа
         * * сверху-снизу
         * от границ окна
         */
        private uint _leftRightMarginWindow;
        private uint _upDownMarginWindow;

        //--Свойства--
        public uint leftRightMarginWindow
        {
            set { _leftRightMarginWindow = value; }
            get { return _leftRightMarginWindow; }
        }
        //------------

        //--Свойства--
        public uint upDownMarginWindow
        {
            set { _upDownMarginWindow = value; }
            get { return _upDownMarginWindow; }
        }
        //------------


        /*
         * Отступы 
         * * слева-справа
         * * сверху-снизу
         * от пунктов меню
         */
        private Stationing _leftRightMargin;
        private Stationing _upDownMargin;

        //--Свойства--
        public Stationing leftRightMargin
        {
            set { _leftRightMargin = value; }
            get { return _leftRightMargin; }
        }
        //------------

        //--Свойства--
        public Stationing upDownMargin
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

        public SpecialConfigContextMenu()
        {
            _menuType = 0;
            _menuItems = new List<MenuButton>();
            _menuButtonHeihgts = new List<Stationing>();
        }

        public SpecialConfigContextMenu(SpecialConfigContextMenu new_config)
        {
            _menuType = new_config.menuType;
            _menuItems = new_config.menuItems;
            _leftRightMargin = new_config.leftRightMargin;
            _upDownMargin = new_config.upDownMargin;
            _menuButtonHeihgts = new_config.buttonHeights;
        }

        public SpecialConfigContextMenu(uint menuType, List<MenuButton> menuItems, List<Stationing> buttonHeights, Stationing newLeftRightMargin, Stationing newUpDownMargin)
        {
            _menuType = menuType;
            _menuItems = menuItems;
            _menuButtonHeihgts = buttonHeights;
            _leftRightMargin = newLeftRightMargin;
            _upDownMargin = newUpDownMargin;
        }

        //-----------------------


        //--Установка высоты кнопок меню--
        public bool SetButtonHeights(uint parentHeight)
        {
            if (_menuButtonHeihgts.Count > 1)
            {
                if (_menuButtonHeihgts.Count != _menuItems.Count)
                    return false;

                for (int i = 0; i < _menuItems.Count; i++)
                    if (_menuButtonHeihgts[i].type == Constants.PERCENT)
                        _menuItems[i].button.Height = _menuButtonHeihgts[i].value * parentHeight / 100;
                    else
                        _menuItems[i].button.Height = _menuButtonHeihgts[i].value;

                return true;
            }

            for (int i = 0; i < _menuItems.Count; i++)
                if (_menuButtonHeihgts[0].type == Constants.PERCENT)
                    _menuItems[i].button.Height = _menuButtonHeihgts[0].value * parentHeight / 100;
                else
                    _menuItems[i].button.Height = _menuButtonHeihgts[0].value;

            return true;
        }
        //--------------------------------

        //--Установка отступов--
        public bool SetButtonMargins(uint parentHeight, uint parentWidth)
        {
            if (_menuItems.Count < 1) return false;

            foreach (MenuButton btn in _menuItems)
            {
                uint leftRight = _leftRightMargin.value;
                uint topRight = _upDownMargin.value;

                if (_leftRightMargin.type == Constants.PERCENT) leftRight = _leftRightMargin.value * parentWidth / 100;
                if (_upDownMargin.type == Constants.PERCENT) topRight = _upDownMargin.value * parentHeight / 100;
                    
                btn.button.Margin = new Thickness(leftRight, topRight, leftRight, topRight);
            }
                

            return true;
        }
        //----------------------


        //----------------------------
    }
}
