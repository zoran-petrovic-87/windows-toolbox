using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace KeyBot
{
    /// <summary>
    /// The MIT License (MIT)
    /// Copyright(c) 2017 Zoran Petrović, zoran@zoran-software.com
    /// 
    /// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
    /// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
    /// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, 
    /// and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
    ///
    /// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
    /// of the Software.
    ///
    /// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
    /// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
    /// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
    /// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
    /// DEALINGS IN THE SOFTWARE.
    /// </summary>
    public partial class FormMain : Form
    {
        private FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

        public FormMain()
        {
            InitializeComponent();
            folderBrowserDialog.Description = "Select where to save log file and captured images";
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();


        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            cboActiveWindowTitle.SelectedIndex = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            string windowName = GetActiveWindowTitle();
            if (windowName == null)
            {
                windowName = "";
            }
            string inputWindowName = txtActiveWindowTitle.Text;
            if (chkActiveWindowTitleIgnoreCase.Checked)
            {
                windowName = windowName.ToLower();
                inputWindowName = inputWindowName.ToLower();
            }

            if (
                (cboActiveWindowTitle.SelectedIndex == 0 && windowName.Equals(inputWindowName))
                ||
                (cboActiveWindowTitle.SelectedIndex == 1 && !windowName.Equals(inputWindowName))
                ||
                (cboActiveWindowTitle.SelectedIndex == 2 && windowName.Contains(inputWindowName))
                ||
                (cboActiveWindowTitle.SelectedIndex == 3 && windowName.StartsWith(inputWindowName))
                ||
                (cboActiveWindowTitle.SelectedIndex == 4 && windowName.EndsWith(inputWindowName))
                )
            {
                if (radCaptureImageFullSceen.Checked || radCaptureImageActiveWindow.Checked)
                {
                    CaptureImage();
                }
                foreach (DataGridViewRow row in dgvKeystrokes.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        SendKeys.Send(row.Cells[colKeystrokeToSend.Name].Value.ToString());
                    }
                }
                if (chkSaveLogFile.Checked)
                {
                    string path = Path.Combine(folderBrowserDialog.SelectedPath, "keybot log.txt");
                    File.AppendAllLines(path, new[] {DateTime.Now.ToString("yyyy_MM_dd-HH_mm_ss") + "\t" + windowName});
                }
                if (radCaptureImageFullSceen.Checked || radCaptureImageActiveWindow.Checked)
                {
                    CaptureImage();
                }
            }
            timer.Start();
        }

        private void CaptureImage()
        {
            try
            {
                Clipboard.Clear();
                if (radCaptureImageFullSceen.Checked)
                {
                    SendKeys.Send("^{PRTSC}");
                }
                else if (radCaptureImageActiveWindow.Checked)
                {
                    SendKeys.Send("%{PRTSC}");
                }
                if (Clipboard.ContainsImage())
                {
                    Image tempImage = Clipboard.GetImage();
                    string file = Path.Combine(folderBrowserDialog.SelectedPath,
                        DateTime.Now.ToString("yyyy_MM_dd-HH_mm_ss"));
                    tempImage.Save(file + ".png", ImageFormat.Png);
                }
            }
            catch (Exception ex)
            {
                if (chkSaveLogFile.Checked)
                {
                    string path = Path.Combine(folderBrowserDialog.SelectedPath, "keybot log.txt");
                    File.AppendAllLines(path, new[] { DateTime.Now.ToString("yyyy_MM_dd-HH_mm_ss") + "\t" + ex.Message });
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (chkSaveLogFile.Checked || radCaptureImageFullSceen.Checked || radCaptureImageActiveWindow.Checked)
            {
                if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            timer.Interval = int.Parse(txtTimerInterval.Text);
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnSendKeyInfo_Click(object sender, EventArgs e)
        {
            FormSendKeyInfo form = new FormSendKeyInfo();
            form.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KeyBot\n\nAuthor: Zoran Petrović (zoran@zoran-software.com)\n\nMIT licence", "About",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}