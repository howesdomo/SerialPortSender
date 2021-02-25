using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerialPortSender
{
    /// <summary>
    /// 发送信息的报头 OR 终端
    /// </summary>
    public class Report
    {
        public string DisplayName { get; set; }
        
        public string Value { get; set; }

        public string HexString { get; set; }

        public string ASCIIString { get; set; }

        public void SetValue(string a, Encoding encoding)
        {
            this.Value = a;
            this.DisplayName = a.StringShowSpecialSymbol();
            this.HexString = a.ToHexString(encoding);
        }

    }
}
