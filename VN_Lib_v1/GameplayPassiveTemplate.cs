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
           

            window.Height = config.screenHeight;
            window.Width = config.screenWidth;

            config.mainGrid = new Grid();

            CreateGrid(config.mainGrid);
            //CreateMenuButton(config.mainGrid);

            //--Задаем фон общему layout--
            BitmapImage back = new BitmapImage
                (new Uri(config.backgroundPath, UriKind.Relative));
            config.mainGrid.Background = new ImageBrush(back);
            //----------------------------


            window.Content = config.mainGrid;
            window.RegisterName("NewGameLayout", config.mainGrid);

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

            try
            {
                for (int i = 0; i != config.row; i++)
                {
                    RowDefinition row = new RowDefinition();

                    try
                    {
                        row.Height = new GridLength(config.rowHeight[i] / config.rowHeight.Min(), GridUnitType.Star);
                    }
                    catch (ArgumentOutOfRangeException e) //если не задан массив размерности, то устанавливаются размеры по умолчанию
                    {
                        //row.Height = new GridLength();
                    }

                    rd.Add(row);
                }


                for (int j = 0; j < config.col; j++)
                {
                    ColumnDefinition col = new ColumnDefinition();

                    try
                    {
                        col.Width = new GridLength(config.colWidth[j] / config.colWidth.Min(), GridUnitType.Star);
                    }
                    catch (ArgumentOutOfRangeException e) //если не задан массив размерности, то устанавливаются размеры по умолчанию
                    {
                        //col.Width = new GridLength();
                    }

                    cd.Add(col);
                }
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show(e.Message);
            }

            g.ShowGridLines = true;
        }

        //------------------------------------------------

    }
}
