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
        private String m_logfilepath = "";
        private String m_createtime = "";
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

        public void create_LogFile(String _path)
        {
            FileStream fs = new FileStream(_path, FileMode.Create);
            fs.Close();//解除占用
        }

        public String CreateTime
        {
            get { return m_createtime; }
            set { m_createtime = value; }
        }
        public string LogFilePath
        {
            get { return m_logfilepath; }
            set { m_logfilepath = value; }
        }

        /// <summary>
        /// 保存数据data到文件的处理过程；
        /// </summary>
        /// <param name="data"></param>
        public bool writeRecordToLog(string data)
        {
            //StreamWriter file = new StreamWriter(this.logFilePath+this.todayTimes.ToString("YYYYMMdd")+".txt",true)；
            //file.Write(data);
            //file.Close();
            //file.Dispose();
            return true;
        }

        public string readLastRecordOfLog( )
        {
            return null;
        }

        public void IsExistAndCreateLogFiles()
        {
            ////判断路径是否存在
            //if (!Directory.Exists(logFilePath))
            //{
            //    Directory.CreateDirectory(logFilePath);
            //}
            //if (!File.Exists(this.logFilePath + this.todayTimes.ToString("YYYYMMdd") + ".txt"))
            //{
            //    File.Create(this.logFilePath + this.todayTimes.ToString("YYYYMMdd") + ".txt");
            //}
        }
    }
}
