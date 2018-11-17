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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.lblDelay = New System.Windows.Forms.Label()
        Me.txtDelay = New System.Windows.Forms.TextBox()
        Me.cbCapture = New System.Windows.Forms.ComboBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.lblCapture = New System.Windows.Forms.Label()
        Me.lblImageType = New System.Windows.Forms.Label()
        Me.lblMs = New System.Windows.Forms.Label()
        Me.captureTimer = New System.Windows.Forms.Timer(Me.components)
        Me.dialogBrowse = New System.Windows.Forms.FolderBrowserDialog()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        Me.TableLayoutPanel4.SuspendLayout
        Me.TableLayoutPanel5.SuspendLayout
        Me.SuspendLayout
        '
        'lblDelay
        '
        Me.lblDelay.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDelay.AutoSize = true
        Me.lblDelay.Location = New System.Drawing.Point(4, 7)
        Me.lblDelay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDelay.Name = "lblDelay"
        Me.lblDelay.Size = New System.Drawing.Size(113, 16)
        Me.lblDelay.TabIndex = 0
        Me.lblDelay.Text = "Delay capture for:"
        '
        'txtDelay
        '
        Me.txtDelay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDelay.Location = New System.Drawing.Point(125, 4)
        Me.txtDelay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDelay.Name = "txtDelay"
        Me.txtDelay.Size = New System.Drawing.Size(295, 22)
        Me.txtDelay.TabIndex = 1
        Me.txtDelay.Text = "2000"
        '
        'cbCapture
        '
        Me.cbCapture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbCapture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCapture.FormattingEnabled = true
        Me.cbCapture.Items.AddRange(New Object() {"Screen", "Active Window"})
        Me.cbCapture.Location = New System.Drawing.Point(70, 4)
        Me.cbCapture.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCapture.Name = "cbCapture"
        Me.cbCapture.Size = New System.Drawing.Size(384, 24)
        Me.cbCapture.TabIndex = 2
        '
        'cbType
        '
        Me.cbType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.FormattingEnabled = true
        Me.cbType.Items.AddRange(New Object() {".png", ".jpg", ".bmp", ".gif"})
        Me.cbType.Location = New System.Drawing.Point(90, 4)
        Me.cbType.Margin = New System.Windows.Forms.Padding(4)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(364, 24)
        Me.cbType.TabIndex = 3
        '
        'btnCapture
        '
        Me.btnCapture.AutoSize = true
        Me.btnCapture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCapture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCapture.Location = New System.Drawing.Point(4, 4)
        Me.btnCapture.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(65, 26)
        Me.btnCapture.TabIndex = 4
        Me.btnCapture.Text = "Capture"
        Me.btnCapture.UseVisualStyleBackColor = true
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnAbout.AutoSize = true
        Me.btnAbout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAbout.Location = New System.Drawing.Point(401, 4)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(53, 26)
        Me.btnAbout.TabIndex = 5
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = true
        '
        'lblCapture
        '
        Me.lblCapture.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCapture.AutoSize = true
        Me.lblCapture.Location = New System.Drawing.Point(4, 8)
        Me.lblCapture.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCapture.Name = "lblCapture"
        Me.lblCapture.Size = New System.Drawing.Size(58, 16)
        Me.lblCapture.TabIndex = 6
        Me.lblCapture.Text = "Capture:"
        '
        'lblImageType
        '
        Me.lblImageType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblImageType.AutoSize = true
        Me.lblImageType.Location = New System.Drawing.Point(4, 8)
        Me.lblImageType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblImageType.Name = "lblImageType"
        Me.lblImageType.Size = New System.Drawing.Size(78, 16)
        Me.lblImageType.TabIndex = 7
        Me.lblImageType.Text = "Image type:"
        '
        'lblMs
        '
        Me.lblMs.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblMs.AutoSize = true
        Me.lblMs.Location = New System.Drawing.Point(428, 7)
        Me.lblMs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMs.Name = "lblMs"
        Me.lblMs.Size = New System.Drawing.Size(26, 16)
        Me.lblMs.TabIndex = 8
        Me.lblMs.Text = "ms"
        '
        'captureTimer
        '
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(464, 161)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = true
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.lblDelay, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblMs, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDelay, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(458, 30)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = true
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblCapture, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cbCapture, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 39)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(458, 32)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = true
        Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblImageType, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cbType, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 77)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(458, 32)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.AutoSize = true
        Me.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnCapture, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnAbout, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 115)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(458, 34)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 161)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Screenshot With Timer v.1.1"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel3.PerformLayout
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.TableLayoutPanel4.PerformLayout
        Me.TableLayoutPanel5.ResumeLayout(false)
        Me.TableLayoutPanel5.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents lblDelay As System.Windows.Forms.Label
    Friend WithEvents txtDelay As System.Windows.Forms.TextBox
    Friend WithEvents cbCapture As System.Windows.Forms.ComboBox
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents btnCapture As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents lblCapture As System.Windows.Forms.Label
    Friend WithEvents lblImageType As System.Windows.Forms.Label
    Friend WithEvents lblMs As System.Windows.Forms.Label
    Friend WithEvents captureTimer As System.Windows.Forms.Timer
    Friend WithEvents dialogBrowse As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
End Class
