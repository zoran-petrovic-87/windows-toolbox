<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.groupBoxImage = New System.Windows.Forms.GroupBox()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        Me.folderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.tBoxWidth = New System.Windows.Forms.TextBox()
        Me.tBoxHeight = New System.Windows.Forms.TextBox()
        Me.chkListBoxSelect = New System.Windows.Forms.CheckedListBox()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.btnSelectNone = New System.Windows.Forms.Button()
        Me.groupBoxSelect = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.chbCrop = New System.Windows.Forms.CheckBox()
        Me.chbHeight = New System.Windows.Forms.CheckBox()
        Me.chbWidth = New System.Windows.Forms.CheckBox()
        Me.chbOrientation = New System.Windows.Forms.CheckBox()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.backgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.btnResize = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.tableLayoutPanelSettings = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbAutoScale = New System.Windows.Forms.ComboBox()
        Me.chbAutoScale = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbPreset = New System.Windows.Forms.ComboBox()
        Me.lblPresetResolutions = New System.Windows.Forms.Label()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSaveAsType = New System.Windows.Forms.Label()
        Me.cmbSaveAsType = New System.Windows.Forms.ComboBox()
        Me.groupBoxImage.SuspendLayout
        CType(Me.pictureBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.groupBoxSelect.SuspendLayout
        Me.TableLayoutPanel8.SuspendLayout
        Me.TableLayoutPanel9.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.TableLayoutPanel4.SuspendLayout
        Me.tableLayoutPanelSettings.SuspendLayout
        Me.TableLayoutPanel6.SuspendLayout
        Me.TableLayoutPanel10.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        Me.TableLayoutPanel5.SuspendLayout
        Me.TableLayoutPanel11.SuspendLayout
        Me.SuspendLayout
        '
        'groupBoxImage
        '
        Me.groupBoxImage.Controls.Add(Me.pictureBox)
        Me.groupBoxImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBoxImage.Location = New System.Drawing.Point(4, 4)
        Me.groupBoxImage.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBoxImage.Name = "groupBoxImage"
        Me.groupBoxImage.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBoxImage.Size = New System.Drawing.Size(568, 194)
        Me.groupBoxImage.TabIndex = 0
        Me.groupBoxImage.TabStop = false
        Me.groupBoxImage.Text = "Image"
        '
        'pictureBox
        '
        Me.pictureBox.BackColor = System.Drawing.Color.Black
        Me.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox.InitialImage = Nothing
        Me.pictureBox.Location = New System.Drawing.Point(4, 19)
        Me.pictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(560, 171)
        Me.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox.TabIndex = 0
        Me.pictureBox.TabStop = false
        '
        'tBoxWidth
        '
        Me.tBoxWidth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tBoxWidth.Location = New System.Drawing.Point(180, 4)
        Me.tBoxWidth.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxWidth.MaxLength = 4
        Me.tBoxWidth.Name = "tBoxWidth"
        Me.tBoxWidth.Size = New System.Drawing.Size(380, 22)
        Me.tBoxWidth.TabIndex = 4
        Me.tBoxWidth.Text = "1280"
        '
        'tBoxHeight
        '
        Me.tBoxHeight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tBoxHeight.Location = New System.Drawing.Point(180, 34)
        Me.tBoxHeight.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxHeight.MaxLength = 4
        Me.tBoxHeight.Name = "tBoxHeight"
        Me.tBoxHeight.Size = New System.Drawing.Size(380, 22)
        Me.tBoxHeight.TabIndex = 5
        Me.tBoxHeight.Text = "720"
        '
        'chkListBoxSelect
        '
        Me.chkListBoxSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkListBoxSelect.FormattingEnabled = true
        Me.chkListBoxSelect.HorizontalScrollbar = true
        Me.chkListBoxSelect.Location = New System.Drawing.Point(4, 50)
        Me.chkListBoxSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.chkListBoxSelect.Name = "chkListBoxSelect"
        Me.chkListBoxSelect.ScrollAlwaysVisible = true
        Me.chkListBoxSelect.Size = New System.Drawing.Size(220, 348)
        Me.chkListBoxSelect.TabIndex = 1
        '
        'btnSelectAll
        '
        Me.btnSelectAll.AutoSize = true
        Me.btnSelectAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSelectAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSelectAll.Location = New System.Drawing.Point(4, 4)
        Me.btnSelectAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(103, 32)
        Me.btnSelectAll.TabIndex = 2
        Me.btnSelectAll.Text = "Select All"
        Me.btnSelectAll.UseVisualStyleBackColor = true
        '
        'btnSelectNone
        '
        Me.btnSelectNone.AutoSize = true
        Me.btnSelectNone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSelectNone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSelectNone.Location = New System.Drawing.Point(115, 4)
        Me.btnSelectNone.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelectNone.Name = "btnSelectNone"
        Me.btnSelectNone.Size = New System.Drawing.Size(103, 32)
        Me.btnSelectNone.TabIndex = 3
        Me.btnSelectNone.Text = "Select none"
        Me.btnSelectNone.UseVisualStyleBackColor = true
        '
        'groupBoxSelect
        '
        Me.groupBoxSelect.Controls.Add(Me.TableLayoutPanel8)
        Me.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBoxSelect.Location = New System.Drawing.Point(4, 72)
        Me.groupBoxSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBoxSelect.Name = "groupBoxSelect"
        Me.groupBoxSelect.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBoxSelect.Size = New System.Drawing.Size(236, 461)
        Me.groupBoxSelect.TabIndex = 9
        Me.groupBoxSelect.TabStop = false
        Me.groupBoxSelect.Text = "Select"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel8.Controls.Add(Me.progressBar, 0, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel9, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.chkListBoxSelect, 0, 1)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(4, 19)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 3
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(228, 438)
        Me.TableLayoutPanel8.TabIndex = 15
        '
        'progressBar
        '
        Me.progressBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.progressBar.Location = New System.Drawing.Point(4, 406)
        Me.progressBar.Margin = New System.Windows.Forms.Padding(4)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(220, 28)
        Me.progressBar.TabIndex = 12
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel9.Controls.Add(Me.btnSelectNone, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.btnSelectAll, 0, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(222, 40)
        Me.TableLayoutPanel9.TabIndex = 0
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnAbout.AutoSize = true
        Me.btnAbout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAbout.Location = New System.Drawing.Point(513, 256)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(53, 26)
        Me.btnAbout.TabIndex = 18
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = true
        '
        'chbCrop
        '
        Me.chbCrop.AutoSize = true
        Me.chbCrop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbCrop.Location = New System.Drawing.Point(4, 120)
        Me.chbCrop.Margin = New System.Windows.Forms.Padding(4)
        Me.chbCrop.Name = "chbCrop"
        Me.chbCrop.Size = New System.Drawing.Size(562, 20)
        Me.chbCrop.TabIndex = 17
        Me.chbCrop.Text = "Crop"
        Me.chbCrop.UseVisualStyleBackColor = true
        '
        'chbHeight
        '
        Me.chbHeight.AutoSize = true
        Me.chbHeight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbHeight.Location = New System.Drawing.Point(4, 34)
        Me.chbHeight.Margin = New System.Windows.Forms.Padding(4)
        Me.chbHeight.Name = "chbHeight"
        Me.chbHeight.Size = New System.Drawing.Size(168, 22)
        Me.chbHeight.TabIndex = 16
        Me.chbHeight.Text = "Fixed image height [px]:"
        Me.chbHeight.UseVisualStyleBackColor = true
        '
        'chbWidth
        '
        Me.chbWidth.AutoSize = true
        Me.chbWidth.Checked = true
        Me.chbWidth.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbWidth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbWidth.Location = New System.Drawing.Point(4, 4)
        Me.chbWidth.Margin = New System.Windows.Forms.Padding(4)
        Me.chbWidth.Name = "chbWidth"
        Me.chbWidth.Size = New System.Drawing.Size(168, 22)
        Me.chbWidth.TabIndex = 15
        Me.chbWidth.Text = "Fixed image width [px]:"
        Me.chbWidth.UseVisualStyleBackColor = true
        '
        'chbOrientation
        '
        Me.chbOrientation.AutoSize = true
        Me.chbOrientation.Checked = true
        Me.chbOrientation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbOrientation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbOrientation.Location = New System.Drawing.Point(4, 92)
        Me.chbOrientation.Margin = New System.Windows.Forms.Padding(4)
        Me.chbOrientation.Name = "chbOrientation"
        Me.chbOrientation.Size = New System.Drawing.Size(562, 20)
        Me.chbOrientation.TabIndex = 6
        Me.chbOrientation.Text = "Auto orientation"
        Me.chbOrientation.UseVisualStyleBackColor = true
        '
        'btnPrev
        '
        Me.btnPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnPrev.AutoSize = true
        Me.btnPrev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPrev.Location = New System.Drawing.Point(252, 4)
        Me.btnPrev.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(29, 26)
        Me.btnPrev.TabIndex = 9
        Me.btnPrev.Text = "<-"
        Me.btnPrev.UseVisualStyleBackColor = true
        '
        'btnNext
        '
        Me.btnNext.AutoSize = true
        Me.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNext.Location = New System.Drawing.Point(289, 4)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(29, 26)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = "->"
        Me.btnNext.UseVisualStyleBackColor = true
        '
        'backgroundWorker
        '
        Me.backgroundWorker.WorkerReportsProgress = true
        '
        'btnResize
        '
        Me.btnResize.AutoSize = true
        Me.btnResize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnResize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnResize.Location = New System.Drawing.Point(4, 38)
        Me.btnResize.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResize.Name = "btnResize"
        Me.btnResize.Size = New System.Drawing.Size(236, 26)
        Me.btnResize.TabIndex = 11
        Me.btnResize.Text = "Resize"
        Me.btnResize.UseVisualStyleBackColor = true
        '
        'btnLoad
        '
        Me.btnLoad.AutoSize = true
        Me.btnLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLoad.Location = New System.Drawing.Point(4, 4)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(236, 26)
        Me.btnLoad.TabIndex = 10
        Me.btnLoad.Text = "Load images from folder"
        Me.btnLoad.UseVisualStyleBackColor = true
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(832, 543)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Controls.Add(Me.groupBoxImage, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tableLayoutPanelSettings, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(576, 537)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnPrev, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnNext, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 205)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(570, 37)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'tableLayoutPanelSettings
        '
        Me.tableLayoutPanelSettings.AutoSize = true
        Me.tableLayoutPanelSettings.ColumnCount = 1
        Me.tableLayoutPanelSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanelSettings.Controls.Add(Me.chbCrop, 0, 4)
        Me.tableLayoutPanelSettings.Controls.Add(Me.chbOrientation, 0, 3)
        Me.tableLayoutPanelSettings.Controls.Add(Me.TableLayoutPanel7, 0, 2)
        Me.tableLayoutPanelSettings.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.tableLayoutPanelSettings.Controls.Add(Me.lblSettings, 0, 0)
        Me.tableLayoutPanelSettings.Controls.Add(Me.TableLayoutPanel10, 0, 5)
        Me.tableLayoutPanelSettings.Controls.Add(Me.TableLayoutPanel5, 0, 6)
        Me.tableLayoutPanelSettings.Controls.Add(Me.btnAbout, 0, 8)
        Me.tableLayoutPanelSettings.Controls.Add(Me.TableLayoutPanel11, 0, 7)
        Me.tableLayoutPanelSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanelSettings.Location = New System.Drawing.Point(3, 248)
        Me.tableLayoutPanelSettings.Name = "tableLayoutPanelSettings"
        Me.tableLayoutPanelSettings.RowCount = 9
        Me.tableLayoutPanelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanelSettings.Size = New System.Drawing.Size(570, 286)
        Me.tableLayoutPanelSettings.TabIndex = 2
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.AutoSize = true
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 85)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(564, 1)
        Me.TableLayoutPanel7.TabIndex = 20
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.AutoSize = true
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel6.Controls.Add(Me.tBoxHeight, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.chbHeight, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.chbWidth, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.tBoxWidth, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(564, 60)
        Me.TableLayoutPanel6.TabIndex = 19
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = true
        Me.lblSettings.Location = New System.Drawing.Point(3, 0)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(56, 16)
        Me.lblSettings.TabIndex = 21
        Me.lblSettings.Text = "Settings"
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.AutoSize = true
        Me.TableLayoutPanel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel10.Controls.Add(Me.cmbAutoScale, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.chbAutoScale, 0, 0)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 147)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(564, 30)
        Me.TableLayoutPanel10.TabIndex = 22
        '
        'cmbAutoScale
        '
        Me.cmbAutoScale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbAutoScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAutoScale.FormattingEnabled = true
        Me.cmbAutoScale.Items.AddRange(New Object() {"4:3", "16:9", "16:10", "1:1"})
        Me.cmbAutoScale.Location = New System.Drawing.Point(102, 3)
        Me.cmbAutoScale.Name = "cmbAutoScale"
        Me.cmbAutoScale.Size = New System.Drawing.Size(459, 24)
        Me.cmbAutoScale.TabIndex = 0
        '
        'chbAutoScale
        '
        Me.chbAutoScale.AutoSize = true
        Me.chbAutoScale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbAutoScale.Location = New System.Drawing.Point(3, 3)
        Me.chbAutoScale.Name = "chbAutoScale"
        Me.chbAutoScale.Size = New System.Drawing.Size(93, 24)
        Me.chbAutoScale.TabIndex = 1
        Me.chbAutoScale.Text = "Auto scale:"
        Me.chbAutoScale.UseVisualStyleBackColor = true
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel3.Controls.Add(Me.groupBoxSelect, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnResize, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnLoad, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(585, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(244, 537)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.AutoSize = true
        Me.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel5.Controls.Add(Me.cmbPreset, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lblPresetResolutions, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 183)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(564, 30)
        Me.TableLayoutPanel5.TabIndex = 23
        '
        'cmbPreset
        '
        Me.cmbPreset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPreset.FormattingEnabled = true
        Me.cmbPreset.Items.AddRange(New Object() {"1920×1080 (full HD)", "1280×720 (HD)", "640x480 (VGA)", "1280×1024 (SXGA 1.31MP)", "1600x1200 (UXGA 1.92MP)", "2048×1536 (QXGA 3.15MP)", "2560×2048 (QSXGA 5.24MP)"})
        Me.cmbPreset.Location = New System.Drawing.Point(127, 3)
        Me.cmbPreset.Name = "cmbPreset"
        Me.cmbPreset.Size = New System.Drawing.Size(434, 24)
        Me.cmbPreset.TabIndex = 24
        '
        'lblPresetResolutions
        '
        Me.lblPresetResolutions.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPresetResolutions.AutoSize = true
        Me.lblPresetResolutions.Location = New System.Drawing.Point(3, 7)
        Me.lblPresetResolutions.Name = "lblPresetResolutions"
        Me.lblPresetResolutions.Size = New System.Drawing.Size(118, 16)
        Me.lblPresetResolutions.TabIndex = 25
        Me.lblPresetResolutions.Text = "Preset resolutions:"
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.AutoSize = true
        Me.TableLayoutPanel11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel11.ColumnCount = 2
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel11.Controls.Add(Me.lblSaveAsType, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.cmbSaveAsType, 1, 0)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(3, 219)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(564, 30)
        Me.TableLayoutPanel11.TabIndex = 24
        '
        'lblSaveAsType
        '
        Me.lblSaveAsType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSaveAsType.AutoSize = true
        Me.lblSaveAsType.Location = New System.Drawing.Point(3, 7)
        Me.lblSaveAsType.Name = "lblSaveAsType"
        Me.lblSaveAsType.Size = New System.Drawing.Size(90, 16)
        Me.lblSaveAsType.TabIndex = 0
        Me.lblSaveAsType.Text = "Save as type:"
        '
        'cmbSaveAsType
        '
        Me.cmbSaveAsType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSaveAsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSaveAsType.FormattingEnabled = true
        Me.cmbSaveAsType.Items.AddRange(New Object() {"Keep original", "JPEG    (Joint Photographic Experts Group)", "PNG    (Portable Network Graphics)", "BMP    (Bitmap image file)", "GIF    (Graphics Interchange Format)"})
        Me.cmbSaveAsType.Location = New System.Drawing.Point(99, 3)
        Me.cmbSaveAsType.Name = "cmbSaveAsType"
        Me.cmbSaveAsType.Size = New System.Drawing.Size(462, 24)
        Me.cmbSaveAsType.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 543)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Batch Image Resizer 1.1"
        Me.groupBoxImage.ResumeLayout(false)
        CType(Me.pictureBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.groupBoxSelect.ResumeLayout(false)
        Me.TableLayoutPanel8.ResumeLayout(false)
        Me.TableLayoutPanel9.ResumeLayout(false)
        Me.TableLayoutPanel9.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.TableLayoutPanel4.PerformLayout
        Me.tableLayoutPanelSettings.ResumeLayout(false)
        Me.tableLayoutPanelSettings.PerformLayout
        Me.TableLayoutPanel6.ResumeLayout(false)
        Me.TableLayoutPanel6.PerformLayout
        Me.TableLayoutPanel10.ResumeLayout(false)
        Me.TableLayoutPanel10.PerformLayout
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel3.PerformLayout
        Me.TableLayoutPanel5.ResumeLayout(false)
        Me.TableLayoutPanel5.PerformLayout
        Me.TableLayoutPanel11.ResumeLayout(false)
        Me.TableLayoutPanel11.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents groupBoxImage As System.Windows.Forms.GroupBox
    Friend WithEvents pictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents folderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents tBoxWidth As System.Windows.Forms.TextBox
    Friend WithEvents tBoxHeight As System.Windows.Forms.TextBox
    Friend WithEvents chkListBoxSelect As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents btnSelectNone As System.Windows.Forms.Button
    Friend WithEvents groupBoxSelect As System.Windows.Forms.GroupBox
    Friend WithEvents chbOrientation As System.Windows.Forms.CheckBox
    Friend WithEvents backgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents chbHeight As System.Windows.Forms.CheckBox
    Friend WithEvents chbWidth As System.Windows.Forms.CheckBox
    Friend WithEvents btnResize As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents progressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents chbCrop As System.Windows.Forms.CheckBox
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents tableLayoutPanelSettings As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents lblSettings As Label
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents cmbAutoScale As ComboBox
    Friend WithEvents chbAutoScale As CheckBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents cmbPreset As ComboBox
    Friend WithEvents lblPresetResolutions As Label
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents lblSaveAsType As Label
    Friend WithEvents cmbSaveAsType As ComboBox
End Class
