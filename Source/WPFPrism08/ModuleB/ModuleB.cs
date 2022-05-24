using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.Modularity;

namespace ModuleB
{
    public class ModuleB : IModule
    {
        private IRegionManager _regionManager;
        public ModuleB(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("RegionB", typeof(MyViewB));
        }
    }
}
