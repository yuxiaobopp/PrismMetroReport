using System.Collections.Generic;
using OxyPlot;

namespace WpfAppOxyPlot.ViewModels
{
    public interface ILineChartModbusViewModel
    {
        IReadOnlyList<DataPoint> RtuDataList { get; }
        /// <summary>
        /// 选择串口
        /// </summary>
        IReadOnlyList<string> CmbPortNameList { get; }

        /// <summary>
        /// 选择波特率
        /// </summary>
        IReadOnlyList<string> CmbBaudList { get; }

        /// <summary>
        /// 选择奇偶校验
        /// </summary>
        IReadOnlyList<string> CmbParityList { get; }

        /// <summary>
        /// 选择数据位
        /// </summary>
        IReadOnlyList<string> CmbDataBitsList { get; }

        /// <summary>
        /// 选择停止位
        /// </summary>
        IReadOnlyList<string> CmbStopBitsList { get; }
    }
}