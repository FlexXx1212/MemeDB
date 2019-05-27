using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeDB.Controllers
{
    class ConfigController
    {
        public static string Path { get; set; }
        private static string FileName = "config.xml";

        #region singleton
        private static ConfigController instance;
        public static ConfigController Instance
        {
            get
            {
                if (instance == null)
                    instance = new ConfigController();
                return instance;
            }
        }
        #endregion

        private ConfigController()
        {
            LoadConfig();
        }

        private void LoadConfig()
        {
            throw new NotImplementedException();
        }
    }
}
