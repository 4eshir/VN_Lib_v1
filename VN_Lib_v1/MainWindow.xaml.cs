using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace VN_Lib_v1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //---------------------------------

        /*
         * ----------------------------
         * Переменная конфигурации окна
         * ----------------------------
         */
        private WindowConfig _config;

        public WindowConfig config
        {
            set { _config = value; }
            get { return _config; }
        }

        //---------------------------------

        //--Конструкторы класса--
        public MainWindow()
        {
            InitializeComponent();
            _config = new WindowConfig();
        }

        /*
         * --------------------
         * Основной конструктор
         * --------------------
         * type - тип отрисовываемого окна
         * * 0 - пустое окно
         * * 1 - окно главного меню
         * * 2 - окно активного геймплея
         * * 3 - окно пассивного геймплея
         */
        public MainWindow(WindowConfig c, int type)
        {
            InitializeComponent();
            _config = c;
            switch (type)
            {
                case 1:
                    GenerateMainMenu();
                    break;
                case 2:
                    GenerateGameplayActive();
                    break;
                case 3:
                    GenerateGameplayPassive();
                    break;
                default:
                    GenerateDefaultWindow();
                    break;
            }

        }
        //-----------------------

        /*
         * config.elements - все объекты в окне
         * [0] - основной layout (Grid)
         * [1] - меню (WrapPanel)
         */
        public void GenerateMainMenu()
        {
            this.Height = config.screenHeight;
            this.Width = config.screenWidth;

            BitmapImage back = new BitmapImage
                (new Uri(config.backgroundPath, UriKind.Relative));
            _config.mainGrid.Background = new ImageBrush(back);

            CreateGrid(_config.mainGrid);
            CreateMenuButton(_config.mainGrid);


            this.Content = _config.mainGrid;
            this.RegisterName("MainLayout", _config.mainGrid);
        }

        /*
         * Создание сетки Grid
         * На основе данных из WindowConfig.SpecialConfig.SpecialConfigMenu
         */
        private void CreateGrid(Grid g)
        {
            RowDefinitionCollection rd = g.RowDefinitions;
            ColumnDefinitionCollection cd = g.ColumnDefinitions;
            for (int i = 0; i != config.row; i++)
            {
                rd.Add(new RowDefinition());
            }

            for (int j = 0; j < config.col; j++)
            {
                cd.Add(new ColumnDefinition());
            }
        }

        /*
         * Создание главного меню (кнопки)
         */
        private void CreateMenuButton(Grid g)
        {
            StackPanel panel = new StackPanel();
            foreach (Object btn in config.specialConfig.menuConfig.menuItems)
            {
                Button b = (Button)btn;
                panel.Children.Add(b);
            }
            Grid.SetRow(panel, 1);
            Grid.SetColumn(panel, 1);
            g.Children.Add(panel);
        }

        public void GenerateGameplayActive()
        {

        }

        public void GenerateGameplayPassive()
        {

        }

        public void GenerateDefaultWindow()
        {

        }

        /*
         * Перерисовка фона после изменения размеров окна
         */
        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Grid main_grid = (Grid)this.FindName("MainLayout");
            if (main_grid != null)
            {
                main_grid.Height = this.ActualHeight;
                main_grid.Width = this.ActualWidth;
                    
                BitmapImage back = new BitmapImage
                    (new Uri(config.backgroundPath, UriKind.Relative));
                ImageBrush backBrush = new ImageBrush(back);
                main_grid.Background = backBrush;
            }
        }
    }
}
