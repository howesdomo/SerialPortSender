using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Net;
using System.Net.Sockets;

namespace SerialPortSender
{
    public partial class FrmSerialPortSender : Form
    {
        /// <summary>
        /// 持续发送
        /// </summary>
        private static bool SendContinue = false;

        /// <summary>
        /// 发送后自增长
        /// </summary>
        private static bool IncreasingAfterSend = false;

        /// <summary>
        /// 发送数据List
        /// </summary>
        public List<DataModel> mDataList = new List<DataModel>();

        /// <summary>
        /// 去除重复的发送数据List
        /// </summary>
        public Dictionary<string, DataModel> mDict = new Dictionary<string, DataModel>();

        private BackgroundWorker bgWoker = new BackgroundWorker();

        public FrmSerialPortSender()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.Text = string.Format("{0} - V {1}", this.Text, Assembly.GetExecutingAssembly().GetName().Version.ToString());

            this.initEvent();
            this.initData();

        }

        private void initData()
        {
            mThreadSleep_BeforeRead = cThreadSleep_BeforeRead;
            this.txtThreadSleep_BeforeReadExsiting.Text = cThreadSleep_BeforeRead.ToString();
            this.txtTimeSpan.Text = "1000";

            var baudRateList = Util.IO.SerialPortUtil.GetBaudRateList();
            this.cbBaudRate.DataSource = baudRateList;
            this.cbBaudRate.DisplayMember = "DisplayName";
            this.Default_BaudRate = baudRateList.First(i => i.Value == 9600);
            this.cbBaudRate.SelectedItem = this.Default_BaudRate;

            var dataBitsList = Util.IO.SerialPortUtil.GetDataBitsList();
            this.cbDataBits.DataSource = dataBitsList;
            this.cbDataBits.DisplayMember = "DisplayName";
            this.Default_DataBits = dataBitsList.First(i => i.Value == 8);
            this.cbDataBits.SelectedItem = this.Default_DataBits;

            var parityList = Util.IO.SerialPortUtil.GetParityList();
            this.cbParity.DataSource = parityList;
            this.cbParity.DisplayMember = "DisplayName";
            this.Default_Parity = parityList.First(i => i.Value == System.IO.Ports.Parity.None);
            this.cbParity.SelectedItem = this.Default_Parity;

            var stopBitsList = Util.IO.SerialPortUtil.GetStopBitsList();
            this.cbStopBits.DataSource = stopBitsList;
            this.cbStopBits.DisplayMember = "DisplayName";
            this.Default_StopBits = stopBitsList.First(i => i.Value == System.IO.Ports.StopBits.One);
            this.cbStopBits.SelectedItem = this.Default_StopBits;


            this.cbSendEncoding.DataSource = mEncodingList;
            this.cbSendEncoding.DisplayMember = "BodyName";

            this.cbReceiveEncoding.DataSource = mEncodingList2;
            this.cbReceiveEncoding.DisplayMember = "BodyName";

            this.rbReportHead_None.Checked = true;  // 初始化配置 开始符号 无
            this.RbReportHead_AllBtn_Click(this.rbReportHead_None, null);

            this.rbReportEnd_CR_LF.Checked = true; // 初始化配置 结束符合 \r\n
            this.RbReportEnd_AllBtn_Click(this.rbReportEnd_CR_LF, null);

            mServerIPList = Howe.Helper.WinNetworkHelper.GetAllDevice();
            cmbServerIP.DataSource = mServerIPList;
            if (mServerIPList.Count > 1) // 因为肯定有一项刷新, 故此处要大于 1
            {
                cmbServerIP.SelectedItem = mServerIPList[0];
            }
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

            this.ckbSendContinue.CheckedChanged += CkbSendContinue_CheckedChanged;

            this.ckbIncreasing.CheckedChanged += CkbIncreasing_CheckedChanged;

            this.rbReportHead_None.Click += RbReportHead_AllBtn_Click;
            this.rbReportHead_STX.Click += RbReportHead_AllBtn_Click;
            this.rbReportHead_ESC.Click += RbReportHead_AllBtn_Click;
            this.rbReportHead_UserSetting.Click += RbReportHead_AllBtn_Click;
            this.txtReportHead_Hex.TextChanged += txtReportHead_Hex_TextChanged;

            this.rbReportEnd_None.Click += RbReportEnd_AllBtn_Click;
            this.rbReportEnd_CR.Click += RbReportEnd_AllBtn_Click;
            this.rbReportEnd_ETX.Click += RbReportEnd_AllBtn_Click;
            this.rbReportEnd_CR_LF.Click += RbReportEnd_AllBtn_Click;
            this.rbReportEnd_UserSetting.Click += RbReportEnd_AllBtn_Click;
            this.txtReportEnd_Hex.TextChanged += txtReportEnd_Hex_TextChanged;

            this.txtThreadSleep_BeforeReadExsiting.TextChanged += TxtThreadSleep_BeforeReadExsiting_TextChanged;
            this.txtThreadSleep_BeforeReadExsiting.LostFocus += TxtThreadSleep_BeforeReadExsiting_LostFocus;

            this.FormClosing += (s, e) =>
            {
                this.closeSerialPort();
            };

            this.btnResetSerialPort.Click += btnResetSerialPort_Click;


            this.btnServerStart.Click += BtnServerStart_Click;
            this.btnServerStop.Click += BtnServerStop_Click;

            this.cbReceiveEncoding.SelectedIndexChanged += cbReceiveEncoding_SelectedIndexChanged;
            this.cbSendEncoding.SelectedIndexChanged += cbSendEncoding_SelectedIndexChanged;

            this.btnDictShow.Click += (s, e) =>
            {
                dataGridViewDict.Visible = true;
            };

            this.btnDictHidden.Click += (s, e) =>
            {
                dataGridViewDict.Visible = false;
            };
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.LoadPortList();
        }

