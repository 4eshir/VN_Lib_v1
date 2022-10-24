using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VN_Lib_v1
{
    /*
     * Базовый класс для классов, реализующих генерацию
     * объектов в окне игры в заисимости от ее состояния
     */
    class GameareaTemplate
    {
        //----------------------------------------------------

        /*
         * --------------------------
         * Переменная, хранящая
         * конфигурации текущего окна
         * --------------------------
         */
        private WindowConfig config;

        /*
         * -----------------------------
         * Переменная глобального layout
         * -----------------------------
         */
        private Grid _base_layout;

        //----------------------------------------------------

        //----------------------------------------------------

        //--Геттер для глобального layout--
        public Grid GetBaseLayout() { return _base_layout; }
        //---------------------------------

        //--Сеттер для глобального layout--
        public void SetBaseLayout(Grid new_layout) { _base_layout = new_layout; }
        //---------------------------------

        //--Конструкторы класса--

        public GameareaTemplate()
        {
            _base_layout = new Grid();
            _base_layout.Name = "MainLayout";
        }

        public GameareaTemplate(Grid new_layout)
        {
            _base_layout = new_layout;
            _base_layout.Name = new_layout.Name;
        }

        //----------------------

        /*
         * Функция, задающая размер
         * базовому layout
         */
        public void SetLayoutSize()
        {
            _base_layout.Height = GameConfig.GetScreenHeight();
            _base_layout.Width = GameConfig.GetScreenWidth();
        }

        /*
         * Виртуальная функция, возвращающее готовое
         * окно класса MainWindow с соответствующими объектами
         */
        public virtual MainWindow CreateTemplate()
        {
            MainWindow window = new MainWindow();
            window.Height = GameConfig.GetScreenHeight();
            window.Width = GameConfig.GetScreenWidth();
            SetLayoutSize();
            window.Content = GetBaseLayout();
            return window;
        }

        //----------------------------------------------------
    }
}
