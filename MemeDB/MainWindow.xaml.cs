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
using MemeDB.Controllers;

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
            Memes = MemeController.Instance.Memes;
            InitializeComponent();
        }

        private ObservableCollection<Meme> SearchTest(string text)
        {
            var result = new ObservableCollection<Meme>();

            foreach (var meme in Memes)
            {
                foreach (var tag in meme.Tags)
                {
                    if (tag.Contains(text))
                    {
                        result.Add(meme);
                        break;
                    }
                }
            }
            return result;
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

        private void WindowBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
                this.WindowState = (this.WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized;
        }
        #endregion

        private void txtSearchBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSearchBox.Text) == false)
                MainList.ItemsSource = SearchTest(txtSearchBox.Text);
            else
                MainList.ItemsSource = Memes;

            if (MainList.SelectedItem == null)
                MainList.SelectedIndex = 0;
        }

        private void MainList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Meme meme = MainList.SelectedItem as Meme;

            lbTags.Items.Clear();
            
            if (meme == null || meme.Tags == null || meme.Tags.Length == 0)
                return;

            if (MainList.SelectedItems != null && MainList.SelectedItems.Count > 1)
                return;
            
            foreach (var tag in meme.Tags)
            {
                lbTags.Items.Add(tag);
            }
        }

        private void MainList_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (var file in files)
                {
                    MemeController.Instance.CreateAndAddMeme(file);
                }
            }
        }

        private void MainList_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && MainList.SelectedItems != null && MainList.SelectedItems.Count > 0 && shouldDragDrop)
            {
                string[] filepaths = new string[MainList.SelectedItems.Count];
                int i = 0;
                foreach (var item in MainList.SelectedItems)
                    filepaths[i++] = ((Meme)item).Path;

                DataObject data = new DataObject(DataFormats.FileDrop, filepaths);
                data.SetData(DataFormats.StringFormat, filepaths);
                DragDrop.DoDragDrop(this, data, DragDropEffects.Copy);
            } else
            {
                shouldDragDrop = false;
            }
        }

        private bool shouldDragDrop = false;
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            shouldDragDrop = true;
        }
    }
}
