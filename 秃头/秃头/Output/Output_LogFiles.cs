using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秃头.Output
{
    public class Output_LogFiles
    {
        private static Output_LogFiles _instance;
        public static Output_LogFiles Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Output_LogFiles();
                return _instance;
            }
        }
        public Output_LogFiles()
        {
            
        }
        private DateTime todayTimes
        {
            get { return DateTime.Now; }
        }
        private string logFilePath
        {
            get { return System.AppDomain.CurrentDomain.BaseDirectory + @"SaveDir"; }
        }
        /// <summary>
        /// 保存数据data到文件的处理过程；
        /// </summary>
        /// <param name="data"></param>
        public bool writeRecordToLog(string data)
        {           
            StreamWriter file = new StreamWriter(this.logFilePath+this.todayTimes.ToString("YYYYMMdd")+".txt",true);
            file.Write(data);
            file.Close();
            file.Dispose();
            return true;
        }

        public string readLastRecordOfLog( )
        {
            return null;
        }

        public void IsExistAndCreateLogFiles()
        {
            //判断路径是否存在
            if (!Directory.Exists(logFilePath))
            {
                Directory.CreateDirectory(logFilePath);
            }
            if (!File.Exists(this.logFilePath + this.todayTimes.ToString("YYYYMMdd") + ".txt"))
            {
                File.Create(this.logFilePath + this.todayTimes.ToString("YYYYMMdd") + ".txt");
            }
        }
    }
}
