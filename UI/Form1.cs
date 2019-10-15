using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using SerialCommunication.BLL;

namespace SerialCommunication
{
    public partial class Form1 : Form
    {
        private SerialCommunicationService service = new SerialCommunicationService();

        //用于记录传送和接收的字节数
        private long receiveCount = 0;
        private long transmitCount = 0;

        //用于接收的可变字符串对象
        private StringBuilder receiveStringBuilder = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        //主窗体加载函数
        private void Form1_Load(object sender, EventArgs e)
        {
            //查询当前计算机端口
            String[] port = System.IO.Ports.SerialPort.GetPortNames();
            comboBoxPortName.Items.AddRange(port);

            //添加至波特率列表
            for (int i = 300; i <= 38400; i = i * 2)
            {
                comboBoxBaudRate.Items.Add(i.ToString());
            }
            String[] baud = { "43000", "56000", "57600", "115200" };
            comboBoxBaudRate.Items.AddRange(baud);

            //默认值
            if (port == null || port.Length <= 0)
            {
                comboBoxPortName.Items.Add("NULL");
                comboBoxPortName.Text = "NULL";
            }
            else
            {
                comboBoxPortName.Text = port.First();
            }
            comboBoxBaudRate.Text = "115200";
            comboBoxDatabits.Text = "8";
            comboBoxParity.Text = "None";
            comboBoxStopBits.Text = "1";
        }

