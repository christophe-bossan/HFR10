﻿using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Controls;
using HFR4WinRT.Model;
using HFR4WinRT.Utilities;
using HFR4WinRT.ViewModel;

namespace HFR4WinRT.Commands
{
    public class OpenTopicCommand : Command
    {
        public override void Execute(object parameter)
        {
            var itemClick = parameter as ItemClickEventArgs;
            if (itemClick != null)
            {
                var topic = itemClick.ClickedItem as Topic;
                Locator.Main.Topics[0] = topic;
                Locator.Main.SelectedTopic = 0;
            }
        }
    }
}
