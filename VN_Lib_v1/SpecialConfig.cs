using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;

namespace VN_Lib_v1
{
    public class SpecialConfig
    {
        //------------------------------

        /*
         * Конфигурации главного меню
         */
        private SpecialConfigMenu _menuConfig;

        //--Свойства--
        public SpecialConfigMenu menuConfig
        {
            set { _menuConfig = value; }
            get { return _menuConfig; }
        }
        //------------

        /*
         * Конфигурации окна пассивного геймплея
         */
        private SpecialConfigPassiveGameplay _passiveGameplayConfig;

        //--Свойства--
        public SpecialConfigPassiveGameplay passiveGameplayConfig
        {
            set { _passiveGameplayConfig = value; }
            get { return _passiveGameplayConfig; }
        }
        //------------

        /*
         * Конфигурации для контекстного меню
         */
        private ConfigContextMenu _contextMenuConfig;

        //--Свойства--
        public ConfigContextMenu contextMenuConfig
        {
            set { _contextMenuConfig = value; }
            get { return _contextMenuConfig; }
        }
        //------------

        //------------------------------


        //------------------------------
    }
}