        //单击"打开/关闭选定串口"按钮事件函数
        private void buttonOpenSerialPost_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPortCurrent.IsOpen)
                {
                    panelSerialPortSet.Enabled = true;
                    serialPortCurrent.Close();
                    buttonOpenSerialPost.Text = "打开选定串口";
                    buttonOpenSerialPost.BackColor = Color.FromArgb(0, 192, 0);
                    labelSerialPortStatus.Text = "串口已关闭";
                    labelSerialPortStatus.ForeColor = Color.FromArgb(192, 0, 0);

                    //清空接收发送区
                    textBoxReceiveText.Text = "";
                    textBoxTransmitText.Text = "";
                }
                else
                {
                    panelSerialPortSet.Enabled = false;

                    //设置串口对象属性
                    serialPortCurrent.PortName = comboBoxPortName.Text;
                    serialPortCurrent.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                    serialPortCurrent.DataBits = Convert.ToInt16(comboBoxDatabits.Text);
                    //None Odd Even Mark Space
                    String parity = comboBoxParity.Text;
                    if (parity.Equals("None"))
                    {
                        serialPortCurrent.Parity = System.IO.Ports.Parity.None;
                    }
                    else if (parity.Equals("Odd"))
                    {
                        serialPortCurrent.Parity = System.IO.Ports.Parity.Odd;
                    }
                    else if (parity.Equals("Even"))
                    {
                        serialPortCurrent.Parity = System.IO.Ports.Parity.Even;
                    }
                    else if (parity.Equals("Mark"))
                    {
                        serialPortCurrent.Parity = System.IO.Ports.Parity.Mark;
                    }
                    else if (parity.Equals("Space"))
                    {
                        serialPortCurrent.Parity = System.IO.Ports.Parity.Space;
                    }
                    //1 1.5 2
                    String stopBits = comboBoxStopBits.Text;
                    if (stopBits.Equals("None"))
                    {
                        serialPortCurrent.StopBits = System.IO.Ports.StopBits.None;
                    }
                    else if (stopBits.Equals("1"))
                    {
                        serialPortCurrent.StopBits = System.IO.Ports.StopBits.One;
                    }
                    else if (stopBits.Equals("1.5"))
                    {
                        serialPortCurrent.StopBits = System.IO.Ports.StopBits.OnePointFive;
                    }
                    else if (stopBits.Equals("2"))
                    {
                        serialPortCurrent.StopBits = System.IO.Ports.StopBits.Two;
                    }

                    serialPortCurrent.Open();
                    buttonOpenSerialPost.Text = "关闭选定串口";
                    buttonOpenSerialPost.BackColor = Color.FromArgb(192, 0, 0);
                    labelSerialPortStatus.Text = "串口已开启";
                    labelSerialPortStatus.ForeColor = Color.FromArgb(0, 192, 0);
                }
            }
            catch (Exception exception)
            {
                //重新创建对象
                comboBoxPortName.Items.Clear();
                String[] port = System.IO.Ports.SerialPort.GetPortNames();
                comboBoxPortName.Items.AddRange(port);
                if (port == null || port.Length <= 0)
                {
                    comboBoxPortName.Items.Add("NULL");
                    comboBoxPortName.Text = "NULL";
                }
                else
                {
                    comboBoxPortName.Text = port.First();
                }

                //警告提示
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show(exception.Message);

                buttonOpenSerialPost.Text = "打开选定串口";
                buttonOpenSerialPost.BackColor = Color.FromArgb(0, 192, 0);
                labelSerialPortStatus.Text = "串口已关闭";
                labelSerialPortStatus.ForeColor = Color.FromArgb(192, 0, 0);

                panelSerialPortSet.Enabled = true;
            }
        }

        //单击"传送"按钮事件函数
        private void buttonTransmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPortCurrent.IsOpen)
                {
                    //判断发送选项是ASCII或HEX
                    if (radioButtonTransmitASCII.Checked)
                    {
                        //ASCII发送模式
                        serialPortCurrent.Write(textBoxTransmitText.Text);
                        transmitCount += textBoxTransmitText.Text.Length;
                    }
                    else
                    {
                        //HEX发送模式
                        string transmitText = textBoxTransmitText.Text;
                        byte[] dataBytes = service.DataToHEX(transmitText);
                        serialPortCurrent.Write(dataBytes, 0, service.handleBytesCount);
                        transmitCount += service.handleBytesCount;
                    }

                    //回显数据量
                    labelTransmitCount.Text = "传送:" + transmitCount.ToString() + "Bytes";
                }
            }
            catch (Exception exception)
            {
                //重新创建对象
                serialPortCurrent = new SerialPort();
                comboBoxPortName.Items.Clear();
                comboBoxPortName.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());

                //警告提示
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show(exception.Message);

                buttonOpenSerialPost.Text = "打开选定串口";
                buttonOpenSerialPost.BackColor = Color.FromArgb(0, 192, 0);

                panelSerialPortSet.Enabled = true;
            }
        }

        //串口接收事件处理函数
        private void SerialPortCurrent_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int readDataCount = serialPortCurrent.BytesToRead;
            byte[] receiveBytes = new byte[readDataCount];
            receiveCount += readDataCount;
            serialPortCurrent.Read(receiveBytes, 0, readDataCount);
            receiveStringBuilder.Clear();

            //判断接收选项是ASCII或HEX
            if (radioButtonReceiveASCII.Checked)
            {
                //ASCII方式
                receiveStringBuilder.Append(Encoding.ASCII.GetString(receiveBytes));
            }
            else
            {
                //HEX方式
                foreach (byte b in receiveBytes)
                {
                    receiveStringBuilder.Append(b.ToString("X2") + " ");
                }
            }

            /*
             * 向串口数据接收区显示接收的数据
             * Invoke解决从不是创建控件的线程访问它
             */
            Invoke((EventHandler)(delegate
            {
                //检查"显示数据接收时间"是否选择
                if (!checkBoxShowTime.Checked)
                {
                    textBoxReceiveText.AppendText(receiveStringBuilder.ToString());
                }
                else
                {
                    textBoxReceiveText.AppendText(System.DateTime.Now.ToString("HH:mm:ss") + "    " + receiveStringBuilder.ToString());
                }

                //判断"接收数据自动换行"选项是否选中
                if (checkBoxNewLine.Checked)
                {
                    textBoxReceiveText.AppendText(System.Environment.NewLine);
                }

                labelReceiveCount.Text = "接收:" + receiveCount.ToString() + "Bytes";
            }));
        }

        //定时器计时结束事件函数
        private void timerAutoTransmit_Tick(object sender, EventArgs e)
        {
            buttonTransmit_Click(buttonTransmit, new EventArgs());
        }

        //选择"自动传送"选项改变事件函数
        private void checkBoxAutoTransmit_CheckedChanged(object sender, EventArgs e)
        {
            //判断"自动传送是否选中"
            if (checkBoxAutoTransmit.Checked)
            {
                //自动传送功能开启
                numericUpDownTransmitTimer.Enabled = false;
                panelTransmitArea.Enabled = false;
                timerAutoTransmit.Interval = int.Parse(numericUpDownTransmitTimer.Text);
                timerAutoTransmit.Start();
                labelSerialPortStatus.Text = "串口已打开" + " 自动发送中...";
            }
            else
            {
                //自动传送功能关闭
                numericUpDownTransmitTimer.Enabled = true;
                timerAutoTransmit.Stop();
                labelSerialPortStatus.Text = "串口已打开";
            }
        }

        //单击"重置计数"按钮事件函数
        private void buttonResetCount_Click(object sender, EventArgs e)
        {
            receiveCount = 0;
            labelReceiveCount.Text = "接收:" + receiveCount.ToString() + "Bytes";

            transmitCount = 0;
            labelTransmitCount.Text = "传送:" + transmitCount.ToString() + "Bytes";
        }

        //单击"清除接收"按钮事件函数
        private void buttonClearReceive_Click(object sender, EventArgs e)
        {
            textBoxReceiveText.Text = "";
        }

        //单击"清除传送"按钮事件函数
        private void buttonClearTransmit_Click(object sender, EventArgs e)
        {
            textBoxTransmitText.Text = "";
        }
        
        //选择保存文件
        private void buttonSelectSaveFile_Click(object sender, EventArgs e)
        {
            String savePath = textBoxTransmitPath.Text;

            try
            {
                savePath = service.CheckPath(savePath);
                if(savePath == null) openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                else openFileDialog.InitialDirectory = savePath;
            }
            catch(FileNotFoundException fileNotFound)
            {
                MessageBox.Show(fileNotFound.Message);
            }

            //单击"确定",即可回显
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSavePath.Text = openFileDialog.FileName;
            }
        }

        //选择保存文件夹
        private void buttonSelectSaveFolder_Click(object sender, EventArgs e)
        {
            String savePath = textBoxSavePath.Text;
           
            try
            {
                savePath = service.CheckPath(savePath);
                if (savePath == null) folderBrowserDialog.SelectedPath = Directory.GetCurrentDirectory();
                else folderBrowserDialog.SelectedPath = savePath;
            }
            catch (FileNotFoundException fileNotFound)
            {
                MessageBox.Show(fileNotFound.Message);
            }

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSavePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        //选择传送文件
        private void buttonSelectTransmitFile_Click(object sender, EventArgs e)
        {
            String transmitPath = textBoxTransmitPath.Text;
            
            try
            {
                transmitPath = service.CheckPath(transmitPath);
                if (transmitPath == null) openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                else openFileDialog.InitialDirectory = transmitPath;
            }
            catch (FileNotFoundException fileNotFound)
            {
                MessageBox.Show(fileNotFound.Message);
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxTransmitPath.Text = openFileDialog.FileName;
            }
        }

        //保存数据到文件
        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            String savePath = textBoxSavePath.Text;
            String saveData= textBoxReceiveText.Text;

            try
            {
                //调用BLL
                service.SaveData(savePath, saveData);
                MessageBox.Show("保存数据成功");
            }
            catch(FileNotFoundException fileNotFound)
            {
                MessageBox.Show(fileNotFound.Message);
            }
        }

        //传送数据
        private void buttonTransmitFile_Click(object sender, EventArgs e)
        {
            String transmitPath = textBoxTransmitPath.Text;

            try
            {
                service.TransmitData(transmitPath);
                MessageBox.Show("传送数据成功");
            }
            catch(FileNotFoundException fileNotFound)
            {
                MessageBox.Show(fileNotFound.Message);
            }
        }
    }
}