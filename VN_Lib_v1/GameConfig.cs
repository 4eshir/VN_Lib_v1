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
    public class GameConfig
    {
        //------------------------------------------

        /*
         * ----------------
         * Ширина окна игры
         * ----------------
         */
        private int _screenWidth;

        //--Свойства--
        public int screenWidth
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
        private int _screenHeight;

        //--Свойства--
        public int screenHeight
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
        public void SetScreenSize(int w, int h)
        {
            _screenWidth = w;
            _screenHeight = h;
        }
        //---------------------------------------

        //------------------------------------------
    }
}
