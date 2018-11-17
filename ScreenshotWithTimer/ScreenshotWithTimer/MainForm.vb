' The MIT License (MIT)
' Copyright(c) 2013 Zoran Petrović, zoran@zoran-software.com
' 
' Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
' documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
' the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, 
' and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in all copies or substantial portions 
' of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
' DEALINGS IN THE SOFTWARE.

Public Class MainForm
    Dim _interval As Integer = 1000
    Dim _tempImage As Image

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        cbCapture.SelectedIndex = 0
        cbType.SelectedIndex = 0
    End Sub

    Private Sub btnCapture_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCapture.Click
        Me.Hide()
        Clipboard.Clear()
        System.Threading.Thread.Sleep(_interval)
        Select Case cbCapture.SelectedIndex
            Case 0
                SendKeys.Send("^{PRTSC}")
            Case 1
                SendKeys.Send("%{PRTSC}")
        End Select
        captureTimer.Start()
    End Sub

    Private Sub txtDelay_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtDelay.TextChanged
        Try
            _interval = Integer.Parse(txtDelay.Text)
        Catch ex As Exception
            MsgBox("Please enter an integer!", MsgBoxStyle.Exclamation, "Error")
            txtDelay.Text = _interval
        End Try
    End Sub

    Private Sub captureTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles captureTimer.Tick
        If Clipboard.ContainsImage Then
            captureTimer.Stop()
            _tempImage = Clipboard.GetImage()
            SaveImage()
        End If
    End Sub

    Private Sub SaveImage()
        Try
            If dialogBrowse.ShowDialog() = DialogResult.OK Then
                Dim file As String = dialogBrowse.SelectedPath & "\Capture " &
                                     My.Computer.Clock.LocalTime.ToString.Replace(":", "-")
                Select Case cbType.SelectedItem
                    Case ".jpg"
                        _tempImage.Save(file & ".jpg", Imaging.ImageFormat.Jpeg)
                    Case ".png"
                        _tempImage.Save(file & ".png", Imaging.ImageFormat.Png)
                    Case ".bmp"
                        _tempImage.Save(file & ".bmp", Imaging.ImageFormat.Bmp)
                    Case ".gif"
                        _tempImage.Save(file & ".gif", Imaging.ImageFormat.Gif)
                End Select
                Me.Show()
                AppActivate(System.Diagnostics.Process.GetCurrentProcess.Id)
                MsgBox("Saved: " & file & cbType.SelectedItem, MsgBoxStyle.Information, "Saved")
            End If
        Catch ex As Exception
            Me.Show()
            AppActivate(System.Diagnostics.Process.GetCurrentProcess.Id)
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAbout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAbout.Click
        MsgBox(
            "Copyright 2013 Zoran Petrović (zoran@zoran-software.com)" & vbNewLine &
            "Licence: MIT License", MsgBoxStyle.Information, "About")
    End Sub
End Class
