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
            
            List<Button> buttons = new List<Button>();
            Button b = new Button();
            b.Content = "Начать игру";
            b.Height = 100;
            b.Width = 300;
            b.Margin = new Thickness(10);
            buttons.Add(b);
            b = new Button();
            b.Content = "Опции";
            b.Height = 100;
            b.Width = 300;
            b.Margin = new Thickness(10);
            buttons.Add(b);
            b = new Button();
            b.Content = "Выйти";
            b.Height = 100;
            b.Width = 300;
            b.Margin = new Thickness(10);
            buttons.Add(b);
            scm.menuItems = buttons;
            scm.menuType = 0;



            SpecialConfig sc = new SpecialConfig();
            sc.menuConfig = scm;


            WindowConfig c = new WindowConfig();
            c.specialConfig = sc;
            c.backgroundPath = "images\\back.jpg";
            c.screenWidth = 1920;
            c.screenHeight = 1080;
            c.row = 3;
            c.col = 3;

            MainWindow w = new MainWindow(c, 1);
            w.Show();



        }
    }
}
