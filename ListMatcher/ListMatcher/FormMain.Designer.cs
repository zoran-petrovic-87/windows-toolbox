namespace ListMatcher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblList1 = new System.Windows.Forms.Label();
            this.dgvList1 = new System.Windows.Forms.DataGridView();
            this.colList1Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colList1Metadata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblList2 = new System.Windows.Forms.Label();
            this.dgvList2 = new System.Windows.Forms.DataGridView();
            this.colList2Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colList2Metadata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblResult = new System.Windows.Forms.Label();
            this.dgvListResult = new System.Windows.Forms.DataGridView();
            this.colListResultList1Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListResultList1Metadata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListResultList2Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListResultList2Metadata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNotFoundValue = new System.Windows.Forms.Label();
            this.txtNotFoundValue = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkIgnoreTextCase = new System.Windows.Forms.CheckBox();
            this.lblFindDesc = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRun = new System.Windows.Forms.Button();
            this.tsmiImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTsvToList1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTsvToList2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExportResultToTsv = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearList1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearList2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearResult = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList2)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListResult)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.splitContainer1.Size = new System.Drawing.Size(627, 261);
            this.splitContainer1.SplitterDistance = 128;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer2.Size = new System.Drawing.Size(627, 128);
            this.splitContainer2.SplitterDistance = 302;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblList1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvList1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(302, 128);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblList1
            // 
            this.lblList1.AutoSize = true;
            this.lblList1.Location = new System.Drawing.Point(2, 0);
            this.lblList1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblList1.Name = "lblList1";
            this.lblList1.Size = new System.Drawing.Size(32, 13);
            this.lblList1.TabIndex = 0;
            this.lblList1.Text = "List 1";
            // 
            // dgvList1
            // 
            this.dgvList1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvList1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colList1Value,
            this.colList1Metadata});
            this.dgvList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList1.Location = new System.Drawing.Point(2, 15);
            this.dgvList1.Margin = new System.Windows.Forms.Padding(2);
            this.dgvList1.Name = "dgvList1";
            this.dgvList1.RowTemplate.Height = 24;
            this.dgvList1.Size = new System.Drawing.Size(298, 111);
            this.dgvList1.TabIndex = 1;
            // 
            // colList1Value
            // 
            this.colList1Value.HeaderText = "Value";
            this.colList1Value.Name = "colList1Value";
            // 
            // colList1Metadata
            // 
            this.colList1Metadata.HeaderText = "Metadata";
            this.colList1Metadata.Name = "colList1Metadata";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblList2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgvList2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(322, 128);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblList2
            // 
            this.lblList2.AutoSize = true;
            this.lblList2.Location = new System.Drawing.Point(2, 0);
            this.lblList2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblList2.Name = "lblList2";
            this.lblList2.Size = new System.Drawing.Size(32, 13);
            this.lblList2.TabIndex = 0;
            this.lblList2.Text = "List 2";
            // 
            // dgvList2
            // 
            this.dgvList2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colList2Value,
            this.colList2Metadata});
            this.dgvList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList2.Location = new System.Drawing.Point(2, 15);
            this.dgvList2.Margin = new System.Windows.Forms.Padding(2);
            this.dgvList2.Name = "dgvList2";
            this.dgvList2.RowTemplate.Height = 24;
            this.dgvList2.Size = new System.Drawing.Size(318, 111);
            this.dgvList2.TabIndex = 1;
            // 
            // colList2Value
            // 
            this.colList2Value.HeaderText = "Value";
            this.colList2Value.Name = "colList2Value";
            // 
            // colList2Metadata
            // 
            this.colList2Metadata.HeaderText = "Metadata";
            this.colList2Metadata.Name = "colList2Metadata";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lblResult, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dgvListResult, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(627, 130);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(2, 0);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Result";
            // 
            // dgvListResult
            // 
            this.dgvListResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colListResultList1Value,
            this.colListResultList1Metadata,
            this.colListResultList2Value,
            this.colListResultList2Metadata});
            this.dgvListResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListResult.Location = new System.Drawing.Point(2, 15);
            this.dgvListResult.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListResult.Name = "dgvListResult";
            this.dgvListResult.RowTemplate.Height = 24;
            this.dgvListResult.Size = new System.Drawing.Size(623, 113);
            this.dgvListResult.TabIndex = 1;
            // 
            // colListResultList1Value
            // 
            this.colListResultList1Value.HeaderText = "List 1 value";
            this.colListResultList1Value.Name = "colListResultList1Value";
            // 
            // colListResultList1Metadata
            // 
            this.colListResultList1Metadata.HeaderText = "List 1 metadata";
            this.colListResultList1Metadata.Name = "colListResultList1Metadata";
            // 
            // colListResultList2Value
            // 
            this.colListResultList2Value.HeaderText = "List 2 value";
            this.colListResultList2Value.Name = "colListResultList2Value";
            // 
            // colListResultList2Metadata
            // 
            this.colListResultList2Metadata.HeaderText = "List 2 metadata";
            this.colListResultList2Metadata.Name = "colListResultList2Metadata";
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(631, 356);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.lblNotFoundValue, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtNotFoundValue, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 267);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(627, 24);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // lblNotFoundValue
            // 
            this.lblNotFoundValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNotFoundValue.AutoSize = true;
            this.lblNotFoundValue.Location = new System.Drawing.Point(2, 5);
            this.lblNotFoundValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotFoundValue.Name = "lblNotFoundValue";
            this.lblNotFoundValue.Size = new System.Drawing.Size(100, 13);
            this.lblNotFoundValue.TabIndex = 0;
            this.lblNotFoundValue.Text = "Value for not found:";
            // 
            // txtNotFoundValue
            // 
            this.txtNotFoundValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotFoundValue.Location = new System.Drawing.Point(106, 2);
            this.txtNotFoundValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotFoundValue.Name = "txtNotFoundValue";
            this.txtNotFoundValue.Size = new System.Drawing.Size(519, 20);
            this.txtNotFoundValue.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chkIgnoreTextCase, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRun, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFindDesc, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 295);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 59);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chkIgnoreTextCase
            // 
            this.chkIgnoreTextCase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkIgnoreTextCase.AutoSize = true;
            this.chkIgnoreTextCase.Location = new System.Drawing.Point(447, 21);
            this.chkIgnoreTextCase.Margin = new System.Windows.Forms.Padding(2);
            this.chkIgnoreTextCase.Name = "chkIgnoreTextCase";
            this.chkIgnoreTextCase.Size = new System.Drawing.Size(102, 17);
            this.chkIgnoreTextCase.TabIndex = 2;
            this.chkIgnoreTextCase.Text = "Ignore text case";
            this.chkIgnoreTextCase.UseVisualStyleBackColor = true;
            // 
            // lblFindDesc
            // 
            this.lblFindDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFindDesc.AutoSize = true;
            this.lblFindDesc.Location = new System.Drawing.Point(3, 23);
            this.lblFindDesc.Name = "lblFindDesc";
            this.lblFindDesc.Size = new System.Drawing.Size(315, 13);
            this.lblFindDesc.TabIndex = 3;
            this.lblFindDesc.Text = "For each value from the list 1 find a matching value form the list 2:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiImport,
            this.tsmiExport,
            this.tsmiAbout});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClearList1,
            this.tsmiClearList2,
            this.tsmiClearResult});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // btnRun
            // 
            this.btnRun.AutoSize = true;
            this.btnRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRun.Image = global::ListMatcher.Properties.Resources.icon_gui_run;
            this.btnRun.Location = new System.Drawing.Point(323, 2);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRun.MinimumSize = new System.Drawing.Size(120, 55);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(120, 55);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Find";
            this.btnRun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tsmiImport
            // 
            this.tsmiImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTsvToList1,
            this.tsmiTsvToList2});
            this.tsmiImport.Image = global::ListMatcher.Properties.Resources.icon_gui_import;
            this.tsmiImport.Name = "tsmiImport";
            this.tsmiImport.Size = new System.Drawing.Size(110, 22);
            this.tsmiImport.Text = "Import";
            // 
            // tsmiTsvToList1
            // 
            this.tsmiTsvToList1.Image = global::ListMatcher.Properties.Resources.icon_gui_browse;
            this.tsmiTsvToList1.Name = "tsmiTsvToList1";
            this.tsmiTsvToList1.Size = new System.Drawing.Size(133, 22);
            this.tsmiTsvToList1.Text = "tsv to List 1";
            this.tsmiTsvToList1.Click += new System.EventHandler(this.tsmiTsvToList1_Click);
            // 
            // tsmiTsvToList2
            // 
            this.tsmiTsvToList2.Image = global::ListMatcher.Properties.Resources.icon_gui_browse;
            this.tsmiTsvToList2.Name = "tsmiTsvToList2";
            this.tsmiTsvToList2.Size = new System.Drawing.Size(133, 22);
            this.tsmiTsvToList2.Text = "tsv to List 2";
            this.tsmiTsvToList2.Click += new System.EventHandler(this.tsmiTsvToList2_Click);
            // 
            // tsmiExport
            // 
            this.tsmiExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExportResultToTsv});
            this.tsmiExport.Image = global::ListMatcher.Properties.Resources.icon_gui_export;
            this.tsmiExport.Name = "tsmiExport";
            this.tsmiExport.Size = new System.Drawing.Size(110, 22);
            this.tsmiExport.Text = "Export";
            // 
            // tsmiExportResultToTsv
            // 
            this.tsmiExportResultToTsv.Image = global::ListMatcher.Properties.Resources.icon_gui_browse;
            this.tsmiExportResultToTsv.Name = "tsmiExportResultToTsv";
            this.tsmiExportResultToTsv.Size = new System.Drawing.Size(138, 22);
            this.tsmiExportResultToTsv.Text = "Result to tsv";
            this.tsmiExportResultToTsv.Click += new System.EventHandler(this.tsmiExportResultToTsv_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Image = global::ListMatcher.Properties.Resources.icon_gui_about;
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(110, 22);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiClearList1
            // 
            this.tsmiClearList1.Image = ((System.Drawing.Image)(resources.GetObject("tsmiClearList1.Image")));
            this.tsmiClearList1.Name = "tsmiClearList1";
            this.tsmiClearList1.Size = new System.Drawing.Size(180, 22);
            this.tsmiClearList1.Text = "Clear List 1";
            this.tsmiClearList1.Click += new System.EventHandler(this.tsmiClearList1_Click);
            // 
            // tsmiClearList2
            // 
            this.tsmiClearList2.Image = ((System.Drawing.Image)(resources.GetObject("tsmiClearList2.Image")));
            this.tsmiClearList2.Name = "tsmiClearList2";
            this.tsmiClearList2.Size = new System.Drawing.Size(136, 22);
            this.tsmiClearList2.Text = "Clear List 2";
            this.tsmiClearList2.Click += new System.EventHandler(this.tsmiClearList2_Click);
            // 
            // tsmiClearResult
            // 
            this.tsmiClearResult.Image = ((System.Drawing.Image)(resources.GetObject("tsmiClearResult.Image")));
            this.tsmiClearResult.Name = "tsmiClearResult";
            this.tsmiClearResult.Size = new System.Drawing.Size(136, 22);
            this.tsmiClearResult.Text = "Clear Result";
            this.tsmiClearResult.Click += new System.EventHandler(this.tsmiClearResult_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 380);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "List Matcher";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList2)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListResult)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiImport;
        private System.Windows.Forms.ToolStripMenuItem tsmiTsvToList1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTsvToList2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblList1;
        private System.Windows.Forms.DataGridView dgvList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblList2;
        private System.Windows.Forms.DataGridView dgvList2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridView dgvListResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colList1Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn colList1Metadata;
        private System.Windows.Forms.DataGridViewTextBoxColumn colList2Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn colList2Metadata;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListResultList1Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListResultList1Metadata;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListResultList2Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListResultList2Metadata;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.CheckBox chkIgnoreTextCase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblNotFoundValue;
        private System.Windows.Forms.TextBox txtNotFoundValue;
        private System.Windows.Forms.ToolStripMenuItem tsmiExport;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportResultToTsv;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearList1;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearList2;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearResult;
        private System.Windows.Forms.Label lblFindDesc;
    }
}

