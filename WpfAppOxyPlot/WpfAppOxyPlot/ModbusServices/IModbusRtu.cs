using Modbus.Device;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppOxyPlot.ModbusServices
{
    public interface IModbusRtu
    {
        /// <summary>
        /// 初始化串口(不打开串口)
        /// </summary>
        /// <returns></returns>
        SerialPort InitSerialPortParameter();

        /// <summary>
        /// 执行功能码
        /// </summary>
        void ExecuteFunction();
    }
}
