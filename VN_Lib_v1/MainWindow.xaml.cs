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
         * [0] - основной layout
         * [1] - меню
         */
        public void GenerateMainMenu()
        {
            this.Height = GameConfig.GetScreenHeight();
            this.Width = GameConfig.GetScreenWidth();
            this.Content = config.GetElements()[0];
            this.RegisterName("MainLayout", config.GetElements()[0]);
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
            /*WrapPanel main_panel = (WrapPanel)this.FindName("MainLayout");
            if (main_panel != null)
            {
                if (this.WindowState == WindowState.Maximized)
                {
                    main_panel.Height = this.MaxHeight;
                    main_panel.Width = this.MaxWidth;
                }
                else if (this.WindowState == WindowState.Maximized)
                {
                    main_panel.Height = this.MinHeight;
                    main_panel.Width = this.MinWidth;
                }
                else
                {
                    main_panel.Height = this.Height;
                    main_panel.Width = this.Width;
                }
                    
                BitmapImage back = new BitmapImage
                    (new Uri(config.GetBackgroundPath(), UriKind.Relative));
                ImageBrush backBrush = new ImageBrush(back);
                main_panel.Background = backBrush;
            }*/
        }
    }
}
