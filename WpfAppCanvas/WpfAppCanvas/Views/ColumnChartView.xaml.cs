using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppCanvas.Views
{
    /// <summary>
    /// ColumnChartView.xaml 的交互逻辑
    /// </summary>
    public partial class ColumnChartView : UserControl
    {
        public ColumnChartView()
        {
            InitializeComponent();

            IndexAxis.LabelFormatter = (index =>
            {
                var ratio = (int)Math.Round(CountSeries.Items.Count / 10.0, 0);
                var label = (int)index + 1;
                return (ratio <= 1 || label % ratio == 1) ? label.ToString("D") : string.Empty;
            });
        }
    }
}
