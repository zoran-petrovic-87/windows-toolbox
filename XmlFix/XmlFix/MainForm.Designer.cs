namespace ZoranXmlFix
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanelFix = new System.Windows.Forms.TableLayoutPanel();
            this.lblReplace = new System.Windows.Forms.Label();
            this.cbGenerateXsd = new System.Windows.Forms.CheckBox();
            this.cbPrettyPrint = new System.Windows.Forms.CheckBox();
            this.cbRemoveNonAsciiChars = new System.Windows.Forms.CheckBox();
            this.cbConvertNumbersWithExponents = new System.Windows.Forms.CheckBox();
            this.dgvReplaceInFiles = new System.Windows.Forms.DataGridView();
            this.colReplaceOldValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReplaceNewValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadReplaceInFilesValues = new System.Windows.Forms.Button();
            this.cbConvertToXmlCharacterReference = new System.Windows.Forms.CheckBox();
            this.cbRemoveInvalidXmlChars = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelFixProgress = new System.Windows.Forms.TableLayoutPanel();
            this.btnFixCancel = new System.Windows.Forms.Button();
            this.progressBarFix = new System.Windows.Forms.ProgressBar();
            this.btnFixRun = new System.Windows.Forms.Button();
            this.btnOpenXml = new System.Windows.Forms.Button();
            this.lblXml = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFix = new System.Windows.Forms.TabPage();
            this.tabPageJoin = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelJoin = new System.Windows.Forms.TableLayoutPanel();
            this.lblRootElement = new System.Windows.Forms.Label();
            this.txtRootElement = new System.Windows.Forms.TextBox();
            this.lblJoinRootAttributes = new System.Windows.Forms.Label();
            this.txtJoinRootAttributes = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelJoinProgress = new System.Windows.Forms.TableLayoutPanel();
            this.btnJoinCancel = new System.Windows.Forms.Button();
            this.progressBarJoin = new System.Windows.Forms.ProgressBar();
            this.btnJoinRun = new System.Windows.Forms.Button();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.txtAbout = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMainHead = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplaceInFiles)).BeginInit();
            this.tableLayoutPanelFixProgress.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageFix.SuspendLayout();
            this.tabPageJoin.SuspendLayout();
            this.tableLayoutPanelJoin.SuspendLayout();
            this.tableLayoutPanelJoinProgress.SuspendLayout();
            this.tpAbout.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelMainHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelFix
            // 
            this.tableLayoutPanelFix.ColumnCount = 1;
            this.tableLayoutPanelFix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFix.Controls.Add(this.lblReplace, 0, 8);
            this.tableLayoutPanelFix.Controls.Add(this.cbGenerateXsd, 0, 7);
            this.tableLayoutPanelFix.Controls.Add(this.cbPrettyPrint, 0, 6);
            this.tableLayoutPanelFix.Controls.Add(this.cbRemoveNonAsciiChars, 0, 5);
            this.tableLayoutPanelFix.Controls.Add(this.cbConvertNumbersWithExponents, 0, 4);
            this.tableLayoutPanelFix.Controls.Add(this.dgvReplaceInFiles, 0, 10);
            this.tableLayoutPanelFix.Controls.Add(this.btnLoadReplaceInFilesValues, 0, 9);
            this.tableLayoutPanelFix.Controls.Add(this.cbConvertToXmlCharacterReference, 0, 3);
            this.tableLayoutPanelFix.Controls.Add(this.cbRemoveInvalidXmlChars, 0, 2);
            this.tableLayoutPanelFix.Controls.Add(this.tableLayoutPanelFixProgress, 0, 12);
            this.tableLayoutPanelFix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFix.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanelFix.Name = "tableLayoutPanelFix";
            this.tableLayoutPanelFix.RowCount = 13;
            this.tableLayoutPanelFix.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFix.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFix.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFix.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFix.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFix.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFix.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFix.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFix.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFix.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanelFix.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFix.Size = new System.Drawing.Size(251, 361);
            this.tableLayoutPanelFix.TabIndex = 1;
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(2, 136);
            this.lblReplace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(82, 13);
            this.lblReplace.TabIndex = 11;
            this.lblReplace.Text = "Replace in files:";
            // 
            // cbGenerateXsd
            // 
            this.cbGenerateXsd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbGenerateXsd.AutoSize = true;
            this.cbGenerateXsd.Location = new System.Drawing.Point(3, 116);
            this.cbGenerateXsd.Name = "cbGenerateXsd";
            this.cbGenerateXsd.Size = new System.Drawing.Size(135, 17);
            this.cbGenerateXsd.TabIndex = 9;
            this.cbGenerateXsd.Text = "Generate XSD schema";
            this.cbGenerateXsd.UseVisualStyleBackColor = true;
            // 
            // cbPrettyPrint
            // 
            this.cbPrettyPrint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbPrettyPrint.AutoSize = true;
            this.cbPrettyPrint.Location = new System.Drawing.Point(3, 93);
            this.cbPrettyPrint.Name = "cbPrettyPrint";
            this.cbPrettyPrint.Size = new System.Drawing.Size(76, 17);
            this.cbPrettyPrint.TabIndex = 7;
            this.cbPrettyPrint.Text = "Pretty print";
            this.cbPrettyPrint.UseVisualStyleBackColor = true;
            // 
            // cbRemoveNonAsciiChars
            // 
            this.cbRemoveNonAsciiChars.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbRemoveNonAsciiChars.AutoSize = true;
            this.cbRemoveNonAsciiChars.Checked = true;
            this.cbRemoveNonAsciiChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemoveNonAsciiChars.Location = new System.Drawing.Point(3, 70);
            this.cbRemoveNonAsciiChars.Name = "cbRemoveNonAsciiChars";
            this.cbRemoveNonAsciiChars.Size = new System.Drawing.Size(146, 17);
            this.cbRemoveNonAsciiChars.TabIndex = 8;
            this.cbRemoveNonAsciiChars.Text = "Remove non-ASCII chars";
            this.cbRemoveNonAsciiChars.UseVisualStyleBackColor = true;
            // 
            // cbConvertNumbersWithExponents
            // 
            this.cbConvertNumbersWithExponents.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbConvertNumbersWithExponents.AutoSize = true;
            this.cbConvertNumbersWithExponents.Checked = true;
            this.cbConvertNumbersWithExponents.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbConvertNumbersWithExponents.Location = new System.Drawing.Point(3, 47);
            this.cbConvertNumbersWithExponents.Name = "cbConvertNumbersWithExponents";
            this.cbConvertNumbersWithExponents.Size = new System.Drawing.Size(180, 17);
            this.cbConvertNumbersWithExponents.TabIndex = 6;
            this.cbConvertNumbersWithExponents.Text = "Convert numbers with exponents";
            this.cbConvertNumbersWithExponents.UseVisualStyleBackColor = true;
            // 
            // dgvReplaceInFiles
            // 
            this.dgvReplaceInFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReplaceInFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReplaceInFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReplaceInFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReplaceOldValue,
            this.colReplaceNewValue});
            this.dgvReplaceInFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReplaceInFiles.Location = new System.Drawing.Point(2, 178);
            this.dgvReplaceInFiles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReplaceInFiles.Name = "dgvReplaceInFiles";
            this.dgvReplaceInFiles.RowTemplate.Height = 24;
            this.dgvReplaceInFiles.Size = new System.Drawing.Size(247, 130);
            this.dgvReplaceInFiles.TabIndex = 12;
            // 
            // colReplaceOldValue
            // 
            this.colReplaceOldValue.HeaderText = "Old value";
            this.colReplaceOldValue.Name = "colReplaceOldValue";
            // 
            // colReplaceNewValue
            // 
            this.colReplaceNewValue.HeaderText = "New value";
            this.colReplaceNewValue.Name = "colReplaceNewValue";
            // 
            // btnLoadReplaceInFilesValues
            // 
            this.btnLoadReplaceInFilesValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadReplaceInFilesValues.Location = new System.Drawing.Point(2, 151);
            this.btnLoadReplaceInFilesValues.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadReplaceInFilesValues.Name = "btnLoadReplaceInFilesValues";
            this.btnLoadReplaceInFilesValues.Size = new System.Drawing.Size(247, 23);
            this.btnLoadReplaceInFilesValues.TabIndex = 14;
            this.btnLoadReplaceInFilesValues.Text = "Load replace values from file (tab separated)";
            this.btnLoadReplaceInFilesValues.UseVisualStyleBackColor = true;
            this.btnLoadReplaceInFilesValues.Click += new System.EventHandler(this.btnLoadReplaceInFilesValues_Click);
            // 
            // cbConvertToXmlCharacterReference
            // 
            this.cbConvertToXmlCharacterReference.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbConvertToXmlCharacterReference.AutoSize = true;
            this.cbConvertToXmlCharacterReference.Checked = true;
            this.cbConvertToXmlCharacterReference.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbConvertToXmlCharacterReference.Location = new System.Drawing.Point(2, 25);
            this.cbConvertToXmlCharacterReference.Margin = new System.Windows.Forms.Padding(2);
            this.cbConvertToXmlCharacterReference.Name = "cbConvertToXmlCharacterReference";
            this.cbConvertToXmlCharacterReference.Size = new System.Drawing.Size(196, 17);
            this.cbConvertToXmlCharacterReference.TabIndex = 13;
            this.cbConvertToXmlCharacterReference.Text = "Convert to XML character reference";
            this.cbConvertToXmlCharacterReference.UseVisualStyleBackColor = true;
            // 
            // cbRemoveInvalidXmlChars
            // 
            this.cbRemoveInvalidXmlChars.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbRemoveInvalidXmlChars.AutoSize = true;
            this.cbRemoveInvalidXmlChars.Checked = true;
            this.cbRemoveInvalidXmlChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemoveInvalidXmlChars.Location = new System.Drawing.Point(3, 3);
            this.cbRemoveInvalidXmlChars.Name = "cbRemoveInvalidXmlChars";
            this.cbRemoveInvalidXmlChars.Size = new System.Drawing.Size(153, 17);
            this.cbRemoveInvalidXmlChars.TabIndex = 5;
            this.cbRemoveInvalidXmlChars.Text = "Remove invalid XML chars";
            this.cbRemoveInvalidXmlChars.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelFixProgress
            // 
            this.tableLayoutPanelFixProgress.AutoSize = true;
            this.tableLayoutPanelFixProgress.ColumnCount = 3;
            this.tableLayoutPanelFixProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFixProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFixProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFixProgress.Controls.Add(this.btnFixCancel, 2, 0);
            this.tableLayoutPanelFixProgress.Controls.Add(this.progressBarFix, 1, 0);
            this.tableLayoutPanelFixProgress.Controls.Add(this.btnFixRun, 0, 0);
            this.tableLayoutPanelFixProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFixProgress.Location = new System.Drawing.Point(3, 329);
            this.tableLayoutPanelFixProgress.Name = "tableLayoutPanelFixProgress";
            this.tableLayoutPanelFixProgress.RowCount = 1;
            this.tableLayoutPanelFixProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFixProgress.Size = new System.Drawing.Size(245, 29);
            this.tableLayoutPanelFixProgress.TabIndex = 15;
            // 
            // btnFixCancel
            // 
            this.btnFixCancel.AutoSize = true;
            this.btnFixCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFixCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFixCancel.Enabled = false;
            this.btnFixCancel.Location = new System.Drawing.Point(192, 3);
            this.btnFixCancel.Name = "btnFixCancel";
            this.btnFixCancel.Size = new System.Drawing.Size(50, 23);
            this.btnFixCancel.TabIndex = 5;
            this.btnFixCancel.Text = "Cancel";
            this.btnFixCancel.UseVisualStyleBackColor = true;
            this.btnFixCancel.Click += new System.EventHandler(this.btnFixCancel_Click);
            // 
            // progressBarFix
            // 
            this.progressBarFix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarFix.Location = new System.Drawing.Point(39, 3);
            this.progressBarFix.Name = "progressBarFix";
            this.progressBarFix.Size = new System.Drawing.Size(147, 23);
            this.progressBarFix.TabIndex = 4;
            // 
            // btnFixRun
            // 
            this.btnFixRun.AutoSize = true;
            this.btnFixRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFixRun.BackColor = System.Drawing.Color.Transparent;
            this.btnFixRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFixRun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFixRun.Location = new System.Drawing.Point(3, 3);
            this.btnFixRun.Name = "btnFixRun";
            this.btnFixRun.Size = new System.Drawing.Size(30, 23);
            this.btnFixRun.TabIndex = 2;
            this.btnFixRun.Text = "Fix";
            this.btnFixRun.UseVisualStyleBackColor = false;
            this.btnFixRun.Click += new System.EventHandler(this.btnFixRun_Click);
            // 
            // btnOpenXml
            // 
            this.btnOpenXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenXml.Location = new System.Drawing.Point(3, 3);
            this.btnOpenXml.Name = "btnOpenXml";
            this.btnOpenXml.Size = new System.Drawing.Size(257, 23);
            this.btnOpenXml.TabIndex = 3;
            this.btnOpenXml.Text = "Select XML folder";
            this.btnOpenXml.UseVisualStyleBackColor = true;
            this.btnOpenXml.Click += new System.EventHandler(this.btnOpenXml_Click);
            // 
            // lblXml
            // 
            this.lblXml.AutoSize = true;
            this.lblXml.ForeColor = System.Drawing.Color.Blue;
            this.lblXml.Location = new System.Drawing.Point(3, 29);
            this.lblXml.Name = "lblXml";
            this.lblXml.Size = new System.Drawing.Size(12, 13);
            this.lblXml.TabIndex = 4;
            this.lblXml.Text = "\\";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFix);
            this.tabControl1.Controls.Add(this.tabPageJoin);
            this.tabControl1.Controls.Add(this.tpAbout);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(2, 48);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(263, 391);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageFix
            // 
            this.tabPageFix.Controls.Add(this.tableLayoutPanelFix);
            this.tabPageFix.Location = new System.Drawing.Point(4, 22);
            this.tabPageFix.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageFix.Name = "tabPageFix";
            this.tabPageFix.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageFix.Size = new System.Drawing.Size(255, 365);
            this.tabPageFix.TabIndex = 0;
            this.tabPageFix.Text = "Fix";
            this.tabPageFix.UseVisualStyleBackColor = true;
            // 
            // tabPageJoin
            // 
            this.tabPageJoin.Controls.Add(this.tableLayoutPanelJoin);
            this.tabPageJoin.Location = new System.Drawing.Point(4, 22);
            this.tabPageJoin.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageJoin.Name = "tabPageJoin";
            this.tabPageJoin.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageJoin.Size = new System.Drawing.Size(255, 365);
            this.tabPageJoin.TabIndex = 1;
            this.tabPageJoin.Text = "Join";
            this.tabPageJoin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelJoin
            // 
            this.tableLayoutPanelJoin.AutoSize = true;
            this.tableLayoutPanelJoin.ColumnCount = 1;
            this.tableLayoutPanelJoin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelJoin.Controls.Add(this.lblRootElement, 0, 0);
            this.tableLayoutPanelJoin.Controls.Add(this.txtRootElement, 0, 1);
            this.tableLayoutPanelJoin.Controls.Add(this.lblJoinRootAttributes, 0, 2);
            this.tableLayoutPanelJoin.Controls.Add(this.txtJoinRootAttributes, 0, 3);
            this.tableLayoutPanelJoin.Controls.Add(this.tableLayoutPanelJoinProgress, 0, 6);
            this.tableLayoutPanelJoin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelJoin.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanelJoin.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelJoin.Name = "tableLayoutPanelJoin";
            this.tableLayoutPanelJoin.RowCount = 7;
            this.tableLayoutPanelJoin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelJoin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelJoin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelJoin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelJoin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelJoin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelJoin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelJoin.Size = new System.Drawing.Size(251, 361);
            this.tableLayoutPanelJoin.TabIndex = 11;
            // 
            // lblRootElement
            // 
            this.lblRootElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRootElement.AutoSize = true;
            this.lblRootElement.Location = new System.Drawing.Point(2, 0);
            this.lblRootElement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRootElement.Name = "lblRootElement";
            this.lblRootElement.Size = new System.Drawing.Size(247, 13);
            this.lblRootElement.TabIndex = 2;
            this.lblRootElement.Text = "Root element:";
            // 
            // txtRootElement
            // 
            this.txtRootElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRootElement.Location = new System.Drawing.Point(2, 15);
            this.txtRootElement.Margin = new System.Windows.Forms.Padding(2);
            this.txtRootElement.Name = "txtRootElement";
            this.txtRootElement.Size = new System.Drawing.Size(247, 20);
            this.txtRootElement.TabIndex = 1;
            this.txtRootElement.Text = "namespace.root";
            // 
            // lblJoinRootAttributes
            // 
            this.lblJoinRootAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJoinRootAttributes.AutoSize = true;
            this.lblJoinRootAttributes.Location = new System.Drawing.Point(2, 37);
            this.lblJoinRootAttributes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJoinRootAttributes.Name = "lblJoinRootAttributes";
            this.lblJoinRootAttributes.Size = new System.Drawing.Size(247, 13);
            this.lblJoinRootAttributes.TabIndex = 3;
            this.lblJoinRootAttributes.Text = "Root attributes:";
            // 
            // txtJoinRootAttributes
            // 
            this.txtJoinRootAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJoinRootAttributes.Location = new System.Drawing.Point(2, 52);
            this.txtJoinRootAttributes.Margin = new System.Windows.Forms.Padding(2);
            this.txtJoinRootAttributes.Name = "txtJoinRootAttributes";
            this.txtJoinRootAttributes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJoinRootAttributes.Size = new System.Drawing.Size(247, 20);
            this.txtJoinRootAttributes.TabIndex = 4;
            this.txtJoinRootAttributes.Text = "xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"";
            this.txtJoinRootAttributes.WordWrap = false;
            // 
            // tableLayoutPanelJoinProgress
            // 
            this.tableLayoutPanelJoinProgress.AutoSize = true;
            this.tableLayoutPanelJoinProgress.ColumnCount = 3;
            this.tableLayoutPanelJoinProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelJoinProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelJoinProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelJoinProgress.Controls.Add(this.btnJoinCancel, 2, 0);
            this.tableLayoutPanelJoinProgress.Controls.Add(this.progressBarJoin, 1, 0);
            this.tableLayoutPanelJoinProgress.Controls.Add(this.btnJoinRun, 0, 0);
            this.tableLayoutPanelJoinProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelJoinProgress.Location = new System.Drawing.Point(2, 332);
            this.tableLayoutPanelJoinProgress.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelJoinProgress.Name = "tableLayoutPanelJoinProgress";
            this.tableLayoutPanelJoinProgress.RowCount = 1;
            this.tableLayoutPanelJoinProgress.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelJoinProgress.Size = new System.Drawing.Size(247, 27);
            this.tableLayoutPanelJoinProgress.TabIndex = 5;
            // 
            // btnJoinCancel
            // 
            this.btnJoinCancel.AutoSize = true;
            this.btnJoinCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnJoinCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnJoinCancel.Enabled = false;
            this.btnJoinCancel.Location = new System.Drawing.Point(195, 2);
            this.btnJoinCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnJoinCancel.Name = "btnJoinCancel";
            this.btnJoinCancel.Size = new System.Drawing.Size(50, 23);
            this.btnJoinCancel.TabIndex = 1;
            this.btnJoinCancel.Text = "Cancel";
            this.btnJoinCancel.UseVisualStyleBackColor = true;
            this.btnJoinCancel.Click += new System.EventHandler(this.bwJoinCancel_Click);
            // 
            // progressBarJoin
            // 
            this.progressBarJoin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarJoin.Location = new System.Drawing.Point(63, 2);
            this.progressBarJoin.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarJoin.Name = "progressBarJoin";
            this.progressBarJoin.Size = new System.Drawing.Size(128, 23);
            this.progressBarJoin.TabIndex = 0;
            // 
            // btnJoinRun
            // 
            this.btnJoinRun.AutoSize = true;
            this.btnJoinRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnJoinRun.BackColor = System.Drawing.Color.Transparent;
            this.btnJoinRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnJoinRun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnJoinRun.Location = new System.Drawing.Point(2, 2);
            this.btnJoinRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnJoinRun.Name = "btnJoinRun";
            this.btnJoinRun.Size = new System.Drawing.Size(57, 23);
            this.btnJoinRun.TabIndex = 0;
            this.btnJoinRun.Text = "Join files";
            this.btnJoinRun.UseVisualStyleBackColor = false;
            this.btnJoinRun.Click += new System.EventHandler(this.btnJoinRun_Click);
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.txtAbout);
            this.tpAbout.Location = new System.Drawing.Point(4, 22);
            this.tpAbout.Margin = new System.Windows.Forms.Padding(2);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Padding = new System.Windows.Forms.Padding(2);
            this.tpAbout.Size = new System.Drawing.Size(255, 365);
            this.tpAbout.TabIndex = 2;
            this.tpAbout.Text = "About";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // txtAbout
            // 
            this.txtAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAbout.Location = new System.Drawing.Point(2, 2);
            this.txtAbout.Margin = new System.Windows.Forms.Padding(2);
            this.txtAbout.Multiline = true;
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAbout.Size = new System.Drawing.Size(251, 361);
            this.txtAbout.TabIndex = 1;
            this.txtAbout.Text = resources.GetString("txtAbout.Text");
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelMainHead, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(267, 441);
            this.tableLayoutPanelMain.TabIndex = 3;
            // 
            // tableLayoutPanelMainHead
            // 
            this.tableLayoutPanelMainHead.AutoSize = true;
            this.tableLayoutPanelMainHead.ColumnCount = 1;
            this.tableLayoutPanelMainHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMainHead.Controls.Add(this.lblXml, 0, 1);
            this.tableLayoutPanelMainHead.Controls.Add(this.btnOpenXml, 0, 0);
            this.tableLayoutPanelMainHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMainHead.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanelMainHead.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelMainHead.Name = "tableLayoutPanelMainHead";
            this.tableLayoutPanelMainHead.RowCount = 2;
            this.tableLayoutPanelMainHead.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMainHead.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMainHead.Size = new System.Drawing.Size(263, 42);
            this.tableLayoutPanelMainHead.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 441);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML Fix v1.1";
            this.tableLayoutPanelFix.ResumeLayout(false);
            this.tableLayoutPanelFix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplaceInFiles)).EndInit();
            this.tableLayoutPanelFixProgress.ResumeLayout(false);
            this.tableLayoutPanelFixProgress.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageFix.ResumeLayout(false);
            this.tabPageJoin.ResumeLayout(false);
            this.tabPageJoin.PerformLayout();
            this.tableLayoutPanelJoin.ResumeLayout(false);
            this.tableLayoutPanelJoin.PerformLayout();
            this.tableLayoutPanelJoinProgress.ResumeLayout(false);
            this.tableLayoutPanelJoinProgress.PerformLayout();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.tableLayoutPanelMainHead.ResumeLayout(false);
            this.tableLayoutPanelMainHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFix;
        private System.Windows.Forms.Button btnOpenXml;
        private System.Windows.Forms.Label lblXml;
        private System.Windows.Forms.CheckBox cbRemoveInvalidXmlChars;
        private System.Windows.Forms.CheckBox cbConvertNumbersWithExponents;
        private System.Windows.Forms.CheckBox cbPrettyPrint;
        private System.Windows.Forms.CheckBox cbRemoveNonAsciiChars;
        private System.Windows.Forms.Button btnFixRun;
        private System.Windows.Forms.CheckBox cbGenerateXsd;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.DataGridView dgvReplaceInFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReplaceOldValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReplaceNewValue;
        private System.Windows.Forms.CheckBox cbConvertToXmlCharacterReference;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFix;
        private System.Windows.Forms.TabPage tabPageJoin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelJoin;
        private System.Windows.Forms.Button btnJoinRun;
        private System.Windows.Forms.TextBox txtRootElement;
        private System.Windows.Forms.Label lblJoinRootAttributes;
        private System.Windows.Forms.TextBox txtJoinRootAttributes;
        private System.Windows.Forms.Label lblRootElement;
        private System.Windows.Forms.Button btnLoadReplaceInFilesValues;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainHead;
        private System.Windows.Forms.ProgressBar progressBarFix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFixProgress;
        private System.Windows.Forms.Button btnFixCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelJoinProgress;
        private System.Windows.Forms.ProgressBar progressBarJoin;
        private System.Windows.Forms.Button btnJoinCancel;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.TextBox txtAbout;
    }
}

