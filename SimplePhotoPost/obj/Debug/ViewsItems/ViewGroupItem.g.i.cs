﻿#pragma checksum "..\..\..\ViewsItems\ViewGroupItem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "958FE52015F5D17D820701503C20317F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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


namespace SimplePhotoPost {
    
    
    /// <summary>
    /// UI_GroupItem
    /// </summary>
    public partial class UI_GroupItem : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\ViewsItems\ViewGroupItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Title;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\ViewsItems\ViewGroupItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\ViewsItems\ViewGroupItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image2;
        
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
            System.Uri resourceLocater = new System.Uri("/SimplePhotoPost;component/viewsitems/viewgroupitem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewsItems\ViewGroupItem.xaml"
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
            this.Title = ((System.Windows.Controls.TextBlock)(target));
            
            #line 24 "..\..\..\ViewsItems\ViewGroupItem.xaml"
            this.Title.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.OpenGroupSettings);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 28 "..\..\..\ViewsItems\ViewGroupItem.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.OpenGroupSettings);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 45 "..\..\..\ViewsItems\ViewGroupItem.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Delete);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 55 "..\..\..\ViewsItems\ViewGroupItem.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.OpenGroupSettings);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Image = ((System.Windows.Controls.Image)(target));
            
            #line 56 "..\..\..\ViewsItems\ViewGroupItem.xaml"
            this.Image.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.OpenGroupSettings);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Image2 = ((System.Windows.Controls.Image)(target));
            
            #line 57 "..\..\..\ViewsItems\ViewGroupItem.xaml"
            this.Image2.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Delete);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

