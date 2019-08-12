using MemeDB.Models;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace MemeDB.Controllers
{
    class MemeController
    {
        #region Properties
        public static string FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MemeDB", "memes.json");
        public ObservableCollection<Meme> Memes { get; set; }
        #endregion
        
        #region Singelton
        private static MemeController instance;

        public static MemeController Instance
        {
            get
            {
                if (instance == null)
                    instance = new MemeController();
                return instance;
            }
        }
        #endregion

        #region Constructor
        private MemeController()
        {
            Memes = new ObservableCollection<Meme>();
            LoadMemes();
        }
        #endregion

        #region Functions
        private void LoadMemes()
        {
            if (File.Exists(FilePath))
            {
                try
                {
                    var fileContent = File.ReadAllText(FilePath);
                    Memes = JsonConvert.DeserializeObject<ObservableCollection<Meme>>(fileContent);
                }
                catch
                {
                    MessageBox.Show("Could not load Memes. Please make sure you have sufficient rights, and the file is not open in another program.", "Error Loading Data", MessageBoxButton.OK, MessageBoxImage.Error);
                    Memes = new ObservableCollection<Meme>();
                }
            }
        }

        public void Save()
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(FilePath));
                File.WriteAllText(FilePath, JsonConvert.SerializeObject(Memes,Formatting.Indented));
            } catch
            {
                MessageBox.Show("Could not save Memes. Please make sure you have sufficient rights, and the file is not open in another program.", "Error Saving Data", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Creates the Meme Object and adds it to the Meme Collection
        /// </summary>
        /// <param name="path">File Path</param>
        /// <param name="tags">List of Tags</param>
        /// <param name="name">Name of the Meme</param>
        /// <returns></returns>
        public Meme AddMeme(string path, string[] tags = null, string name = null)
        {
            if (MemeExists(path))
                return null;

            Meme m = new Meme(name == null ? Path.GetFileNameWithoutExtension(path) : name, path, tags);
            Memes.Add(m);
            Save();
            return m;
        }

        private bool MemeExists(string path)
        {
            foreach (var item in Memes)
            {
                if(item.Path == path)
                    return true;
            }
            return false;
        }

        public void DeleteMeme(Meme m)
        {
            if(Memes != null && Memes.Contains(m))
                Memes.Remove(m);
            Save();
        }
        #endregion
    }
}
