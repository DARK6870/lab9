﻿#pragma checksum "..\..\..\MatrixWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DC4A9C502ADD3A15656EDA4158AFA48DC5F65F20"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using lab7;


namespace lab7 {
    
    
    /// <summary>
    /// MatrixWindow
    /// </summary>
    public partial class MatrixWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\MatrixWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\MatrixWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sum;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MatrixWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button min;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\MatrixWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button count;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\MatrixWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteColumn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\MatrixWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox col;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\MatrixWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button massiv_btn;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\MatrixWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label result_label;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/lab7;component/matrixwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MatrixWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.datagrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.Sum = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\MatrixWindow.xaml"
            this.Sum.Click += new System.Windows.RoutedEventHandler(this.Sum_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.min = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\MatrixWindow.xaml"
            this.min.Click += new System.Windows.RoutedEventHandler(this.min_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.count = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\MatrixWindow.xaml"
            this.count.Click += new System.Windows.RoutedEventHandler(this.count_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.deleteColumn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\MatrixWindow.xaml"
            this.deleteColumn.Click += new System.Windows.RoutedEventHandler(this.deleteColumn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.col = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.massiv_btn = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\MatrixWindow.xaml"
            this.massiv_btn.Click += new System.Windows.RoutedEventHandler(this.massiv_btn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.result_label = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

