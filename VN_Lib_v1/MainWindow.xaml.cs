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
            /*switch (type)
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
            }*/

        }
        //-----------------------

        



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


        /*
         * ------------------------------
         * --Обработчики нажатия кнопок--
         * ------------------------------
         */

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "Escape")
            {
                if (ObserverMainWindow.isContextMenu)
                {
                    ObserverMainWindow.contextMenu.Close();
                    ObserverMainWindow.isContextMenu = false;
                }

                if (ObserverMainWindow.windowType != Constants.MAIN_MENU_WINDOW)
                {
                    //--Создание окна контекстного меню--

                    SpecialConfigContextMenu sccm = new SpecialConfigContextMenu();

                    sccm.leftRightMargin = new Stationing(20, Constants.PERCENT);
                    sccm.upDownMargin = new Stationing(5, Constants.PERCENT);

                    List<Stationing> heights = new List<Stationing>();
                    heights.Add(new Stationing(15, Constants.PERCENT));

                    sccm.buttonHeights = heights;

                    List<MenuButton> buttons = new List<MenuButton>();
                    Button b = new Button();
                    b.Content = "Продолжить";
                    buttons.Add(new MenuButton(b, 0));
                    b = new Button();
                    b.Content = "Сохранить игру";
                    buttons.Add(new MenuButton(b, 0));
                    b = new Button();
                    b.Content = "Загрузить игру";
                    buttons.Add(new MenuButton(b, 0));
                    b = new Button();
                    b.Content = "Выйти в главное меню";
                    buttons.Add(new MenuButton(b, 0));

                    sccm.menuItems = buttons;
                    sccm.menuType = Constants.VERTICAL_MENU;

                    sccm.upDownMarginWindow = 0;
                    sccm.leftRightMarginWindow = 0;

                    SpecialConfig sc = new SpecialConfig();
                    sc.contextMenuConfig = sccm;

                    WindowConfig c = new WindowConfig();

                    c.backgroundPath = "images\\back_context.jpg";

                    c.screenHeight = 500;
                    c.screenWidth = 350;
                    c.specialConfig = sc;

                    ContextMenuTemplate cmt = new ContextMenuTemplate(c);

                    ContextMenu cm = cmt.CreateTemplate();

                    ObserverMainWindow.isContextMenu = true;
                    ObserverMainWindow.contextMenu = cm;

                    //-----------------------------------


                    cm.ShowDialog();
                }
            }
        }

        //-------------------------------
    }
}
