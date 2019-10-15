using System;
using System.IO;
using SerialCommunication.DAL;
using System.Text.RegularExpressions;

/*
 * 业务逻辑层
 * 功能:清洗传送的数据,传入DAL
 */
namespace SerialCommunication.BLL
{
    public class SerialCommunicationService
    {
        //创建数据访问层对象
        private SerialCommunicationDao dao = new SerialCommunicationDao();

        public int handleBytesCount = 0;

        /* 
         * 参数:savePath(保存路径)
         * 功能:清洗路径,加工文本,调用DAL
         */
        public void SaveData(String savePath, String saveData) 
        {
            //洗涤路径,如果路径不正确,抛出异常
            try
            {
                savePath = CheckPath(savePath);
            }
            catch
            {
                throw new FileNotFoundException("保存路径错误,请重新选择");
            }

            //加工文本
            saveData =  "SaveTime:" + System.DateTime.Now.ToString("HH:mm:ss") + System.Environment.NewLine + 
                        "DataText:" + saveData;
            
            //调用DAL
            dao.SaveDataToFileText(savePath, saveData);
        }

        /* 
         * 参数:transmitPath(传送路径,只能为文本文件,不存在文件夹)
         * 功能:清洗路径,调用DAL
         */
        public String TransmitData(String transmitPath)
        {
            //洗涤路径,如果路径不正确,抛出异常
            try
            {
                transmitPath = CheckPath(transmitPath);
            }
            catch
            {
                throw new FileNotFoundException("传送路径错误,请重新选择");
            }

            return dao.TransmitDataFile(transmitPath);
        }

        /*
         * 功能:检查路径
         *      如果是文件夹,返回path + "ReceiveDataSaveFile.txt"
         *      如果是文本文件,无操作
         *      如果路径不正确,返回null给调用者
         */
        public String CheckPath(String path)
        {
            //用正则表达式消除空白字符
            path = Regex.Replace(path, @"\s", "");
            if (path == String.Empty) return null;

            if (Directory.Exists(path))
            {
                //路径为文件夹
                return path + @"\ReceiveDataSaveFile.txt";
            }
            else if (File.Exists(path))
            {
                //路径为文本文件
                return path;
            }
            else
            {
                //路径不正确
                throw new FileNotFoundException("不是一个正确文件夹路径");
            }
        }

        /*
         * 功能:将数据清洗转换为HEX模式,并记录处理字节数
         */
        public byte[] DataToHEX(String data)
        {
            //用正则表达式消除空白字符
            data = Regex.Replace(data, @"\s", "");

            //判断是否为双数,如不是,向高位加0
            if (data.Length % 2 != 0)
            {
                data = "0" + data;
            }

            handleBytesCount = data.Length / 2;

            byte[] dataBytes = new byte[handleBytesCount];

            for (int count = 0; count < handleBytesCount; count++)
            {
                dataBytes[count] = Convert.ToByte(data.Substring(count * 2, 2), 16);
            }

            return dataBytes;
        }

        public void DataToASCII()
        {

        }
    }
}
