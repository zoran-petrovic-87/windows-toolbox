namespace KeyBot
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTimerInterval = new System.Windows.Forms.Label();
            this.txtTimerInterval = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblActiveWindowTitle = new System.Windows.Forms.Label();
            this.chkActiveWindowTitleIgnoreCase = new System.Windows.Forms.CheckBox();
            this.txtActiveWindowTitle = new System.Windows.Forms.TextBox();
            this.cboActiveWindowTitle = new System.Windows.Forms.ComboBox();
            this.chkSaveLogFile = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSendKeys = new System.Windows.Forms.Label();
            this.btnSendKeyInfo = new System.Windows.Forms.Button();
            this.dgvKeystrokes = new System.Windows.Forms.DataGridView();
            this.colKeystrokeToSend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.radCaptureImageNo = new System.Windows.Forms.RadioButton();
            this.radCaptureImageActiveWindow = new System.Windows.Forms.RadioButton();
            this.radCaptureImageFullSceen = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeystrokes)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkSaveLogFile, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(597, 342);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblTimerInterval, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTimerInterval, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(591, 26);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblTimerInterval
            // 
            this.lblTimerInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerInterval.AutoSize = true;
            this.lblTimerInterval.Location = new System.Drawing.Point(3, 6);
            this.lblTimerInterval.Name = "lblTimerInterval";
            this.lblTimerInterval.Size = new System.Drawing.Size(138, 13);
            this.lblTimerInterval.TabIndex = 0;
            this.lblTimerInterval.Text = "Timer interval [milliseconds]:";
            // 
            // txtTimerInterval
            // 
            this.txtTimerInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimerInterval.Location = new System.Drawing.Point(147, 3);
            this.txtTimerInterval.Name = "txtTimerInterval";
            this.txtTimerInterval.Size = new System.Drawing.Size(441, 20);
            this.txtTimerInterval.TabIndex = 1;
            this.txtTimerInterval.Text = "1000";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.lblActiveWindowTitle, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkActiveWindowTitleIgnoreCase, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtActiveWindowTitle, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cboActiveWindowTitle, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(591, 27);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lblActiveWindowTitle
            // 
            this.lblActiveWindowTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActiveWindowTitle.AutoSize = true;
            this.lblActiveWindowTitle.Location = new System.Drawing.Point(3, 7);
            this.lblActiveWindowTitle.Name = "lblActiveWindowTitle";
            this.lblActiveWindowTitle.Size = new System.Drawing.Size(198, 13);
            this.lblActiveWindowTitle.TabIndex = 0;
            this.lblActiveWindowTitle.Text = "Only send keys when active window title";
            // 
            // chkActiveWindowTitleIgnoreCase
            // 
            this.chkActiveWindowTitleIgnoreCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkActiveWindowTitleIgnoreCase.AutoSize = true;
            this.chkActiveWindowTitleIgnoreCase.Location = new System.Drawing.Point(506, 5);
            this.chkActiveWindowTitleIgnoreCase.Name = "chkActiveWindowTitleIgnoreCase";
            this.chkActiveWindowTitleIgnoreCase.Size = new System.Drawing.Size(82, 17);
            this.chkActiveWindowTitleIgnoreCase.TabIndex = 2;
            this.chkActiveWindowTitleIgnoreCase.Text = "Ignore case";
            this.chkActiveWindowTitleIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // txtActiveWindowTitle
            // 
            this.txtActiveWindowTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtActiveWindowTitle.Location = new System.Drawing.Point(413, 3);
            this.txtActiveWindowTitle.Name = "txtActiveWindowTitle";
            this.txtActiveWindowTitle.Size = new System.Drawing.Size(87, 20);
            this.txtActiveWindowTitle.TabIndex = 1;
            // 
            // cboActiveWindowTitle
            // 
            this.cboActiveWindowTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboActiveWindowTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActiveWindowTitle.FormattingEnabled = true;
            this.cboActiveWindowTitle.Items.AddRange(new object[] {
            "is equal to",
            "is not equal to",
            "contains",
            "starts with",
            "ends with"});
            this.cboActiveWindowTitle.Location = new System.Drawing.Point(207, 3);
            this.cboActiveWindowTitle.MinimumSize = new System.Drawing.Size(200, 0);
            this.cboActiveWindowTitle.Name = "cboActiveWindowTitle";
            this.cboActiveWindowTitle.Size = new System.Drawing.Size(200, 21);
            this.cboActiveWindowTitle.TabIndex = 3;
            // 
            // chkSaveLogFile
            // 
            this.chkSaveLogFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSaveLogFile.AutoSize = true;
            this.chkSaveLogFile.Checked = true;
            this.chkSaveLogFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveLogFile.Location = new System.Drawing.Point(3, 287);
            this.chkSaveLogFile.Name = "chkSaveLogFile";
            this.chkSaveLogFile.Size = new System.Drawing.Size(90, 17);
            this.chkSaveLogFile.TabIndex = 5;
            this.chkSaveLogFile.Text = "Create log file";
            this.chkSaveLogFile.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.btnStart, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnAbout, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnStop, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 310);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(591, 29);
            this.tableLayoutPanel7.TabIndex = 7;
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAbout.Location = new System.Drawing.Point(513, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(84, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dgvKeystrokes, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 68);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(591, 184);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.lblSendKeys, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnSendKeyInfo, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(585, 29);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // lblSendKeys
            // 
            this.lblSendKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSendKeys.AutoSize = true;
            this.lblSendKeys.Location = new System.Drawing.Point(3, 8);
            this.lblSendKeys.Name = "lblSendKeys";
            this.lblSendKeys.Size = new System.Drawing.Size(286, 13);
            this.lblSendKeys.TabIndex = 0;
            this.lblSendKeys.Text = "Send these keystrokes to the active application:";
            // 
            // btnSendKeyInfo
            // 
            this.btnSendKeyInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSendKeyInfo.Location = new System.Drawing.Point(507, 3);
            this.btnSendKeyInfo.Name = "btnSendKeyInfo";
            this.btnSendKeyInfo.Size = new System.Drawing.Size(75, 23);
            this.btnSendKeyInfo.TabIndex = 1;
            this.btnSendKeyInfo.Text = "Help";
            this.btnSendKeyInfo.UseVisualStyleBackColor = true;
            this.btnSendKeyInfo.Click += new System.EventHandler(this.btnSendKeyInfo_Click);
            // 
            // dgvKeystrokes
            // 
            this.dgvKeystrokes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKeystrokes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeystrokes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKeystrokeToSend});
            this.dgvKeystrokes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKeystrokes.Location = new System.Drawing.Point(3, 38);
            this.dgvKeystrokes.Name = "dgvKeystrokes";
            this.dgvKeystrokes.Size = new System.Drawing.Size(585, 143);
            this.dgvKeystrokes.TabIndex = 1;
            // 
            // colKeystrokeToSend
            // 
            this.colKeystrokeToSend.HeaderText = "Keystrokes to send";
            this.colKeystrokeToSend.Name = "colKeystrokeToSend";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 23);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.radCaptureImageNo, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.radCaptureImageActiveWindow, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.radCaptureImageFullSceen, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(591, 23);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // radCaptureImageNo
            // 
            this.radCaptureImageNo.AutoSize = true;
            this.radCaptureImageNo.Checked = true;
            this.radCaptureImageNo.Location = new System.Drawing.Point(3, 3);
            this.radCaptureImageNo.Name = "radCaptureImageNo";
            this.radCaptureImageNo.Size = new System.Drawing.Size(127, 17);
            this.radCaptureImageNo.TabIndex = 0;
            this.radCaptureImageNo.TabStop = true;
            this.radCaptureImageNo.Text = "Do not capture image";
            this.radCaptureImageNo.UseVisualStyleBackColor = true;
            // 
            // radCaptureImageActiveWindow
            // 
            this.radCaptureImageActiveWindow.AutoSize = true;
            this.radCaptureImageActiveWindow.Location = new System.Drawing.Point(255, 3);
            this.radCaptureImageActiveWindow.Name = "radCaptureImageActiveWindow";
            this.radCaptureImageActiveWindow.Size = new System.Drawing.Size(133, 17);
            this.radCaptureImageActiveWindow.TabIndex = 2;
            this.radCaptureImageActiveWindow.Text = "Capture active window";
            this.radCaptureImageActiveWindow.UseVisualStyleBackColor = true;
            // 
            // radCaptureImageFullSceen
            // 
            this.radCaptureImageFullSceen.AutoSize = true;
            this.radCaptureImageFullSceen.Location = new System.Drawing.Point(136, 3);
            this.radCaptureImageFullSceen.Name = "radCaptureImageFullSceen";
            this.radCaptureImageFullSceen.Size = new System.Drawing.Size(113, 17);
            this.radCaptureImageFullSceen.TabIndex = 1;
            this.radCaptureImageFullSceen.Text = "Capture full screen";
            this.radCaptureImageFullSceen.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 342);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "KeyBot";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeystrokes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTimerInterval;
        private System.Windows.Forms.TextBox txtTimerInterval;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblActiveWindowTitle;
        private System.Windows.Forms.TextBox txtActiveWindowTitle;
        private System.Windows.Forms.CheckBox chkActiveWindowTitleIgnoreCase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton radCaptureImageNo;
        private System.Windows.Forms.RadioButton radCaptureImageFullSceen;
        private System.Windows.Forms.RadioButton radCaptureImageActiveWindow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox cboActiveWindowTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkSaveLogFile;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblSendKeys;
        private System.Windows.Forms.Button btnSendKeyInfo;
        private System.Windows.Forms.DataGridView dgvKeystrokes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKeystrokeToSend;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnStop;
    }
}

