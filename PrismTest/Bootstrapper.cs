using Prism.Ioc;
using Prism.Regions;
using Prism.Unity;
using PrismTest.Adapter;
using PrismTest.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PrismTest
{
    public class Bootstrapper : PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            //入口程序启动界面
            return Container.Resolve<ActivationDeactivationTest>();
            //return Container.Resolve<ViewInjectionTest>();
            //return Container.Resolve<DiscoveryViewA>();
            //return Container.Resolve<RegionAdapterTest>();
            //return Container.Resolve<RegionsTest>();
            //return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);

            //注册模块加载适配器  例 StackPanel类型的适配器
            regionAdapterMappings.RegisterMapping<StackPanel>(Container.Resolve<StackPanelRegionAdapter>());
        }
    }
}
