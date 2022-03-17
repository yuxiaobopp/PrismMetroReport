using Ikc5.TypeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppOxyPlot.Models
{
    public class ChartRepository : BaseNotifyPropertyChanged, IChartRepository
    {
        #region Lists

        private const int LineCount = 100;
        private readonly List<int> _lineCountList = new List<int>(LineCount);

        private const int ColumnCount = 50;
        private readonly IDictionary<int, int> _columnCountDictionary = new Dictionary<int, int>(ColumnCount);

        #endregion

        #region IChartRepository

        public IReadOnlyList<int> LineCountList => _lineCountList;

        public IReadOnlyList<int> ColumnCountList => GetColumnCountList().ToList();


        private readonly List<string> _cmModbusRtuFunList = new List<string>(8);
        private readonly List<string> _cmbPortNameList = new List<string>(10);
        private readonly List<string> _cmbBaudList = new List<string>(10);
        private readonly List<string> _cmbParityList = new List<string>(10);
        private readonly List<string> _cmbDataBitsList = new List<string>(10);
        private readonly List<string> _cmbStopBitsList = new List<string>(10);
        public IReadOnlyList<string> CmbModbusRtuFunList => _cmModbusRtuFunList;
        public IReadOnlyList<string> CmbPortNameList => _cmbPortNameList;
        public IReadOnlyList<string> CmbBaudList => _cmbBaudList;
        public IReadOnlyList<string> CmbParityList => _cmbParityList;
        public IReadOnlyList<string> CmbDataBitsList => _cmbDataBitsList;
        public IReadOnlyList<string> CmbStopBitsList => _cmbStopBitsList;

        private const int LineRtuData = 100;
        private readonly List<int> _lineRtuDataList = new List<int>(LineRtuData);
        public IReadOnlyList<int> LineRtuDataList => _lineRtuDataList;

        public void AddLineCount(int newValue)
        {
            _lineCountList.Add(newValue);
            if (_lineCountList.Count > LineCount)
                _lineCountList.RemoveAt(0);

            OnPropertyChanged(nameof(LineCountList));
        }

        public void AddLineRtuData(int newValue)
        {

            _lineRtuDataList.Add(newValue);
            if (_lineRtuDataList.Count > LineCount)
                _lineRtuDataList.RemoveAt(0);

            OnPropertyChanged(nameof(LineRtuDataList));
        }

        public void AddColumnCount(int index, int newValue)
        {
            index = Math.Max(0, Math.Min(index, ColumnCount - 1));
            _columnCountDictionary[index] = newValue;

            OnPropertyChanged(nameof(ColumnCountList));
        }

        private IEnumerable<int> GetColumnCountList()
        {
            var maxIndex = _columnCountDictionary.Count == 0
                ? -1
                : _columnCountDictionary.Keys.Max();
            for (var index = 0; index <= maxIndex; index++)
            {
                yield return _columnCountDictionary.ContainsKey(index) ?
                                _columnCountDictionary[index]
                                : 0;
            }
        }

        public void AddModbusRtuFun(string value)
        {
            _cmModbusRtuFunList.Add(value);
            OnPropertyChanged(nameof(CmbModbusRtuFunList));
        }

        public void AddCmbPortName(string value)
        {
            _cmbPortNameList.Add(value);
            OnPropertyChanged(nameof(CmbPortNameList));
        }

        public void AddCmbBaud(string value)
        {
            _cmbBaudList.Add(value);
            OnPropertyChanged(nameof(CmbBaudList));
        }

        public void AddCmbParity(string value)
        {
            _cmbParityList.Add(value);
            OnPropertyChanged(nameof(CmbParityList));
        }

        public void AddCmbDataBits(string value)
        {
            _cmbDataBitsList.Add(value);
            OnPropertyChanged(nameof(_cmbDataBitsList));
        }

        public void AddCmbStopBits(string value)
        {
            _cmbStopBitsList.Add(value);
            OnPropertyChanged(nameof(CmbStopBitsList));
        }


        #endregion
    }
}
