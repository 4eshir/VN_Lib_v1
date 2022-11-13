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

        //------------------------------


        //------------------------------
    }
}
