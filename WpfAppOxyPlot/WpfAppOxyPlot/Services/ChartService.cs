using Ikc5.TypeLibrary;
using System;
using System.Windows.Threading;
using WpfAppOxyPlot.Models;

namespace WpfAppOxyPlot.Services
{
    public class ChartService : IService
    {
        private readonly IChartRepository _chartRepository;

        public ChartService(IChartRepository chartRepository)
        {
            chartRepository.ThrowIfNull(nameof(chartRepository));
            _chartRepository = chartRepository;

            _countTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(250),
                IsEnabled = false
            };
            _countTimer.Tick += CountTimerTick;
        }

        #region IChartService

        /// <summary>
        /// Start service.
        /// </summary>
        public void OnStart()
        {
            _countTimer.Start();
        }

        /// <summary>
        /// Stop service, cleanup data.
        /// </summary>
        public void OnStop()
        {
            _countTimer.Stop();
        }

        #endregion

        #region Service data
        private readonly DispatcherTimer _countTimer;
        private readonly Random _countRandom = new Random(987654321);
        private readonly Random _indexRandom = new Random(123456789);

        /// <summary>
        /// Method emulates new data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountTimerTick(object sender, EventArgs e)
        {
            var value = _countRandom.Next(150);
            _chartRepository.AddLineCount(value);

            var index = _indexRandom.Next(50);
            value = _countRandom.Next(100);
            _chartRepository.AddColumnCount(index, value);

            _countTimer.Start();
        }

        public void InitUserControlsComboBox()
        {
            for (int i = 1; i <= 10; i++)
            {
                _chartRepository.AddCmbPortName($"COM{i}");
            }

            string[] bauds = { "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "56000" };
            foreach (var item in bauds)
            {
                _chartRepository.AddCmbBaud(item);
            }

            string[] parity = { "奇", "偶", "无" };
            foreach (var item in parity)
            {
                _chartRepository.AddCmbParity(item);
            }

            string[] databits = { "7", "8" };
            foreach (var item in databits)
            {
                _chartRepository.AddCmbDataBits(item);
            }

            string[] stopbits = { "1", "2" };
            foreach (var item in stopbits)
            {
                _chartRepository.AddCmbStopBits(item);
            }

            string[] funs = { "01 Read Coils", "02 Read DisCrete Inputs", "03 Read Holding Registers", "04 Read Input Registers", "05 Write Single Coil", "06 Write Single Registers", "0F Write Multiple Coils", "10 Write Multiple Registers" };
            foreach (var item in funs)
            {
                _chartRepository.AddModbusRtuFun(item);
            }

        }

        #endregion
    }
}
