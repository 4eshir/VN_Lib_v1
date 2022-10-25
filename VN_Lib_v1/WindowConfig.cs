using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VN_Lib_v1
{
    public class WindowConfig
    {
        //------------------------------------------------

        /*
         * Переменная, хранящая путь к фоновому
         * изображению главного меню приложения
         */
        private String _background_path;

        /*
         * Текущая высота окна приложения
         */
        private int _current_screen_height;


        /*
         * Текущая ширина окна приложения
         */
        private int _current_screen_width;

        /*
         * Список элементов, расположенных в окне
         */
        private List<Object> _elements;


        /*
         * Специальные настройки окна
         */
        private SpecialConfig _special_config;

        //------------------------------------------------

        //------------------------------------------------

        //--Конструкторы класса--

        public WindowConfig()
        {
            _current_screen_height = Constants.DEFAULT_SCREEN_HEIGHT;
            _current_screen_width = Constants.DEFAULT_SCREEN_WIDTH;
            _background_path = "";
            _elements = new List<Object>();
            _special_config = new SpecialConfig();
        }

        public WindowConfig(WindowConfig config)
        {
            _current_screen_height = config.GetCurrentHeight();
            _current_screen_width = config.GetCurrentWidth();
            _background_path = config.GetBackgroundPath();
            _elements = config.GetElements();
            _special_config = config.GetSpecialConfig();
        }

        public WindowConfig(String new_path, int new_height, int new_width, List<Object> new_elements, SpecialConfig new_config)
        {
            _current_screen_height = new_height;
            _current_screen_width = new_width;
            _background_path = new_path;
            _elements = new_elements;
            _special_config = new_config;
        }

        //-----------------------

        //--Геттер для пути к фоновому изображению--
        public String GetBackgroundPath() { return _background_path; }
        //------------------------------------------

        //--Сеттер для пути к фоновому изображению--
        public void SetBackgroundPath(String new_path) { _background_path = new_path; }
        //------------------------------------------

        //--Геттер для получения текущей высоты окна приложения--
        public int GetCurrentHeight() { return _current_screen_height; }
        //-------------------------------------------------------

        //--Сеттер для изменения текущей высоты окна приложения--
        public void SetCurrentHeight(int new_height) { _current_screen_height = new_height; }
        //-------------------------------------------------------

        //--Геттер для получения текущей ширины окна приложения--
        public int GetCurrentWidth() { return _current_screen_width; }
        //-------------------------------------------------------

        //--Сеттер для изменения текущей ширины окна приложения--
        public void SetCurrentWidth(int new_width) { _current_screen_width = new_width; }
        //-------------------------------------------------------

        //--Геттер для получения элементов контроля в окне--
        public List<Object> GetElements() { return _elements; }
        //--------------------------------------------------

        //--Сеттер для изменения элементов контроля в окне--
        public void SetElements(List<Object> new_elements) { _elements = new_elements; }
        //--------------------------------------------------

        //--Геттер для получения специальных конфигураций--
        public SpecialConfig GetSpecialConfig() { return _special_config; }
        //-------------------------------------------------

        //--Сеттер для изменения специальных конфигураций--
        public void SetSpecialConfig(SpecialConfig new_config) { _special_config = new_config; }
        //-------------------------------------------------

        //------------------------------------------------
    }
}
