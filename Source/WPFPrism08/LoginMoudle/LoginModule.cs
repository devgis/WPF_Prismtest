using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.Events;
using Contract;

namespace LoginMoudle
{
    public class LoginModule : IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IEventAggregator eventAggregator;

        public LoginModule(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            this.regionManager = regionManager;
            this.eventAggregator = eventAggregator;
        }

        //public LoginModule(IRegionManager regionManager)
        //{
        //    this.regionManager = regionManager;
        //    //this.eventAggregator = eventAggregator;
        //}

        #region IModule Members

        public void Initialize()
        {
            IRegion region = regionManager.Regions["LoginRegion"];

            if (region != null)
            {
                var loginView = new DefaultLoginView();

                loginView.LoginSucessed += loginView_LoginSucessed;

                region.Add(loginView);
                region.Activate(loginView);
            }
        }

        void loginView_LoginSucessed(object sender, LoginSucessedEventArgs e)
        {
            //if (eventAggregator != null)
            //{
            //    eventAggregator.GetEvent<LoginSucessedEvent>().Publish(new LoginSucessedEventArgs());
            //}

            eventAggregator.GetEvent<GetInputMessages>().Publish(e.Message);
        }

        #endregion
    }
}
