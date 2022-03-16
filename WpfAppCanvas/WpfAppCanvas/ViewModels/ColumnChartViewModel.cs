using Ikc5.TypeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using WpfAppCanvas.Models;

namespace WpfAppCanvas.ViewModels
{
    public class ColumnChartViewModel : BaseNotifyPropertyChanged, IColumnChartViewModel
    {
        private readonly IChartRepository _chartRepository;

        public ColumnChartViewModel(IChartRepository chartRepository)
        {
            chartRepository.ThrowIfNull(nameof(chartRepository));
            _chartRepository = chartRepository;
            chartRepository.PropertyChanged += ChartRepositoryPropertyChanged;
        }

        private void ChartRepositoryPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!nameof(IChartRepository.ColumnCountList).Equals(e.PropertyName))
                return;

            OnPropertyChanged(nameof(CountList));
        }

        /// <summary>
        /// List of numbers.
        /// </summary>
        public IReadOnlyList<Tuple<string, int>> CountList =>
            _chartRepository.ColumnCountList.
            Select((value, index) => new Tuple<string, int>(index.ToString("D"), value)).
            ToList();
    }
}
