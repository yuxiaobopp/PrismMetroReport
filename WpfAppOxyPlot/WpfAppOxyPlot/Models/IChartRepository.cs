using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppOxyPlot.Models
{
    public interface IChartRepository : INotifyPropertyChanged
    {
        IReadOnlyList<int> LineCountList { get; }
        IReadOnlyList<int> ColumnCountList { get; }

        void AddLineCount(int newValue);
        void AddColumnCount(int index, int newValue);
    }
}
