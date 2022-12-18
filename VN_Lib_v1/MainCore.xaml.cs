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
            
            List<Button> buttons = new List<Button>();
            List<uint> heights = new List<uint>();
            heights.Add(50);
            Button b = new Button();
            b.Content = "Начать игру";
            buttons.Add(b);
            b = new Button();
            b.Content = "Опции";
            buttons.Add(b);
            b = new Button();
            b.Content = "Выйти";
            buttons.Add(b);
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
            MainWindow w = mainMenuTemplate.CreateTemplate();
            w.Show();



        }
    }
}
