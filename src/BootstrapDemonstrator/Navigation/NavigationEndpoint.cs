﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrapDemonstrator.Navigation
{
    public class NavigationEndpoint
    {
        public NavigationBarViewModel get_navigation_bar()
        {
            return new NavigationBarViewModel();
        }
    }

    public class NavigationBarViewModel{}
}