﻿using System;
using Windows.UI.Xaml.Controls;
using HFR4WinRT.Views;
using Page = HFR4WinRT.Model.Page;

namespace HFR4WinRT.Services.Classes
{
    public class NavigationService
    {
        private Frame _navigationFrame;

        public void Navigate(Page page)
        {
            switch (page)
            {
                case Page.Connect:
                    _navigationFrame.Navigate(typeof(ConnectPage));
                    break;
                case Page.Main:
                    _navigationFrame.Navigate(typeof(MainPage));
                    break;
                default:
                    break;
            }
        }
        public Windows.UI.Xaml.Controls.Page CurrentPage { get { return _navigationFrame.Content as Windows.UI.Xaml.Controls.Page; } }
        public void Initialize(Frame rootFrame)
        {
            _navigationFrame = rootFrame;
        }
    }
}
