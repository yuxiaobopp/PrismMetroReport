using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Ikc5.TypeLibrary;
using OxyPlot;
using WpfAppOxyPlot.Models;

namespace WpfAppOxyPlot.ViewModels
{
    public class LineChartModbusViewModel : BaseNotifyPropertyChanged, ILineChartModbusViewModel
    {
        private readonly IChartRepository _chartRepository;

        public LineChartModbusViewModel(IChartRepository chartRepository)
        {
            chartRepository.ThrowIfNull(nameof(chartRepository));
            _chartRepository = chartRepository;
            chartRepository.PropertyChanged += ChartRepositoryPropertyChanged;
        }

        private void ChartRepositoryPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!nameof(IChartRepository.CmbModbusRtuFunList).Equals(e.PropertyName) ||
                !nameof(IChartRepository.LineRtuDataList).Equals(e.PropertyName)||
                !nameof(IChartRepository.CmbParityList).Equals(e.PropertyName)||
                !nameof(IChartRepository.CmbBaudList).Equals(e.PropertyName)||
                !nameof(IChartRepository.CmbDataBitsList).Equals(e.PropertyName) ||
                !nameof(IChartRepository.CmbPortNameList).Equals(e.PropertyName)||
                !nameof(IChartRepository.CmbStopBitsList).Equals(e.PropertyName)
                )
                return;

            OnPropertyChanged(nameof(RtuDataList));
        }

        public IReadOnlyList<DataPoint> RtuDataList =>
            _chartRepository.LineRtuDataList.Select((value, index) => new DataPoint(index, value)).ToList();

        public IReadOnlyList<string> CmbModbusRtuFunList => _chartRepository.CmbModbusRtuFunList;
        public IReadOnlyList<string> CmbPortNameList => _chartRepository.CmbPortNameList;

        public IReadOnlyList<string> CmbBaudList => _chartRepository.CmbBaudList;

        public IReadOnlyList<string> CmbParityList => _chartRepository.CmbParityList;

        public IReadOnlyList<string> CmbDataBitsList => _chartRepository.CmbDataBitsList;

        public IReadOnlyList<string> CmbStopBitsList => _chartRepository.CmbStopBitsList;
    }
}
