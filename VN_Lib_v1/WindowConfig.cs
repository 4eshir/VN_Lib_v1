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
         * Тип позиционирования
         * 0 - абсолютное позиционирование (пустой Grid)
         * 1 - относительное позиционирование (конкретная ячейка Grid)
         */
        private uint _positioiningType;

        //--Свойства--
        public uint positioiningType
        {
            set { _positioiningType = value; }
            get { return _positioiningType; }
        }
        //------------

        /*
         * Размерность Grid
         * _row - количество строк
         * _col - количество столбцов
         */
        private uint _row;
        private uint _col;

        //--Свойства--
        public uint row
        {
            set { _row = value; }
            get { return _row; }
        }

        public uint col
        {
            set { _col = value; }
            get { return _col; }
        }
        //------------

        /*
         * Высота и ширина строк и столбцов Grid
         * _rowHeight - высота строк (в процентах)
         * _colWidth - ширина столбцов (в процентах)
         */
        private List<uint> _rowHeight;
        private List<uint> _colWidth;

        //--Свойства--
        public List<uint> rowHeight
        {
            set { _rowHeight = value; }
            get { return _rowHeight; }
        }

        public List<uint> colWidth
        {
            set { _colWidth = value; }
            get { return _colWidth; }
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
        private uint _screenHeight;

        //--Свойства--
        public uint screenHeight
        {
            set { _screenHeight = value; }
            get { return _screenHeight; }
        }
        //------------

        /*
         * Текущая ширина окна приложения
         */
        private uint _screenWidth;

        //--Свойства--
        public uint screenWidth
        {
            set { _screenWidth = value; }
            get { return _screenWidth; }
        }
        //------------

        /*
         * Блокировка ресайза окна
         */
        private uint _resizeState;

        //--Свойства--
        public uint resizeState
        {
            set { _resizeState = value; }
            get { return _resizeState; }
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
            _screenHeight = Constants.DEFAULT_SCREEN_HEIGHT;
            _screenWidth = Constants.DEFAULT_SCREEN_WIDTH;
            _backgroundPath = "";
            _specialConfig = new SpecialConfig();
            _mainGrid = new Grid();
            _row = 0;
            _col = 0;
            _rowHeight = new List<uint>();
            _colWidth = new List<uint>();
        }

        public WindowConfig(WindowConfig config)
        {
            _screenHeight = config.screenHeight;
            _screenWidth = config.screenWidth;
            _backgroundPath = config.backgroundPath;
            _specialConfig = config.specialConfig;
            _mainGrid = config.mainGrid;
            _row = config.row;
            _col = config.col;
            _rowHeight = config.rowHeight;
            _colWidth = config.colWidth;
        }

        public WindowConfig(String newPath, uint newHeight, uint newWidth, SpecialConfig newConfig, Grid newGrid, uint newRow, uint newCol, List<uint> newRowHeight, List<uint> newColWidth)
        {
            _screenHeight = newHeight;
            _screenWidth = newWidth;
            _backgroundPath = newPath;
            _specialConfig = newConfig;
            _mainGrid = newGrid;
            _row = newRow;
            _col = newCol;
            _rowHeight = newRowHeight;
            _colWidth = newColWidth;
        }

        //-----------------------

        

        //------------------------------------------------
    }
}
