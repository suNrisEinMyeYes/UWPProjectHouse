﻿#pragma checksum "C:\Users\Администратор\Desktop\clonemy22222\UWPProjectHouse\ProjectHouseUWP\Settings.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8106AE314ABEA30D63CE55AABFD131B7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectHouseUWP
{
    partial class Settings : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Settings.xaml line 11
                {
                    global::Windows.UI.Xaml.Controls.Grid element2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element2).KeyDown += this.Grid_KeyDown;
                }
                break;
            case 3: // Settings.xaml line 12
                {
                    this.ExtraGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // Settings.xaml line 23
                {
                    this.MainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5: // Settings.xaml line 24
                {
                    this.Login = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Settings.xaml line 25
                {
                    this.Password = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 7: // Settings.xaml line 26
                {
                    this.LoginTxt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // Settings.xaml line 27
                {
                    this.PassTxt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // Settings.xaml line 28
                {
                    this.ConfirmBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ConfirmBtn).Click += this.Save_Click;
                }
                break;
            case 10: // Settings.xaml line 29
                {
                    this.ExtraBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ExtraBtn).Click += this.ExtraBtn_Click;
                }
                break;
            case 11: // Settings.xaml line 30
                {
                    this.SuccessBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Settings.xaml line 31
                {
                    this.ProgRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 13: // Settings.xaml line 13
                {
                    this.Server = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14: // Settings.xaml line 14
                {
                    this.DBName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15: // Settings.xaml line 15
                {
                    this.ServerTxt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // Settings.xaml line 16
                {
                    this.DBNameTxt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