        #region 设置 接收等待时间(毫秒)

        private void TxtThreadSleep_BeforeReadExsiting_TextChanged(object sender, EventArgs e)
        {
            try
            {
                edit_ThreadSleep_BeforeReadExsiting();
            }
            catch (Exception ex)
            {

            }
        }

        private void TxtThreadSleep_BeforeReadExsiting_LostFocus(object sender, EventArgs e)
        {
            try
            {
                edit_ThreadSleep_BeforeReadExsiting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtThreadSleep_BeforeReadExsiting.Focus();
                txtThreadSleep_BeforeReadExsiting.SelectAll();
            }
        }

        private void edit_ThreadSleep_BeforeReadExsiting()
        {
            string tmp = this.txtThreadSleep_BeforeReadExsiting.Text;

            int r = 0;

            if (int.TryParse(tmp, out r))
            {
                if (r == 0)
                {
                    mThreadSleep_BeforeRead = null;
                }
                else
                {
                    mThreadSleep_BeforeRead = r;
                }
            }
            else
            {
                throw new Exception("请设置正确的接收前等待时间(毫秒)");
            }
        }

        #endregion

        private string getSendContent(string msg)
        {
            Report head = GetReportHead();
            Report end = GetReportEnd();

            string r = string.Format("{0}{1}{2}", head.Value, msg, end.Value);
            return r;
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
            FrmSerialPortSender.IncreasingAfterSend = tmpCheckBox.Checked; // 自增长计算逻辑已优化, 无需再根据内容判断能否进行自增长
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

                serialPort1.BaudRate = (this.cbBaudRate.SelectedItem as Util.IO.BaudRate).Value;
                serialPort1.DataBits = (this.cbDataBits.SelectedItem as Util.IO.DataBits).Value;
                serialPort1.Parity = (this.cbParity.SelectedItem as Util.IO.Parity).Value;
                serialPort1.StopBits = (this.cbStopBits.SelectedItem as Util.IO.StopBits).Value;

                this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);

                serialPort1.Open();

