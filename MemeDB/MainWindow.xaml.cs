using MemeDB.Models;
using NReco.VideoConverter;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

namespace MemeDB
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Meme> Memes { get; set; }

        public MainWindow()
        {
            Memes = new ObservableCollection<Meme>();
            InitializeComponent();

            BitmapImage bi = new BitmapImage();

            bi.BeginInit();
            bi.UriSource = new Uri(@"D:\Videos\Recordings\GFX\photo.jpg");
            bi.EndInit();

            Meme m = new Meme("Photo", @"D:\Videos\Recordings\VFX\MCDAB.mp4", new string[] { "minecraft", "dab", "mc", "dabben", "lit", "fam" }, bi);
            Memes.Add(m);


            using (MemoryStream memStream = new MemoryStream())
            {
                FFMpegConverter ffmpeg = new FFMpegConverter();
                ffmpeg.GetVideoThumbnail(@"D:\Videos\Recordings\VFX\MCDAB.mp4", @"D:\Videos\Recordings\VFX\MCDAB_thumb.jpg");
                BitmapImage img = new BitmapImage();
                img.BeginInit();
                img.UriSource = new Uri(@"D:\Videos\Recordings\VFX\MCDAB_thumb.jpg");
                img.EndInit();

                m = new Meme("MC Dab", @"D:\Videos\Recordings\VFX\MCDAB.mp4", new string[] { "minecraft", "dab", "mc", "dabben", "lit", "fam" }, img);
                Memes.Add(m);
            }


            
        }

        #region Window Bar
        private void WindowBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = (this.WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void WindowBar_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed && this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                this.Top = 0;
                this.DragMove();
            }
        }
        #endregion
    }
}
