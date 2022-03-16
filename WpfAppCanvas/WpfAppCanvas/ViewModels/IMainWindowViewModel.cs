using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCanvas.ViewModels
{


    public interface IMainWindowViewModel
    {
        ILineChartViewModel LineChartViewModel { get; }
        IColumnChartViewModel ColumnChartViewModel { get; }
    }
}
