﻿#pragma checksum "..\..\CustomersList.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4061827B469B5EA41D1A803A91DEB4827222EDA3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PhoneBook;
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




/// <summary>
/// PhoneBook
/// </summary>
public partial class PhoneBook : System.Windows.Window, System.Windows.Markup.IComponentConnector {
    
    
    #line 31 "..\..\CustomersList.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.DataGrid myDataGrid;
    
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
        System.Uri resourceLocater = new System.Uri("/PhoneBook;component/customerslist.xaml", System.UriKind.Relative);
        
        #line 1 "..\..\CustomersList.xaml"
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
        
        #line 13 "..\..\CustomersList.xaml"
        ((PhoneBook)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
        
        #line default
        #line hidden
        return;
            case 2:
        this.myDataGrid = ((System.Windows.Controls.DataGrid)(target));
        return;
            }
        this._contentLoaded = true;
    }
}

