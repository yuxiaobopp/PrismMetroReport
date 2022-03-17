using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;

namespace WpfAppOxyPlot.ViewModels
{
    public class DesignLineChartModbusViewModel : ILineChartModbusViewModel
    {
        public DesignLineChartModbusViewModel()
        {
            //RtuDataList = new List<DataPoint>(new[] { new DataPoint(0, 0), new DataPoint(1, 3), new DataPoint(2, 6), new DataPoint(3, 5), });
        }

        public IReadOnlyList<DataPoint> RtuDataList { get; }

        public IReadOnlyList<string> CmbPortNameList { get; }

        public IReadOnlyList<string> CmbBaudList { get; }

        public IReadOnlyList<string> CmbParityList { get; }

        public IReadOnlyList<string> CmbDataBitsList { get; }

        public IReadOnlyList<string> CmbStopBitsList { get; }

        public IReadOnlyList<string> CmbModbusRtuFunList { get; }
    }
}
