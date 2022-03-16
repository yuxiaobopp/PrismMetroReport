using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using WpfAppCanvas.Models;
using WpfAppCanvas.Services;
using WpfAppCanvas.ViewModels;

namespace WpfAppCanvas
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// https://www.codeproject.com/Articles/1164395/Wpf-application-with-real-time-data-in-OxyPlot-cha
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost host;
        public App()
        {
            host = new HostBuilder()
          .ConfigureServices((hostContext, services) =>
          {
              //Add business services as needed
              services.AddScoped<IChartRepository, ChartRepository>();
              services.AddScoped<IService, ChartService>();

              services.AddScoped<IMainWindowViewModel, MainWindowViewModel>();
              services.AddScoped<IColumnChartViewModel, ColumnChartViewModel>();
              services.AddScoped<ILineChartViewModel, LineChartViewModel>();

              //Lets Create single tone instance of Master windows
              services.AddSingleton<MainWindow>();

          }).Build();

            using(var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var masterWindow = services.GetRequiredService<MainWindow>();
                    masterWindow.Show();

                    var chartservice = services.GetRequiredService<IService>();
                    chartservice.OnStart();
                }
                catch (System.Exception ex)
                {

                    
                }
            }
        }
    }
}
