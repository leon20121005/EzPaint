﻿#pragma checksum "C:\Users\Leon\Desktop\EzPaint\DrawingApp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "26FF9C52F374A9275FC269B8092AA202"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrawingApp
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this._canvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    #line 11 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Canvas)this._canvas).PointerPressed += this.HandleCanvasPointerPressed;
                    #line 11 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Canvas)this._canvas).PointerReleased += this.HandleCanvasPointerReleased;
                    #line 11 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Canvas)this._canvas).PointerMoved += this.HandleCanvasPointerMoved;
                    #line default
                }
                break;
            case 2:
                {
                    this._undoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this._undoButton).Click += this.ClickUndoButton;
                    #line default
                }
                break;
            case 3:
                {
                    this._redoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this._redoButton).Click += this.ClickRedoButton;
                    #line default
                }
                break;
            case 4:
                {
                    this._rectangleButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this._rectangleButton).Click += this.ClickRectangleButton;
                    #line default
                }
                break;
            case 5:
                {
                    this._triangleButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this._triangleButton).Click += this.ClickTriangleButton;
                    #line default
                }
                break;
            case 6:
                {
                    this._circleButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this._circleButton).Click += this.ClickCircleButton;
                    #line default
                }
                break;
            case 7:
                {
                    this._lineButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 21 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this._lineButton).Click += this.ClickLineButton;
                    #line default
                }
                break;
            case 8:
                {
                    this._saveButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this._saveButton).Click += this.ClickSaveButton;
                    #line default
                }
                break;
            case 9:
                {
                    this._uploadButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this._uploadButton).Click += this.ClickUploadButton;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

