using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows;

namespace VN_Lib_v1
{
    class ContextMenuTemplate
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

        public ContextMenuTemplate()
        {
            config = new WindowConfig();
        }

        public ContextMenuTemplate(WindowConfig c)
        {
            config = c;
        }

        //-----------------------


        /*
        * ------------------------------------------
        * Override функция, возвращающее готовое
        * окно класса ContextMenu с контекстным меню
        * ------------------------------------------
        *
        * config.elements - все объекты в окне
        * [0] - основной layout (Grid)
        * [1] - меню (WrapPanel)
        */
        public ContextMenu CreateTemplate()
        {
            ContextMenu window = new ContextMenu(config);

            window.Height = config.screenHeight;
            window.Width = config.screenWidth;

            config.mainGrid = new Grid();

            CreateMenuButton(config.mainGrid);

            //--Задаем фон общему layout--
            BitmapImage back = new BitmapImage
                (new Uri(config.backgroundPath, UriKind.Relative));
            config.mainGrid.Background = new ImageBrush(back);
            //----------------------------

            config.specialConfig.contextMenuConfig.SetButtonHeights(config.screenHeight);
            config.specialConfig.contextMenuConfig.SetButtonMargins(config.screenHeight, config.screenWidth);

            window.Content = config.mainGrid;
            window.RegisterName("NewGameLayout", config.mainGrid);

            SetWindowProperties(window);

            return window;
        }


        public void CreateMenuButton(Grid g)
        {
            StackPanel panel = new StackPanel();
            panel.Height = config.screenHeight;
            panel.Width = config.screenWidth;
            
            if (config.specialConfig.contextMenuConfig.menuType == 0) panel.Orientation = Orientation.Vertical;
            if (config.specialConfig.contextMenuConfig.menuType == 1) panel.Orientation = Orientation.Horizontal;
            foreach (Object btn in config.specialConfig.contextMenuConfig.menuItems)
            {
                MenuButton btn1 = (MenuButton)btn;
                //BindingMenuButtonHandlers(btn1.button, btn1.buttonType);
                panel.Children.Add(btn1.button);
            }

            panel.Margin = new Thickness(config.specialConfig.contextMenuConfig.leftRightMarginWindow,
                                        config.specialConfig.contextMenuConfig.upDownMarginWindow,
                                        config.specialConfig.contextMenuConfig.leftRightMarginWindow,
                                        config.specialConfig.contextMenuConfig.upDownMarginWindow);

            g.Children.Add(panel);
        }

        public void SetWindowProperties(ContextMenu cm)
        {
            cm.Owner = ObserverMainWindow.mainWindow;
            cm.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            cm.ShowInTaskbar = false;
            cm.WindowStyle = WindowStyle.None;
            cm.ResizeMode = ResizeMode.NoResize;
        }


            


        //------------------------------------------------
    }
}
