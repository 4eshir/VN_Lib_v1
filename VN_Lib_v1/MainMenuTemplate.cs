using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace VN_Lib_v1
{
    class MainMenuTemplate : GameareaTemplate
    {
        //------------------------------------------------

        /*
         * --------------------------
         * Переменная, хранящая
         * конфигурации текущего окна
         * --------------------------
         */
        private WindowConfig config;

        //------------------------------------------------


        //------------------------------------------------

        //--Конструкторы класса--

        public MainMenuTemplate()
        {
            config = new WindowConfig();
        }

        public MainMenuTemplate(WindowConfig c)
        {
            config = c;
        }

        //-----------------------

        /*
         * -------------------------------------
        * Override функция, возвращающее готовое
        * окно класса MainWindow с главным меню
        * --------------------------------------
        */
        public override MainWindow CreateTemplate()
        {
            List<Object> elements = new List<Object>();

            SetLayoutSize(); //устанавливаем общий layout

            //--Задаем фон общему layout--
            BitmapImage back = new BitmapImage
                (new Uri(config.GetBackgroundPath(), UriKind.Relative));
            ImageBrush backBrush = new ImageBrush(back);
            GetBaseLayout().Background = backBrush;
            elements.Add(GetBaseLayout());
            //----------------------------

            config.SetElements(elements);


            MainWindow window = new MainWindow(config, 1);

            return window;
        }

        //------------------------------------------------
    }
}
