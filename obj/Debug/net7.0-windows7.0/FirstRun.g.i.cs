﻿#pragma checksum "..\..\..\FirstRun.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A9F31924815A2F47B74C091E16ED202D038776DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using NoCheatsGD_UI_;
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


namespace NoCheatsGD_UI_ {
    
    
    /// <summary>
    /// FirstRun
    /// </summary>
    public partial class FirstRun : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\FirstRun.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NoCheatsGD_UI_.FirstRun SettingsWindow;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\FirstRun.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SettingsGird;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\FirstRun.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DebugButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NoCheatsGD(UI);component/firstrun.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FirstRun.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SettingsWindow = ((NoCheatsGD_UI_.FirstRun)(target));
            return;
            case 2:
            this.SettingsGird = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 17 "..\..\..\FirstRun.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.DebugActived);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 47 "..\..\..\FirstRun.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bypasspath);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 59 "..\..\..\FirstRun.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.playerpath);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 71 "..\..\..\FirstRun.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.globalpath);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 83 "..\..\..\FirstRun.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.corepath);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 95 "..\..\..\FirstRun.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.creatorpath);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 107 "..\..\..\FirstRun.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.variablespath);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 119 "..\..\..\FirstRun.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 131 "..\..\..\FirstRun.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.gdbotpath);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 143 "..\..\..\FirstRun.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Reset);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 158 "..\..\..\FirstRun.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.InfoShow);
            
            #line default
            #line hidden
            return;
            case 14:
            this.DebugButton = ((System.Windows.Controls.Button)(target));
            
            #line 164 "..\..\..\FirstRun.xaml"
            this.DebugButton.Click += new System.Windows.RoutedEventHandler(this.DubugWindow);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

