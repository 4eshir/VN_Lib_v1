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
                if (ObserverMainWindow.windowType != Constants.MAIN_MENU_WINDOW)
                {
                    ContextMenu cm = new ContextMenu();
                    SpecialConfigContextMenu sccm = new SpecialConfigContextMenu();
                    sccm.height = 500;
                    sccm.width = 350;

                    cm.Height = sccm.height;
                    cm.Width = sccm.width;

                    cm.Owner = ObserverMainWindow.mainWindow;
                    cm.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
                    cm.ShowInTaskbar = false;

                    cm.ShowDialog();
                }
            }
        }

        //-------------------------------
    }
}
