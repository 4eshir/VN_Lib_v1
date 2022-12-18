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
    class MainMenuTemplate : GameareaTemplate
    {
        //------------------------------------------------

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
            BitmapImage back = new BitmapImage
                (new Uri(config.backgroundPath, UriKind.Relative));
            _config.mainGrid.Background = new ImageBrush(back);
            //----------------------------

            window.Height = config.screenHeight;
            window.Width = config.screenWidth;


            CreateGrid(_config.mainGrid);
            CreateMenuButton(_config.mainGrid);


            window.Content = _config.mainGrid;
            window.RegisterName("MainLayout", _config.mainGrid);            

            return window;
        }

        //------------------------------------------------


        /*
         * Создание сетки Grid
         * На основе данных из WindowConfig:
         * * row/col - количество строк/столбцов,
         * * rowHeight/colHeight - высота строк/ширина столбцов
         */
        private void CreateGrid(Grid g)
        {
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

        /*
         * Создание главного меню (кнопки)
         */
        private void CreateMenuButton(Grid g)
        {
            StackPanel panel = new StackPanel();
            if (config.specialConfig.menuConfig.menuType == 0) panel.Orientation = Orientation.Vertical;
            if (config.specialConfig.menuConfig.menuType == 1) panel.Orientation = Orientation.Horizontal;
            foreach (Object btn in config.specialConfig.menuConfig.menuItems)
            {
                Button b = (Button)btn;
                panel.Children.Add(b);
            }
            Grid.SetRow(panel, config.specialConfig.menuConfig.menuPosition.positionValue[Constants.GRID_POSITION].first);
            Grid.SetColumn(panel, config.specialConfig.menuConfig.menuPosition.positionValue[Constants.GRID_POSITION].second);
            panel.VerticalAlignment = VerticalAlignment.Center;
            g.Children.Add(panel);
        }
    }
}
