﻿#pragma checksum "..\..\AddCategoryWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2450FD937936FC4F43015E3350E68AAA6353D228"
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
    /// AddCategoryWindow
    /// </summary>
    public partial class AddCategoryWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\AddCategoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonExitWindow;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\AddCategoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDeleteCategory;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\AddCategoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAddCategory;
        
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
            System.Uri resourceLocater = new System.Uri("/LIBRARYMANAGEMENTPART2;component/addcategorywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddCategoryWindow.xaml"
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
            this.ButtonExitWindow = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\AddCategoryWindow.xaml"
            this.ButtonExitWindow.Click += new System.Windows.RoutedEventHandler(this.ButtonExitWindow_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonDeleteCategory = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\AddCategoryWindow.xaml"
            this.ButtonDeleteCategory.Click += new System.Windows.RoutedEventHandler(this.ButtonDeleteCategory_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonAddCategory = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\AddCategoryWindow.xaml"
            this.ButtonAddCategory.Click += new System.Windows.RoutedEventHandler(this.ButtonAddCategory_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

