﻿#pragma checksum "..\..\..\Views\AddContact.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E1C8A367C41B356AEEED8D01D09401E5D18CFCE86E0D2579E3F98D06621E932B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
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


namespace ContactsWSIO.Views {
    
    
    /// <summary>
    /// AddContact
    /// </summary>
    public partial class AddContact : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Views\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_firstname;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_lastname;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_email;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_phone;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Views\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_mobile;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Views\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_birthday;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Views\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_setbirthday;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar cal_seld;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Views\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_esc;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Views\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_saveContact;
        
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
            System.Uri resourceLocater = new System.Uri("/ContactsWSIO;component/views/addcontact.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AddContact.xaml"
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
            this.tb_firstname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tb_lastname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tb_email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tb_phone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tb_mobile = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tb_birthday = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btn_setbirthday = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Views\AddContact.xaml"
            this.btn_setbirthday.Click += new System.Windows.RoutedEventHandler(this.btn_setbirthday_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cal_seld = ((System.Windows.Controls.Calendar)(target));
            
            #line 43 "..\..\..\Views\AddContact.xaml"
            this.cal_seld.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.cal_seld_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_esc = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Views\AddContact.xaml"
            this.btn_esc.Click += new System.Windows.RoutedEventHandler(this.Btn_esc_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_saveContact = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Views\AddContact.xaml"
            this.btn_saveContact.Click += new System.Windows.RoutedEventHandler(this.Btn_saveContact_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

