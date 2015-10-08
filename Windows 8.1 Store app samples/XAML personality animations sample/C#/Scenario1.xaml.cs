//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using SDKTemplate;
using System;
using Windows.UI.Xaml.Media.Animation;

namespace PersonalityAnimations
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Scenario1 : SDKTemplate.Common.LayoutAwarePage
    {
        // A pointer back to the main page.  This is needed if you want to call methods in MainPage such
        // as NotifyUser()
        MainPage rootPage = MainPage.Current;
        
        public Scenario1()
        {
            this.InitializeComponent();
            PopIn.IsEnabled = false;
        }

        private void PopInClick(object sender, RoutedEventArgs e)
        {
            PopInStoryboard.Begin();
            PopIn.IsEnabled = false;
            PopOut.IsEnabled = true;
        }

        private void PopOutClick(object sender, RoutedEventArgs e)
        {
            PopOutStoryboard.Begin();
            PopIn.IsEnabled = true;
            PopOut.IsEnabled = false;
        }

    }
}
