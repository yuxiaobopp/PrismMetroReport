using Modules.ViewModels;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace Modules.Views
{
    /// <summary>
    /// TestLoadManual.xaml 的交互逻辑
    /// </summary>
    public partial class TestLoadManual : Window
    {
        IModuleManager _moduleManager;
   
        public TestLoadManual(IModuleManager moduleManager)
        {
            InitializeComponent();
            _moduleManager = moduleManager;

           
        }

        #region 通信协议

        /// <summary>
        /// 头
        /// </summary>
        public const int CW_HEAD = 0x01;
        /// <summary>
        /// 功能
        /// </summary>
        public const int CW_CONTROL= 0x03;

        /// <summary>
        /// 数据长度
        /// </summary>
        public const int CW_DATALEN = 0x06;

        /// <summary>
        /// 数据
        /// </summary>
        public const int CW_DATA = 0x0E;

    

        #endregion


        public const int WM_DEVICECHANGE = 0x219;          //Windows消息编号
        public const int DBT_DEVICEARRIVAL = 0x8000;
        public const int DBT_DEVICEREMOVECOMPLETE = 0x0000000000000007;//0x8004;

        //设备插拔改变函数
        private IntPtr DeveiceChanged(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            string[] PortNames;
            if (msg == WM_DEVICECHANGE)
            {
                switch (wParam.ToInt32())
                {
                    case DBT_DEVICEARRIVAL://设备插入  
                        PortNames = SerialPort.GetPortNames();
                        //if (IsWorking == true && PortNames.Contains(ConfigInfo.Port))
                        //{
                        //    if (serialPortUtil != null)
                        //    {
                        //        serialPortUtil.OpenPort();
                        //        MsgBox.Show("串口连接成功！");
                        //    }
                        //}
                        break;
                    case DBT_DEVICEREMOVECOMPLETE: //设备卸载
                        PortNames = SerialPort.GetPortNames();
                        //if (IsWorking == true && !PortNames.Contains(ConfigInfo.Port))
                        //{
                        //    MsgBox.Show("串口连接断开！");
                        //}
                        break;
                    default:
                        break;
                }
            }
            return IntPtr.Zero;
        }
        /// <summary>
        /// 按钮触发加载模块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _moduleManager.LoadModule("ModuleAModule");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            IntPtr wptr = new WindowInteropHelper(Window.GetWindow(this)).Handle;
            HwndSource hs = HwndSource.FromHwnd(wptr);
            if (hs != null)
                hs.AddHook(new HwndSourceHook(DeveiceChanged));
        }
    }
}
