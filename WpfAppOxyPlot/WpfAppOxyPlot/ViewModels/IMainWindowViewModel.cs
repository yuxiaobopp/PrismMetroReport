
namespace WpfAppOxyPlot.ViewModels
{
    public interface IMainWindowViewModel
    {
        ILineChartViewModel LineChartViewModel { get; }
        IColumnChartViewModel ColumnChartViewModel { get; }
        ILineChartModbusViewModel LineChartModbusViewModel { get; set; }
    }
}
