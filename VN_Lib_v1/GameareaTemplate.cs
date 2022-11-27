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


        //----------------------------------------------------

        //--Конструкторы класса--

        public GameareaTemplate()
        {

        }

        public GameareaTemplate(Grid new_layout)
        {
            
        }

        //----------------------

        /*
         * Функция, задающая размер
         * базовому layout
         */
        public void SetLayoutSize()
        {
            
        }

        /*
         * Виртуальная функция, возвращающее готовое
         * окно класса MainWindow с соответствующими объектами
         */
        public virtual MainWindow CreateTemplate()
        {
            return new MainWindow();
        }

        //----------------------------------------------------
    }
}
