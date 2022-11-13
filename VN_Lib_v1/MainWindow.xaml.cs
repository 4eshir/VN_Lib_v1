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
        private WindowConfig config;

        //---------------------------------

        //--Конструкторы класса--
        public MainWindow()
        {
            InitializeComponent();
            config = new WindowConfig();
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
            config = c;
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
            this.Height = GameConfig.screenHeight;
            this.Width = GameConfig.screenWidth;

            Grid main_grid = (Grid)config.elements[0];
            CreateGrid(main_grid);

            //main_grid.Children.Add((WrapPanel)config.GetElements()[1]);

            this.Content = main_grid;
            this.RegisterName("MainLayout", main_grid);
        }

        /*
         * Создание сетки Grid
         * На основе данных из WindowConfig.SpecialConfig.SpecialConfigMenu
         */
        private void CreateGrid(Grid g)
        {
            RowDefinitionCollection rd = g.RowDefinitions;
            ColumnDefinitionCollection cd = g.ColumnDefinitions;
            for (int i = 0; i != config.specialConfig.menuConfig.row; i++)
            {
                rd.Add(new RowDefinition());
                for (int j = 0; j < config.specialConfig.menuConfig.col; j++)
                {
                    cd.Add(new ColumnDefinition());
                }

                Button b = new Button();
                b.Name = "Button" + i;

            }
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
