using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCanvas.ViewModels
{
    public interface ILineChartViewModel
    {
        IReadOnlyList<DataPoint> CountList { get; }
    }
}
