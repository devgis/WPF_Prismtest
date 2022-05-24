using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace ModuleA
{
    public class ModuleA:IModule
    {
        private IRegionManager _regionManager;
        public ModuleA(IRegionManager regionManager)
        {
            _regionManager=regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("RegionA", typeof(MyViewA));
        }
    }
}
