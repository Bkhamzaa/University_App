﻿#pragma checksum "..\..\..\..\Views\AddStudentWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BA7A3E1E2F6CEF54378462C030F22D95FC509BE1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using University_app.Views;


namespace University_app.Views {
    
    
    /// <summary>
    /// AddStudentWindow
    /// </summary>
    public partial class AddStudentWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\Views\AddStudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProgramComboBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\AddStudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox LevelComboBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Views\AddStudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CinIDTextBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Views\AddStudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Views\AddStudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Views\AddStudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/University_app;component/views/addstudentwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AddStudentWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ProgramComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\..\..\Views\AddStudentWindow.xaml"
            this.ProgramComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProgramComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LevelComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\..\..\Views\AddStudentWindow.xaml"
            this.LevelComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LevelComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CinIDTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.FirstNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.LastNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.EmailTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 75 "..\..\..\..\Views\AddStudentWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

