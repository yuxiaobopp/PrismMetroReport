using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NModbus;
using System.Net.Sockets;
using System.Threading;

namespace ModbusRtu
{
    public partial class Form1 : Form
    {

        private static ModbusFactory modbusFactory;
        private static IModbusMaster master;
        //写线圈或写寄存器数组
        bool[] coilsBuffer;
        ushort[] registerBuffer;
        //功能码
        string functionCode;
        //参数(分别为站号,起始地址,长度)
        byte slaveAddress;
        ushort startAddress;
        ushort numberOfPoints;

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化modbusmaster
            modbusFactory = new ModbusFactory();
            //在本地测试 所以使用回环地址,modbus协议规定端口号 502
            master = modbusFactory.CreateMaster(new TcpClient("127.0.0.1", 502));
            //设置读取超时时间
            master.Transport.ReadTimeout = 2000;
            master.Transport.Retries = 2000;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }
        /// <summary>
        /// 读/写
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ExecuteFunction();
        }

        private async void ExecuteFunction()
        {
            try
            {
                //重新实例化是为了 modbus slave更换连接时不报错 
                master = modbusFactory.CreateMaster(new TcpClient("127.0.0.1", 502));
                if (functionCode != null)
                {
                    switch (functionCode)
                    {
                        case "01 Read Coils"://读取单个线圈
                            SetReadParameters();
                            coilsBuffer = master.ReadCoils(slaveAddress, startAddress, numberOfPoints);

                            for (int i = 0; i < coilsBuffer.Length; i++)
                            {
                                SetMsg(coilsBuffer[i] + " ");
                            }
                            SetMsg("\r\n");
                            break;
                        case "02 Read DisCrete Inputs"://读取输入线圈/离散量线圈
                            SetReadParameters();

                            coilsBuffer = master.ReadInputs(slaveAddress, startAddress, numberOfPoints);
                            for (int i = 0; i < coilsBuffer.Length; i++)
                            {
                                SetMsg(coilsBuffer[i] + " ");
                            }
                            SetMsg("\r\n");
                            break;
                        case "03 Read Holding Registers"://读取保持寄存器
                            SetReadParameters();
                            registerBuffer = master.ReadHoldingRegisters(slaveAddress, startAddress, numberOfPoints);
                            for (int i = 0; i < registerBuffer.Length; i++)
                            {
                                SetMsg(registerBuffer[i] + " ");
                            }
                            SetMsg("\r\n");
                            break;
                        case "04 Read Input Registers"://读取输入寄存器
                            SetReadParameters();
                            registerBuffer = master.ReadInputRegisters(slaveAddress, startAddress, numberOfPoints);
                            for (int i = 0; i < registerBuffer.Length; i++)
                            {
                                SetMsg(registerBuffer[i] + " ");
                            }
                            SetMsg("\r\n");
                            break;
                        case "05 Write Single Coil"://写单个线圈
                            SetWriteParametes();
                            await master.WriteSingleCoilAsync(slaveAddress, startAddress, coilsBuffer[0]);
                            break;
                        case "06 Write Single Registers"://写单个输入线圈/离散量线圈
                            SetWriteParametes();
                            await master.WriteSingleRegisterAsync(slaveAddress, startAddress, registerBuffer[0]);
                            break;
                        case "0F Write Multiple Coils"://写一组线圈
                            SetWriteParametes();
                            await master.WriteMultipleCoilsAsync(slaveAddress, startAddress, coilsBuffer);
                            break;
                        case "10 Write Multiple Registers"://写一组保持寄存器
                            SetWriteParametes();
                            await master.WriteMultipleRegistersAsync(slaveAddress, startAddress, registerBuffer);
                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("请选择功能码!");
                }
               master.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 4)
            {
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
            }
            comboBox1.Invoke(new Action(() => { functionCode = comboBox1.SelectedItem.ToString(); }));
        }

        /// <summary>
        /// 初始化读参数
        /// </summary>
        private void SetReadParameters()
        {
            if (txt_startAddr1.Text == "" || txt_slave1.Text == "" || txt_length.Text == "")
            {
                MessageBox.Show("请填写读参数!");
            }
            else
            {
                slaveAddress = byte.Parse(txt_slave1.Text);
                startAddress = ushort.Parse(txt_startAddr1.Text);
                numberOfPoints = ushort.Parse(txt_length.Text);
            }
        }
        /// <summary>
        /// 初始化写参数
        /// </summary>
        private void SetWriteParametes()
        {
            if (txt_startAddr2.Text == "" || txt_slave2.Text == "" || txt_data.Text == "")
            {
                MessageBox.Show("请填写写参数!");
            }
            else
            {
                slaveAddress = byte.Parse(txt_slave2.Text);
                startAddress = ushort.Parse(txt_startAddr2.Text);
                //判断是否写线圈
                if (comboBox1.SelectedIndex == 4 || comboBox1.SelectedIndex == 6)
                {
                    string[] strarr = txt_data.Text.Split(' ');
                    coilsBuffer = new bool[strarr.Length];
                    //转化为bool数组
                    for (int i = 0; i < strarr.Length; i++)
                    {
                        // strarr[i] == "0" ? coilsBuffer[i] = true : coilsBuffer[i] = false;
                        if (strarr[i] == "0")
                        {
                            coilsBuffer[i] = false;
                        }
                        else
                        {
                            coilsBuffer[i] = true;
                        }
                    }
                }
                else
                {
                    //转化ushort数组
                    string[] strarr = txt_data.Text.Split(' ');
                    registerBuffer = new ushort[strarr.Length];
                    for (int i = 0; i < strarr.Length; i++)
                    {
                        registerBuffer[i] = ushort.Parse(strarr[i]);
                    }
                }
            }
        }
        /// <summary>
        /// 清除文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        /// <summary>
        /// SetMessage
        /// </summary>
        /// <param name="msg"></param>
        public void SetMsg(string msg)
        {
            richTextBox1.Invoke(new Action(() => { richTextBox1.AppendText(msg); }));
        }

    }
}
