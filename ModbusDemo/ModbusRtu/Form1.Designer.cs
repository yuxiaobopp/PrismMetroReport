namespace ModbusRtu
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_length = new System.Windows.Forms.TextBox();
            this.txt_startAddr1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_slave1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.txt_startAddr2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_slave2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_stopBits = new System.Windows.Forms.ComboBox();
            this.cmb_databBits = new System.Windows.Forms.ComboBox();
            this.cmb_parity = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_baud = new System.Windows.Forms.ComboBox();
            this.lable111 = new System.Windows.Forms.Label();
            this.lable223 = new System.Windows.Forms.Label();
            this.cmb_portname = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 279);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(782, 171);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "01 Read Coils",
            "02 Read DisCrete Inputs",
            "03 Read Holding Registers",
            "04 Read Input Registers",
            "05 Write Single Coil",
            "06 Write Single Registers",
            "0F Write Multiple Coils",
            "10 Write Multiple Registers"});
            this.comboBox1.Location = new System.Drawing.Point(65, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "功能码";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Read/Write";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "站号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "起始地址:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_length);
            this.groupBox1.Controls.Add(this.txt_startAddr1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_slave1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 68);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读操作";
            // 
            // txt_length
            // 
            this.txt_length.Location = new System.Drawing.Point(329, 20);
            this.txt_length.Name = "txt_length";
            this.txt_length.Size = new System.Drawing.Size(88, 21);
            this.txt_length.TabIndex = 11;
            // 
            // txt_startAddr1
            // 
            this.txt_startAddr1.Location = new System.Drawing.Point(194, 20);
            this.txt_startAddr1.Name = "txt_startAddr1";
            this.txt_startAddr1.Size = new System.Drawing.Size(88, 21);
            this.txt_startAddr1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "长度:";
            // 
            // txt_slave1
            // 
            this.txt_slave1.Location = new System.Drawing.Point(41, 20);
            this.txt_slave1.Name = "txt_slave1";
            this.txt_slave1.Size = new System.Drawing.Size(88, 21);
            this.txt_slave1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_data);
            this.groupBox2.Controls.Add(this.txt_startAddr2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_slave2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 68);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "写操作";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(351, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(377, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "(数据之间用\'空格\'隔开,线圈数据用0或1表示,寄存器数据ushort类型)";
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(353, 20);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(423, 21);
            this.txt_data.TabIndex = 11;
            // 
            // txt_startAddr2
            // 
            this.txt_startAddr2.Location = new System.Drawing.Point(194, 20);
            this.txt_startAddr2.Name = "txt_startAddr2";
            this.txt_startAddr2.Size = new System.Drawing.Size(88, 21);
            this.txt_startAddr2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "数据数组:";
            // 
            // txt_slave2
            // 
            this.txt_slave2.Location = new System.Drawing.Point(41, 20);
            this.txt_slave2.Name = "txt_slave2";
            this.txt_slave2.Size = new System.Drawing.Size(88, 21);
            this.txt_slave2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "站号:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "起始地址:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmb_stopBits);
            this.groupBox3.Controls.Add(this.cmb_databBits);
            this.groupBox3.Controls.Add(this.cmb_parity);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmb_baud);
            this.groupBox3.Controls.Add(this.lable111);
            this.groupBox3.Controls.Add(this.lable223);
            this.groupBox3.Controls.Add(this.cmb_portname);
            this.groupBox3.Location = new System.Drawing.Point(13, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(768, 65);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "串口参数";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label11.Location = new System.Drawing.Point(429, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 32;
            this.label11.Text = "数据位";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label10.Location = new System.Drawing.Point(558, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "停止位";
            // 
            // cmb_stopBits
            // 
            this.cmb_stopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_stopBits.FormattingEnabled = true;
            this.cmb_stopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmb_stopBits.Location = new System.Drawing.Point(605, 22);
            this.cmb_stopBits.Name = "cmb_stopBits";
            this.cmb_stopBits.Size = new System.Drawing.Size(76, 20);
            this.cmb_stopBits.TabIndex = 30;
            // 
            // cmb_databBits
            // 
            this.cmb_databBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_databBits.FormattingEnabled = true;
            this.cmb_databBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cmb_databBits.Location = new System.Drawing.Point(476, 22);
            this.cmb_databBits.Name = "cmb_databBits";
            this.cmb_databBits.Size = new System.Drawing.Size(76, 20);
            this.cmb_databBits.TabIndex = 29;
            // 
            // cmb_parity
            // 
            this.cmb_parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_parity.FormattingEnabled = true;
            this.cmb_parity.Items.AddRange(new object[] {
            "奇",
            "偶",
            "无"});
            this.cmb_parity.Location = new System.Drawing.Point(347, 22);
            this.cmb_parity.Name = "cmb_parity";
            this.cmb_parity.Size = new System.Drawing.Size(76, 20);
            this.cmb_parity.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.Location = new System.Drawing.Point(312, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "校验";
            // 
            // cmb_baud
            // 
            this.cmb_baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_baud.FormattingEnabled = true;
            this.cmb_baud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000"});
            this.cmb_baud.Location = new System.Drawing.Point(229, 22);
            this.cmb_baud.Name = "cmb_baud";
            this.cmb_baud.Size = new System.Drawing.Size(77, 20);
            this.cmb_baud.TabIndex = 26;
            // 
            // lable111
            // 
            this.lable111.AutoSize = true;
            this.lable111.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lable111.Location = new System.Drawing.Point(182, 25);
            this.lable111.Name = "lable111";
            this.lable111.Size = new System.Drawing.Size(41, 12);
            this.lable111.TabIndex = 25;
            this.lable111.Text = "波特率";
            // 
            // lable223
            // 
            this.lable223.AutoSize = true;
            this.lable223.Location = new System.Drawing.Point(17, 25);
            this.lable223.Name = "lable223";
            this.lable223.Size = new System.Drawing.Size(29, 12);
            this.lable223.TabIndex = 24;
            this.lable223.Text = "串口";
            // 
            // cmb_portname
            // 
            this.cmb_portname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_portname.FormattingEnabled = true;
            this.cmb_portname.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.cmb_portname.Location = new System.Drawing.Point(63, 22);
            this.cmb_portname.Name = "cmb_portname";
            this.cmb_portname.Size = new System.Drawing.Size(109, 20);
            this.cmb_portname.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 463);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Modbus Rtu Master";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_slave1;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.TextBox txt_startAddr1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.TextBox txt_startAddr2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_slave2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_stopBits;
        private System.Windows.Forms.ComboBox cmb_databBits;
        private System.Windows.Forms.ComboBox cmb_parity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_baud;
        private System.Windows.Forms.Label lable111;
        private System.Windows.Forms.Label lable223;
        private System.Windows.Forms.ComboBox cmb_portname;
    }
}

