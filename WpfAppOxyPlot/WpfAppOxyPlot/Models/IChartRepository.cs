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
        IReadOnlyList<int> LineRtuDataList { get; }
        IReadOnlyList<int> ColumnCountList { get; }

        #region 串口工具属性
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

        /// <summary>
        /// 添加串口
        /// </summary>
        /// <param name="value"></param>
        void AddCmbPortName(string value);

        /// <summary>
        /// 添加波特率
        /// </summary>
        /// <param name="value"></param>
        void AddCmbBaud(string value);

        /// <summary>
        /// 添加校验
        /// </summary>
        /// <param name="value"></param>
        void AddCmbParity(string value);

        /// <summary>
        /// 添加数据位
        /// </summary>
        /// <param name="value"></param>
        void AddCmbDataBits(string value);

        /// <summary>
        /// 添加停止位
        /// </summary>
        /// <param name="value"></param>
        void AddCmbStopBits(string value);

        #endregion


        void AddLineCount(int newValue);
        void AddLineRtuData(int newValue);
        void AddColumnCount(int index, int newValue);
    }
}
