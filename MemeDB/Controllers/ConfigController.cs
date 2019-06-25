using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeDB.Controllers
{
    class ConfigController
    {
        public static string FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MemeDB", "config.xml");

        private Config config;
        public Config Config
        {
            get
            {
                return config;
            }
        }

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
            this.config = new Config();
            this.config.Language = "de-DE";
            this.config.Theme = Config.Themes.Dark;
        }
    }

    [Serializable]
    class Config
    {
        public string Language { get; set; }

        public Themes Theme { get; set; }

        public enum Themes
        {
            Light,
            Dark
        }
    }
}
