using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCanvas.ViewModels
{
    public interface IColumnChartViewModel
    {
        IReadOnlyList<Tuple<string, int>> CountList { get; }
    }
}
