﻿using System.Windows;
using MahApps.Metro.Controls;
using Prism.Ioc;
using Prism.Regions;
using PrismMetroSample.Infrastructure.Constants;

namespace PrismMetroSample.Shell.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var regionManager= ContainerLocator.Current.Resolve<IRegionManager>();
            if (regionManager != null)
            {
                SetRegionManager(regionManager, this.flyoutsControlRegion, RegionNames.FlyoutRegion);
                SetRegionManager(regionManager, this.rightWindowCommandsRegion, RegionNames.ShowSearchPatientRegion);
            }
        }

        void SetRegionManager(IRegionManager regionManager, DependencyObject regionTarget, string regionName)
        {
            RegionManager.SetRegionName(regionTarget, regionName);
            RegionManager.SetRegionManager(regionTarget, regionManager);
        }
    }
}
