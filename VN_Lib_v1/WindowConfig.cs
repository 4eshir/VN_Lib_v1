using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VN_Lib_v1
{
    public class WindowConfig
    {
        //------------------------------------------------

        /*
         * Переменная, хранящая основной слой
         * приложения типа Grid
         */
        private Grid _mainGrid;

        //--Свойства--
        public Grid mainGrid
        {
            set { _mainGrid = value; }
            get { return _mainGrid; }
        }
        //------------

        /*
         * Переменная, хранящая путь к фоновому
         * изображению главного меню приложения
         */
        private string _backgroundPath;

        //--Свойства--
        public string backgroundPath
        {
            set { _backgroundPath = value; }
            get { return _backgroundPath; }
        }
        //------------

        /*
         * Текущая высота окна приложения
         */
        private int _currentScreenHeight;

        //--Свойства--
        public int currentScreenHeight
        {
            set { _currentScreenHeight = value; }
            get { return _currentScreenHeight; }
        }
        //------------

        /*
         * Текущая ширина окна приложения
         */
        private int _currentScreenWidth;

        //--Свойства--
        public int currentScreenWidth
        {
            set { _currentScreenWidth = value; }
            get { return _currentScreenWidth; }
        }
        //------------

        /*
         * Список элементов, расположенных в окне
         */
        private List<Object> _elements;

        //--Свойства--
        public List<Object> elements
        {
            set { _elements = value; }
            get { return _elements; }
        }
        //------------


        /*
         * Специальные настройки окна
         */
        private SpecialConfig _specialConfig;

        //--Свойства--
        public SpecialConfig specialConfig
        {
            set { _specialConfig = value; }
            get { return _specialConfig; }
        }
        //------------

        //------------------------------------------------

        //------------------------------------------------

        //--Конструкторы класса--

        public WindowConfig()
        {
            _currentScreenHeight = Constants.DEFAULT_SCREEN_HEIGHT;
            _currentScreenWidth = Constants.DEFAULT_SCREEN_WIDTH;
            _backgroundPath = "";
            _elements = new List<Object>();
            _specialConfig = new SpecialConfig();
            _mainGrid = new Grid();
        }

        public WindowConfig(WindowConfig config)
        {
            _currentScreenHeight = config.currentScreenHeight;
            _currentScreenWidth = config.currentScreenWidth;
            _backgroundPath = config.backgroundPath;
            _elements = config.elements;
            _specialConfig = config.specialConfig;
            _mainGrid = config.mainGrid;
        }

        public WindowConfig(String newPath, int newHeight, int newWidth, List<Object> newElements, SpecialConfig newConfig, Grid newGrid)
        {
            _currentScreenHeight = newHeight;
            _currentScreenWidth = newHeight;
            _backgroundPath = newPath;
            _elements = newElements;
            _specialConfig = newConfig;
            _mainGrid = newGrid;
        }

        //-----------------------

        

        //------------------------------------------------
    }
}
