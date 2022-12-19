using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VN_Lib_v1
{
    public class MenuButton
    {
        /*
         * Кнопка меню
         */
        private Button _button;

        //--Свойства--
        public Button button
        {
            set { _button = value; }
            get { return _button; }
        }
        //------------

        /*
         * Тип кнопки меню
         */
        private uint _buttonType;

        //--Свойства--
        public uint buttonType
        {
            set { _buttonType = value; }
            get { return _buttonType; }
        }
        //------------


        //--Конструкторы класса--

        public MenuButton()
        {
            _button = new Button();
            _buttonType = Constants.DEFAULT_BUTTON;
        }

        public MenuButton(Button newButton, uint newButtonType)
        {
            _button = newButton;
            _buttonType = newButtonType;
        }

        //-----------------------
    }
}
