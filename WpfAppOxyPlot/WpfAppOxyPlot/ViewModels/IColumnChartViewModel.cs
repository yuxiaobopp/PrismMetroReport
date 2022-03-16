using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WpfAppOxyPlot.ViewModels
{
    public interface IColumnChartViewModel
    {
        IReadOnlyList<Tuple<string, int>> CountList { get; }
    }
}