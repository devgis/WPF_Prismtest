using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.Modularity;

namespace LNS.LogApp.Models
{
    public class Model : IModule
    {
        private IRegionManager _regionManager;
        public Model(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("RegionModel", typeof(ModelView));
        }
    }
}
