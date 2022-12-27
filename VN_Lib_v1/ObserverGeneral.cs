using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VN_Lib_v1
{
    static class ObserverGeneral
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
         * Контекстное меню
         */
        private static ContextMenu _contextMenu;

        //--Свойства--
        public static ContextMenu contextMenu
        {
            set { _contextMenu = value; }
            get { return _contextMenu; }
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
         * Конфигурации главного меню
         */
        private static WindowConfig _windowConfigMainMenu;

        //--Свойства--
        public static WindowConfig windowConfigMainMenu
        {
            set { _windowConfigMainMenu = value; }
            get { return _windowConfigMainMenu; }
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

        /*
         * Открыто ли контекстное меню
         */
        private static bool _isContextMenu;

        //--Свойства--
        public static bool isContextMenu
        {
            set { _isContextMenu = value; }
            get { return _isContextMenu; }
        }
        //------------

        //------------------------------
    }
}
