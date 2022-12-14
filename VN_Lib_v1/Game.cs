using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VN_Lib_v1
{
    /*
     * Основной класс игры
     */
    class Game
    {
        //------------------------------------------------------------------

        /*
         * ------------------------------------------
         * Переменная состояния игры на данный момент
         * ------------------------------------------
         * 0 - игра завершена
         * 1 - игра в главном меню
         * 2 - игра в основном потоке (игровой процесс)
         * 3 - игра в основном потоке, приостановлена (меню паузы)
         */
        private uint _state;

        //--Свойства--
        public uint state
        {
            set { _state = value; }
            get { return _state; }
        }
        //------------

        /*
         * --------------------------------------------------------
         * Переменная состояния элементов контроля на данный момент
         * --------------------------------------------------------
         * 0 - элементы контроля отсутствуют
         * 1 - элементы контроля недоступны
         * 2 - элементы контроля доступны
         */
        private uint _control;

        //--Свойства--
        public uint control
        {
            set { _control = value; }
            get { return _control; }
        }
        //------------

        private GameConfig _gameConfig;

        //--Свойства--
        public GameConfig gameConfig
        {
            set { _gameConfig = value; }
            get { return _gameConfig; }
        }
        //------------


        /*
         * -----------------
         * Главное окно игры
         * -----------------
         */
        private MainWindow _window;

        //--Свойства--
        public MainWindow window
        {
            set { _window = value; }
            get { return _window; }
        }
        //------------

        //------------------------------------------------------------------


        //------------------------------------------------------------------

        //-------------------------------------------

        //--Конструкторы класса--

        public Game()
        {
            _state = 1;
            _control = 0;
            _window = new MainWindow();
        }

        public Game(uint newState, uint newControl, MainWindow newWindow)
        {
            _state = newState;
            _control = newControl;
            _window = newWindow;
        }

        //-----------------------

        //--Функция старта игры--
        /*
         * Для запуска используются:
         * - переменная state (установлена в 1)
         * - переменная control (установлена в 0)
         * - переменная config (config.screen_width/config.screen_height используются для установки стартового размера экрана)
         * 
         * Функция открывает окно класса MainWindow
         */
        public void StartGame()
        {
            GameareaTemplate template = new GameareaTemplate();
            _window = template.CreateTemplate();
            _window.Show();
        }

        //------------------------------------------------------------------
    }
}
