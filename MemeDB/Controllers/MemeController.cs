using MemeDB.Models;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace MemeDB.Controllers
{
    class MemeController
    {
        #region Properties
        public static string FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MemeDB", "memes.xml");
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
        /// <summary>
        /// Dummy Function to preload memes
        /// </summary>
        private void LoadMemes()
        {
            var meme1 = AddMeme(@"D:\Videos\Recordings\VFX\MCDAB.mp4", new string[] { "minecraft", "dab", "mc", "dabben", "lit", "fam" }, "MC Dab");
            var meme2 = AddMeme(@"D:\Videos\Recordings\VFX\SubscribeLike_GFX.mp4", new string[] { "subscribe", "like", "abonnieren", "gefällt", "sub" }, "Subscribe & Like");
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
        }
        #endregion
    }
}
