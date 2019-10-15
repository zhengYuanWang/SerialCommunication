namespace SerialCommunication
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelSerialPortSet = new System.Windows.Forms.Panel();
            this.labelSerialSet = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.comboBoxPortName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDatabits = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenSerialPost = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonResetCount = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelReceiveCount = new System.Windows.Forms.Label();
            this.labelTransmitCount = new System.Windows.Forms.Label();
            this.labelSerialPortStatus = new System.Windows.Forms.Label();
            this.panelReceiveSet = new System.Windows.Forms.Panel();
            this.labelReceiveSet = new System.Windows.Forms.Label();
            this.checkBoxNewLine = new System.Windows.Forms.CheckBox();
            this.buttonClearReceive = new System.Windows.Forms.Button();
            this.checkBoxShowTime = new System.Windows.Forms.CheckBox();
            this.radioButtonReceiveHEX = new System.Windows.Forms.RadioButton();
            this.radioButtonReceiveASCII = new System.Windows.Forms.RadioButton();
            this.panelTransmitSet = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownTransmitTimer = new System.Windows.Forms.NumericUpDown();
            this.labelTransmitSet = new System.Windows.Forms.Label();
            this.buttonClearTransmit = new System.Windows.Forms.Button();
            this.checkBoxAutoTransmit = new System.Windows.Forms.CheckBox();
            this.radioButtonTransmitHEX = new System.Windows.Forms.RadioButton();
            this.radioButtonTransmitASCII = new System.Windows.Forms.RadioButton();
            this.panelTransmitArea = new System.Windows.Forms.Panel();
            this.textBoxTransmitText = new System.Windows.Forms.TextBox();
            this.buttonTransmit = new System.Windows.Forms.Button();
            this.panelReceiveArea = new System.Windows.Forms.Panel();
            this.textBoxReceiveText = new System.Windows.Forms.TextBox();
            this.serialPortCurrent = new System.IO.Ports.SerialPort(this.components);
            this.timerAutoTransmit = new System.Windows.Forms.Timer(this.components);
            this.textBoxSavePath = new System.Windows.Forms.TextBox();
            this.buttonSelectSaveFolder = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.panelSaveData = new System.Windows.Forms.Panel();
            this.buttonSelectSaveFile = new System.Windows.Forms.Button();
            this.textBoxTransmitPath = new System.Windows.Forms.TextBox();
            this.buttonSelectTransmitFile = new System.Windows.Forms.Button();
            this.buttonTransmitFile = new System.Windows.Forms.Button();
            this.panelTransmitData = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panelSerialPortSet.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelReceiveSet.SuspendLayout();
            this.panelTransmitSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransmitTimer)).BeginInit();
            this.panelTransmitArea.SuspendLayout();
            this.panelReceiveArea.SuspendLayout();
            this.panelSaveData.SuspendLayout();
            this.panelTransmitData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSerialPortSet
            // 
            this.panelSerialPortSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSerialPortSet.Controls.Add(this.labelSerialSet);
            this.panelSerialPortSet.Controls.Add(this.comboBoxStopBits);
            this.panelSerialPortSet.Controls.Add(this.comboBoxPortName);
            this.panelSerialPortSet.Controls.Add(this.label5);
            this.panelSerialPortSet.Controls.Add(this.label4);
            this.panelSerialPortSet.Controls.Add(this.comboBoxParity);
            this.panelSerialPortSet.Controls.Add(this.label3);
            this.panelSerialPortSet.Controls.Add(this.label2);
            this.panelSerialPortSet.Controls.Add(this.comboBoxDatabits);
            this.panelSerialPortSet.Controls.Add(this.comboBoxBaudRate);
            this.panelSerialPortSet.Controls.Add(this.label1);
            this.panelSerialPortSet.Location = new System.Drawing.Point(12, 12);
            this.panelSerialPortSet.Name = "panelSerialPortSet";
            this.panelSerialPortSet.Size = new System.Drawing.Size(209, 251);
            this.panelSerialPortSet.TabIndex = 0;
            // 
            // labelSerialSet
            // 
            this.labelSerialSet.AutoSize = true;
            this.labelSerialSet.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSerialSet.ForeColor = System.Drawing.Color.Blue;
            this.labelSerialSet.Location = new System.Drawing.Point(122, 228);
            this.labelSerialSet.Name = "labelSerialSet";
            this.labelSerialSet.Size = new System.Drawing.Size(90, 21);
            this.labelSerialSet.TabIndex = 12;
            this.labelSerialSet.Text = "串口设置区";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "None",
            "1",
            "1.5",
            "2"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(87, 167);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(117, 29);
            this.comboBoxStopBits.TabIndex = 9;
            // 
            // comboBoxPortName
            // 
            this.comboBoxPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPortName.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxPortName.FormattingEnabled = true;
            this.comboBoxPortName.Location = new System.Drawing.Point(87, 3);
            this.comboBoxPortName.Name = "comboBoxPortName";
            this.comboBoxPortName.Size = new System.Drawing.Size(117, 29);
            this.comboBoxPortName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "校验位";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBoxParity.Location = new System.Drawing.Point(87, 126);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(117, 29);
            this.comboBoxParity.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // comboBoxDatabits
            // 
            this.comboBoxDatabits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDatabits.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxDatabits.FormattingEnabled = true;
            this.comboBoxDatabits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.comboBoxDatabits.Location = new System.Drawing.Point(87, 85);
            this.comboBoxDatabits.Name = "comboBoxDatabits";
            this.comboBoxDatabits.Size = new System.Drawing.Size(117, 29);
            this.comboBoxDatabits.TabIndex = 7;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(87, 44);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(117, 29);
            this.comboBoxBaudRate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "串口\r\n";
            // 
            // buttonOpenSerialPost
            // 
            this.buttonOpenSerialPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonOpenSerialPost.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOpenSerialPost.Location = new System.Drawing.Point(12, 269);
            this.buttonOpenSerialPost.Name = "buttonOpenSerialPost";
            this.buttonOpenSerialPost.Size = new System.Drawing.Size(209, 40);
            this.buttonOpenSerialPost.TabIndex = 0;
            this.buttonOpenSerialPost.Text = "打开选定串口";
            this.buttonOpenSerialPost.UseVisualStyleBackColor = false;
            this.buttonOpenSerialPost.Click += new System.EventHandler(this.buttonOpenSerialPost_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonResetCount);
            this.panel2.Controls.Add(this.labelVersion);
            this.panel2.Controls.Add(this.labelReceiveCount);
            this.panel2.Controls.Add(this.labelTransmitCount);
            this.panel2.Controls.Add(this.labelSerialPortStatus);
            this.panel2.Location = new System.Drawing.Point(12, 628);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 37);
            this.panel2.TabIndex = 0;
            // 
            // buttonResetCount
            // 
            this.buttonResetCount.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonResetCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonResetCount.Location = new System.Drawing.Point(695, -1);
            this.buttonResetCount.Name = "buttonResetCount";
            this.buttonResetCount.Size = new System.Drawing.Size(109, 37);
            this.buttonResetCount.TabIndex = 1;
            this.buttonResetCount.Text = "重置计数";
            this.buttonResetCount.UseVisualStyleBackColor = true;
            this.buttonResetCount.Click += new System.EventHandler(this.buttonResetCount_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelVersion.Location = new System.Drawing.Point(1008, 8);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(144, 21);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "1.2.3.191015_beta";
            // 
            // labelReceiveCount
            // 
            this.labelReceiveCount.AutoSize = true;
            this.labelReceiveCount.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelReceiveCount.Location = new System.Drawing.Point(568, 8);
            this.labelReceiveCount.Name = "labelReceiveCount";
            this.labelReceiveCount.Size = new System.Drawing.Size(95, 21);
            this.labelReceiveCount.TabIndex = 2;
            this.labelReceiveCount.Text = "接收:0Bytes";
            // 
            // labelTransmitCount
            // 
            this.labelTransmitCount.AutoSize = true;
            this.labelTransmitCount.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTransmitCount.Location = new System.Drawing.Point(442, 7);
            this.labelTransmitCount.Name = "labelTransmitCount";
            this.labelTransmitCount.Size = new System.Drawing.Size(95, 21);
            this.labelTransmitCount.TabIndex = 3;
            this.labelTransmitCount.Text = "传送:0Bytes";
            // 
            // labelSerialPortStatus
            // 
            this.labelSerialPortStatus.AutoSize = true;
            this.labelSerialPortStatus.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSerialPortStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSerialPortStatus.Location = new System.Drawing.Point(3, 8);
            this.labelSerialPortStatus.Name = "labelSerialPortStatus";
            this.labelSerialPortStatus.Size = new System.Drawing.Size(90, 21);
            this.labelSerialPortStatus.TabIndex = 1;
            this.labelSerialPortStatus.Text = "串口已关闭";
            // 
            // panelReceiveSet
            // 
            this.panelReceiveSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReceiveSet.Controls.Add(this.labelReceiveSet);
            this.panelReceiveSet.Controls.Add(this.checkBoxNewLine);
            this.panelReceiveSet.Controls.Add(this.buttonClearReceive);
            this.panelReceiveSet.Controls.Add(this.checkBoxShowTime);
            this.panelReceiveSet.Controls.Add(this.radioButtonReceiveHEX);
            this.panelReceiveSet.Controls.Add(this.radioButtonReceiveASCII);
            this.panelReceiveSet.Location = new System.Drawing.Point(12, 315);
            this.panelReceiveSet.Name = "panelReceiveSet";
            this.panelReceiveSet.Size = new System.Drawing.Size(209, 167);
            this.panelReceiveSet.TabIndex = 0;
            // 
            // labelReceiveSet
            // 
            this.labelReceiveSet.AutoSize = true;
            this.labelReceiveSet.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelReceiveSet.ForeColor = System.Drawing.Color.Blue;
            this.labelReceiveSet.Location = new System.Drawing.Point(122, 145);
            this.labelReceiveSet.Name = "labelReceiveSet";
            this.labelReceiveSet.Size = new System.Drawing.Size(90, 21);
            this.labelReceiveSet.TabIndex = 11;
            this.labelReceiveSet.Text = "接收设置区";
            // 
            // checkBoxNewLine
            // 
            this.checkBoxNewLine.AutoSize = true;
            this.checkBoxNewLine.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxNewLine.Location = new System.Drawing.Point(4, 64);
            this.checkBoxNewLine.Name = "checkBoxNewLine";
            this.checkBoxNewLine.Size = new System.Drawing.Size(164, 25);
            this.checkBoxNewLine.TabIndex = 4;
            this.checkBoxNewLine.Text = "接收数据自动换行";
            this.checkBoxNewLine.UseVisualStyleBackColor = true;
            // 
            // buttonClearReceive
            // 
            this.buttonClearReceive.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClearReceive.Location = new System.Drawing.Point(3, 95);
            this.buttonClearReceive.Name = "buttonClearReceive";
            this.buttonClearReceive.Size = new System.Drawing.Size(201, 38);
            this.buttonClearReceive.TabIndex = 3;
            this.buttonClearReceive.Text = "清除接收";
            this.buttonClearReceive.UseVisualStyleBackColor = true;
            this.buttonClearReceive.Click += new System.EventHandler(this.buttonClearReceive_Click);
            // 
            // checkBoxShowTime
            // 
            this.checkBoxShowTime.AutoSize = true;
            this.checkBoxShowTime.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxShowTime.Location = new System.Drawing.Point(3, 33);
            this.checkBoxShowTime.Name = "checkBoxShowTime";
            this.checkBoxShowTime.Size = new System.Drawing.Size(164, 25);
            this.checkBoxShowTime.TabIndex = 2;
            this.checkBoxShowTime.Text = "接收数据显示时间";
            this.checkBoxShowTime.UseVisualStyleBackColor = true;
            // 
            // radioButtonReceiveHEX
            // 
            this.radioButtonReceiveHEX.AutoSize = true;
            this.radioButtonReceiveHEX.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonReceiveHEX.Location = new System.Drawing.Point(85, 2);
            this.radioButtonReceiveHEX.Name = "radioButtonReceiveHEX";
            this.radioButtonReceiveHEX.Size = new System.Drawing.Size(66, 25);
            this.radioButtonReceiveHEX.TabIndex = 1;
            this.radioButtonReceiveHEX.Text = "HEX";
            this.radioButtonReceiveHEX.UseVisualStyleBackColor = true;
            // 
            // radioButtonReceiveASCII
            // 
            this.radioButtonReceiveASCII.AutoSize = true;
            this.radioButtonReceiveASCII.Checked = true;
            this.radioButtonReceiveASCII.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonReceiveASCII.Location = new System.Drawing.Point(3, 3);
            this.radioButtonReceiveASCII.Name = "radioButtonReceiveASCII";
            this.radioButtonReceiveASCII.Size = new System.Drawing.Size(76, 25);
            this.radioButtonReceiveASCII.TabIndex = 0;
            this.radioButtonReceiveASCII.TabStop = true;
            this.radioButtonReceiveASCII.Text = "ASCII";
            this.radioButtonReceiveASCII.UseVisualStyleBackColor = true;
            // 
            // panelTransmitSet
            // 
            this.panelTransmitSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTransmitSet.Controls.Add(this.label9);
            this.panelTransmitSet.Controls.Add(this.numericUpDownTransmitTimer);
            this.panelTransmitSet.Controls.Add(this.labelTransmitSet);
            this.panelTransmitSet.Controls.Add(this.buttonClearTransmit);
            this.panelTransmitSet.Controls.Add(this.checkBoxAutoTransmit);
            this.panelTransmitSet.Controls.Add(this.radioButtonTransmitHEX);
            this.panelTransmitSet.Controls.Add(this.radioButtonTransmitASCII);
            this.panelTransmitSet.Location = new System.Drawing.Point(12, 488);
            this.panelTransmitSet.Name = "panelTransmitSet";
            this.panelTransmitSet.Size = new System.Drawing.Size(209, 134);
            this.panelTransmitSet.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(176, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "ms";
            // 
            // numericUpDownTransmitTimer
            // 
            this.numericUpDownTransmitTimer.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDownTransmitTimer.Location = new System.Drawing.Point(102, 30);
            this.numericUpDownTransmitTimer.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTransmitTimer.Name = "numericUpDownTransmitTimer";
            this.numericUpDownTransmitTimer.Size = new System.Drawing.Size(75, 29);
            this.numericUpDownTransmitTimer.TabIndex = 11;
            this.numericUpDownTransmitTimer.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelTransmitSet
            // 
            this.labelTransmitSet.AutoSize = true;
            this.labelTransmitSet.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTransmitSet.ForeColor = System.Drawing.Color.Blue;
            this.labelTransmitSet.Location = new System.Drawing.Point(122, 111);
            this.labelTransmitSet.Name = "labelTransmitSet";
            this.labelTransmitSet.Size = new System.Drawing.Size(90, 21);
            this.labelTransmitSet.TabIndex = 10;
            this.labelTransmitSet.Text = "传送设置区";
            // 
            // buttonClearTransmit
            // 
            this.buttonClearTransmit.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClearTransmit.Location = new System.Drawing.Point(3, 65);
            this.buttonClearTransmit.Name = "buttonClearTransmit";
            this.buttonClearTransmit.Size = new System.Drawing.Size(201, 38);
            this.buttonClearTransmit.TabIndex = 6;
            this.buttonClearTransmit.Text = "清除传送";
            this.buttonClearTransmit.UseVisualStyleBackColor = true;
            this.buttonClearTransmit.Click += new System.EventHandler(this.buttonClearTransmit_Click);
            // 
            // checkBoxAutoTransmit
            // 
            this.checkBoxAutoTransmit.AutoSize = true;
            this.checkBoxAutoTransmit.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxAutoTransmit.Location = new System.Drawing.Point(4, 34);
            this.checkBoxAutoTransmit.Name = "checkBoxAutoTransmit";
            this.checkBoxAutoTransmit.Size = new System.Drawing.Size(100, 25);
            this.checkBoxAutoTransmit.TabIndex = 5;
            this.checkBoxAutoTransmit.Text = "自动传送";
            this.checkBoxAutoTransmit.UseVisualStyleBackColor = true;
            this.checkBoxAutoTransmit.CheckedChanged += new System.EventHandler(this.checkBoxAutoTransmit_CheckedChanged);
            // 
            // radioButtonTransmitHEX
            // 
            this.radioButtonTransmitHEX.AutoSize = true;
            this.radioButtonTransmitHEX.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonTransmitHEX.Location = new System.Drawing.Point(85, 3);
            this.radioButtonTransmitHEX.Name = "radioButtonTransmitHEX";
            this.radioButtonTransmitHEX.Size = new System.Drawing.Size(66, 25);
            this.radioButtonTransmitHEX.TabIndex = 2;
            this.radioButtonTransmitHEX.Text = "HEX";
            this.radioButtonTransmitHEX.UseVisualStyleBackColor = true;
            // 
            // radioButtonTransmitASCII
            // 
            this.radioButtonTransmitASCII.AutoSize = true;
            this.radioButtonTransmitASCII.Checked = true;
            this.radioButtonTransmitASCII.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonTransmitASCII.Location = new System.Drawing.Point(3, 3);
            this.radioButtonTransmitASCII.Name = "radioButtonTransmitASCII";
            this.radioButtonTransmitASCII.Size = new System.Drawing.Size(76, 25);
            this.radioButtonTransmitASCII.TabIndex = 1;
            this.radioButtonTransmitASCII.TabStop = true;
            this.radioButtonTransmitASCII.Text = "ASCII";
            this.radioButtonTransmitASCII.UseVisualStyleBackColor = true;
            // 
            // panelTransmitArea
            // 
            this.panelTransmitArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTransmitArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTransmitArea.Controls.Add(this.textBoxTransmitText);
            this.panelTransmitArea.Controls.Add(this.buttonTransmit);
            this.panelTransmitArea.Location = new System.Drawing.Point(227, 414);
            this.panelTransmitArea.Name = "panelTransmitArea";
            this.panelTransmitArea.Size = new System.Drawing.Size(942, 163);
            this.panelTransmitArea.TabIndex = 0;
            // 
            // textBoxTransmitText
            // 
            this.textBoxTransmitText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTransmitText.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTransmitText.Location = new System.Drawing.Point(-1, -1);
            this.textBoxTransmitText.Multiline = true;
            this.textBoxTransmitText.Name = "textBoxTransmitText";
            this.textBoxTransmitText.Size = new System.Drawing.Size(841, 163);
            this.textBoxTransmitText.TabIndex = 0;
            // 
            // buttonTransmit
            // 
            this.buttonTransmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTransmit.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTransmit.Location = new System.Drawing.Point(846, -1);
            this.buttonTransmit.Name = "buttonTransmit";
            this.buttonTransmit.Size = new System.Drawing.Size(95, 163);
            this.buttonTransmit.TabIndex = 1;
            this.buttonTransmit.Text = "传送";
            this.buttonTransmit.UseVisualStyleBackColor = true;
            this.buttonTransmit.Click += new System.EventHandler(this.buttonTransmit_Click);
            // 
            // panelReceiveArea
            // 
            this.panelReceiveArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReceiveArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReceiveArea.Controls.Add(this.textBoxReceiveText);
            this.panelReceiveArea.Location = new System.Drawing.Point(227, 12);
            this.panelReceiveArea.Name = "panelReceiveArea";
            this.panelReceiveArea.Size = new System.Drawing.Size(942, 350);
            this.panelReceiveArea.TabIndex = 0;
            // 
            // textBoxReceiveText
            // 
            this.textBoxReceiveText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReceiveText.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxReceiveText.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxReceiveText.Location = new System.Drawing.Point(-1, 0);
            this.textBoxReceiveText.Multiline = true;
            this.textBoxReceiveText.Name = "textBoxReceiveText";
            this.textBoxReceiveText.ReadOnly = true;
            this.textBoxReceiveText.Size = new System.Drawing.Size(942, 349);
            this.textBoxReceiveText.TabIndex = 0;
            // 
            // serialPortCurrent
            // 
            this.serialPortCurrent.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPortCurrent_DataReceived);
            // 
            // timerAutoTransmit
            // 
            this.timerAutoTransmit.Tick += new System.EventHandler(this.timerAutoTransmit_Tick);
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSavePath.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSavePath.Location = new System.Drawing.Point(3, 3);
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.Size = new System.Drawing.Size(593, 29);
            this.textBoxSavePath.TabIndex = 0;
            // 
            // buttonSelectSaveFolder
            // 
            this.buttonSelectSaveFolder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSelectSaveFolder.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSelectSaveFolder.Location = new System.Drawing.Point(717, -2);
            this.buttonSelectSaveFolder.Name = "buttonSelectSaveFolder";
            this.buttonSelectSaveFolder.Size = new System.Drawing.Size(109, 41);
            this.buttonSelectSaveFolder.TabIndex = 1;
            this.buttonSelectSaveFolder.Text = "选择目录";
            this.buttonSelectSaveFolder.UseVisualStyleBackColor = true;
            this.buttonSelectSaveFolder.Click += new System.EventHandler(this.buttonSelectSaveFolder_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSaveFile.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSaveFile.Location = new System.Drawing.Point(832, -2);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(109, 41);
            this.buttonSaveFile.TabIndex = 2;
            this.buttonSaveFile.Text = "保存数据";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // panelSaveData
            // 
            this.panelSaveData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSaveData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSaveData.Controls.Add(this.buttonSelectSaveFile);
            this.panelSaveData.Controls.Add(this.buttonSaveFile);
            this.panelSaveData.Controls.Add(this.buttonSelectSaveFolder);
            this.panelSaveData.Controls.Add(this.textBoxSavePath);
            this.panelSaveData.Location = new System.Drawing.Point(227, 368);
            this.panelSaveData.Name = "panelSaveData";
            this.panelSaveData.Size = new System.Drawing.Size(942, 39);
            this.panelSaveData.TabIndex = 1;
            // 
            // buttonSelectSaveFile
            // 
            this.buttonSelectSaveFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSelectSaveFile.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSelectSaveFile.Location = new System.Drawing.Point(602, -2);
            this.buttonSelectSaveFile.Name = "buttonSelectSaveFile";
            this.buttonSelectSaveFile.Size = new System.Drawing.Size(109, 41);
            this.buttonSelectSaveFile.TabIndex = 3;
            this.buttonSelectSaveFile.Text = "选择文件";
            this.buttonSelectSaveFile.UseVisualStyleBackColor = true;
            this.buttonSelectSaveFile.Click += new System.EventHandler(this.buttonSelectSaveFile_Click);
            // 
            // textBoxTransmitPath
            // 
            this.textBoxTransmitPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTransmitPath.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTransmitPath.Location = new System.Drawing.Point(3, 3);
            this.textBoxTransmitPath.Name = "textBoxTransmitPath";
            this.textBoxTransmitPath.Size = new System.Drawing.Size(708, 29);
            this.textBoxTransmitPath.TabIndex = 0;
            // 
            // buttonSelectTransmitFile
            // 
            this.buttonSelectTransmitFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSelectTransmitFile.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSelectTransmitFile.Location = new System.Drawing.Point(717, -1);
            this.buttonSelectTransmitFile.Name = "buttonSelectTransmitFile";
            this.buttonSelectTransmitFile.Size = new System.Drawing.Size(109, 44);
            this.buttonSelectTransmitFile.TabIndex = 1;
            this.buttonSelectTransmitFile.Text = "选择文件";
            this.buttonSelectTransmitFile.UseVisualStyleBackColor = true;
            this.buttonSelectTransmitFile.Click += new System.EventHandler(this.buttonSelectTransmitFile_Click);
            // 
            // buttonTransmitFile
            // 
            this.buttonTransmitFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonTransmitFile.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTransmitFile.Location = new System.Drawing.Point(832, -1);
            this.buttonTransmitFile.Name = "buttonTransmitFile";
            this.buttonTransmitFile.Size = new System.Drawing.Size(109, 44);
            this.buttonTransmitFile.TabIndex = 2;
            this.buttonTransmitFile.Text = "传送文件";
            this.buttonTransmitFile.UseVisualStyleBackColor = true;
            this.buttonTransmitFile.Click += new System.EventHandler(this.buttonTransmitFile_Click);
            // 
            // panelTransmitData
            // 
            this.panelTransmitData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTransmitData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTransmitData.Controls.Add(this.buttonTransmitFile);
            this.panelTransmitData.Controls.Add(this.buttonSelectTransmitFile);
            this.panelTransmitData.Controls.Add(this.textBoxTransmitPath);
            this.panelTransmitData.Location = new System.Drawing.Point(227, 582);
            this.panelTransmitData.Name = "panelTransmitData";
            this.panelTransmitData.Size = new System.Drawing.Size(942, 40);
            this.panelTransmitData.TabIndex = 5;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "(*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 677);
            this.Controls.Add(this.buttonOpenSerialPost);
            this.Controls.Add(this.panelTransmitData);
            this.Controls.Add(this.panelSaveData);
            this.Controls.Add(this.panelTransmitSet);
            this.Controls.Add(this.panelReceiveSet);
            this.Controls.Add(this.panelReceiveArea);
            this.Controls.Add(this.panelTransmitArea);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSerialPortSet);
            this.Name = "Form1";
            this.Text = "串口通信软件测试版";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSerialPortSet.ResumeLayout(false);
            this.panelSerialPortSet.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelReceiveSet.ResumeLayout(false);
            this.panelReceiveSet.PerformLayout();
            this.panelTransmitSet.ResumeLayout(false);
            this.panelTransmitSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransmitTimer)).EndInit();
            this.panelTransmitArea.ResumeLayout(false);
            this.panelTransmitArea.PerformLayout();
            this.panelReceiveArea.ResumeLayout(false);
            this.panelReceiveArea.PerformLayout();
            this.panelSaveData.ResumeLayout(false);
            this.panelSaveData.PerformLayout();
            this.panelTransmitData.ResumeLayout(false);
            this.panelTransmitData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSerialPortSet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelReceiveSet;
        private System.Windows.Forms.Panel panelTransmitSet;
        private System.Windows.Forms.Panel panelTransmitArea;
        private System.Windows.Forms.Panel panelReceiveArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOpenSerialPost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPortName;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxDatabits;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Button buttonTransmit;
        private System.Windows.Forms.TextBox textBoxTransmitText;
        private System.Windows.Forms.TextBox textBoxReceiveText;
        private System.IO.Ports.SerialPort serialPortCurrent;
        private System.Windows.Forms.RadioButton radioButtonReceiveASCII;
        private System.Windows.Forms.RadioButton radioButtonReceiveHEX;
        private System.Windows.Forms.CheckBox checkBoxShowTime;
        private System.Windows.Forms.Button buttonClearReceive;
        private System.Windows.Forms.RadioButton radioButtonTransmitHEX;
        private System.Windows.Forms.RadioButton radioButtonTransmitASCII;
        private System.Windows.Forms.CheckBox checkBoxAutoTransmit;
        private System.Windows.Forms.Label labelSerialPortStatus;
        private System.Windows.Forms.Label labelReceiveCount;
        private System.Windows.Forms.Label labelTransmitCount;
        private System.Windows.Forms.Button buttonResetCount;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Timer timerAutoTransmit;
        private System.Windows.Forms.CheckBox checkBoxNewLine;
        private System.Windows.Forms.Button buttonClearTransmit;
        private System.Windows.Forms.Label labelTransmitSet;
        private System.Windows.Forms.Label labelReceiveSet;
        private System.Windows.Forms.Label labelSerialSet;
        private System.Windows.Forms.NumericUpDown numericUpDownTransmitTimer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSavePath;
        private System.Windows.Forms.Button buttonSelectSaveFolder;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Panel panelSaveData;
        private System.Windows.Forms.TextBox textBoxTransmitPath;
        private System.Windows.Forms.Button buttonSelectTransmitFile;
        private System.Windows.Forms.Button buttonTransmitFile;
        private System.Windows.Forms.Panel panelTransmitData;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonSelectSaveFile;
    }
}

