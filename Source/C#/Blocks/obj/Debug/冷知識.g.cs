﻿

#pragma checksum "C:\Users\a1\Desktop\_Blocks Template v.1.0.0.0\Source\C#\Blocks\冷知識.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BC5DFBAD3E0AF0BC22372CF9E53917C1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Blocks
{
    partial class InstructionPage : global::Blocks.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 63 "..\..\冷知識.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.r1_Checked;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 64 "..\..\冷知識.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.r2_Checked;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 37 "..\..\冷知識.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


