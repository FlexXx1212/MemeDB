using MemeDB.Models;
using NReco.VideoConverter;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

        /// <summary>
        /// Dummy Function to preload memes
        /// </summary>
        private void LoadMemes()
        {
            var meme1 = CreateAndAddMeme(@"D:\Videos\Recordings\VFX\MCDAB.mp4", new string[] { "minecraft", "dab", "mc", "dabben", "lit", "fam" });
            var meme2 = CreateAndAddMeme(@"D:\Videos\Recordings\VFX\SubscribeLike_GFX.mp4", new string[] { "subscribe", "like", "abonnieren", "gefällt", "sub" });
        }
        
        /// <summary>
        /// Creates the Meme Object and adds it to the Meme Collection
        /// </summary>
        /// <param name="path">File Path</param>
        /// <param name="tags">List of Tags</param>
        /// <returns></returns>
        public Meme CreateAndAddMeme(string path, string[] tags = null)
        {
            using (MemoryStream memStream = new MemoryStream())
            {
                FFMpegConverter ffmpeg = new FFMpegConverter();
                ffmpeg.GetVideoThumbnail(path, memStream);

                using (Image image = Image.FromStream(memStream, true, false))
                {
                    var bitmapSource = GetImageStream(image);
                    Meme m = new Meme(Path.GetFileNameWithoutExtension(path), path, tags, bitmapSource);
                    Memes.Add(m);
                    return m;
                }
            }
        }


        public static BitmapSource GetImageStream(Image myImage)
        {
            var bitmap = new Bitmap(myImage);
            IntPtr bmpPt = bitmap.GetHbitmap();
            BitmapSource bitmapSource =
             System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                   bmpPt,
                   IntPtr.Zero,
                   Int32Rect.Empty,
                   BitmapSizeOptions.FromEmptyOptions());

            //freeze bitmapSource and clear memory to avoid memory leaks
            bitmapSource.Freeze();
            
            DeleteObject(bmpPt);

            return bitmapSource;
        }

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DeleteObject(IntPtr value);
    }
}
