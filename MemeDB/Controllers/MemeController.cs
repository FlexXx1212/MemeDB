using MemeDB.Models;
using NReco.VideoConverter;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MemeDB.Controllers
{
    class MemeController
    {
        public ObservableCollection<Meme> Memes { get; set; }

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

        private MemeController()
        {
            Memes = new ObservableCollection<Meme>();
            LoadMemes();
        }

        private void LoadMemes()
        {
            var meme1 = CreateMeme(@"D:\Videos\Recordings\VFX\MCDAB.mp4", new string[] { "minecraft", "dab", "mc", "dabben", "lit", "fam" });
            var meme2 = CreateMeme(@"D:\Videos\Recordings\VFX\SubscribeLike_GFX.mp4", new string[] { "subscribe", "like", "abonnieren", "gefällt", "sub" });
            Memes.Add(meme1);
            Memes.Add(meme2);
        }

        public Meme CreateMeme(string path, string[] tags = null)
        {
            using (MemoryStream memStream = new MemoryStream())
            {
                FFMpegConverter ffmpeg = new FFMpegConverter();
                ffmpeg.GetVideoThumbnail(path, path.Remove(path.Length - 3) + "jpg");
                BitmapImage img = new BitmapImage();
                img.BeginInit();
                img.UriSource = new Uri(path.Remove(path.Length - 3) + "jpg");
                img.EndInit();

                Meme m = new Meme(Path.GetFileNameWithoutExtension(path), path, tags, img);
                return m;
            }
        }
        
    }
}
