﻿#pragma checksum "..\..\BorrowBooksWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EAEC2D083CB4D3AC8AC39BF10BAB693077C57665"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LIBRARYMANAGEMENTPART2;
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


namespace LIBRARYMANAGEMENTPART2 {
    
    
    /// <summary>
    /// BorrowBooksWindow
    /// </summary>
    public partial class BorrowBooksWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\BorrowBooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonExit;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\BorrowBooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem TitleAscending;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\BorrowBooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem TitleDescscending;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\BorrowBooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem CategoryAscending;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\BorrowBooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem CategoryDescscending;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\BorrowBooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem IDNumberAscending;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\BorrowBooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem IDNumberDescscending;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\BorrowBooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem DefaultSort;
        
        #line default
        #line hidden
        
        
        #line 227 "..\..\BorrowBooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePickerDateBorrowed;
        
        #line default
        #line hidden
        
        
        #line 235 "..\..\BorrowBooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockDateDeadline;
        
        #line default
        #line hidden
        
        
        #line 240 "..\..\BorrowBooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBorrowBook;
        
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
            System.Uri resourceLocater = new System.Uri("/LIBRARYMANAGEMENTPART2;component/borrowbookswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BorrowBooksWindow.xaml"
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
            
            #line 8 "..\..\BorrowBooksWindow.xaml"
            ((LIBRARYMANAGEMENTPART2.BorrowBooksWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonExit = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\BorrowBooksWindow.xaml"
            this.ButtonExit.Click += new System.Windows.RoutedEventHandler(this.ButtonExit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TitleAscending = ((System.Windows.Controls.MenuItem)(target));
            
            #line 129 "..\..\BorrowBooksWindow.xaml"
            this.TitleAscending.Click += new System.Windows.RoutedEventHandler(this.TitleAscending_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TitleDescscending = ((System.Windows.Controls.MenuItem)(target));
            
            #line 132 "..\..\BorrowBooksWindow.xaml"
            this.TitleDescscending.Click += new System.Windows.RoutedEventHandler(this.TitleDescscending_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CategoryAscending = ((System.Windows.Controls.MenuItem)(target));
            
            #line 137 "..\..\BorrowBooksWindow.xaml"
            this.CategoryAscending.Click += new System.Windows.RoutedEventHandler(this.CategoryAscending_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CategoryDescscending = ((System.Windows.Controls.MenuItem)(target));
            
            #line 140 "..\..\BorrowBooksWindow.xaml"
            this.CategoryDescscending.Click += new System.Windows.RoutedEventHandler(this.CategoryDescscending_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.IDNumberAscending = ((System.Windows.Controls.MenuItem)(target));
            
            #line 145 "..\..\BorrowBooksWindow.xaml"
            this.IDNumberAscending.Click += new System.Windows.RoutedEventHandler(this.IDNumberAscending_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.IDNumberDescscending = ((System.Windows.Controls.MenuItem)(target));
            
            #line 148 "..\..\BorrowBooksWindow.xaml"
            this.IDNumberDescscending.Click += new System.Windows.RoutedEventHandler(this.IDNumberDescscending_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DefaultSort = ((System.Windows.Controls.MenuItem)(target));
            
            #line 153 "..\..\BorrowBooksWindow.xaml"
            this.DefaultSort.Click += new System.Windows.RoutedEventHandler(this.DefaultSort_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.DatePickerDateBorrowed = ((System.Windows.Controls.DatePicker)(target));
            
            #line 230 "..\..\BorrowBooksWindow.xaml"
            this.DatePickerDateBorrowed.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DatePickerDateBorrowed_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.TextBlockDateDeadline = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.ButtonBorrowBook = ((System.Windows.Controls.Button)(target));
            
            #line 241 "..\..\BorrowBooksWindow.xaml"
            this.ButtonBorrowBook.Click += new System.Windows.RoutedEventHandler(this.ButtonBorrowBook_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

