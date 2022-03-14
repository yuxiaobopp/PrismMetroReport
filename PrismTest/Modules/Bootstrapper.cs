using ModuleA;
using Modules.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System.Windows;

namespace Modules
{
    public class Bootstrapper : PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            
            return Container.Resolve<TestLoadManual>();
            //return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        #region 读取模块多种方式（集中方式只能各自独立使用）
        /// <summary>
        /// 1 配置文件方式读取模块
        /// </summary>
        /// <returns></returns>
        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    return new ConfigurationModuleCatalog();
        //    //return base.CreateModuleCatalog();
        //}

        /// <summary>
        /// 2 代码方式读取模块
        /// </summary>
        /// <param name="moduleCatalog"></param>
        //protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        //{
        //    //base.ConfigureModuleCatalog(moduleCatalog);
        //    moduleCatalog.AddModule<ModuleA.ModuleAModule>();
        //}


        //3 从路径读取模块
        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    var path = System.IO.Path.GetFullPath(@".\Modules");
        //    //return base.CreateModuleCatalog();
        //    return new DirectoryModuleCatalog {
        //     ModulePath= @".\Modules" //需要再bin/Debug/netcoreapp3.1文件夹里面加个Modules文件夹，把其他模块dll输出道这个文件夹
        //    };
        //}

        // 4 手动触发加载模块
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            //base.ConfigureModuleCatalog(moduleCatalog);
            var moduleAType = typeof(ModuleAModule);
            moduleCatalog.AddModule(new ModuleInfo { 
            
                ModuleName=moduleAType.Name,
                ModuleType=moduleAType.AssemblyQualifiedName,
                InitializationMode=InitializationMode.OnDemand//手动加载模块
            });
        }
        #endregion

    }
}
