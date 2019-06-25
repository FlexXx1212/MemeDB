using NReco.VideoConverter;
using System.IO;
using System.Windows.Media;
using System.Drawing;
using System.Runtime.InteropServices;
using System;
using System.Windows.Media.Imaging;
using System.Windows;

namespace MemeDB.Models
{
    public class Meme
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string[] Tags { get; set; }
        public ImageSource Thumbnail { get; set; }
        public float? ThumbnailFrame { get; set; }

        public Meme(string name, string path, string[] tags, float? thumbnailFrame)
        {
            Name = name;
            Path = path;
            Tags = tags;
            ThumbnailFrame = thumbnailFrame;
            Thumbnail = GenerateThumbnail();
        }

        public ImageSource GenerateThumbnail(float? frame = null)
        {
            using (MemoryStream memStream = new MemoryStream())
            {
                FFMpegConverter ffmpeg = new FFMpegConverter();
                ffmpeg.GetVideoThumbnail(Path, memStream, frame != null ? frame : ThumbnailFrame);

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
    }
}
