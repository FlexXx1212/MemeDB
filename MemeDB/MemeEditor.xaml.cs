using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MemeDB.Controllers;
using MemeDB.Models;

namespace MemeDB
{
    /// <summary>
    /// Interaktionslogik für MemeEditor.xaml
    /// </summary>
    public partial class MemeEditor : Window
    {
        #region Properties
        private Meme meme;
        #endregion

        #region Constructor
        public MemeEditor(Meme m)
        {
            InitializeComponent();
            meme = m;

            Init();
        }
        #endregion

        #region Functions
        private void Init()
        {
            tbName.Text = meme.Name;
            if (meme.Tags != null && meme.Tags.Length > 0)
            {
                foreach (var tag in meme.Tags)
                {
                    lbTags.Items.Add(tag);
                }
            }
        }
        #endregion

        #region Events
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Check for changes
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            meme.Name = this.tbName.Text;

            string[] newTags = new string[lbTags.Items.Count];

            for (int i = 0; i < lbTags.Items.Count; i++)
            {
                newTags[i] = lbTags.Items[i] as string;
            }

            meme.Tags = newTags;

            MemeController.Instance.Save();
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(!lbTags.Items.Contains(tbSearch.Text))
            {
                lbTags.Items.Add(tbSearch.Text);
            }
            tbSearch.Text = "";
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(lbTags.SelectedItem != null)
            {
                lbTags.Items.Remove(lbTags.SelectedItem);
            }
        }

        private void btnDeleteMeme_Click(object sender, RoutedEventArgs e)
        {
            var respsonse = MessageBox.Show("Really delete the meme \"" + meme.Name + "\" ?", "Really?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (respsonse == MessageBoxResult.Yes)
                MemeController.Instance.DeleteMeme(meme);
            this.Close();
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
            this.Close();
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

        private void lbTags_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Delete)
            {
                if (lbTags.SelectedItem != null)
                {
                    lbTags.Items.Remove(lbTags.SelectedItem);
                }
            }
        }
    }
}
