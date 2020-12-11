namespace SerialPortSender
{
    partial class FrmSerialPortSender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSerialPortSender));
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEncoding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hexContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInputContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.cmbCom = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ckbSendContinue = new System.Windows.Forms.CheckBox();
            this.txtTimeSpan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIncreasing = new System.Windows.Forms.TextBox();
            this.ckbIncreasing = new System.Windows.Forms.CheckBox();
            this.statusStrip_Status = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReportHead_Hex = new System.Windows.Forms.TextBox();
            this.txtReportHead_ASCII = new System.Windows.Forms.TextBox();
            this.rbReportHead_UserSetting = new System.Windows.Forms.RadioButton();
            this.rbReportHead_STX = new System.Windows.Forms.RadioButton();
            this.rbReportHead_ESC = new System.Windows.Forms.RadioButton();
            this.rbReportHead_None = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbReportEnd_None = new System.Windows.Forms.RadioButton();
            this.rbReportEnd_ETX = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReportEnd_Hex = new System.Windows.Forms.TextBox();
            this.txtReportEnd_ASCII = new System.Windows.Forms.TextBox();
            this.rbReportEnd_CR_LF = new System.Windows.Forms.RadioButton();
            this.rbReportEnd_CR = new System.Windows.Forms.RadioButton();
            this.rbReportEnd_UserSetting = new System.Windows.Forms.RadioButton();
            this.cbExportLog = new System.Windows.Forms.CheckBox();
            this.txtThreadSleep_BeforeReadExsiting = new System.Windows.Forms.TextBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnResetSerialPort = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnServerStop = new System.Windows.Forms.Button();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.cmbServerIP = new System.Windows.Forms.ComboBox();
            this.cbSendEncoding = new System.Windows.Forms.ComboBox();
            this.cbReceiveEncoding = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnDictShow = new System.Windows.Forms.Button();
            this.btnDictHidden = new System.Windows.Forms.Button();
            this.dataGridViewDict = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2Encoding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2InputContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnClearList = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnClientStop = new System.Windows.Forms.Button();
            this.txtClientIP = new System.Windows.Forms.TextBox();
            this.btnClientStart = new System.Windows.Forms.Button();
            this.txtClientPort = new System.Windows.Forms.TextBox();
            this.tabServer = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbTopMost = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip_Status.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDict)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabClient.SuspendLayout();
            this.tabServer.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 9);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(87, 25);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "开启端口";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(118, 9);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(87, 25);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "关闭端口";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(328, 10);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(87, 142);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "发送";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // txtContent
            // 
            this.txtContent.AcceptsReturn = true;
            this.txtContent.AcceptsTab = true;
            this.txtContent.Location = new System.Drawing.Point(50, 50);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(264, 102);
            this.txtContent.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNo,
            this.Column1,
            this.Column3,
            this.colEncoding,
            this.Column2,
            this.hexContent,
            this.columnDateTime,
            this.colInputContent});
            this.dataGridView1.Location = new System.Drawing.Point(12, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(867, 257);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // ColumnNo
            // 
            this.ColumnNo.DataPropertyName = "No";
            this.ColumnNo.HeaderText = "No.";
            this.ColumnNo.MinimumWidth = 6;
            this.ColumnNo.Name = "ColumnNo";
            this.ColumnNo.ReadOnly = true;
            this.ColumnNo.Width = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Status";
            this.Column1.HeaderText = "状态";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DateTimeInfo";
            this.Column3.HeaderText = "日期时间";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 180;
            // 
            // colEncoding
            // 
            this.colEncoding.DataPropertyName = "Encoding";
            this.colEncoding.HeaderText = "编码格式";
            this.colEncoding.MinimumWidth = 6;
            this.colEncoding.Name = "colEncoding";
            this.colEncoding.ReadOnly = true;
            this.colEncoding.Width = 110;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Content";
            this.Column2.HeaderText = "内容 ( 包含报头与终端信息 )";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 230;
            // 
            // hexContent
            // 
            this.hexContent.DataPropertyName = "ContentByHex";
            this.hexContent.HeaderText = "Hex ( 包含报头与终端信息 )";
            this.hexContent.MinimumWidth = 6;
            this.hexContent.Name = "hexContent";
            this.hexContent.ReadOnly = true;
            this.hexContent.Width = 250;
            // 
            // columnDateTime
            // 
            this.columnDateTime.DataPropertyName = "DateTime";
            this.columnDateTime.HeaderText = "[隐藏]DateTime";
            this.columnDateTime.MinimumWidth = 6;
            this.columnDateTime.Name = "columnDateTime";
            this.columnDateTime.ReadOnly = true;
            this.columnDateTime.Visible = false;
            this.columnDateTime.Width = 110;
            // 
            // colInputContent
            // 
            this.colInputContent.DataPropertyName = "InputContent";
            this.colInputContent.HeaderText = "[隐藏]InputContent";
            this.colInputContent.MinimumWidth = 6;
            this.colInputContent.Name = "colInputContent";
            this.colInputContent.ReadOnly = true;
            this.colInputContent.Visible = false;
            this.colInputContent.Width = 110;
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(328, 158);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(87, 25);
            this.btnEmpty.TabIndex = 5;
            this.btnEmpty.Text = "清空";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // cmbCom
            // 
            this.cmbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(227, 10);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(87, 21);
            this.cmbCom.TabIndex = 6;
            this.cmbCom.SelectedValueChanged += new System.EventHandler(this.cmbCom_SelectedValueChanged);
            // 
            // ckbSendContinue
            // 
            this.ckbSendContinue.AutoSize = true;
            this.ckbSendContinue.Location = new System.Drawing.Point(9, 22);
            this.ckbSendContinue.Name = "ckbSendContinue";
            this.ckbSendContinue.Size = new System.Drawing.Size(54, 18);
            this.ckbSendContinue.TabIndex = 7;
            this.ckbSendContinue.Text = "启用";
            this.ckbSendContinue.UseVisualStyleBackColor = true;
            // 
            // txtTimeSpan
            // 
            this.txtTimeSpan.Location = new System.Drawing.Point(9, 98);
            this.txtTimeSpan.Name = "txtTimeSpan";
            this.txtTimeSpan.Size = new System.Drawing.Size(206, 22);
            this.txtTimeSpan.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "内容";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "间隔发送毫秒(ms)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIncreasing);
            this.groupBox2.Controls.Add(this.ckbIncreasing);
            this.groupBox2.Controls.Add(this.ckbSendContinue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTimeSpan);
            this.groupBox2.Location = new System.Drawing.Point(431, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 128);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "持续发送";
            // 
            // txtIncreasing
            // 
            this.txtIncreasing.Location = new System.Drawing.Point(76, 46);
            this.txtIncreasing.Name = "txtIncreasing";
            this.txtIncreasing.Size = new System.Drawing.Size(139, 22);
            this.txtIncreasing.TabIndex = 13;
            // 
            // ckbIncreasing
            // 
            this.ckbIncreasing.AutoSize = true;
            this.ckbIncreasing.Location = new System.Drawing.Point(9, 48);
            this.ckbIncreasing.Name = "ckbIncreasing";
            this.ckbIncreasing.Size = new System.Drawing.Size(68, 18);
            this.ckbIncreasing.TabIndex = 13;
            this.ckbIncreasing.Text = "自增长";
            this.ckbIncreasing.UseVisualStyleBackColor = true;
            // 
            // statusStrip_Status
            // 
            this.statusStrip_Status.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.statusStrip_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip_Status.Location = new System.Drawing.Point(0, 587);
            this.statusStrip_Status.Name = "statusStrip_Status";
            this.statusStrip_Status.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip_Status.Size = new System.Drawing.Size(888, 22);
            this.statusStrip_Status.TabIndex = 15;
            this.statusStrip_Status.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtReportHead_Hex);
            this.groupBox1.Controls.Add(this.txtReportHead_ASCII);
            this.groupBox1.Controls.Add(this.rbReportHead_UserSetting);
            this.groupBox1.Controls.Add(this.rbReportHead_STX);
            this.groupBox1.Controls.Add(this.rbReportHead_ESC);
            this.groupBox1.Controls.Add(this.rbReportHead_None);
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 130);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "报头";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "HEX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "ASCII";
            // 
            // txtReportHead_Hex
            // 
            this.txtReportHead_Hex.Location = new System.Drawing.Point(63, 102);
            this.txtReportHead_Hex.Name = "txtReportHead_Hex";
            this.txtReportHead_Hex.Size = new System.Drawing.Size(127, 22);
            this.txtReportHead_Hex.TabIndex = 6;
            // 
            // txtReportHead_ASCII
            // 
            this.txtReportHead_ASCII.Location = new System.Drawing.Point(63, 74);
            this.txtReportHead_ASCII.Name = "txtReportHead_ASCII";
            this.txtReportHead_ASCII.Size = new System.Drawing.Size(127, 22);
            this.txtReportHead_ASCII.TabIndex = 5;
            // 
            // rbReportHead_UserSetting
            // 
            this.rbReportHead_UserSetting.AutoSize = true;
            this.rbReportHead_UserSetting.Location = new System.Drawing.Point(75, 46);
            this.rbReportHead_UserSetting.Name = "rbReportHead_UserSetting";
            this.rbReportHead_UserSetting.Size = new System.Drawing.Size(67, 18);
            this.rbReportHead_UserSetting.TabIndex = 4;
            this.rbReportHead_UserSetting.TabStop = true;
            this.rbReportHead_UserSetting.Text = "自定义";
            this.rbReportHead_UserSetting.UseVisualStyleBackColor = true;
            // 
            // rbReportHead_STX
            // 
            this.rbReportHead_STX.AutoSize = true;
            this.rbReportHead_STX.Location = new System.Drawing.Point(75, 21);
            this.rbReportHead_STX.Name = "rbReportHead_STX";
            this.rbReportHead_STX.Size = new System.Drawing.Size(46, 18);
            this.rbReportHead_STX.TabIndex = 3;
            this.rbReportHead_STX.TabStop = true;
            this.rbReportHead_STX.Text = "STX";
            this.rbReportHead_STX.UseVisualStyleBackColor = true;
            // 
            // rbReportHead_ESC
            // 
            this.rbReportHead_ESC.AutoSize = true;
            this.rbReportHead_ESC.Location = new System.Drawing.Point(6, 46);
            this.rbReportHead_ESC.Name = "rbReportHead_ESC";
            this.rbReportHead_ESC.Size = new System.Drawing.Size(46, 18);
            this.rbReportHead_ESC.TabIndex = 2;
            this.rbReportHead_ESC.TabStop = true;
            this.rbReportHead_ESC.Text = "ESC";
            this.rbReportHead_ESC.UseVisualStyleBackColor = true;
            // 
            // rbReportHead_None
            // 
            this.rbReportHead_None.AutoSize = true;
            this.rbReportHead_None.Location = new System.Drawing.Point(6, 21);
            this.rbReportHead_None.Name = "rbReportHead_None";
            this.rbReportHead_None.Size = new System.Drawing.Size(39, 18);
            this.rbReportHead_None.TabIndex = 1;
            this.rbReportHead_None.TabStop = true;
            this.rbReportHead_None.Text = "无";
            this.rbReportHead_None.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbReportEnd_None);
            this.groupBox3.Controls.Add(this.rbReportEnd_ETX);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtReportEnd_Hex);
            this.groupBox3.Controls.Add(this.txtReportEnd_ASCII);
            this.groupBox3.Controls.Add(this.rbReportEnd_CR_LF);
            this.groupBox3.Controls.Add(this.rbReportEnd_CR);
            this.groupBox3.Controls.Add(this.rbReportEnd_UserSetting);
            this.groupBox3.Location = new System.Drawing.Point(224, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 130);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "终端";
            // 
            // rbReportEnd_None
            // 
            this.rbReportEnd_None.AutoSize = true;
            this.rbReportEnd_None.Location = new System.Drawing.Point(80, 46);
            this.rbReportEnd_None.Name = "rbReportEnd_None";
            this.rbReportEnd_None.Size = new System.Drawing.Size(39, 18);
            this.rbReportEnd_None.TabIndex = 12;
            this.rbReportEnd_None.TabStop = true;
            this.rbReportEnd_None.Text = "无";
            this.rbReportEnd_None.UseVisualStyleBackColor = true;
            // 
            // rbReportEnd_ETX
            // 
            this.rbReportEnd_ETX.AutoSize = true;
            this.rbReportEnd_ETX.Location = new System.Drawing.Point(101, 21);
            this.rbReportEnd_ETX.Name = "rbReportEnd_ETX";
            this.rbReportEnd_ETX.Size = new System.Drawing.Size(46, 18);
            this.rbReportEnd_ETX.TabIndex = 10;
            this.rbReportEnd_ETX.TabStop = true;
            this.rbReportEnd_ETX.Text = "ETX";
            this.rbReportEnd_ETX.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "HEX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "ASCII";
            // 
            // txtReportEnd_Hex
            // 
            this.txtReportEnd_Hex.Location = new System.Drawing.Point(46, 102);
            this.txtReportEnd_Hex.Name = "txtReportEnd_Hex";
            this.txtReportEnd_Hex.Size = new System.Drawing.Size(142, 22);
            this.txtReportEnd_Hex.TabIndex = 3;
            // 
            // txtReportEnd_ASCII
            // 
            this.txtReportEnd_ASCII.Location = new System.Drawing.Point(46, 74);
            this.txtReportEnd_ASCII.Name = "txtReportEnd_ASCII";
            this.txtReportEnd_ASCII.Size = new System.Drawing.Size(142, 22);
            this.txtReportEnd_ASCII.TabIndex = 2;
            // 
            // rbReportEnd_CR_LF
            // 
            this.rbReportEnd_CR_LF.AutoSize = true;
            this.rbReportEnd_CR_LF.Location = new System.Drawing.Point(6, 46);
            this.rbReportEnd_CR_LF.Name = "rbReportEnd_CR_LF";
            this.rbReportEnd_CR_LF.Size = new System.Drawing.Size(60, 18);
            this.rbReportEnd_CR_LF.TabIndex = 1;
            this.rbReportEnd_CR_LF.TabStop = true;
            this.rbReportEnd_CR_LF.Text = "CR+LF";
            this.rbReportEnd_CR_LF.UseVisualStyleBackColor = true;
            // 
            // rbReportEnd_CR
            // 
            this.rbReportEnd_CR.AutoSize = true;
            this.rbReportEnd_CR.Location = new System.Drawing.Point(6, 21);
            this.rbReportEnd_CR.Name = "rbReportEnd_CR";
            this.rbReportEnd_CR.Size = new System.Drawing.Size(39, 18);
            this.rbReportEnd_CR.TabIndex = 0;
            this.rbReportEnd_CR.TabStop = true;
            this.rbReportEnd_CR.Text = "CR";
            this.rbReportEnd_CR.UseVisualStyleBackColor = true;
            // 
            // rbReportEnd_UserSetting
            // 
            this.rbReportEnd_UserSetting.AutoSize = true;
            this.rbReportEnd_UserSetting.Location = new System.Drawing.Point(129, 47);
            this.rbReportEnd_UserSetting.Name = "rbReportEnd_UserSetting";
            this.rbReportEnd_UserSetting.Size = new System.Drawing.Size(67, 18);
            this.rbReportEnd_UserSetting.TabIndex = 11;
            this.rbReportEnd_UserSetting.TabStop = true;
            this.rbReportEnd_UserSetting.Text = "自定义";
            this.rbReportEnd_UserSetting.UseVisualStyleBackColor = true;
            // 
            // cbExportLog
            // 
            this.cbExportLog.AutoSize = true;
            this.cbExportLog.Location = new System.Drawing.Point(614, 65);
            this.cbExportLog.Name = "cbExportLog";
            this.cbExportLog.Size = new System.Drawing.Size(82, 18);
            this.cbExportLog.TabIndex = 18;
            this.cbExportLog.Text = "记录数据";
            this.cbExportLog.UseVisualStyleBackColor = true;
            // 
            // txtThreadSleep_BeforeReadExsiting
            // 
            this.txtThreadSleep_BeforeReadExsiting.Location = new System.Drawing.Point(13, 22);
            this.txtThreadSleep_BeforeReadExsiting.Name = "txtThreadSleep_BeforeReadExsiting";
            this.txtThreadSleep_BeforeReadExsiting.Size = new System.Drawing.Size(124, 22);
            this.txtThreadSleep_BeforeReadExsiting.TabIndex = 19;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(76, 21);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(87, 21);
            this.cbBaudRate.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnResetSerialPort);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cbStopBits);
            this.groupBox4.Controls.Add(this.cbParity);
            this.groupBox4.Controls.Add(this.cbDataBits);
            this.groupBox4.Controls.Add(this.cbBaudRate);
            this.groupBox4.Location = new System.Drawing.Point(431, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 170);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "串口设置";
            // 
            // btnResetSerialPort
            // 
            this.btnResetSerialPort.Location = new System.Drawing.Point(12, 140);
            this.btnResetSerialPort.Name = "btnResetSerialPort";
            this.btnResetSerialPort.Size = new System.Drawing.Size(151, 25);
            this.btnResetSerialPort.TabIndex = 23;
            this.btnResetSerialPort.Text = "重置";
            this.btnResetSerialPort.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 14);
            this.label12.TabIndex = 28;
            this.label12.Text = "停止位";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 14);
            this.label11.TabIndex = 27;
            this.label11.Text = "奇偶校验";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 14);
            this.label10.TabIndex = 26;
            this.label10.Text = "数据位";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 14);
            this.label9.TabIndex = 25;
            this.label9.Text = "波特率";
            // 
            // cbStopBits
            // 
            this.cbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Location = new System.Drawing.Point(76, 111);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(87, 21);
            this.cbStopBits.TabIndex = 24;
            // 
            // cbParity
            // 
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(76, 81);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(87, 21);
            this.cbParity.TabIndex = 23;
            // 
            // cbDataBits
            // 
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Location = new System.Drawing.Point(76, 50);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(87, 21);
            this.cbDataBits.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 14);
            this.label14.TabIndex = 27;
            this.label14.Text = "端口";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 14);
            this.label13.TabIndex = 26;
            this.label13.Text = "IP";
            // 
            // btnServerStop
            // 
            this.btnServerStop.Enabled = false;
            this.btnServerStop.Location = new System.Drawing.Point(105, 68);
            this.btnServerStop.Name = "btnServerStop";
            this.btnServerStop.Size = new System.Drawing.Size(77, 25);
            this.btnServerStop.TabIndex = 25;
            this.btnServerStop.Text = "停止";
            this.btnServerStop.UseVisualStyleBackColor = true;
            // 
            // btnServerStart
            // 
            this.btnServerStart.Location = new System.Drawing.Point(6, 68);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(77, 25);
            this.btnServerStart.TabIndex = 24;
            this.btnServerStart.Text = "开始";
            this.btnServerStart.UseVisualStyleBackColor = true;
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(68, 33);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(114, 22);
            this.txtServerPort.TabIndex = 14;
            this.txtServerPort.Text = "48001";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(68, 5);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(114, 22);
            this.txtServerIP.TabIndex = 9;
            this.txtServerIP.Text = "127.0.0.1";
            // 
            // cmbServerIP
            // 
            this.cmbServerIP.DisplayMember = "DisplayName";
            this.cmbServerIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServerIP.DropDownWidth = 200;
            this.cmbServerIP.FormattingEnabled = true;
            this.cmbServerIP.Location = new System.Drawing.Point(69, 6);
            this.cmbServerIP.Name = "cmbServerIP";
            this.cmbServerIP.Size = new System.Drawing.Size(135, 21);
            this.cmbServerIP.TabIndex = 28;
            this.cmbServerIP.SelectedIndexChanged += new System.EventHandler(this.cmbServerIP_SelectedIndexChanged);
            // 
            // cbSendEncoding
            // 
            this.cbSendEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSendEncoding.FormattingEnabled = true;
            this.cbSendEncoding.Location = new System.Drawing.Point(52, 160);
            this.cbSendEncoding.Name = "cbSendEncoding";
            this.cbSendEncoding.Size = new System.Drawing.Size(102, 21);
            this.cbSendEncoding.TabIndex = 25;
            // 
            // cbReceiveEncoding
            // 
            this.cbReceiveEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReceiveEncoding.FormattingEnabled = true;
            this.cbReceiveEncoding.Location = new System.Drawing.Point(212, 160);
            this.cbReceiveEncoding.Name = "cbReceiveEncoding";
            this.cbReceiveEncoding.Size = new System.Drawing.Size(102, 21);
            this.cbReceiveEncoding.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(172, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 14);
            this.label15.TabIndex = 27;
            this.label15.Text = "接收";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 14);
            this.label16.TabIndex = 28;
            this.label16.Text = "发送";
            // 
            // btnDictShow
            // 
            this.btnDictShow.Location = new System.Drawing.Point(9, 22);
            this.btnDictShow.Name = "btnDictShow";
            this.btnDictShow.Size = new System.Drawing.Size(94, 25);
            this.btnDictShow.TabIndex = 28;
            this.btnDictShow.Text = "去除重复";
            this.btnDictShow.UseVisualStyleBackColor = true;
            // 
            // btnDictHidden
            // 
            this.btnDictHidden.Location = new System.Drawing.Point(9, 50);
            this.btnDictHidden.Name = "btnDictHidden";
            this.btnDictHidden.Size = new System.Drawing.Size(94, 25);
            this.btnDictHidden.TabIndex = 29;
            this.btnDictHidden.Text = "显示全部";
            this.btnDictHidden.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDict
            // 
            this.dataGridViewDict.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDict.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.colDateTime,
            this.col2Encoding,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.col2InputContent});
            this.dataGridViewDict.Location = new System.Drawing.Point(12, 325);
            this.dataGridViewDict.Name = "dataGridViewDict";
            this.dataGridViewDict.ReadOnly = true;
            this.dataGridViewDict.RowHeadersVisible = false;
            this.dataGridViewDict.RowHeadersWidth = 45;
            this.dataGridViewDict.RowTemplate.Height = 23;
            this.dataGridViewDict.Size = new System.Drawing.Size(867, 257);
            this.dataGridViewDict.TabIndex = 30;
            this.dataGridViewDict.Visible = false;
            this.dataGridViewDict.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDict_CellMouseDoubleClick);
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            this.colNo.HeaderText = "[隐藏]No.";
            this.colNo.MinimumWidth = 6;
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Visible = false;
            this.colNo.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn2.HeaderText = "状态";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateTimeInfo";
            this.dataGridViewTextBoxColumn3.HeaderText = "日期时间";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 180;
            // 
            // colDateTime
            // 
            this.colDateTime.DataPropertyName = "DateTime";
            this.colDateTime.HeaderText = "[隐藏]DateTime";
            this.colDateTime.MinimumWidth = 6;
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.ReadOnly = true;
            this.colDateTime.Visible = false;
            this.colDateTime.Width = 110;
            // 
            // col2Encoding
            // 
            this.col2Encoding.DataPropertyName = "Encoding";
            this.col2Encoding.HeaderText = "[隐藏]Encoding";
            this.col2Encoding.MinimumWidth = 6;
            this.col2Encoding.Name = "col2Encoding";
            this.col2Encoding.ReadOnly = true;
            this.col2Encoding.Visible = false;
            this.col2Encoding.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Content";
            this.dataGridViewTextBoxColumn4.HeaderText = "内容 ( 包含报头与终端信息 )";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 230;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ContentByHex";
            this.dataGridViewTextBoxColumn5.HeaderText = "Hex ( 包含报头与终端信息 )";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // col2InputContent
            // 
            this.col2InputContent.DataPropertyName = "InputContent";
            this.col2InputContent.HeaderText = "[隐藏]InputContent";
            this.col2InputContent.MinimumWidth = 6;
            this.col2InputContent.Name = "col2InputContent";
            this.col2InputContent.ReadOnly = true;
            this.col2InputContent.Visible = false;
            this.col2InputContent.Width = 110;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnClearList);
            this.groupBox6.Controls.Add(this.btnDictShow);
            this.groupBox6.Controls.Add(this.btnDictHidden);
            this.groupBox6.Location = new System.Drawing.Point(768, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(109, 168);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "列表信息";
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(9, 137);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(94, 25);
            this.btnClearList.TabIndex = 30;
            this.btnClearList.Text = "清空列表";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabClient);
            this.tabControl1.Controls.Add(this.tabServer);
            this.tabControl1.Location = new System.Drawing.Point(661, 191);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(220, 130);
            this.tabControl1.TabIndex = 33;
            // 
            // tabClient
            // 
            this.tabClient.BackColor = System.Drawing.SystemColors.Control;
            this.tabClient.Controls.Add(this.label17);
            this.tabClient.Controls.Add(this.label18);
            this.tabClient.Controls.Add(this.btnClientStop);
            this.tabClient.Controls.Add(this.txtClientIP);
            this.tabClient.Controls.Add(this.btnClientStart);
            this.tabClient.Controls.Add(this.txtClientPort);
            this.tabClient.Location = new System.Drawing.Point(4, 23);
            this.tabClient.Name = "tabClient";
            this.tabClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabClient.Size = new System.Drawing.Size(212, 103);
            this.tabClient.TabIndex = 0;
            this.tabClient.Text = "Client";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 14);
            this.label17.TabIndex = 33;
            this.label17.Text = "端口";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 14);
            this.label18.TabIndex = 32;
            this.label18.Text = "IP";
            // 
            // btnClientStop
            // 
            this.btnClientStop.Enabled = false;
            this.btnClientStop.Location = new System.Drawing.Point(105, 68);
            this.btnClientStop.Name = "btnClientStop";
            this.btnClientStop.Size = new System.Drawing.Size(77, 25);
            this.btnClientStop.TabIndex = 31;
            this.btnClientStop.Text = "停止";
            this.btnClientStop.UseVisualStyleBackColor = true;
            this.btnClientStop.Click += new System.EventHandler(this.btnClientStop_Click);
            // 
            // txtClientIP
            // 
            this.txtClientIP.Location = new System.Drawing.Point(68, 5);
            this.txtClientIP.Name = "txtClientIP";
            this.txtClientIP.Size = new System.Drawing.Size(114, 22);
            this.txtClientIP.TabIndex = 28;
            // 
            // btnClientStart
            // 
            this.btnClientStart.Location = new System.Drawing.Point(6, 68);
            this.btnClientStart.Name = "btnClientStart";
            this.btnClientStart.Size = new System.Drawing.Size(77, 25);
            this.btnClientStart.TabIndex = 30;
            this.btnClientStart.Text = "开始";
            this.btnClientStart.UseVisualStyleBackColor = true;
            this.btnClientStart.Click += new System.EventHandler(this.btnClientStart_Click);
            // 
            // txtClientPort
            // 
            this.txtClientPort.Location = new System.Drawing.Point(68, 33);
            this.txtClientPort.Name = "txtClientPort";
            this.txtClientPort.Size = new System.Drawing.Size(114, 22);
            this.txtClientPort.TabIndex = 29;
            // 
            // tabServer
            // 
            this.tabServer.BackColor = System.Drawing.SystemColors.Control;
            this.tabServer.Controls.Add(this.label14);
            this.tabServer.Controls.Add(this.label13);
            this.tabServer.Controls.Add(this.btnServerStop);
            this.tabServer.Controls.Add(this.txtServerIP);
            this.tabServer.Controls.Add(this.btnServerStart);
            this.tabServer.Controls.Add(this.txtServerPort);
            this.tabServer.Controls.Add(this.cmbServerIP);
            this.tabServer.Location = new System.Drawing.Point(4, 23);
            this.tabServer.Name = "tabServer";
            this.tabServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabServer.Size = new System.Drawing.Size(212, 103);
            this.tabServer.TabIndex = 1;
            this.tabServer.Text = "Server(特殊规则)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtThreadSleep_BeforeReadExsiting);
            this.groupBox5.Location = new System.Drawing.Point(614, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(148, 50);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "接收等待时间(毫秒)";
            // 
            // cbTopMost
            // 
            this.cbTopMost.AutoSize = true;
            this.cbTopMost.Location = new System.Drawing.Point(614, 89);
            this.cbTopMost.Name = "cbTopMost";
            this.cbTopMost.Size = new System.Drawing.Size(82, 18);
            this.cbTopMost.TabIndex = 35;
            this.cbTopMost.Text = "窗口置顶";
            this.cbTopMost.UseVisualStyleBackColor = true;
            this.cbTopMost.CheckedChanged += new System.EventHandler(this.cbTopMost_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(614, 167);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(147, 14);
            this.linkLabel1.TabIndex = 37;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "github.com/howesdomo";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmSerialPortSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 609);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cbTopMost);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.dataGridViewDict);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbReceiveEncoding);
            this.Controls.Add(this.cbSendEncoding);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.cbExportLog);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip_Status);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSerialPortSender";
            this.Text = "端口发送接收数据模拟";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip_Status.ResumeLayout(false);
            this.statusStrip_Status.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDict)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabClient.ResumeLayout(false);
            this.tabClient.PerformLayout();
            this.tabServer.ResumeLayout(false);
            this.tabServer.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.ComboBox cmbCom;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox ckbSendContinue;
        private System.Windows.Forms.TextBox txtTimeSpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIncreasing;
        private System.Windows.Forms.CheckBox ckbIncreasing;
        private System.Windows.Forms.StatusStrip statusStrip_Status;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReportHead_Hex;
        private System.Windows.Forms.TextBox txtReportHead_ASCII;
        private System.Windows.Forms.RadioButton rbReportHead_UserSetting;
        private System.Windows.Forms.RadioButton rbReportHead_STX;
        private System.Windows.Forms.RadioButton rbReportHead_ESC;
        private System.Windows.Forms.RadioButton rbReportHead_None;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbReportEnd_UserSetting;
        private System.Windows.Forms.RadioButton rbReportEnd_ETX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReportEnd_Hex;
        private System.Windows.Forms.TextBox txtReportEnd_ASCII;
        private System.Windows.Forms.RadioButton rbReportEnd_CR_LF;
        private System.Windows.Forms.RadioButton rbReportEnd_CR;
        private System.Windows.Forms.CheckBox cbExportLog;
        private System.Windows.Forms.TextBox txtThreadSleep_BeforeReadExsiting;
        private System.Windows.Forms.RadioButton rbReportEnd_None;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.Button btnResetSerialPort;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnServerStop;
        private System.Windows.Forms.Button btnServerStart;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.ComboBox cbSendEncoding;
        private System.Windows.Forms.ComboBox cbReceiveEncoding;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnDictShow;
        private System.Windows.Forms.Button btnDictHidden;
        private System.Windows.Forms.DataGridView dataGridViewDict;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmbServerIP;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.TabPage tabServer;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnClientStop;
        private System.Windows.Forms.TextBox txtClientIP;
        private System.Windows.Forms.Button btnClientStart;
        private System.Windows.Forms.TextBox txtClientPort;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbTopMost;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEncoding;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hexContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInputContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2Encoding;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2InputContent;
        private System.Windows.Forms.Button btnClearList;
    }
}