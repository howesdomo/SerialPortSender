using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerialPortSender
{

    public class DataModel
    {
        public int No { get; set; }

        public string Status { get; set; }

        public DateTime DateTime { get; set; }

        public string DateTimeInfo
        {
            get { return this.DateTime.ToString("yyyy-MM-dd HH:mm:ss.fff"); }
        }

        public string Encoding { get; set; }

        /// <summary>
        /// 实际发送/接收内容 (包含报头与终端信息)
        /// </summary>
        public string Content { get; set; }

        public string ContentByHex { get; set; }

        /// <summary>
        /// 输入框内容 (不包含报头与终端信息)
        /// </summary>
        public string InputContent { get; set; }

        [Obsolete]
        public string CSVXHeader()
        {
            return "No.,状态,日期时间, 内容 (包含报头与终端信息),Hex (包含报头与终端信息)\r\n";
        }

        [Obsolete]
        public string CSVXContent()
        {
            return string.Format("{0},{1},{2},{3},{4}\r\n", this.No, this.Status, this.DateTimeInfo, this.Content, this.ContentByHex);
        }

        public string SQLiteInsert()
        {
            return string.Format($"insert into MyData values ('{this.Status}', {this.DateTime.Ticks}, '{this.DateTimeInfo}', '{this.Encoding}', '{this.Content}', '{this.ContentByHex}')");
        }
    }
}
