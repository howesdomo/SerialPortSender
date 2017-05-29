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
        public string Date_Time { get; set; }
        public string Content { get; set; }

        public string ContentByHex { get; set; }
    }
}