                this.PortEnabled();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.serialPort1.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            }
        }

        public string RefreshPortListInfo
        {
            get { return "刷新..."; }
        }

        void LoadPortList()
        {
            var list = Util.IO.SerialPortUtil.GetPortNameList(); // 获取所有串口
            list.Add(this.RefreshPortListInfo);
            cmbCom.DataSource = list;
            this.PortUnEnabled();
        }

        private void cmbCom_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCom.SelectedValue.ToString() == this.RefreshPortListInfo)
            {
                this.LoadPortList();
            }
        }

        private void PortEnabled()
        {
            this.btnOpen.Enabled = false;
            this.cmbCom.Enabled = false;
            this.txtThreadSleep_BeforeReadExsiting.Enabled = false;

            this.btnclose.Enabled = true;
            this.btnScan.Enabled = true;
            this.btnEmpty.Enabled = true;
            this.ckbIncreasing.Enabled = true;
            this.ckbSendContinue.Enabled = true;
            this.txtTimeSpan.Enabled = true;
            this.txtContent.Enabled = true;
            this.txtIncreasing.Enabled = true;

            this.cbBaudRate.Enabled = false;
            this.cbDataBits.Enabled = false;
            this.cbParity.Enabled = false;
            this.cbStopBits.Enabled = false;
            this.btnResetSerialPort.Enabled = false;
        }

        private void PortUnEnabled()
        {
            this.btnOpen.Enabled = true;
            this.cmbCom.Enabled = true;
            this.txtThreadSleep_BeforeReadExsiting.Enabled = true;

            this.btnclose.Enabled = false;
            this.btnScan.Enabled = false;
            this.btnEmpty.Enabled = false;
            this.ckbIncreasing.Enabled = false;
            this.ckbSendContinue.Enabled = false;
            this.txtTimeSpan.Enabled = false;
            this.txtContent.Enabled = false;
            this.txtIncreasing.Enabled = false;

            this.cbBaudRate.Enabled = true;
            this.cbDataBits.Enabled = true;
            this.cbParity.Enabled = true;
            this.cbStopBits.Enabled = true;
            this.btnResetSerialPort.Enabled = true;
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

                // **** 关键 , 当发送端快速并且不停地发送信息, 此时调用 serialPort1.Close() 会卡死
                // 故应 
                // 1) 停止注册 DataReceived事件
                // 2) Application.DoEvents();
                // 3) serialPort1.Close();
                this.serialPort1.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
                Thread.Sleep(500);
                Application.DoEvents();
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
            this.statusStrip_Status.Text = string.Empty;
            if (string.IsNullOrEmpty(this.txtContent.Text)) // 不能发送全空内容, 但能发送空格
            {
                this.lblStatus.Text = "错误：发送内容为空。";
                return;
            }

            if (this.ckbIncreasing.Checked == true &&
                (string.IsNullOrEmpty(this.txtIncreasing.Text) || !int.TryParse(this.txtIncreasing.Text, out int tmpTryParse) || tmpTryParse < 0) // 自增长可以等于0
               )
            {
                this.lblStatus.Text = "错误：未设置自增长值 或 自增长值有误。";
                return;
            }

            try
            {
                if (FrmSerialPortSender.IncreasingAfterSend)
                {
                    this.txtContent.Text = this.getIncreasingTextV2(txtContent.Text);
                }

                string sendContent = this.getSendContent(this.txtContent.Text);
                byte[] toWrite = mSendEncoding.GetBytes(sendContent);
                serialPort1.Write(toWrite, 0, toWrite.Length);

                DataModel t = new DataModel();
                t.No = this.mDataList.Count + 1;
                t.Status = "发送";
                t.DateTime = DateTime.Now;
                // t.DateTimeInfo = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                t.Encoding = mSendEncoding.BodyName.ToString();

                t.InputContent = txtContent.Text;
                t.Content = sendContent.StringShowSpecialSymbol();
                t.ContentByHex = ByteArray2HexString(sendContent, mSendEncoding);


                List<DataModel> templ = new List<DataModel>();
                templ.Add(t);
                templ.AddRange(this.mDataList);
                this.mDataList = templ;
                dataGridView1.DataSource = mDataList;

                string key = txtContent.Text;
                DataModel dictToAdd = null;
                if (mDict.TryGetValue(key, out dictToAdd) == true)
                {
                    dictToAdd.DateTime = t.DateTime;
                }
                else
                {
                    dictToAdd = t;
                    mDict.Add(key, dictToAdd);

                    List<DataModel> dictToList = new List<DataModel>();
                    foreach (string itemKey in mDict.Keys)
                    {
                        dictToList.Add(mDict.GetValue(itemKey));
                    }

                    dataGridViewDict.DataSource = dictToList;
                }

                if (cbExportLog.Checked == true)
                {
                    // LogAsync(t);
                    LogAsync_V2(t);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 根据自增长数值, 计算发送内容
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        string getIncreasingTextV2(string content)
        {
            var matches = System.Text.RegularExpressions.Regex.Matches(content, "[0-9]+");

            System.Text.RegularExpressions.Match match = null;

            for (int i = matches.Count - 1; i >= 0;)
            {
                match = matches[i];
                break;
            }

            if (match == null)
            {
                return $"{content}1";
            }

            string prefix = content.Substring(0, match.Index); // 自增长前缀信息
            string suffix = content.Substring(match.Index + match.Length); // 自增长后缀信息

            long a = 0;
            long.TryParse(content.Substring(match.Index, match.Length), out a);
            string increaseInfo = (a + 1).ToString().PadLeft(match.Length, '0'); // 自增长

            string r = $"{prefix}{increaseInfo}{suffix}";
            return r;
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {

            this.txtContent.Text = string.Empty;
            this.txtContent.Focus();
        }

        private const int cThreadSleep_BeforeRead = 80;

        private int? mThreadSleep_BeforeRead { get; set; }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (this.serialPort1.IsOpen == false)
            {
                return;
            }

            try
            {
                string barcode = string.Empty;

                if (mThreadSleep_BeforeRead.HasValue)
                {
                    Thread.Sleep(mThreadSleep_BeforeRead.Value);
                }

                int length = serialPort1.BytesToRead;
                byte[] buf = new byte[length];
                serialPort1.Read(buf, 0, length);

                barcode = mReceiveEncoding.GetString(buf, 0, buf.Length);

                DataModel t = new DataModel();
                t.No = this.mDataList.Count + 1;
                t.Status = "接收";
                t.DateTime = DateTime.Now;
                // t.DateTimeInfo = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                t.Encoding = mReceiveEncoding.BodyName;
                t.Content = barcode.StringShowSpecialSymbol();
                t.InputContent = barcode.Trim();
                t.ContentByHex = ByteArray2HexString(buf);

                List<DataModel> templ = new List<DataModel>();
                templ.Add(t);
                templ.AddRange(mDataList);
                mDataList = templ;

                if (cbExportLog.Checked == true)
                {
                    LogAsync_V2(t);
                }

                //this.Invoke
                //(
                //    (EventHandler)(delegate
                //    {
                //        dataGridView1.DataSource = DataList;
                //    })
                //);
                this.Invoke(new Action(() => { dataGridView1.DataSource = mDataList; }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string ByteArray2HexString(byte[] buf)
        {
            string contentByHex = string.Empty;

            foreach (byte i in buf)
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

            return contentByHex;
        }

        public static string ByteArray2HexString(string msg, Encoding encoding)
        {
            byte[] buf = encoding.GetBytes(msg);
            string contentByHex = string.Empty;

            foreach (byte i in buf)
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
            return contentByHex;
        }

        #region 报文信息

        void RbReportHead_AllBtn_Click(object sender, EventArgs e)
        {
            var r = GetReportHead();
            this.txtReportHead_Hex.Text = r.HexString;
            this.txtReportHead_ASCII.Text = r.ASCIIString;
        }

        void RbReportEnd_AllBtn_Click(object sender, EventArgs e)
        {
            var r = GetReportEnd();
            this.txtReportEnd_Hex.Text = r.HexString;
            this.txtReportEnd_ASCII.Text = r.ASCIIString;
        }

        Report GetReportHead()
        {
            Report r = new Report();

            if (this.rbReportHead_None.Checked)
            {
                r.SetValue(string.Empty, mSendEncoding);
            }
            else if (this.rbReportHead_STX.Checked)
            {
                r.SetValue("\x02", mSendEncoding);
            }
            else if (this.rbReportHead_ESC.Checked)
            {
                r.SetValue("\x1B", mSendEncoding);
            }
            else if (this.rbReportHead_UserSetting.Checked)
            {
                string args = string.Empty;

                try
                {
                    args = mSendEncoding.GetString(this.txtReportHead_Hex.Text.HexString2ByteArray(" "));
                }
                catch (Exception)
                {
                    this.lblStatus.Text = $"自定义报头信息转换失败";
                }

                r.SetValue(args, mSendEncoding);
            }

            return r;
        }

        Report GetReportEnd()
        {
            Report r = new Report();

            if (this.rbReportEnd_None.Checked)
            {
                r.SetValue(string.Empty, mSendEncoding);
            }
            else if (this.rbReportEnd_CR.Checked)
            {
                r.SetValue("\x0D", mSendEncoding);
            }
            else if (this.rbReportEnd_ETX.Checked)
            {
                r.SetValue("\x03", mSendEncoding);
            }
            else if (this.rbReportEnd_CR_LF.Checked)
            {
                r.SetValue("\x0D\x0A", mSendEncoding);
            }
            else if (this.rbReportEnd_UserSetting.Checked)
            {
                string args = string.Empty;

                try
                {
                    args = mSendEncoding.GetString(this.txtReportEnd_Hex.Text.HexString2ByteArray(" "));
                }
                catch (Exception)
                {
                    this.lblStatus.Text = $"自定义终端信息转换失败";
                }
                r.SetValue(args, mSendEncoding);
            }

            return r;
        }

        private void txtReportHead_Hex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mSendEncoding.GetString(this.txtReportHead_Hex.Text.HexString2ByteArray(" "));
                this.lblStatus.Text = string.Empty;
            }
            catch (Exception)
            {
                this.lblStatus.Text = $"自定义报头信息转换失败";
            }
        }

        private void txtReportEnd_Hex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mSendEncoding.GetString(this.txtReportEnd_Hex.Text.HexString2ByteArray(" "));
                this.lblStatus.Text = string.Empty;
            }
            catch (Exception)
            {
                this.lblStatus.Text = $"自定义终端信息转换失败";
            }
        }

        #endregion

        #region 导出日志

        string getDBFilePath()
        {
            var dir = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SerialPortSenderLog");

            if (System.IO.Directory.Exists(dir) == false)
            {
                System.IO.Directory.CreateDirectory(dir);
            }

            var fileName = string.Format("Log_{0}.db", DateTime.Now.ToString("yyyy-MM-dd"));
            var filePath = System.IO.Path.Combine(dir, fileName);

            return filePath;
        }

        string getConnStr()
        {
            // return Util.DBHelper.SQLiteConnStr(getDBFilePath(), password: "github.com/howesdomo/"); // SQLite 免费版不支持加密
            // SQL logic error
            // Cannot use "Password" connection string property: library was not built with encryption support.
            return Util.DBHelper.SQLiteConnStr(getDBFilePath());
        }

        void LogAsync_V2(DataModel args)
        {
            // 未有数据库文件, 新建文件并用脚本构建结构
            if (System.IO.File.Exists(getDBFilePath()) == false)
            {
                // 采用脚本创建数据库结构
                //string copyFrom = System.IO.Path.Combine(Environment.CurrentDirectory, "DataBaseSeed.db");
                //System.IO.File.Copy(copyFrom, getDBFilePath());

                Util.DBHelper.GetDataSet
                (
                    factory: Util.DBHelper.GetDbProviderFactory(Util.DbProvider.SQLite),
                    connectionString: getConnStr(),
                    argCommandType: System.Data.CommandType.Text,
                    commandText: "CREATE TABLE \"main\".\"MyData\"(\"Status\"  TEXT NOT NULL, \"DateTimeTick\"  INTEGER NOT NULL, \"DateTimeInfo\"  TEXT NOT NULL, \"Encoding\"  TEXT, \"Content\"  TEXT, \"Hex\"  TEXT, PRIMARY KEY(\"DateTimeTick\") ) ;",
                    paramsList: null,
                    isBeginTransaction: true, // SQLite 推荐开启事务进行 CUD 操作
                    isRollbackForTest: false
                );
            }

            // 插入数据
            Util.DBHelper.GetDataSet
            (
                factory: Util.DBHelper.GetDbProviderFactory(Util.DbProvider.SQLite),
                connectionString: getConnStr(),
                argCommandType: System.Data.CommandType.Text,
                commandText: args.SQLiteInsert(),
                paramsList: null,
                isBeginTransaction: true, // SQLite 推荐开启事务进行 CUD 操作
                isRollbackForTest: false
            );
        }

        #endregion

        /// <summary>
        /// 双击DataGridView内容, 复制内容到输入框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var rowCollection = this.dataGridView1.Rows[e.RowIndex];
            var cell = rowCollection.Cells["colInputContent"];
            string content = cell.Value.ToString();
            this.txtContent.Text = content;
        }

        private void dataGridViewDict_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var rowCollection = this.dataGridViewDict.Rows[e.RowIndex];
            var cell = rowCollection.Cells["col2InputContent"];
            string content = cell.Value.ToString();
            this.txtContent.Text = content;
        }


        public Util.IO.BaudRate Default_BaudRate { get; set; }
        public Util.IO.DataBits Default_DataBits { get; set; }
        public Util.IO.Parity Default_Parity { get; set; }
        public Util.IO.StopBits Default_StopBits { get; set; }

        private void btnResetSerialPort_Click(object sender, EventArgs e)
        {
            this.cbBaudRate.SelectedItem = this.Default_BaudRate;
            this.cbDataBits.SelectedItem = this.Default_DataBits;
            this.cbParity.SelectedItem = this.Default_Parity;
            this.cbStopBits.SelectedItem = this.Default_StopBits;
        }

        #region Encoding 发送接收编码

        List<Encoding> mEncodingList = new List<Encoding>()
        {
            Encoding.GetEncoding(936),
            Encoding.UTF8,
            Encoding.Unicode,
            Encoding.ASCII,
        };

        List<Encoding> mEncodingList2 = new List<Encoding>()
        {
            Encoding.GetEncoding(936),
            Encoding.UTF8,
            Encoding.Unicode,
            Encoding.ASCII,
        };

        private Encoding mSendEncoding { get; set; }
        private void cbSendEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            mSendEncoding = cbSendEncoding.SelectedItem as Encoding;
        }

        private Encoding mReceiveEncoding { get; set; }
        private void cbReceiveEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            mReceiveEncoding = cbReceiveEncoding.SelectedItem as Encoding;
        }

        #endregion

        #region Socket Server

        // 定义Socket对象
        System.Net.Sockets.TcpListener mTcpListener { get; set; }

        // 定义监听线程
        System.Threading.Tasks.Task taskListen { get; set; }

        // 定义接收客户端数据线程
        System.Threading.Tasks.Task taskReceive { get; set; }

        // 定义双方通信
        System.Net.Sockets.TcpClient remoteClient { get; set; }

        LinkedList<System.Net.Sockets.TcpClient> remoteClientLinkedList { get; set; } = new LinkedList<System.Net.Sockets.TcpClient>();


        private void BtnServerStart_Click(object sender, EventArgs e)
        {
            this.btnServerStart.Enabled = false;
            try
            {
                remoteClientLinkedList.Clear();

                IPAddress ip = IPAddress.Parse(this.txtServerIP.Text.Trim());
                int port = Convert.ToInt32(this.txtServerPort.Text.Trim());

                mTcpListener = new System.Net.Sockets.TcpListener(ip, port);
                mTcpListener.Start();

                string msg = "Server : Start Listening";
                System.Diagnostics.Debug.WriteLine(msg);

                taskListen = new System.Threading.Tasks.Task(ListenClientConnect);
                taskListen.Start();

                this.btnServerStop.Enabled = true;
                this.txtServerIP.Enabled = false;
                this.cmbServerIP.Enabled = false;
                this.txtServerPort.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetFullInfo());
                this.btnServerStart.Enabled = true;
            }
        }

        private void BtnServerStop_Click(object sender, EventArgs e)
        {
            this.btnServerStop.Enabled = false;
            try
            {
                mTcpListener.Stop();
                this.btnServerStart.Enabled = true;

                this.txtServerIP.Enabled = true;
                this.cmbServerIP.Enabled = true;
                this.txtServerPort.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetFullInfo());
                this.btnServerStop.Enabled = true;
            }
        }


        private void ListenClientConnect()
        {
            while (true)
            {
                //监听到客户端的连接，获取双方通信socket
                System.Net.Sockets.TcpClient remoteClient = mTcpListener.AcceptTcpClient();
                remoteClientLinkedList.AddLast(remoteClient);

                string msg = "Server : Client Connected! Local:{0} <-- Client:{1}".FormatWith
                (
                    remoteClient.Client.LocalEndPoint,
                    remoteClient.Client.RemoteEndPoint
                );
                System.Diagnostics.Debug.WriteLine(msg);

                //创建线程循环接收客户端发送的数据
                taskReceive = new System.Threading.Tasks.Task(() => Receive(remoteClient));
                taskReceive.ContinueWith((task) =>
                {
                    System.Diagnostics.Debug.WriteLine("taskReceive is end");
                });

                //传入双方通信socket
                taskReceive.Start();
            }
        }

        //接收客户端数据
        private void Receive(TcpClient myClientSocket)
        {
            while (true)
            {
                try
                {
                    string str = myClientSocket.Receive(); // 自定义扩展方法
                    this.Invoke(new Action(() =>
                    {
                        this.txtContent.Text = str;
                        this.btnScan_Click(this.btnScan, new EventArgs());
                    }));
                }
                catch (Exception ex)
                {
                    string msg = "{0}".FormatWith(ex.GetFullInfo());
                    System.Diagnostics.Debug.WriteLine(msg);
                    Util.LogUtils.LogAsync(ex.GetFullInfo());
                }
            }
        }

        /// <summary>
        /// 本机 IP 列表
        /// </summary>
        List<Howe.Helper.NetworkInterfaceAdv> mServerIPList = Howe.Helper.WinNetworkHelper.GetAllDevice();

        /// <summary>
        /// 选择本机IP列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbServerIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbServerIP.SelectedIndex < 0)
            {
                return;
            }

            int index = cmbServerIP.SelectedIndex;

            if (mServerIPList[index].DisplayName == Howe.Helper.NetworkInterfaceAdv.RefleshInfo)
            {
                mServerIPList = Howe.Helper.WinNetworkHelper.GetAllDevice();
                cmbServerIP.DataSource = mServerIPList;
                this.txtServerIP.Text = string.Empty;
            }
            else
            {
                this.txtServerIP.Text = mServerIPList[index].IPAddress.ToString();
            }
        }

        #endregion

        #region 以 Socket 的方式连接到扫描头服务端

        TcpClient mTcpClient { get; set; }

        // 创建接收消息的线程
        System.Threading.Tasks.Task mtaskReceive;

        private void btnClientStart_Click(object sender, EventArgs e)
        {
            this.btnClientStart.Enabled = false;

            try
            {
                IPAddress ip = IPAddress.Parse(this.txtClientIP.Text.Trim());
                int port = Convert.ToInt32(this.txtClientPort.Text.Trim());

                // 连接服务端
                mTcpClient = new TcpClient();
                mTcpClient.Connect(ip, port); // 开始侦听

                string msg = "Client : Server Connected! Local:{0} --> Server:{1}".FormatWith
                (
                    mTcpClient.Client.LocalEndPoint,
                    mTcpClient.Client.RemoteEndPoint
                );
                System.Diagnostics.Debug.WriteLine(msg);


                //开启线程不停的接收服务端发送的数据
                mtaskReceive = new System.Threading.Tasks.Task(() => receive());
                mtaskReceive.ContinueWith((task) =>
                {
                    System.Diagnostics.Debug.WriteLine("client taskReceive finish");
                });

                mtaskReceive.Start();

                this.btnClientStop.Enabled = true;
            }
            catch (Exception ex)
            {
                // obj 
                mTcpClient = null;
                taskReceive = null;

                //
                MessageBox.Show(ex.GetFullInfo());
                this.btnClientStart.Enabled = true;
            }
        }

        //接收服务端消息的线程方法
        private void receive()
        {
            while (true)
            {
                try
                {
                    string str = mTcpClient.StandardReceive(); // 标准接收方式
                    this.Invoke(new Action(() =>
                    {
                        this.txtContent.Text = str;
                        this.btnScan_Click(this.btnScan, new EventArgs());
                    }));
                }
                catch (System.IO.IOException ioException)
                {
                    if (mTcpClient.Connected == false)
                    {
                        break;
                    }

                    string msg = "{0}".FormatWith(ioException.GetFullInfo());
                    System.Diagnostics.Debug.WriteLine(msg);

                    throw ioException;
                }
                catch (Exception ex)
                {
                    string msg = "{0}".FormatWith(ex.GetFullInfo());
                    System.Diagnostics.Debug.WriteLine(msg);
                }
            }
        }

        private void btnClientStop_Click(object sender, EventArgs e)
        {
            this.btnClientStop.Enabled = false;
            try
            {
                mTcpClient.Client.Close();

                this.btnClientStart.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetFullInfo());
                this.btnClientStop.Enabled = true;
            }
        }

        #endregion

        private void cbTopMost_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox tmpCheckBox = sender as CheckBox;
            this.TopMost = tmpCheckBox.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Util.ProgressUtils.ExcuteBatCMD($"start https://github.com/howesdomo/SerialPortSender");
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            mDataList = new List<DataModel>();
            dataGridView1.DataSource = mDataList;

            mDict = new Dictionary<string, DataModel>();
            dataGridViewDict.DataSource = new List<DataModel>();
        }
    }
}
