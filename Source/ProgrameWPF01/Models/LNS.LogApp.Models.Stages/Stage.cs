using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.Modularity;

namespace LNS.LogApp.Models
{
    public class Stage : IModule
    {
        private IRegionManager _regionManager;
        public Stage(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("RegionStage", typeof(StageView));
        }
    }
}
