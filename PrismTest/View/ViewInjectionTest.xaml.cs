using Prism.Ioc;
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
    /// ViewInjectionTest.xaml 的交互逻辑
    /// </summary>
    public partial class ViewInjectionTest : Window
    {
        IContainerExtension _container;
        IRegionManager _regionManager;
        public ViewInjectionTest(IContainerExtension container,IRegionManager regionManager)
        {
            InitializeComponent();

            _container = container;
            _regionManager = regionManager;

            //regionManager.RegisterViewWithRegion<ViewA>("ContentRegion");
        }

        /// <summary>
        /// 点击按钮，注入模块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var view = _container.Resolve<ViewA>();
            IRegion region = _regionManager.Regions["ContentRegion"];
            region.Add(view);
        }
    }
}
