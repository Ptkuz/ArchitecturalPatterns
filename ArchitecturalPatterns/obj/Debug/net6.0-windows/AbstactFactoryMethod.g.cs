#pragma checksum "..\..\..\AbstactFactoryMethod.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6639E26941D16BD5163E19B17A6F68E76D43D904"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ArchitecturalPatterns;
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


namespace ArchitecturalPatterns {
    
    
    /// <summary>
    /// AbstactFactoryMethod
    /// </summary>
    public partial class AbstactFactoryMethod : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\AbstactFactoryMethod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonHit;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\AbstactFactoryMethod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonUse;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\AbstactFactoryMethod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listActions;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\AbstactFactoryMethod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonHit1;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\AbstactFactoryMethod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonUse1;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\AbstactFactoryMethod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listActions1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ArchitecturalPatterns;component/abstactfactorymethod.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AbstactFactoryMethod.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.buttonHit = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\AbstactFactoryMethod.xaml"
            this.buttonHit.Click += new System.Windows.RoutedEventHandler(this.buttonHit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonUse = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\AbstactFactoryMethod.xaml"
            this.buttonUse.Click += new System.Windows.RoutedEventHandler(this.buttonUse_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listActions = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.buttonHit1 = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\AbstactFactoryMethod.xaml"
            this.buttonHit1.Click += new System.Windows.RoutedEventHandler(this.buttonHit1_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonUse1 = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\AbstactFactoryMethod.xaml"
            this.buttonUse1.Click += new System.Windows.RoutedEventHandler(this.buttonUse1_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.listActions1 = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

