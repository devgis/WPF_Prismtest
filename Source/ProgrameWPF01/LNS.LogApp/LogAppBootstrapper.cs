using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.UnityExtensions;
using System.Windows;
using LNS.LogApp.Models;
using Microsoft.Practices.Prism.Modularity;
using LNS.LogApp.Contract;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Events;

namespace LNS.LogApp
{
    public class LogAppBootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return this.Container.TryResolve<MainWindow>();
        }

        protected override void InitializeShell()
        {   //  控制页面在初始化时显示Shell页面
            App.Current.MainWindow = (Window)this.Shell; ; //new ShellWindow();//(UIElement)this.Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {

            //  注册Module。在实际开发中可以使用xaml做配置文件，
            //  这样就可以将PrismStarter与ModuleA和ModuleB完全解耦，也就不再需要引用这两个项目
            Type departmentType = typeof(Department);
            ModuleInfo moduleDepartment = new ModuleInfo
            {
                ModuleName = departmentType.Name,
                ModuleType = departmentType.AssemblyQualifiedName,
            };

            Type logType = typeof(Log);
            ModuleInfo moduleLog = new ModuleInfo
            {
                ModuleName = logType.Name,
                ModuleType = logType.AssemblyQualifiedName,
            };

            Type modelType = typeof(Model);
            ModuleInfo moduleModel = new ModuleInfo
            {
                ModuleName = modelType.Name,
                ModuleType = modelType.AssemblyQualifiedName,
            };

            Type personType = typeof(Person);
            ModuleInfo modulePerson = new ModuleInfo
            {
                ModuleName = personType.Name,
                ModuleType = personType.AssemblyQualifiedName,
            };

            Type projectType = typeof(Project);
            ModuleInfo moduleProject = new ModuleInfo
            {
                ModuleName = projectType.Name,
                ModuleType = projectType.AssemblyQualifiedName,
            };

            Type stageType = typeof(Stage);
            ModuleInfo moduleStage = new ModuleInfo
            {
                ModuleName = stageType.Name,
                ModuleType = stageType.AssemblyQualifiedName,
            };

            this.ModuleCatalog.AddModule(moduleDepartment);
            this.ModuleCatalog.AddModule(moduleLog);
            this.ModuleCatalog.AddModule(moduleModel);
            this.ModuleCatalog.AddModule(modulePerson);
            this.ModuleCatalog.AddModule(moduleProject);
            this.ModuleCatalog.AddModule(moduleStage);
        }


        protected override void ConfigureContainer()
        {   //  注册一下TextProvider，这样在通过容器请求ITextProvider时会返回TextProvider实例
            base.ConfigureContainer();
            this.Container.RegisterInstance<ITextProvider>(new TextProvider());
        }

    }
}
