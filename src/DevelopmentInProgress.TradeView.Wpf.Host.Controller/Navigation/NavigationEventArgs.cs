﻿using DevelopmentInProgress.TradeView.Wpf.Controls.NavigationPanel;
using System;

namespace DevelopmentInProgress.TradeView.Wpf.Host.Controller.Navigation
{
    public class NavigationEventArgs : EventArgs
    {
        public NavigationEventArgs(NavigationListItem navigationListItem)
        {
            NavigationListItem = navigationListItem;
        }

        public NavigationListItem NavigationListItem { get; private set; }
    }
}
