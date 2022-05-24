using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.Commands;

namespace ModuleA
{
    public class ModuleA:IModule
    {
        public static CompositeCommand MyCompositeCommand = new CompositeCommand(true);
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
