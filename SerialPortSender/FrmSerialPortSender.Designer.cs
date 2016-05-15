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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.cmbCom = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ckbSendContinue = new System.Windows.Forms.CheckBox();
            this.txtTimeSpan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIncreasing = new System.Windows.Forms.TextBox();
            this.ckbIncreasing = new System.Windows.Forms.CheckBox();
            this.ckbEndWithEnter = new System.Windows.Forms.CheckBox();
            this.ColumnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip_Status = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(10, 8);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "开启端口";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(101, 8);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "关闭端口";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(281, 9);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 103);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "发送";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(43, 46);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(227, 123);
            this.txtContent.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNo,
            this.Column1,
            this.Column3,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(10, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(525, 161);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(281, 146);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(75, 23);
            this.btnEmpty.TabIndex = 5;
            this.btnEmpty.Text = "清空";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // cmbCom
            // 
            this.cmbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(195, 9);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(75, 20);
            this.cmbCom.TabIndex = 6;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // ckbSendContinue
            // 
            this.ckbSendContinue.AutoSize = true;
            this.ckbSendContinue.Location = new System.Drawing.Point(16, 78);
            this.ckbSendContinue.Name = "ckbSendContinue";
            this.ckbSendContinue.Size = new System.Drawing.Size(72, 16);
            this.ckbSendContinue.TabIndex = 7;
            this.ckbSendContinue.Text = "持续发送";
            this.ckbSendContinue.UseVisualStyleBackColor = true;
            // 
            // txtTimeSpan
            // 
            this.txtTimeSpan.Location = new System.Drawing.Point(29, 46);
            this.txtTimeSpan.Name = "txtTimeSpan";
            this.txtTimeSpan.Size = new System.Drawing.Size(98, 21);
            this.txtTimeSpan.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "内容";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "间隔发送时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "ms";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtIncreasing);
            this.groupBox2.Controls.Add(this.ckbIncreasing);
            this.groupBox2.Controls.Add(this.ckbSendContinue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTimeSpan);
            this.groupBox2.Location = new System.Drawing.Point(367, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 157);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "持续发送";
            // 
            // txtIncreasing
            // 
            this.txtIncreasing.Location = new System.Drawing.Point(29, 129);
            this.txtIncreasing.Name = "txtIncreasing";
            this.txtIncreasing.Size = new System.Drawing.Size(98, 21);
            this.txtIncreasing.TabIndex = 13;
            // 
            // ckbIncreasing
            // 
            this.ckbIncreasing.AutoSize = true;
            this.ckbIncreasing.Location = new System.Drawing.Point(16, 104);
            this.ckbIncreasing.Name = "ckbIncreasing";
            this.ckbIncreasing.Size = new System.Drawing.Size(60, 16);
            this.ckbIncreasing.TabIndex = 13;
            this.ckbIncreasing.Text = "自增长";
            this.ckbIncreasing.UseVisualStyleBackColor = true;
            // 
            // ckbEndWithEnter
            // 
            this.ckbEndWithEnter.AutoSize = true;
            this.ckbEndWithEnter.Location = new System.Drawing.Point(281, 121);
            this.ckbEndWithEnter.Name = "ckbEndWithEnter";
            this.ckbEndWithEnter.Size = new System.Drawing.Size(72, 16);
            this.ckbEndWithEnter.TabIndex = 14;
            this.ckbEndWithEnter.Text = "结束换行";
            this.ckbEndWithEnter.UseVisualStyleBackColor = true;
            // 
            // ColumnNo
            // 
            this.ColumnNo.DataPropertyName = "No";
            this.ColumnNo.HeaderText = "No.";
            this.ColumnNo.Name = "ColumnNo";
            this.ColumnNo.Width = 40;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Status";
            this.Column1.HeaderText = "状态";
            this.Column1.Name = "Column1";
            this.Column1.Width = 36;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Date_Time";
            this.Column3.HeaderText = "日期-时间";
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Content";
            this.Column2.HeaderText = "内容";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // statusStrip_Status
            // 
            this.statusStrip_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip_Status.Location = new System.Drawing.Point(0, 339);
            this.statusStrip_Status.Name = "statusStrip_Status";
            this.statusStrip_Status.Size = new System.Drawing.Size(543, 22);
            this.statusStrip_Status.TabIndex = 15;
            this.statusStrip_Status.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmSerialPortSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 361);
            this.Controls.Add(this.statusStrip_Status);
            this.Controls.Add(this.ckbEndWithEnter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnOpen);
            this.Name = "FrmSerialPortSender";
            this.Text = "端口发送接收数据模拟";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip_Status.ResumeLayout(false);
            this.statusStrip_Status.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIncreasing;
        private System.Windows.Forms.CheckBox ckbIncreasing;
        private System.Windows.Forms.CheckBox ckbEndWithEnter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.StatusStrip statusStrip_Status;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}