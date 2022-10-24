using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private static int screen_width;

        /*
         * ----------------
         * Высота окна игры
         * ----------------
         */
        private static int screen_height;

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

        //--Геттер для получения ширины экрана--
        public static int GetScreenWidth() { return screen_width; }
        //--------------------------------------

        //--Геттер для получения высоты экрана--
        public static int GetScreenHeight() { return screen_height; }
        //--------------------------------------

        //--Сеттер для изменения ширины экрана--
        public static void SetScreenWidth(int new_screen_width) { screen_width = new_screen_width; }
        //--------------------------------------

        //--Сеттер для изменения высоты экрана--
        public static void SetScreenHeight(int new_screen_height) { screen_height = new_screen_height; }
        //--------------------------------------

        //--Метод для установки размеров экрана--
        public static void SetScreenSize(int w, int h)
        {
            screen_width = w;
            screen_height = h;
        }
        //---------------------------------------

        //------------------------------------------
    }
}
