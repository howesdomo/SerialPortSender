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

        public string DateTimeInfo { get; set; }

        public string Content { get; set; }

        public string ContentByHex { get; set; }

        public string CSVXHeader()
        {
            return "No.,状态,日期时间, 内容 (包含报头与终端信息),Hex (包含报头与终端信息)\r\n";
        }

        public string CSVXContent()
        {
            return string.Format("{0},{1},{2},{3},{4}\r\n", this.No, this.Status, this.DateTimeInfo, this.Content, this.ContentByHex);
        }
    }
}
