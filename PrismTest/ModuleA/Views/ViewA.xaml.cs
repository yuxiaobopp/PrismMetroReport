using ModuleA.COM.Demo;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModuleA.Views
{
    /// <summary>
    /// ViewA.xaml 的交互逻辑
    /// </summary>
    public partial class ViewA : UserControl
    {
        
        private CommHelper comm { get; set; }

        private string receive { get; set; }
        private string ToHexString(byte[] array)
        {
            if (array == null) return string.Empty;
            StringBuilder buffer = new StringBuilder();
            foreach (var item in array)
            {
                buffer.Append($"{item.ToString("X2")} ");
            }
            return buffer.ToString();
        }

        /// <summary>
        /// 头部数据规则
        /// </summary>
        private HashSet<string> HEAD_DATA = new HashSet<string>{ "01", "03", "06" };

        /// <summary>
        /// 头部数据验证
        /// </summary>
        /// <returns></returns>
        private bool CheckHead(string headString)
        {
            return headString == string.Join(" ", HEAD_DATA).ToString();
        }

        /// <summary>
        /// 获取头部数据 数组
        /// </summary>
        /// <param name="temperatureDataString"></param>
        /// <returns></returns>
        private HashSet<string> GetHead(string temperatureDataString)
        {
            var sp = temperatureDataString.Split(" ");
            if (sp.Length < 3)
                return null;

            Array.Resize(ref sp, 3);
            return new HashSet<string>(sp);
        }

        /// <summary>
        /// 获取温度位置数据
        /// </summary>
        /// <param name="temperatureDataString"></param>
        /// <returns></returns>
        private Array GetTemperatureData(string temperatureDataString)
        {
            var sp = temperatureDataString.Split(" ");

            //var spHead = GetHeadString(temperatureDataString);

            //数据位6位
            var spTemperature = new string[6];
            Array.ConstrainedCopy(sp, 3, spTemperature, 0, 6);

            return spTemperature;
        }

       /// <summary>
       /// 体温高位、体温低位、气温高位、气温低位、距离高位、距离低位
       /// 6数据位按顺序获取 获取体温高位数字
       /// </summary>
       /// <param name="data"></param>
       /// <returns></returns>
        private string GetTemperatureHighNum(Array data)
        {
            return data.GetValue(0).ToString();
        }

        /// <summary>
        /// 体温高位、体温低位、气温高位、气温低位、距离高位、距离低位
        /// 6数据位按顺序获取 获取体温低位数字
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private string GetTemperatureLowNum(Array data)
        {
            return data.GetValue(1).ToString();
        }

        void comm_DataReceived(byte[] readBuffer1)
        {
            //log.Info(HexCon.ByteToString(readBuffer));

            try
            {
                receive = ToHexString(readBuffer1);

                var head = GetHead(receive);
                if (head == null)
                    return;

                //校验head
                if (head.Count != 3)
                {
                    //头部数据不规范
                    return;
                }

                //温度位置数据处理
                var temperatureData = GetTemperatureData(receive);

                if (temperatureData == null)
                    return;

                if (temperatureData != null && temperatureData.Length < 6)
                {
                    //温度数据不足6位
                    return;
                }

                //只对规范的数据进行转换

                var highNum = GetTemperatureHighNum(temperatureData);
                //int highNumValue = Convert.ToInt32(highNum, 16);
                var lowNum = GetTemperatureLowNum(temperatureData);

                int numValue = Convert.ToInt32($"{highNum}{lowNum}", 16);

            }
            catch (Exception ex)
            {

            }

            //if (string.Equals(receive.Trim(), str, StringComparison.CurrentCultureIgnoreCase))
            //{
            //    try
            //    {
            //        byte[] send = new byte[1];
            //        send[0] = 0x05;

            //        comm.DataReceived -= new CommHelper.EventHandle(comm_DataReceived);
            //    }
            //    catch (Exception ex)
            //    {
            //    }
            //}
        }
        public ViewA()
        {
            InitializeComponent();
            //用于监听Windows消息 
            //注意获取窗口句柄一定要写在窗口loaded事件里，才能获取到窗口句柄，否则为空
            //HwndSource hwndSource = PresentationSource.FromVisual(this) as HwndSource;//窗口过程
            //if (hwndSource != null)
            //    hwndSource.AddHook(new HwndSourceHook(DeveiceChanged));  //挂钩

            comList.SelectionChanged += ComList_SelectionChanged;
            openport.Click += Openport_Click;
        }

        private void Openport_Click(object sender, RoutedEventArgs e)
        {
            ChangePortName(comList.Text);
        }

        private void ComList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var portName = (sender as ComboBox).Text;
        }

        private void ChangePortName(string portName)
        {
            if (string.IsNullOrWhiteSpace(portName))
                return;

            //加载串口
            CommHelper comm = new CommHelper();

            ConfigClass config = new ConfigClass();
            comm.serialPort.PortName = portName;//config.ReadConfig("SendHealCard");
            //波特率
            comm.serialPort.BaudRate = 9600;
            //数据位
            comm.serialPort.DataBits = 6; //  8;
            //两个停止位
            comm.serialPort.StopBits = System.IO.Ports.StopBits.One;
            //无奇偶校验位
            comm.serialPort.Parity = System.IO.Ports.Parity.None;
            comm.serialPort.ReadTimeout = 1000;//100;
            comm.serialPort.WriteTimeout = -1;

            comm.Open();
            if (comm.IsOpen)
            {
                comm.DataReceived += new CommHelper.EventHandle(comm_DataReceived);
            }
        }
    }
}
