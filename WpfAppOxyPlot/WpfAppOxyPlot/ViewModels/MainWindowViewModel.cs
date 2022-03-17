using Ikc5.TypeLibrary;
using Microsoft.Practices.Unity;

namespace WpfAppOxyPlot.ViewModels
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        public MainWindowViewModel()
        {
        }

        #region IMainWindowViewModel

        [Dependency]
        public ILineChartViewModel LineChartViewModel { get; set; }

        [Dependency]
        public IColumnChartViewModel ColumnChartViewModel { get; set; }

        [Dependency]
        public ILineChartModbusViewModel LineChartModbusViewModel { get; set; }

        #endregion
    }
}