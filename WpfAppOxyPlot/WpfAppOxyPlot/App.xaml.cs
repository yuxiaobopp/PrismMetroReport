using Ikc5.TypeLibrary.Logging;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfAppOxyPlot.Models;
using WpfAppOxyPlot.Services;
using WpfAppOxyPlot.ViewModels;

namespace WpfAppOxyPlot
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private IService _chartService = null;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IUnityContainer container = new UnityContainer();

            container.RegisterType<ILogger, EmptyLogger>();
            container.RegisterType<IChartRepository, ChartRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<IService, ChartService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IMainWindowViewModel, MainWindowViewModel>();
            container.RegisterType<IColumnChartViewModel, ColumnChartViewModel>();
            container.RegisterType<ILineChartViewModel, LineChartViewModel>();
            container.RegisterType<ILineChartModbusViewModel, LineChartModbusViewModel>();

            _chartService = container.Resolve<IService>();
            var mainWindow = container.Resolve<MainWindow>();
            Application.Current.MainWindow = mainWindow;
            Application.Current.MainWindow.Show();

            _chartService.OnStart();

            _chartService.InitUserControlsComboBox();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _chartService.OnStop();
            base.OnExit(e);
        }
    }
}
