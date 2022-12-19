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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VN_Lib_v1
{
    /// <summary>
    /// Логика взаимодействия для MainCore.xaml
    /// </summary>
    public partial class MainCore : Window
    {
        public MainCore()
        {
            InitializeComponent();
            StartGame();
        }

        public void StartGame()
        {
            SpecialConfigMenu scm = new SpecialConfigMenu();
            scm.leftRightMargin = 200;
            scm.upDownMargin = 10;
            
            List<MenuButton> buttons = new List<MenuButton>();
            List<uint> heights = new List<uint>();
            heights.Add(50);
            Button b = new Button();
            b.Content = "Начать игру";
            buttons.Add(new MenuButton(b, Constants.START_NEW_GAME));
            b = new Button();
            b.Content = "Опции";
            buttons.Add(new MenuButton(b, Constants.OPTIONS));
            b = new Button();
            b.Content = "Выйти";
            buttons.Add(new MenuButton(b, Constants.QUIT));
            scm.menuItems = buttons;
            scm.buttonHeights = heights;
            scm.menuType = Constants.VERTICAL_MENU;
            scm.SetButtonHeights();
            scm.SetButtonMargins();
            scm.menuPosition = new Position(Constants.GRID_POSITION, 1, 2);



            SpecialConfig sc = new SpecialConfig();
            sc.menuConfig = scm;


            WindowConfig c = new WindowConfig();
            c.specialConfig = sc;
            c.backgroundPath = "images\\back.jpg";
            c.screenWidth = 1920;
            c.screenHeight = 1080;
            c.colWidth = new List<uint>() { 33 };
            c.rowHeight = new List<uint>() { 33 };
            c.row = 3;
            c.col = 3;

            MainMenuTemplate mainMenuTemplate = new MainMenuTemplate(c);
            ObserverMainWindow.windowConfig = c;
            ObserverMainWindow.mainWindow = mainMenuTemplate.CreateTemplate();
            ObserverMainWindow.mainWindow.Show();
/*
            GameplayPassiveTemplate gameplayPassiveTemplate = new GameplayPassiveTemplate(c);
            ObserverMainWindow.mainWindow.Content = gameplayPassiveTemplate.CreateTemplate().Content;
*/
        }
    }
}
