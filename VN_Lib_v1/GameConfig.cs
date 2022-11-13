using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VN_Lib_v1
{
    /*
     * Класс глобальных настроек игры
     */
    public static class GameConfig
    {
        //------------------------------------------

        /*
         * ----------------
         * Ширина окна игры
         * ----------------
         */
        private static int _screenWidth;

        //--Свойства--
        public static int screenWidth
        {
            set { _screenWidth = value; }
            get { return _screenWidth; }
        }
        //------------

        /*
         * ----------------
         * Высота окна игры
         * ----------------
         */
        private static int _screenHeight;

        //--Свойства--
        public static int screenHeight
        {
            set { _screenHeight = value; }
            get { return _screenHeight; }
        }
        //------------


        //------------------------------------------

        //------------------------------------------

        /*//--Конструкторы класса--

        public GameConfig()
        {
            screen_width = Constants.DEFAULT_SCREEN_WIDTH;
            screen_height = Constants.DEFAULT_SCREEN_HEIGHT;
        }

        public GameConfig(GameConfig c)
        {
            screen_width = c.screen_width;
            screen_height = c.screen_height;
        }

        //-----------------------*/

        //--Метод для установки размеров экрана--
        public static void SetScreenSize(int w, int h)
        {
            _screenWidth = w;
            _screenHeight = h;
        }
        //---------------------------------------

        //------------------------------------------
    }
}
