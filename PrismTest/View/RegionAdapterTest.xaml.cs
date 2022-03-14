using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PrismTest.View
{
    /// <summary>
    /// RegionAdapter.xaml 的交互逻辑
    /// </summary>
    public partial class RegionAdapterTest : Window
    {
        //public RegionAdapterTest()
        public RegionAdapterTest(IRegionManager regionManager)
        {
            InitializeComponent();
            //view discovery
            //注册模块控件，名字一致才渲染
            regionManager.RegisterViewWithRegion<ViewA>("ContentRegion");
        }
    }
}
