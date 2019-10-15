using System;
using System.IO;

/*
 * 数据访问层
 * 功能:对文件直接操作
 */
namespace SerialCommunication.DAL
{
    public class SerialCommunicationDao
    {
        /*
         * 参数:savePath(文件路径),saveText(需要保存的数据文本)
         * 功能:保存数据到文件
         */
        public void SaveDataToFileText(String savePath, String saveText)
        {
            //创建流对象
            StreamWriter streamWriter = new StreamWriter(new FileStream(savePath, FileMode.Append));
                
            //写入流对象
            streamWriter.WriteLine(saveText);
            
            streamWriter.Flush();
            streamWriter.Close();
        }

        /*
         * 参数:savePath(文件路径),transmitPath(需要传送的数据文本)
         * 功能:传送数据文件
         */
        public String TransmitDataFile(String transmitPath)
        {
            //创建流对象
            StreamReader streamReader = new StreamReader(new FileStream(transmitPath, FileMode.Open));

            //读取流对象
            String transmitData = streamReader.ReadToEnd();

            streamReader.Close();

            return transmitData;
        }
    }
}
