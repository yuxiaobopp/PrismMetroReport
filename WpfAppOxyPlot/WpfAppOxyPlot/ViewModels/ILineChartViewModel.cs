using System.Collections.Generic;
using OxyPlot;

namespace WpfAppOxyPlot.ViewModels
{
    public interface ILineChartViewModel
    {
        IReadOnlyList<DataPoint> CountList { get; }
    }
}