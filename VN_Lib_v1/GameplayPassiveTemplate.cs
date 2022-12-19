using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows;

namespace VN_Lib_v1
{
    /*
     * Класс, реализующий генерацию объектов
     * в окне для состояния игрового процесса без контроля игрока
     */
    class GameplayPassiveTemplate : GameplayTemplate
    {
        //------------------------------------------------

        //------------------------------------------------


        //------------------------------------------------

        //--Конструкторы класса--

        public GameplayPassiveTemplate()
        {
            config = new WindowConfig();
        }

        public GameplayPassiveTemplate(WindowConfig c)
        {
            config = c;
        }

        //-----------------------


        /*
        * --------------------------------------
        * Override функция, возвращающее готовое
        * окно класса MainWindow с главным меню
        * --------------------------------------
        *
        * config.elements - все объекты в окне
        * [0] - основной layout (Grid)
        * [1] - меню (WrapPanel)
        */
        public override MainWindow CreateTemplate()
        {
            MainWindow window = new MainWindow(config, 1);

            //--??Возможно на удаление??--
            //List<Object> elements = new List<Object>(); 

            SetLayoutSize(); //устанавливаем общий layout

            //--Задаем фон общему layout--
            /*BitmapImage back = new BitmapImage
                (new Uri(config.backgroundPath, UriKind.Relative));
            config.mainGrid.Background = new ImageBrush(back);*/
            //----------------------------

            window.Height = config.screenHeight;
            window.Width = config.screenWidth;

            config.mainGrid = new Grid();

            CreateGrid(config.mainGrid);
            //CreateMenuButton(config.mainGrid);


            window.Content = config.mainGrid;
            window.RegisterName("MainLayout", config.mainGrid);

            return window;
        }


        /*
         * Создание сетки Grid
         * Для окна пассивного геймлпея:
         * Столбцов: 1
         * Строк: 1
         */
        private void CreateGrid(Grid g)
        {
            g.Children.Clear();
            g.RowDefinitions.Clear();
            g.ColumnDefinitions.Clear();

            RowDefinitionCollection rd = g.RowDefinitions;
            ColumnDefinitionCollection cd = g.ColumnDefinitions;

            RowDefinition row = new RowDefinition();
            rd.Add(row);

            ColumnDefinition col = new ColumnDefinition();
            cd.Add(col);

            g.ShowGridLines = true;
        }

        //------------------------------------------------

    }
}
