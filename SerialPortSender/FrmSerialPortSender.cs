using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SerialPortSender
{
    public partial class FrmSerialPortSender : Form
    {
        /// <summary>
        /// 持续发送
        /// </summary>
        private static bool SendContinue = false;

        /// <summary>
        /// 发送已回车符结束
        /// </summary>
        private static bool SendWithEnter = false;

        /// <summary>
        /// 发送后自增长
        /// </summary>
        private static bool IncreasingAfterSend = false;

        /// <summary>
        /// 发送数据List
        /// </summary>
        public List<DataModel> DataList = new List<DataModel>();

        private BackgroundWorker bgWoker = new BackgroundWorker();

        public FrmSerialPortSender()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.initEvent();
            this.initData();

        }

        private void initData()
        {
            this.txtTimeSpan.Text = "1000";
            this.ckbEndWithEnter.Checked = true;
        }

        private void initEvent()
        {
            this.Load += Form_Load;

            #region BackgroundWorker

            this.bgWoker.WorkerReportsProgress = true;
            this.bgWoker.WorkerSupportsCancellation = true;

            this.bgWoker.DoWork += BgWoker_DoWork;
            this.bgWoker.ProgressChanged += BgWoker_ProgressChanged;
            this.bgWoker.RunWorkerCompleted += BgWoker_RunWorkerCompleted;

            #endregion

            this.ckbEndWithEnter.CheckedChanged += CkbEndWithEnter_CheckedChanged;

            this.ckbSendContinue.CheckedChanged += CkbSendContinue_CheckedChanged;

            this.ckbIncreasing.CheckedChanged += CkbIncreasing_CheckedChanged;

            this.FormClosing += (s, e) =>
            {
                this.closeSerialPort();
            };
        }

        private void CkbEndWithEnter_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                CheckBox tmp = sender as CheckBox;
                FrmSerialPortSender.SendWithEnter = tmp.Checked;

                if (FrmSerialPortSender.SendWithEnter)
                {
                    this.txtIncreasing.Enabled = true;
                    if (string.IsNullOrEmpty(this.txtIncreasing.Text))
                    {
                        this.txtIncreasing.Text = "1";
                    }
                }
                else
                {
                    this.txtIncreasing.Enabled = false;
                }
            }
        }

        private void BgWoker_DoWork(object sender, DoWorkEventArgs e)
        {

            int timeSpan = 1000;
            if (e.Argument != null && e.Argument is int)
            {
                timeSpan = (int)e.Argument;
            }
            BackgroundWorker senderBg = sender as BackgroundWorker;
            while (FrmSerialPortSender.SendContinue)
            {
                senderBg.ReportProgress(1);
                Thread.Sleep(timeSpan);
            }
        }

        private void BgWoker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("停止连续发送!");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error: " + e.Error.Message);
            }
        }

        private void BgWoker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.btnScan_Click(null, null);
        }

        private void CkbSendContinue_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtContent.Text))
            {
                this.ckbSendContinue.Checked = false;
                return;
            }

            if (SendContinue == true)
            {
                this.bgWoker.CancelAsync();
                FrmSerialPortSender.SendContinue = false;
            }

            if (this.ckbSendContinue.Checked)
            {
                int timeSpan = 0;
                if (int.TryParse(this.txtTimeSpan.Text, out timeSpan) && timeSpan > 0)
                {
                    if (bgWoker != null && bgWoker.IsBusy == false)
                    {
                        FrmSerialPortSender.SendContinue = true;
                        bgWoker.RunWorkerAsync(timeSpan);
                    }
                }
                else
                {
                    MessageBox.Show("输入整数");
                }
            }
        }

        private void CkbIncreasing_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox tmpCheckBox = sender as CheckBox;

            if (tmpCheckBox.Checked)
            {
                string content = this.txtContent.Text;
                int index = content.Length;
                int tmp = 0;
                for (int i = content.Length - 1; i > 0; i--)
                {
                    if (int.TryParse(content[i].ToString(), out tmp))
                    {
                        index = i;
                    }
                    else
                    {
                        break;
                    }
                }

                if (index == content.Length)
                {
                    MessageBox.Show("当前内容不能设置自增长");
                    tmpCheckBox.Checked = false;
                }
                else
                {
                    FrmSerialPortSender.IncreasingAfterSend = tmpCheckBox.Checked;
                }
            }

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //开启端口
            if (string.IsNullOrEmpty(cmbCom.Text))
            {
                MessageBox.Show("请选择com口");
                return;
            }
            try
            {
                serialPort1.PortName = cmbCom.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Parity = System.IO.Ports.Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.Open();

                this.PortEnabled();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form_Load(object sender, EventArgs e)
        {
            //获取所有端口
            var array = System.IO.Ports.SerialPort.GetPortNames();
            cmbCom.DataSource = array.ToList().OrderBy(i => i).ToArray();
            this.PortUnEnabled();
        }

        private void PortEnabled()
        {
            this.btnOpen.Enabled = false;

            this.btnclose.Enabled = true;
            this.btnScan.Enabled = true;
            this.btnEmpty.Enabled = true;
            this.ckbIncreasing.Enabled = true;
            this.ckbEndWithEnter.Enabled = true;
            this.ckbSendContinue.Enabled = true;
            this.txtTimeSpan.Enabled = true;
            this.txtContent.Enabled = true;
            this.txtIncreasing.Enabled = true;
        }

        private void PortUnEnabled()
        {
            this.btnOpen.Enabled = true;

            this.btnclose.Enabled = false;
            this.btnScan.Enabled = false;
            this.btnEmpty.Enabled = false;
            this.ckbIncreasing.Enabled = false;
            this.ckbEndWithEnter.Enabled = false;
            this.ckbSendContinue.Enabled = false;
            this.txtTimeSpan.Enabled = false;
            this.txtContent.Enabled = false;
            this.txtIncreasing.Enabled = false;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.closeSerialPort();
        }

        private void closeSerialPort()
        {
            //关闭端口
            try
            {
                FrmSerialPortSender.SendContinue = false;
                Thread.Sleep(500);
                this.ckbSendContinue.Checked = false;
                serialPort1.Close();
                this.PortUnEnabled();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            int tmpTryParse = 0;
            this.statusStrip_Status.Text = string.Empty;
            if (string.IsNullOrEmpty(this.txtContent.Text) || string.IsNullOrEmpty(this.txtContent.Text.Trim()))
            {
                this.lblStatus.Text = "错误：发送内容为空。";
                return;
            }

            if (
                    (this.ckbIncreasing.Checked == true
                    && (string.IsNullOrEmpty(this.txtIncreasing.Text) || !int.TryParse(this.txtIncreasing.Text, out tmpTryParse) || tmpTryParse <= 0)
                    )
               )
            {
                this.lblStatus.Text = "错误：未设置自增长值 或 自增长值有误。";
                return;
            }

            try
            {
                if (FrmSerialPortSender.IncreasingAfterSend)
                {
                    this.txtContent.Text = this.getIncreasingText(txtContent.Text);
                }

                if (FrmSerialPortSender.SendWithEnter)
                {
                    serialPort1.WriteLine(txtContent.Text);
                }
                else
                {
                    serialPort1.Write(txtContent.Text);
                }

                DataModel t = new DataModel();
                t.No = this.DataList.Count + 1;
                t.Status = "发送";
                t.Date_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                t.Content = txtContent.Text;

                List<DataModel> templ = new List<DataModel>();
                templ.Add(t);
                templ.AddRange(this.DataList);
                this.DataList = templ;
                dataGridView1.DataSource = DataList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string getIncreasingText(string content)
        {
            int index = 0;
            int tmp = 0;
            for (int i = content.Length - 1; i > 0; i--)
            {
                if (int.TryParse(content[i].ToString(), out tmp))
                {
                    index = i;
                }
                else
                {
                    break;
                }
            }
            long a = 0;
            long.TryParse(content.Substring(index), out a);

            int length = content.Length - index; // 字符串占位长度
            int numberLength = a.ToString().Length; // 长度
            int newLength = (a + 1).ToString().Length; // 自增长后长度

            string m = ((a + 1).ToString().PadLeft(length, '0')); //自增长后字符串
            string result = content.Substring(0, index) + m;

            return result;
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            DataList = new List<DataModel>();
            dataGridView1.DataSource = DataList;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(500); // TODO : 等待数据传送完毕时间

                string barcode = string.Empty;
                string contentByHex = string.Empty;
                if (FrmSerialPortSender.SendWithEnter)
                {
                    barcode = serialPort1.ReadLine();
                }
                else
                {
                    int length = serialPort1.BytesToRead;
                    byte[] buf = new byte[length];
                    serialPort1.Read(buf, 0, length);
                    barcode = System.Text.Encoding.Default.GetString(buf, 0, buf.Length);

                    foreach (var i in buf)
                    {
                        string a = string.Format("{0:X}", i).PadLeft(2, '0');
                        if (string.IsNullOrEmpty(contentByHex) == false)
                        {
                            contentByHex += " " + a;
                        }
                        else
                        {
                            contentByHex = a;
                        }
                    }
                }

                DataModel t = new DataModel();
                t.No = this.DataList.Count + 1;
                t.Status = "接收";
                t.Date_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                t.Content = barcode;
                t.ContentByHex = contentByHex;

                List<DataModel> templ = new List<DataModel>();
                templ.Add(t);
                templ.AddRange(DataList);
                DataList = templ;
                this.Invoke((EventHandler)(delegate
                {
                    dataGridView1.DataSource = DataList;
                }));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
