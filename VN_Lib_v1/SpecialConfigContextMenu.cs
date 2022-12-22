﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VN_Lib_v1
{
    public class SpecialConfigContextMenu
    {
        //----------------------------

        //--Конфигурация главного меню

        /*
         * Размеры окна
         * width - ширина окна
         * height - выоста окна
         */
        private uint _height;
        private uint _width;

        //--Свойства--
        public uint height
        {
            set { _height = value; }
            get { return _height; }
        }

        public uint width
        {
            set { _width = value; }
            get { return _width; }
        }
        //------------

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

        public SpecialConfigContextMenu()
        {
            _menuType = 0;
            _menuItems = new List<MenuButton>();
            _height = 200;
            _width = 150;
        }

        public SpecialConfigContextMenu(SpecialConfigContextMenu new_config)
        {
            _menuType = new_config.menuType;
            _menuItems = new_config.menuItems;
            _leftRightMargin = new_config.leftRightMargin;
            _upDownMargin = new_config.upDownMargin;
            _height = new_config.height;
            _width = new_config.width;

            SetButtonMargins();
        }

        public SpecialConfigContextMenu(uint menuType, List<MenuButton> menuItems, List<uint> buttonHeights, uint newLeftRightMargin, uint newUpDownMargin, uint newHeight, uint newWidth)
        {
            _menuType = menuType;
            _menuItems = menuItems;
            _menuButtonHeihgts = buttonHeights;
            _leftRightMargin = newLeftRightMargin;
            _upDownMargin = newUpDownMargin;
            _height = newHeight;
            _width = newHeight;

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
                    _menuItems[i].button.Height = _menuButtonHeihgts[i];

                return true;
            }

            for (int i = 0; i < _menuItems.Count; i++)
                _menuItems[i].button.Height = _menuButtonHeihgts[0];

            return true;
        }
        //--------------------------------

        //--Установка отступов--
        public bool SetButtonMargins()
        {
            if (_menuItems.Count < 1) return false;

            foreach (MenuButton btn in _menuItems)
                btn.button.Margin = new Thickness(_leftRightMargin, _upDownMargin, _leftRightMargin, _upDownMargin);

            return true;
        }
        //----------------------


        //----------------------------
    }
}