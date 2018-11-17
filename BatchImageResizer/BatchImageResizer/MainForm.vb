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

Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.IO

Public Class MainForm
    Dim _tempPath As String
    Dim _saveType As Integer

    Private Sub AutoImageWidth()
        Select Case cmbAutoScale.SelectedItem
            Case "4:3"
                tBoxWidth.Text = Math.Floor(tBoxHeight.Text * 4 / 3)
            Case "16:9"
                tBoxWidth.Text = Math.Floor(tBoxHeight.Text * 16 / 9)
            Case "16:10"
                tBoxWidth.Text = Math.Floor(tBoxHeight.Text * 16 / 10)
            Case "1:1"
                tBoxWidth.Text = Math.Floor(tBoxHeight.Text * 1)
        End Select
    End Sub

    Private Sub AutoImageHeight()
        Select Case cmbAutoScale.SelectedItem
            Case "4:3"
                tBoxHeight.Text = Math.Floor(tBoxWidth.Text * 3 / 4)
            Case "16:9"
                tBoxHeight.Text = Math.Floor(tBoxWidth.Text * 9 / 16)
            Case "16:10"
                tBoxHeight.Text = Math.Floor(tBoxWidth.Text * 10 / 16)
            Case "1:1"
                tBoxHeight.Text = Math.Floor(tBoxWidth.Text * 1)
        End Select
    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSelectAll.Click
        For i = 0 To chkListBoxSelect.Items.Count - 1
            chkListBoxSelect.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub btnSelectNone_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSelectNone.Click
        For i = 0 To chkListBoxSelect.Items.Count - 1
            chkListBoxSelect.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        cmbAutoScale.SelectedItem = "16:9"
        chkListBoxSelect.CheckOnClick = True
    End Sub

    Private Sub chkListBoxSelect_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles chkListBoxSelect.SelectedIndexChanged
        pictureBox.Image = Image.FromFile(folderBrowserDialog.SelectedPath & chkListBoxSelect.SelectedItem)
    End Sub

    Private Sub backgroundWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) _
        Handles backgroundWorker.DoWork
        backgroundWorker.ReportProgress(0)
        Dim folder As String = "\Resized-" & tBoxWidth.Text & "x" & tBoxHeight.Text
        Try
            If chkListBoxSelect.Items.Count <> 0 Then
                My.Computer.FileSystem.CreateDirectory(folderBrowserDialog.SelectedPath & folder)
            End If
            'o - original, i - input, n - new
            Dim outputFile As String
            Dim oH, oW, nH, nW, iH, iW As Integer
            Dim fixH, fixW, crop As Boolean
            Dim diffOrientation
            Dim cropRect As Rectangle
            iH = Integer.Parse(tBoxHeight.Text)
            iW = Integer.Parse(tBoxWidth.Text)
            fixH = chbHeight.Checked
            fixW = chbWidth.Checked
            crop = chbCrop.Checked

            For i = 0 To chkListBoxSelect.Items.Count - 1
                If chkListBoxSelect.CheckedItems.Contains(chkListBoxSelect.Items.Item(i)) Then
                    Dim imgSource As New Bitmap(_tempPath & chkListBoxSelect.Items.Item(i).ToString)
                    outputFile = folderBrowserDialog.SelectedPath & folder & chkListBoxSelect.Items.Item(i)
                    'dimensions
                    oH = imgSource.Height
                    oW = imgSource.Width
                    diffOrientation = False
                    Console.WriteLine(iW & " " & iH)
                    'Calculate free dimension
                    If fixH AndAlso Not fixW Then
                        iW = oW / oH * iH
                    ElseIf Not fixH AndAlso fixW Then
                        iH = oH / oW * iW
                    End If
                    Console.WriteLine(iW & " " & iH)
                    If chbOrientation.Checked Then
                        If oH < oW And iH < iW Then 'landscape
                            nH = iH
                            nW = iW
                        ElseIf oH > oW And iH > iW Then 'portrait
                            nH = iH
                            nW = iW
                        Else 'different orientation
                            nH = iW
                            nW = iH
                            diffOrientation = True
                        End If
                    Else
                        nH = iH
                        nW = iW
                    End If
                    Console.WriteLine(nW & " " & nH)

                    If crop Then
                        If Not diffOrientation Then
                            cropRect = New Rectangle((oW - iW) / 2, (oH - iH) / 2, iW, iH)
                        Else
                            cropRect = New Rectangle((oH - iH) / 2, (oW - iW) / 2, iH, iW)
                        End If
                    Else
                        cropRect = New Rectangle(0, 0, oW, oH)
                    End If

                    Dim imgOutput As String = folderBrowserDialog.SelectedPath & chkListBoxSelect.Items.Item(i)
                    Dim bitmapOutput As New Bitmap(nW, nH)
                    Dim graphicsOutput As Graphics = Graphics.FromImage(bitmapOutput)
                    graphicsOutput.DrawImage(imgSource, New Rectangle(0, 0, nW, nH), cropRect, GraphicsUnit.Pixel)
                    imgSource.Dispose()
                    outputFile = Path.Combine(Path.GetDirectoryName(outputFile),
                                              Path.GetFileNameWithoutExtension(outputFile))
                    If _saveType = -1 Or _saveType = 0 Then
                        If _
                            imgOutput.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) Or
                            imgOutput.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) Then
                            bitmapOutput.Save(outputFile & ".jpg", ImageFormat.Jpeg)
                        ElseIf imgOutput.EndsWith(".gif", StringComparison.OrdinalIgnoreCase) Then
                            bitmapOutput.Save(outputFile & ".gif", ImageFormat.Gif)
                        ElseIf imgOutput.EndsWith(".png", StringComparison.OrdinalIgnoreCase) Then
                            bitmapOutput.Save(outputFile & ".png", ImageFormat.Png)
                        ElseIf imgOutput.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) Then
                            bitmapOutput.Save(outputFile & ".bmp", ImageFormat.Bmp)
                        Else
                            bitmapOutput.Save(outputFile & ".jpg", ImageFormat.Jpeg)
                        End If
                    ElseIf _saveType = 1 Then
                        bitmapOutput.Save(outputFile & ".jpg", ImageFormat.Jpeg)
                    ElseIf _saveType = 2 Then
                        bitmapOutput.Save(outputFile & ".png", ImageFormat.Png)
                    ElseIf _saveType = 3 Then
                        bitmapOutput.Save(outputFile & ".bmp", ImageFormat.Bmp)
                    ElseIf _saveType = 4 Then
                        bitmapOutput.Save(outputFile & ".gif", ImageFormat.Gif)
                    End If
                End If
                backgroundWorker.ReportProgress(100 * i / chkListBoxSelect.Items.Count)
            Next
            backgroundWorker.ReportProgress(100)
            MsgBox("Saved in:" & vbNewLine & folderBrowserDialog.SelectedPath & folder, MsgBoxStyle.Information, "Done")
            Process.Start("explorer.exe", folderBrowserDialog.SelectedPath & folder & "\")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            backgroundWorker.Dispose()
        End Try
    End Sub

    Private Sub backgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs) _
        Handles backgroundWorker.ProgressChanged
        progressBar.Value = e.ProgressPercentage
        Try
            'pictureBox.Image = Image.FromFile(folderBrowserDialog.SelectedPath & chkListBoxSelect.Items.Item(tempI).ToString)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub backgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) _
        Handles backgroundWorker.RunWorkerCompleted
        btnLoad.Enabled = True
        btnSelectAll.Enabled = True
        btnSelectNone.Enabled = True
        tBoxWidth.Enabled = True
        tBoxHeight.Enabled = True
        chbOrientation.Enabled = True
        btnResize.Enabled = True
        tableLayoutPanelSettings.Enabled = True
    End Sub

    Private Sub tBoxHeight_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tBoxHeight.TextChanged
        If chbAutoScale.Checked = True AndAlso tBoxHeight.Focused = True Then
            Try
                AutoImageWidth()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub tBoxWidth_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tBoxWidth.TextChanged
        If chbAutoScale.Checked = True AndAlso tBoxWidth.Focused = True Then
            Try
                AutoImageHeight()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        If chkListBoxSelect.SelectedIndex < chkListBoxSelect.Items.Count - 1 Then
            chkListBoxSelect.SelectedIndex += 1
        End If
    End Sub

    Private Sub btnPrev_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrev.Click
        If chkListBoxSelect.SelectedIndex >= 1 Then
            chkListBoxSelect.SelectedIndex -= 1
        End If
    End Sub

    Private Sub cmbPreset_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cmbPreset.SelectedIndexChanged
        Select Case cmbPreset.SelectedIndex
            Case 0
                tBoxWidth.Text = 1920
                tBoxHeight.Text = 1080
            Case 1
                tBoxWidth.Text = 1280
                tBoxHeight.Text = 720
            Case 2
                tBoxWidth.Text = 640
                tBoxHeight.Text = 480
            Case 3
                tBoxWidth.Text = 1280
                tBoxHeight.Text = 1024
            Case 4
                tBoxWidth.Text = 1600
                tBoxHeight.Text = 1200
            Case 5
                tBoxWidth.Text = 2048
                tBoxHeight.Text = 1536
            Case 6
                tBoxWidth.Text = 2560
                tBoxHeight.Text = 2048
        End Select
    End Sub

    Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
        folderBrowserDialog.ShowNewFolderButton = False
        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            chkListBoxSelect.Items.Clear()
            _tempPath = folderBrowserDialog.SelectedPath
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(folderBrowserDialog.SelectedPath)
                If _
                    foundFile.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) Or
                    foundFile.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) Or
                    foundFile.EndsWith(".gif", StringComparison.OrdinalIgnoreCase) Or
                    foundFile.EndsWith(".png", StringComparison.OrdinalIgnoreCase) Or
                    foundFile.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) Then
                    chkListBoxSelect.Items.Add(foundFile.Remove(0, folderBrowserDialog.SelectedPath.Length), True)
                End If
            Next
        End If
    End Sub

    Private Sub btnResize_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnResize.Click
        btnSelectAll.Enabled = False
        btnSelectNone.Enabled = False
        tBoxWidth.Enabled = False
        tBoxHeight.Enabled = False
        chbOrientation.Enabled = False
        btnResize.Enabled = False
        tableLayoutPanelSettings.Enabled = False
        _saveType = cmbSaveAsType.SelectedIndex
        backgroundWorker.RunWorkerAsync()
    End Sub

    Private Sub btnAbout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAbout.Click
        MsgBox(
            "Copyright 2013 Zoran Petrović (zoran@zoran-software.com)" & vbNewLine &
            "Licence: MIT License", MsgBoxStyle.Information, "About")
    End Sub
End Class
