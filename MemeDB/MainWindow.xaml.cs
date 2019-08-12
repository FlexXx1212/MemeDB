using MemeDB.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using MemeDB.Controllers;
using System.Globalization;
using System.Threading;
using Microsoft.Win32;

namespace MemeDB
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Properties
        public ObservableCollection<Meme> Memes { get; set; }
        #endregion

        #region Constructor
        public MainWindow()
        {
            Memes = MemeController.Instance.Memes;
            InitializeComponent();
            InitText();
        }
        #endregion

        #region Functions
        private void InitText()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            //btnEdit.Content = Properties.Resources.ButtonEdit;
            //tbPreviewSearchBar.Text = Properties.Resources.PreviewSearchBar;
        }

        private ObservableCollection<Meme> SearchTest(string text)
        {
            var result = new ObservableCollection<Meme>();

            foreach (var meme in Memes)
            {
                // search in Name
                if (meme.Name.Contains(text))
                {
                    result.Add(meme);
                    continue;
                }

                // search in Tags
                if (meme.Tags != null && meme.Tags.Length > 0)
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
            }
            return result;
        }

        /// <summary>
        /// Opens the MemeEditor Window if an Item is selected
        /// </summary>
        private void EditMeme()
        {
            var item = MainList.SelectedItem;
            if (item == null || !(item is Meme))
                return;

            MemeEditor tes = new MemeEditor(item as Meme);
            tes.Owner = this;
            tes.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            tes.ShowDialog();
            MainList.Items.Refresh();
            UpdateTagList();
        }

        private void UpdateTagList()
        {
            Meme meme = MainList.SelectedItem as Meme;

            lbTags.Items.Clear();

            btnEdit.IsEnabled = false;
            MenuButtonEditMeme.IsEnabled = false;
            MenuButtonDeleteMeme.IsEnabled = false;

            if (meme == null)
                return;

            if (MainList.SelectedItems != null && MainList.SelectedItems.Count > 1)
                return;

            if (meme.Tags != null && meme.Tags.Length > 0)
            {
                foreach (var tag in meme.Tags)
                {
                    lbTags.Items.Add(tag);
                }
            }

            btnEdit.IsEnabled = true;
            MenuButtonEditMeme.IsEnabled = true;
            MenuButtonDeleteMeme.IsEnabled = true;
        }

        private void AddMemesFromExplorer()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (var file in openFileDialog.FileNames)
                {
                    MemeController.Instance.AddMeme(file);
                }
            }
        }

        private void DeleteMeme()
        {
            var selected = MainList.SelectedItem as Meme;
            if (selected != null)
            {
                var respsonse = MessageBox.Show("Really delete the meme \"" + selected.Name + "\" ?", "Really?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if(respsonse == MessageBoxResult.Yes)
                    MemeController.Instance.DeleteMeme(selected);
            }
        }
        #endregion
        
        #region Events
        private void txtSearchBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSearchBox.Text) == false)
                MainList.ItemsSource = SearchTest(txtSearchBox.Text);
            else
                MainList.ItemsSource = Memes;
        }

        private void MainList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            UpdateTagList();
        }
        
        private void MainList_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (var file in files)
                {
                    MemeController.Instance.AddMeme(file);
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

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditMeme();
        }

        private void MenuButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddMemesFromExplorer();
        }

        private void MenuButtonEditMeme_Click(object sender, RoutedEventArgs e)
        {
            EditMeme();
        }

        private void MenuButtonDeleteMeme_Click(object sender, RoutedEventArgs e)
        {
            DeleteMeme();
        }
        

        private void MenuButtonOptions_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("MenuButtonOptions_Click");
        }

        private void MenuButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("MenuButtonAbout_Click");
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ClickCount == 2)
                EditMeme();
        }

        private void MainList_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainList.SelectedItem = null;
        }

        private void MainList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
                DeleteMeme();
        }
        #endregion

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
            if (e.LeftButton == MouseButtonState.Pressed && this.WindowState == WindowState.Maximized)
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
    }
}
