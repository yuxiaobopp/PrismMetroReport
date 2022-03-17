using Modbus.Device;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppOxyPlot.ModbusServices
{
    public class ModbusRtu:IModbusRtu
    {
        private static IModbusMaster master;
        private static SerialPort port;
        //写线圈或写寄存器数组
        private bool[] coilsBuffer;
        private ushort[] registerBuffer;
        //功能码
        private string functionCode;
        //参数(分别为站号,起始地址,长度)
        private byte slaveAddress;
        private ushort startAddress;
        private ushort numberOfPoints;
        //串口参数
        private string portName;
        private int baudRate;
        private Parity parity;
        private int dataBits;
        private StopBits stopBits;

        public ModbusRtu()
        {
           
        }

        public void ExecuteFunction()
        {
            throw new NotImplementedException();
        }

        public SerialPort InitSerialPortParameter()
        {
            throw new NotImplementedException();
        }
    }
}
