﻿#pragma checksum "..\..\BukuTamu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5A01BC6352FA885ACFEB9A09262D9E5E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CiburuyDesk;
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


namespace CiburuyDesk {
    
    
    /// <summary>
    /// BukuTamu
    /// </summary>
    public partial class BukuTamu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\BukuTamu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image bg;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\BukuTamu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\BukuTamu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image email_icon_png;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\BukuTamu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image user_icon_png;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\BukuTamu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image masukBtn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\BukuTamu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox namaBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\BukuTamu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
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
            System.Uri resourceLocater = new System.Uri("/CiburuyDesk;component/bukutamu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BukuTamu.xaml"
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
            this.bg = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.emailBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\BukuTamu.xaml"
            this.emailBox.GotFocus += new System.Windows.RoutedEventHandler(this.emailBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 20 "..\..\BukuTamu.xaml"
            this.emailBox.LostFocus += new System.Windows.RoutedEventHandler(this.emailBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.email_icon_png = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.user_icon_png = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.masukBtn = ((System.Windows.Controls.Image)(target));
            
            #line 23 "..\..\BukuTamu.xaml"
            this.masukBtn.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.masukbtn_Click);
            
            #line default
            #line hidden
            
            #line 23 "..\..\BukuTamu.xaml"
            this.masukBtn.MouseEnter += new System.Windows.Input.MouseEventHandler(this.masukbtn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 23 "..\..\BukuTamu.xaml"
            this.masukBtn.MouseLeave += new System.Windows.Input.MouseEventHandler(this.masukbtn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 6:
            this.namaBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\BukuTamu.xaml"
            this.namaBox.GotFocus += new System.Windows.RoutedEventHandler(this.namaBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 24 "..\..\BukuTamu.xaml"
            this.namaBox.LostFocus += new System.Windows.RoutedEventHandler(this.namaBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.label = ((System.Windows.Controls.Label)(target));
            
            #line 25 "..\..\BukuTamu.xaml"
            this.label.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.text_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

