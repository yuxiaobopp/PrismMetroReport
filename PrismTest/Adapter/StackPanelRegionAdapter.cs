using Prism.Regions;
using System.Windows;
using System.Windows.Controls;

namespace PrismTest.Adapter
{
    public class StackPanelRegionAdapter : RegionAdapterBase<StackPanel>
    {
        public StackPanelRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory):base(regionBehaviorFactory)
        {

        }
        protected override void Adapt(IRegion region, StackPanel regionTarget)
        {
            region.Views.CollectionChanged += (s, e) => {

                if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                {
                    foreach (FrameworkElement item in e.NewItems)
                    {
                        regionTarget.Children.Add(item);//有新模块渲染，会调用这里
                    }
                }
            };
        }

     

        protected override IRegion CreateRegion()
        {
            return new AllActiveRegion();
        }
    }
}
