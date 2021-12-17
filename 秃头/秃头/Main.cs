using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 秃头.Output;

namespace 秃头
{
    public partial class Main : Form
    {
        private int m_hairlosstimes;
        public int HairLossTimes
        {
            get { return m_hairlosstimes; }
            set { m_hairlosstimes = value; }
        }
        public Main( )
        {
            InitializeComponent();
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            m_hairlosstimes++;
            string thetime = DateTime.Now.ToString("yyyyMMddHHmmss");
            Hair hair = new Hair(thetime);
            
            string message1="掉了";
            string message2="根头发！";
            this.lbl_times.Text = this.m_hairlosstimes.ToString();
            string data = thetime+":"+message1 + this.m_hairlosstimes.ToString() + message2;
            Output_LogFiles.Instance.writeRecordToLog(data);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Output_LogFiles.Instance.writeRecordToLog("close程序");
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            Output_LogFiles.Instance.writeRecordToLog("Open程序");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //在程序打开时，判断是否存在log文件
            Output_LogFiles.Instance.IsExistAndCreateLogFiles();

            String str=Output_LogFiles.Instance.readLastRecordOfLog();
        }
    }
}
