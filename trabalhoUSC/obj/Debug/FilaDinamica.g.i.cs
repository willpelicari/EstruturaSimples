﻿#pragma checksum "..\..\FilaDinamica.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "79967621F21935E681EC595EBED8D5D4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace trabalhoUSC {
    
    
    /// <summary>
    /// FilaDinamicaWindow
    /// </summary>
    public partial class FilaDinamicaWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\FilaDinamica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxFila;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\FilaDinamica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\FilaDinamica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\FilaDinamica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Texto;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\FilaDinamica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label EscrevaNome;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\FilaDinamica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAlterar;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\FilaDinamica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProcurar;
        
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
            System.Uri resourceLocater = new System.Uri("/trabalhoUSC;component/filadinamica.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FilaDinamica.xaml"
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
            this.listBoxFila = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\FilaDinamica.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\FilaDinamica.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Texto = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\FilaDinamica.xaml"
            this.Texto.KeyDown += new System.Windows.Input.KeyEventHandler(this.enterPessoa);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EscrevaNome = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btnAlterar = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\FilaDinamica.xaml"
            this.btnAlterar.Click += new System.Windows.RoutedEventHandler(this.btnAlterar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnProcurar = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\FilaDinamica.xaml"
            this.btnProcurar.Click += new System.Windows.RoutedEventHandler(this.btnProcurar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

