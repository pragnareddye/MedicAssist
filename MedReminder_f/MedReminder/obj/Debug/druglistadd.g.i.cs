﻿#pragma checksum "C:\Users\Nouman\Documents\Visual Studio 2010\Projects\MedReminder\MedReminder\druglistadd.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4C2387EDDD01C3446F84C8E1ADE0E61D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace MedReminder {
    
    
    public partial class druglistadd : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.TextBox medname;
        
        internal System.Windows.Controls.TextBlock textBlock2;
        
        internal System.Windows.Controls.TextBlock textBlock3;
        
        internal System.Windows.Controls.TextBlock textBlock4;
        
        internal System.Windows.Controls.TextBox dose;
        
        internal System.Windows.Controls.TextBox course;
        
        internal System.Windows.Controls.TextBox quantity;
        
        internal System.Windows.Controls.TextBlock textBlock5;
        
        internal System.Windows.Controls.TextBox alarmContent;
        
        internal Microsoft.Phone.Controls.TimePicker timePicker1;
        
        internal System.Windows.Controls.TextBlock textBlock6;
        
        internal System.Windows.Controls.ListBox lbAlarms;
        
        internal System.Windows.Controls.Border border1;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/MedReminder;component/druglistadd.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.medname = ((System.Windows.Controls.TextBox)(this.FindName("medname")));
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock2")));
            this.textBlock3 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock3")));
            this.textBlock4 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock4")));
            this.dose = ((System.Windows.Controls.TextBox)(this.FindName("dose")));
            this.course = ((System.Windows.Controls.TextBox)(this.FindName("course")));
            this.quantity = ((System.Windows.Controls.TextBox)(this.FindName("quantity")));
            this.textBlock5 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock5")));
            this.alarmContent = ((System.Windows.Controls.TextBox)(this.FindName("alarmContent")));
            this.timePicker1 = ((Microsoft.Phone.Controls.TimePicker)(this.FindName("timePicker1")));
            this.textBlock6 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock6")));
            this.lbAlarms = ((System.Windows.Controls.ListBox)(this.FindName("lbAlarms")));
            this.border1 = ((System.Windows.Controls.Border)(this.FindName("border1")));
        }
    }
}

