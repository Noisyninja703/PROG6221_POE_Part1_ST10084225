﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0F4EA0A0F38EDC35E6758F50E8E90C269670FF3C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PROG6221_POE_Draft2;
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


namespace PROG6221_POE_Draft2 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SidebarStack;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LV;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem LV1;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem LV2;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem LV3;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem LV4;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem LV5;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem LV6;
        
        #line default
        #line hidden
        
        
        #line 260 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame mainFrame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PROG6221_POE_Draft2;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SidebarStack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.LV = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.LV1 = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 35 "..\..\..\MainWindow.xaml"
            this.LV1.Selected += new System.Windows.RoutedEventHandler(this.LV0_Selected);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LV2 = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 60 "..\..\..\MainWindow.xaml"
            this.LV2.Selected += new System.Windows.RoutedEventHandler(this.LV1_Selected);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LV3 = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 85 "..\..\..\MainWindow.xaml"
            this.LV3.Selected += new System.Windows.RoutedEventHandler(this.LV2_Selected);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LV4 = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 111 "..\..\..\MainWindow.xaml"
            this.LV4.Selected += new System.Windows.RoutedEventHandler(this.LV3_Selected);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LV5 = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 135 "..\..\..\MainWindow.xaml"
            this.LV5.Selected += new System.Windows.RoutedEventHandler(this.LV4_Selected);
            
            #line default
            #line hidden
            return;
            case 8:
            this.LV6 = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 161 "..\..\..\MainWindow.xaml"
            this.LV6.Selected += new System.Windows.RoutedEventHandler(this.LV5_Selected);
            
            #line default
            #line hidden
            return;
            case 9:
            this.mainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
