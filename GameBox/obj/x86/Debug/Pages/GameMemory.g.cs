﻿#pragma checksum "C:\Users\aa205651\source\repos\GameBox\GameBox\Pages\GameMemory.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "819B84B83E41638589EAF908510A963B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameBox
{
    partial class GameMemory : 
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
            case 2: // Pages\GameMemory.xaml line 29
                {
                    this.backButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 3: // Pages\GameMemory.xaml line 30
                {
                    this.level = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Pages\GameMemory.xaml line 31
                {
                    this.player = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // Pages\GameMemory.xaml line 32
                {
                    this.playerName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Pages\GameMemory.xaml line 33
                {
                    this.card0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.card0).Tapped += this.cardClicked;
                }
                break;
            case 7: // Pages\GameMemory.xaml line 34
                {
                    this.card1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.card1).Tapped += this.cardClicked;
                }
                break;
            case 8: // Pages\GameMemory.xaml line 35
                {
                    this.card2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.card2).Tapped += this.cardClicked;
                }
                break;
            case 9: // Pages\GameMemory.xaml line 36
                {
                    this.card3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.card3).Tapped += this.cardClicked;
                }
                break;
            case 10: // Pages\GameMemory.xaml line 37
                {
                    this.card4 = (global::Windows.UI.Xaml.Controls.Image)(target);
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

