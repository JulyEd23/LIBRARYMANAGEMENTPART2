﻿#pragma checksum "..\..\AddBorrowerWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E59FB5EFE7EAE9B771DFD68CFA1012EC"
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
    /// AddBorrowerWindow
    /// </summary>
    public partial class AddBorrowerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\AddBorrowerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAddBorrowerWindowClose;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\AddBorrowerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButtonMale;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\AddBorrowerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButtonFemale;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\AddBorrowerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButtonStudent;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\AddBorrowerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButtonTeacher;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\AddBorrowerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockIDNumber;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\AddBorrowerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAddBorrower;
        
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
            System.Uri resourceLocater = new System.Uri("/LIBRARYMANAGEMENTPART2;component/addborrowerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddBorrowerWindow.xaml"
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
            this.ButtonAddBorrowerWindowClose = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\AddBorrowerWindow.xaml"
            this.ButtonAddBorrowerWindowClose.Click += new System.Windows.RoutedEventHandler(this.ButtonAddBorrowerWindowClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RadioButtonMale = ((System.Windows.Controls.RadioButton)(target));
            
            #line 73 "..\..\AddBorrowerWindow.xaml"
            this.RadioButtonMale.Checked += new System.Windows.RoutedEventHandler(this.RadioButtonMale_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RadioButtonFemale = ((System.Windows.Controls.RadioButton)(target));
            
            #line 78 "..\..\AddBorrowerWindow.xaml"
            this.RadioButtonFemale.Checked += new System.Windows.RoutedEventHandler(this.RadioButtonFemale_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RadioButtonStudent = ((System.Windows.Controls.RadioButton)(target));
            
            #line 94 "..\..\AddBorrowerWindow.xaml"
            this.RadioButtonStudent.Checked += new System.Windows.RoutedEventHandler(this.RadioButtonStudent_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RadioButtonTeacher = ((System.Windows.Controls.RadioButton)(target));
            
            #line 99 "..\..\AddBorrowerWindow.xaml"
            this.RadioButtonTeacher.Checked += new System.Windows.RoutedEventHandler(this.RadioButtonTeacher_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TextBlockIDNumber = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.ButtonAddBorrower = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\AddBorrowerWindow.xaml"
            this.ButtonAddBorrower.Click += new System.Windows.RoutedEventHandler(this.ButtonAddBorrower_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

