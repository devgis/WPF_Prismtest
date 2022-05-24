using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.UnityExtensions;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Contract;
using Microsoft.Practices.Unity;
using System.Threading;
using Microsoft.Practices.Prism.Events;

namespace WPFPrism
{
    public class PrismStarterBootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return this.Container.TryResolve<ShellWindow>();
        }

        protected override void InitializeShell()
        {   //  控制页面在初始化时显示Shell页面
            App.Current.MainWindow = (Window)this.Shell; ; //new ShellWindow();//(UIElement)this.Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            Thread t = new Thread(DoEvent);
            t.Start();

            //  注册Module。在实际开发中可以使用xaml做配置文件，
            //  这样就可以将PrismStarter与ModuleA和ModuleB完全解耦，也就不再需要引用这两个项目
            Type moduleAType = typeof(ModuleA.ModuleA);
            ModuleInfo moduleA = new ModuleInfo
            {
                ModuleName = moduleAType.Name,
                ModuleType = moduleAType.AssemblyQualifiedName,
            };

            Type moduleBType = typeof(ModuleB.ModuleB);
            ModuleInfo moduleB = new ModuleInfo
            {
                ModuleName = moduleBType.Name,
                ModuleType = moduleBType.AssemblyQualifiedName,
            };

            Type loginType = typeof(LoginMoudle.LoginModule);
            ModuleInfo modulelogin = new ModuleInfo
            {
                ModuleName = loginType.Name,
                ModuleType = loginType.AssemblyQualifiedName,
            };

            //Type moduleCType = typeof(ModuleB.ModuleB);
            //ModuleInfo moduleC = new ModuleInfo
            //{
            //    ModuleName = moduleCType.Name,
            //    ModuleType = moduleCType.AssemblyQualifiedName,
            //};

            this.ModuleCatalog.AddModule(moduleA);
            this.ModuleCatalog.AddModule(moduleB);
            this.ModuleCatalog.AddModule(modulelogin);
            //this.ModuleCatalog.AddModule(moduleA);
        }

        private void DoEvent()
        {
            //while (true)
            //{
            //    LoginSucessedEvent　
            //}
        }

        public void myMethod(object o)//这个方法一定是公有的，不然事件触发时找不到，会报错。
        {
            MessageBox.Show(o.ToString());
        }　　

        protected override void ConfigureContainer()
        {   //  注册一下TextProvider，这样在通过容器请求ITextProvider时会返回TextProvider实例
            base.ConfigureContainer();
            this.Container.RegisterInstance<ITextProvider>(new TextProvider());
            //this.Container.RegisterInstance<ITextProvider>(new TextProvider());
            //TextProvider t= new TextProvider();
            //this.Container.RegisterInstance(typeof(TextProvider), "WPFPrism.TextProvider", t,null);
        }
    }
}
