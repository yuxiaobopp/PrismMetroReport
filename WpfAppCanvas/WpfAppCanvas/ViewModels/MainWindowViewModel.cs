using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCanvas.ViewModels
{
    public class MainWindowViewModel : IMainWindowViewModel
    {


        public MainWindowViewModel()
        {
        }

        #region IMainWindowViewModel

        public ILineChartViewModel LineChartViewModel { get; set; }

        public IColumnChartViewModel ColumnChartViewModel { get; set; }

        #endregion
    }
}
