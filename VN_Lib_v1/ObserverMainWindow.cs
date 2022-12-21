using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VN_Lib_v1
{
    static class ObserverMainWindow
    {
        //------------------------------

        /*
         * Главное окно игры
         */
        private static MainWindow _mainWindow;

        //--Свойства--
        public static MainWindow mainWindow
        {
            set { _mainWindow = value; }
            get { return _mainWindow; }
        }
        //------------

        /*
         * Конфигурации текущего окна
         */
        private static WindowConfig _windowConfig;

        //--Свойства--
        public static WindowConfig windowConfig
        {
            set { _windowConfig = value; }
            get { return _windowConfig; }
        }
        //------------

        /*
         * Тип текущего окна
         */
        private static uint _windowType;

        //--Свойства--
        public static uint windowType
        {
            set { _windowType = value; }
            get { return _windowType; }
        }
        //------------

        //------------------------------
    }
}
