﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "655FEE97F85BE5D6969317134E5B5149"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using MemeDB;
using MemeDB.Properties;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MemeDB {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 9 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MemeDB.MainWindow MyMainWindow;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel WindowBar;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuButtonAdd;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuButtonExit;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuButtonEditMeme;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuButtonDeleteMeme;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuButtonAbout;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEdit;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbTags;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbPreviewSearchBar;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchBox;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox MainList;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MemeDB;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MyMainWindow = ((MemeDB.MainWindow)(target));
            return;
            case 3:
            this.WindowBar = ((System.Windows.Controls.DockPanel)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.WindowBar.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WindowBar_MouseDown);
            
            #line default
            #line hidden
            
            #line 34 "..\..\MainWindow.xaml"
            this.WindowBar.MouseMove += new System.Windows.Input.MouseEventHandler(this.WindowBar_MouseMove);
            
            #line default
            #line hidden
            
            #line 34 "..\..\MainWindow.xaml"
            this.WindowBar.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.WindowBar_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 35 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 36 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 37 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MenuButtonAdd = ((System.Windows.Controls.MenuItem)(target));
            
            #line 41 "..\..\MainWindow.xaml"
            this.MenuButtonAdd.Click += new System.Windows.RoutedEventHandler(this.MenuButtonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MenuButtonExit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 44 "..\..\MainWindow.xaml"
            this.MenuButtonExit.Click += new System.Windows.RoutedEventHandler(this.MenuButtonExit_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MenuButtonEditMeme = ((System.Windows.Controls.MenuItem)(target));
            
            #line 47 "..\..\MainWindow.xaml"
            this.MenuButtonEditMeme.Click += new System.Windows.RoutedEventHandler(this.MenuButtonEditMeme_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.MenuButtonDeleteMeme = ((System.Windows.Controls.MenuItem)(target));
            
            #line 48 "..\..\MainWindow.xaml"
            this.MenuButtonDeleteMeme.Click += new System.Windows.RoutedEventHandler(this.MenuButtonDeleteMeme_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.MenuButtonAbout = ((System.Windows.Controls.MenuItem)(target));
            
            #line 51 "..\..\MainWindow.xaml"
            this.MenuButtonAbout.Click += new System.Windows.RoutedEventHandler(this.MenuButtonAbout_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\MainWindow.xaml"
            this.btnEdit.Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.lbTags = ((System.Windows.Controls.ListBox)(target));
            return;
            case 14:
            this.tbPreviewSearchBar = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            this.txtSearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 70 "..\..\MainWindow.xaml"
            this.txtSearchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 16:
            this.MainList = ((System.Windows.Controls.ListBox)(target));
            
            #line 73 "..\..\MainWindow.xaml"
            this.MainList.MouseMove += new System.Windows.Input.MouseEventHandler(this.MainList_MouseMove);
            
            #line default
            #line hidden
            
            #line 73 "..\..\MainWindow.xaml"
            this.MainList.Drop += new System.Windows.DragEventHandler(this.MainList_Drop);
            
            #line default
            #line hidden
            
            #line 73 "..\..\MainWindow.xaml"
            this.MainList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MainList_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 73 "..\..\MainWindow.xaml"
            this.MainList.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MainList_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 73 "..\..\MainWindow.xaml"
            this.MainList.KeyDown += new System.Windows.Input.KeyEventHandler(this.MainList_KeyDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 21 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            
            #line 21 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

