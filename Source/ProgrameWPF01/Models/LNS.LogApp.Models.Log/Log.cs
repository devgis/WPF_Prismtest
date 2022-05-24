using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.Modularity;

namespace LNS.LogApp.Models
{
    public class Log : IModule
    {
        private IRegionManager _regionManager;
        public Log(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("RegionLog", typeof(LogView));
        }
    }
}
