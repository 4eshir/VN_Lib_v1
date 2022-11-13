using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
        private WindowConfig _config;

        //--Свойства--
        public WindowConfig config
        {
            set { _config = value; }
            get { return _config; }
        }
        //------------

        /*
         * -----------------------------
         * Переменная глобального layout
         * -----------------------------
         */
        private Grid _baseLayout;

        //--Свойства--
        public Grid baseLayout
        {
            set { _baseLayout = value; }
            get { return _baseLayout; }
        }
        //------------

        //----------------------------------------------------

        //--Конструкторы класса--

        public GameareaTemplate()
        {
            _baseLayout = new Grid();
            _baseLayout.Name = "MainLayout";
        }

        public GameareaTemplate(Grid new_layout)
        {
            _baseLayout = new_layout;
            _baseLayout.Name = new_layout.Name;
        }

        //----------------------

        /*
         * Функция, задающая размер
         * базовому layout
         */
        public void SetLayoutSize()
        {
            _baseLayout.Height = GameConfig.screenHeight;
            _baseLayout.Width = GameConfig.screenWidth;
        }

        /*
         * Виртуальная функция, возвращающее готовое
         * окно класса MainWindow с соответствующими объектами
         */
        public virtual MainWindow CreateTemplate()
        {
            MainWindow window = new MainWindow();
            window.Height = GameConfig.screenHeight;
            window.Width = GameConfig.screenWidth;
            SetLayoutSize();
            window.Content = _baseLayout;
            return window;
        }

        //----------------------------------------------------
    }
}
