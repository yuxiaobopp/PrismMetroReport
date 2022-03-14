using ModuleDirectoryTest1.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleDirectoryTest1
{
    public class ModuleDirectoryTest1Module : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion<ViewB>("ContentRegion1");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
