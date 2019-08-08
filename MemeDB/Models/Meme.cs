using NReco.VideoConverter;
using System.IO;
using System.Windows.Media;
using System.Drawing;
using System.Runtime.InteropServices;
using System;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Collections.Generic;
using WMPLib;

namespace MemeDB.Models
{
    public class Meme
    {
        #region Properties
        public string Name { get; set; }
        public string Path { get; set; }
        public string[] Tags { get; set; }
        public ImageSource Thumbnail { get; set; }
        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG", ".JPEG" };
        #endregion

        #region Constructor
        public Meme(string name, string path, string[] tags)
        {
            Name = name;
            Path = path;
            Tags = tags;

            if (ImageExtensions.Contains(System.IO.Path.GetExtension(path).ToUpperInvariant()))
            {
                BitmapImage img = new BitmapImage();
                img.BeginInit();
                img.UriSource = new Uri(path);
                img.EndInit();
                Thumbnail = img;
            }
            else
            {
                try
                {
                    Thumbnail = GenerateThumbnail();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error generating Thumbnail Image: " + ex.Message);
                }
            }
        }
        #endregion

        #region Functions

        public ImageSource GenerateThumbnail(float? frame = null)
        {
            using (MemoryStream memStream = new MemoryStream())
            {
                FFMpegConverter ffmpeg = new FFMpegConverter();

                var player = new WindowsMediaPlayer();
                var clip = player.newMedia(Path);

                ffmpeg.GetVideoThumbnail(Path, memStream, (float?) clip.duration / 2);
                
                using (Image image = Image.FromStream(memStream, true, false))
                {
                    var bitmapSource = GetImageStream(image);

                    return bitmapSource;
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
        #endregion
    }
}
