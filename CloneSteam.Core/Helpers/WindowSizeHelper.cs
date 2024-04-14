using CloneSteam.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneSteam.Core.Helpers
{
    public class WindowSizeHelper
    {
        public static event EventHandler<RegionNameEventArgs>? OnRegionChangedEvent;

        public WindowSizeHelper() 
        {
            
        }

        public void OnRegionChanged(string para)
        {
            OnRegionChangedEvent?.Invoke(this, new RegionNameEventArgs(para));
        }
    }
}
