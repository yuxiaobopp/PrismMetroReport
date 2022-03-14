using ModuleDirectoryTest.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleDirectoryTest
{
    public class ModuleDirectoryTestModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion<ViewA>("ContentRegion");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
