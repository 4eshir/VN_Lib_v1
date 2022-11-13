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
        }

        public void StartGame()
        {
            SpecialConfigMenu scm = new SpecialConfigMenu();
            scm.row = 3;
            scm.col = 3;
            List<Button> buttons = new List<Button>();
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
            scm.menuType = 0;

            SpecialConfig sc = new SpecialConfig();


            WindowConfig c = new WindowConfig();
            MainWindow w = new MainWindow();
            Game g = new Game();
            
            
            


        }
    }
}
