using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VN_Lib_v1
{
    static class Constants
    {
        //--Константы для класса GameConfig--
        public const int DEFAULT_SCREEN_WIDTH = 1280;
        public const int DEFAULT_SCREEN_HEIGHT = 720;
        //-----------------------------------

        //--Константы для типов меню--
        public const int VERTICAL_MENU = 0;
        public const int HORIZONTAL_MENU = 1;
        //----------------------------

        //--Константы для типов позиционирования--
        public const int ABSOLUTE_POSITION = 0;
        public const int GRID_POSITION = 1;
        //----------------------------------------

        //--Константы для типов источника данных--
        public const int FROM_ACTIVE_GAMEPLAY = 0;
        public const int FROM_PASSIVE_GAMEPLAY = 1;
        public const int FROM_MAIN_MENU = 2;
        //----------------------------------------

        //--Константы для функций главного меню--
        public const uint DEFAULT_BUTTON = 0;
        public const uint START_NEW_GAME = 1;
        public const uint OPTIONS = 2;
        public const uint QUIT = 3;
        //---------------------------------------
    }
}
